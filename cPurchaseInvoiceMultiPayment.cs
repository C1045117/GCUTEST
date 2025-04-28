using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cPurchaseInvoiceMultiPayment : cPurchaseInvoicePayment
{
	private int _supplierId;

	private string _supplierName;

	private cPurchaseInvoicePayment[] _allocation;

	private double _allocatedAmount;

	private string _description;

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

	public string SupplierName
	{
		get
		{
			return _supplierName;
		}
		set
		{
			_supplierName = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = Module1.cleanStringKeepCrlf(value);
		}
	}

	public double AllocatedAmount
	{
		get
		{
			return _allocatedAmount;
		}
		set
		{
			_allocatedAmount = value;
		}
	}

	public cPurchaseInvoicePayment[] Allocation
	{
		get
		{
			return _allocation;
		}
		set
		{
			_allocation = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cPurchaseInvoiceMultiPayment(double MultiPaymentId)
	{
		if (!(MultiPaymentId > 0.0))
		{
			return;
		}
		base.MultiPaymentId = MultiPaymentId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*, b.pcName, c.supName, d.currencyId, d.currencyName  FROM purchaseinvoices_multipayments a, paymentcodes b, suppliers c, currency d, account e WHERE a.pcId = b.pcId  AND a.accountId = e.accountId  AND a.supId = c.supId  AND e.currencyId = d.currencyId  AND mpayId = " + Conversions.ToString(base.MultiPaymentId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_supplierId = Conversions.ToInteger(dataTable.Rows[0]["supId"]);
			_supplierName = Conversions.ToString(dataTable.Rows[0]["supName"]);
			base.PaymentDate = Conversions.ToDate(dataTable.Rows[0]["mpayDate"]);
			base.PaymentCodeId = Conversions.ToByte(dataTable.Rows[0]["pcId"]);
			base.PaymentCodeName = Conversions.ToString(dataTable.Rows[0]["pcName"]);
			base.InFront = Conversions.ToByte(dataTable.Rows[0]["mpayInFront"]);
			base.Amount = Conversions.ToDouble(dataTable.Rows[0]["mpayAmount"]);
			base.AccountId = Conversions.ToInteger(dataTable.Rows[0]["accountId"]);
			_description = Conversions.ToString(dataTable.Rows[0]["mpayNote"]);
			_allocatedAmount = Conversions.ToDouble(dataTable.Rows[0]["mpayAllocated"]);
			base.CurrencyId = Conversions.ToInteger(dataTable.Rows[0]["currencyId"]);
			base.CurrencyName = Conversions.ToString(dataTable.Rows[0]["currencyName"]);
			base.CurrencyRate = Conversions.ToDouble(dataTable.Rows[0]["currencyRate"]);
			if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["pcName"], "C/G", TextCompare: false))
			{
				strSql = " SELECT cheqDate, cheqNumber  FROM chequesout  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
				dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				if (dataTable.Rows.Count > 0)
				{
					base.ChequeDate = Conversions.ToDate(dataTable.Rows[0]["cheqDate"]);
					base.ChequeNumber = Conversions.ToString(dataTable.Rows[0]["cheqNumber"]);
				}
			}
		}
		else
		{
			base.MultiPaymentId = 0.0;
			Information.Err().Raise(513, null, "Pembayaran tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.invId, invNumber, invDate, invTotal-invReturn-invDiscount-invDeduction-invPayment as invPayable, payAmount  FROM purchaseinvoices a, purchaseinvoices_payments b  WHERE a.invId = b.invId  AND mpayId = " + Conversions.ToString(base.MultiPaymentId) + " ORDER BY invDate ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_allocation = new cPurchaseInvoicePayment[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_allocation[num] = new cPurchaseInvoicePayment();
				_allocation[num].InvoiceId = Conversions.ToDouble(row["invId"]);
				_allocation[num].InvoiceDate = Conversions.ToDate(row["invDate"]);
				_allocation[num].InvoiceNumber = Conversions.ToString(row["invNumber"]);
				_allocation[num].InvoicePayable = Conversions.ToDouble(row["invPayable"]);
				_allocation[num].Amount = Conversions.ToDouble(row["payAmount"]);
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Save()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
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
						val = Module1.connectData.BeginTransaction();
						if (base.MultiPaymentId == 0.0)
						{
							string strSql = " INSERT INTO purchaseinvoices_multipayments  (mpayDate, mpayAmount, mpayInFront,  pcId, supId, accountId,  mpayNote, mpayCreated, mpayAllocated,  currencyRate) VALUES  ('" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(base.Amount)) + "," + Conversions.ToString(base.InFront) + "," + Conversions.ToString(base.PaymentCodeId) + "," + Conversions.ToString(_supplierId) + "," + Conversions.ToString(base.AccountId) + ",'" + _description + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Module1.unformatNumber(Conversions.ToString(AllocatedAmount)) + "," + Module1.unformatNumber(Conversions.ToString(base.CurrencyRate)) + ")";
							Module1.sqlNonQuery(strSql, "data");
							base.MultiPaymentId = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE purchaseinvoices_multipayments  SET mpayDate = '" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "', mpayAmount = " + Module1.unformatNumber(Conversions.ToString(base.Amount)) + ", mpayInFront = " + Conversions.ToString(base.InFront) + ", pcId = " + Conversions.ToString(base.PaymentCodeId) + ", supId = " + Conversions.ToString(_supplierId) + ", accountId = " + Conversions.ToString(base.AccountId) + ", mpayAllocated = " + Module1.unformatNumber(Conversions.ToString(_allocatedAmount)) + ", currencyRate = " + Module1.unformatNumber(Conversions.ToString(base.CurrencyRate)) + ", mpayNote = '" + _description + "' WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM chequesout  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " SELECT * FROM purchaseinvoices_payments  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
							DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
							int num3 = dataTable.Rows.Count - 1;
							for (int i = 0; i <= num3; i++)
							{
								strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE purchaseinvoices  SET invDatePaid = '0000-00-00',  invPayment =  (SELECT IFNULL(SUM(payAmount),0) FROM purchaseinvoices_payments  WHERE invId = ", dataTable.Rows[i]["invId"]), " AND mpayId <> "), base.MultiPaymentId), ") "), " WHERE invId = "), dataTable.Rows[i]["invId"]));
								Module1.sqlNonQuery(strSql, "data");
							}
							strSql = " DELETE FROM purchaseinvoices_payments  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
							Module1.sqlNonQuery(strSql, "data");
						}
						if (Operators.CompareString(base.PaymentCodeName, "C/G", TextCompare: false) == 0)
						{
							string strSql = " INSERT INTO chequesOut(cheqNumber,cheqDate,bankId,  payId, mpayId) VALUES  ('" + base.ChequeNumber + "','" + Strings.Format(base.ChequeDate, "yyyy-MM-dd") + "',0, 0," + Conversions.ToString(base.MultiPaymentId) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						if (!Information.IsNothing(_allocation))
						{
							cPurchaseInvoicePayment[] allocation = _allocation;
							foreach (cPurchaseInvoicePayment cPurchaseInvoicePayment2 in allocation)
							{
								string strSql = " INSERT INTO purchaseinvoices_payments  (payDate,payAmount,pcId, invId,mpayId, accountId,  currencyRate) VALUES  ('" + Strings.Format(base.PaymentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(cPurchaseInvoicePayment2.Amount)) + "," + Conversions.ToString(base.PaymentCodeId) + "," + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId) + "," + Conversions.ToString(base.MultiPaymentId) + "," + Conversions.ToString(base.AccountId) + "," + Module1.unformatNumber(Conversions.ToString(base.CurrencyRate)) + ")";
								Module1.sqlNonQuery(strSql, "data");
								strSql = " UPDATE purchaseinvoices  SET invPayment =  (SELECT SUM(payAmount) FROM purchaseinvoices_payments  WHERE invId = " + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId) + ") WHERE invId = " + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId);
								Module1.sqlNonQuery(strSql, "data");
								strSql = " SELECT invTotal-invReturn-invDiscount-invDeduction-invPayment as Payable  FROM purchaseinvoices  WHERE invId = " + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId);
								DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
								double num4 = Conversions.ToDouble(dataTable.Rows[0]["Payable"]);
								if (num4 == 0.0)
								{
									strSql = " SELECT payDate  FROM purchaseInvoices_payments  WHERE invId = " + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId) + " ORDER BY payDate DESC ";
									dataTable = Module1.sqlTable(strSql, "data", Clone: false);
									DateTime dateTime = Conversions.ToDate(dataTable.Rows[0]["payDate"]);
									strSql = " UPDATE purchaseinvoices  SET invDatePaid = '" + Strings.Format(dateTime, "yyyy-MM-dd") + "' WHERE invid = " + Conversions.ToString(cPurchaseInvoicePayment2.InvoiceId);
									Module1.sqlNonQuery(strSql, "data");
								}
							}
						}
						val.Commit();
						goto end_IL_0001;
					case 1716:
						num = -1;
						switch (num2)
						{
						case 2:
							if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
							{
								val.Rollback();
							}
							Information.Err().Raise(513, null, Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_06ea;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1716;
				continue;
			}
			break;
			IL_06ea:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Delete()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
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
						val = Module1.connectData.BeginTransaction();
						string strSql = " DELETE FROM chequesout  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " SELECT * FROM purchaseinvoices_payments  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
						DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						int num3 = dataTable.Rows.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							strSql = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" UPDATE purchaseinvoices  SET invPayment =  (SELECT IFNULL(SUM(payAmount),0) FROM purchaseinvoices_payments  WHERE invId = ", dataTable.Rows[i]["invId"]), " AND mpayId = 0) "), " WHERE invId = "), dataTable.Rows[i]["invId"]));
							Module1.sqlNonQuery(strSql, "data");
						}
						strSql = " DELETE FROM purchaseinvoices_payments  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM purchaseinvoices_multipayments  WHERE mpayId = " + Conversions.ToString(base.MultiPaymentId);
						Module1.sqlNonQuery(strSql, "data");
						val.Commit();
						goto end_IL_0001;
					}
					case 399:
						num = -1;
						switch (num2)
						{
						case 2:
							if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
							{
								val.Rollback();
							}
							Information.Err().Raise(513, null, Information.Err().Description);
							goto end_IL_0001;
						}
						break;
					}
					goto IL_01c5;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 399;
				continue;
			}
			break;
			IL_01c5:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int SupplierId, int PaymentCode, int PaymentType, int IsReturn, int GroupId, int BranchId)
	{
		string text = "";
		if (IsReturn == 0)
		{
			text = " SELECT 0 as invId, a.mpayId, mpayDate as payDate,  supName, CONCAT('M-',pcName) as pcName, mpayamount as payAmount, mpayAmount-IF(totalAlloc IS NULL,0,totalAlloc) AS payRemain, mpayCreated as payCreated, '0' as type  FROM purchaseinvoices_multipayments a  LEFT JOIN  (SELECT mpayId, SUM(payAmount) as totalAlloc FROM purchaseinvoices_payments   GROUP BY mpayId) d  ON a.mpayId = d.mpayId,  paymentcodes b, suppliers c  WHERE a.pcId = b.pcId  AND a.supId = c.supId ";
			switch (intRange)
			{
			case 1:
				text = text + " AND mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND mpayDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
				break;
			case 2:
				text = text + " AND mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'";
				break;
			}
			if (SupplierId > 0)
			{
				text = text + " AND a.supId = " + Conversions.ToString(SupplierId);
			}
			if (PaymentCode > 0)
			{
				text = text + " AND a.pcId = " + Conversions.ToString(PaymentCode);
			}
			if (GroupId > 0)
			{
				text = text + " AND a.supId IN  (SELECT supId FROM groups_suppliers WHERE groupId = " + Conversions.ToString(GroupId) + ")";
			}
		}
		if (PaymentType == 0)
		{
			if (Operators.CompareString(text, "", TextCompare: false) != 0)
			{
				text += " UNION ";
			}
			text = text + " SELECT a.invId, mpayId, payDate as payDate,  supName, pcName, IF(d.invIsReturn=1,payAmount*-1,payAmount) AS payAmount, 0 AS payRemain, payCreated, '1' as type  FROM purchaseinvoices_payments a, paymentcodes b, suppliers c, purchaseinvoices d  WHERE a.mpayId = 0  AND a.pcId = b.pcId  AND a.invId = d.invId  AND d.supId = c.supId  AND invIsReturn = " + Conversions.ToString(IsReturn);
			switch (intRange)
			{
			case 1:
				text = text + " AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND payDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
				break;
			case 2:
				text = text + " AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'";
				break;
			}
			if (SupplierId > 0)
			{
				text = text + " AND d.supId = " + Conversions.ToString(SupplierId);
			}
			if (PaymentCode > 0)
			{
				text = text + " AND a.pcId = " + Conversions.ToString(PaymentCode);
			}
			if (GroupId > 0)
			{
				text = text + " AND d.supId IN  (SELECT supId FROM groups_suppliers WHERE groupId = " + Conversions.ToString(GroupId) + ")";
			}
		}
		return Module1.sqlTable(intRange switch
		{
			2 => text + " ORDER BY payCreated DESC LIMIT 100 ", 
			3 => text + " ORDER BY payDate DESC ", 
			_ => text + " ORDER BY payDate ", 
		}, "data", Clone: false);
	}
}
