using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cCashAccount
{
	public static DataTable dtCashAccount(int BranchId, int GroupId, bool Active, string PermissionType, int Currency)
	{
		string text = " SELECT accountId, accountName  FROM account  WHERE accountCashBank = 1 ";
		if (Currency > 0)
		{
			text = text + " AND (currencyId = " + Conversions.ToString(Currency) + " OR currencyId = 1) ";
		}
		if (GroupId > 0)
		{
			text = ((Operators.CompareString(PermissionType, "GENERAL", TextCompare: false) != 0) ? (text + " AND accountId IN (SELECT kgId FROM groupKg WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1)") : (text + " AND accountId IN (SELECT kgId FROM groupKg WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)"));
		}
		if (BranchId > 0)
		{
			text = text + " AND branchId = " + Conversions.ToString(BranchId);
		}
		text += " ORDER BY accountName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static object getBalance(DateTime FirstBalanceDate, DateTime BalanceDate, int AccountId)
	{
		object obj = 0;
		string strSql = " SELECT accountBalanceAmount FROM account  WHERE accountId = " + Conversions.ToString(AccountId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["accountBalanceAmount"]);
		}
		strSql = " select sum(b.pbAmount) as total from penjBayar b  where b.pbDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND b.pbDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND b.pkId = 1 AND b.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " select sum(pbgAmount-allocatedAmount) as total from penjBayarGroup b  where pbgDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND pbgDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  and b.pkId = 1 and b.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(b.voucherAmount) AS total  FROM voucher a, voucher_account b  WHERE a.voucherId = b.voucherId  AND a.voucherDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND a.voucherDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND b.voucherDebitCredit = 1  AND b.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(b.voucherAmount) AS total  FROM voucher a, voucher_account b  WHERE a.voucherId = b.voucherId  AND a.voucherDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND a.voucherDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND b.voucherDebitCredit = 2  AND b.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(c.currencyId = b.currencyId, payAmount, payAmount * a.currencyRate)) as total FROM purchaseinvoices_payments a,purchaseinvoices b, account c WHERE pcId = 1  AND a.accountId = c.accountId  AND payDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND payDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.invId = b.invId  AND a.accountId = " + Conversions.ToString(AccountId) + "  AND b.invId NOT IN (SELECT invReturnId FROM purchaseinvoices_returns) ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(c.currencyId = b.currencyId, mpayAmount-mpayAllocated, (mpayAmount-mpayAllocated) * a.currencyRate)) as total  FROM purchaseinvoices_multipayments a, suppliers b, account c  WHERE pcId = 1  AND a.supId = b.supId  AND a.accountId = c.accountId  AND mpayAmount <> mpayAllocated  AND mpayDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND mpayDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId) + " ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(pexCost) as total FROM processes a,processextras b  WHERE a.proId = b.proId  AND a.proDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND a.proDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND b.kgId = " + Conversions.ToString(AccountId) + " ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		return obj;
	}

	public static DataTable CashBook(DateTime FirstBalanceDate, DateTime dateFirst, DateTime dateLast, int CashAccountId, int AccountId, int SalesId, string Description, int GroupId, int SearchType, bool ShowBalance)
	{
		string text = "";
		if (((AccountId == -2 && SalesId == 0) & (Operators.CompareString(Description, "", TextCompare: false) == 0)) && ShowBalance)
		{
			double num = Conversions.ToDouble(getBalance(FirstBalanceDate, dateFirst, CashAccountId));
			text = " SELECT 0 as type, 0 as id, 0 as id2, CURDATE() AS cashBookDate,  'Saldo Awal' AS description, '0' as accountNumber," + Module1.unformatNumber(Conversions.ToString(num)) + " AS debit,  0 AS credit, 1 AS orderby1, 1 as orderby2 ";
			text += " UNION ALL ";
		}
		text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 AS id, 0 AS id2, CURDATE() as cashBookDate,  d.accountName as description, d.accountNumber, SUM(b.voucherAmount) as debit,  0 as credit, 2 as orderby1, 1 as orderby2 ") : (text + " SELECT voucherType AS type, a.voucherId as id, 0 AS id2, a.voucherDate as cashBookDate,  CONCAT(d.accountName,': ',a.voucherDescription) as description, d.accountNumber, b.voucherAmount as debit,  0 as credit, 2 as orderby1, 1 as orderby2 "));
		text = text + " FROM voucher a, voucher_account b, account c, account d  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND b.counterAccountId = d.accountId  AND b.voucherDebitCredit = 1  AND b.accountId = " + Conversions.ToString(CashAccountId) + " AND a.voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND a.voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (AccountId > 0)
		{
			text = text + " AND b.counterAccountId = " + Conversions.ToString(AccountId);
		}
		if (SalesId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesId) + " ";
		}
		if (Operators.CompareString(Description, "", TextCompare: false) != 0)
		{
			text = text + " and a.voucherDescription like '%" + Description + "%' ";
		}
		if (SearchType == 2)
		{
			text += " GROUP BY d.accountId ";
		}
		text += " UNION ALL ";
		text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, 0, CURDATE() as cashBookDate,  d.accountName as description, d.accountNumber, 0 as debit,  SUM(b.voucherAmount) as credit, 2 as orderby1, 2 as orderby2 ") : (text + " SELECT voucherType as type, a.voucherId as id, 0, a.voucherDate as cashBookDate,  CONCAT(d.accountName,': ',a.voucherDescription) as description, d.accountNumber, 0 as debit,  b.voucherAmount as credit, 2 as orderby1, 2 as orderby2 "));
		text = text + " FROM voucher a, voucher_account b, account c, account d  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND b.counterAccountId = d.accountId  AND b.voucherDebitCredit = 2  AND b.accountId = " + Conversions.ToString(CashAccountId) + " AND a.voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND a.voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (AccountId > 0)
		{
			text = text + " AND b.counterAccountId = " + Conversions.ToString(AccountId);
		}
		if (SalesId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesId) + " ";
		}
		if (Operators.CompareString(Description, "", TextCompare: false) != 0)
		{
			text = text + " and a.voucherDescription like '%" + Description + "%' ";
		}
		if (SearchType == 2)
		{
			text += " GROUP BY d.accountId ";
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 10, 0, 0, CURDATE(),  'Kontanan', '', COALESCE(SUM(pbAmount),0),  0, 2, 1 ") : (text + " SELECT 10, b.wilId, salesId, pbDate,  CONCAT('Kontanan Wilayah ',b.wilName, ' (',salesName,')'), '', SUM(pbAmount),  0, 2, 1 "));
			text = text + " FROM  (SELECT c.salesId, d.pbDate, c.salesName,   d.pbAmount, e.wilId   FROM penjualan a,sales c, penjBayar d, customer e   WHERE a.custId = e.custId   AND d.salesId=c.salesId   AND a.penjId = d.penjId   AND d.pkId = 1   AND d.accountId = " + Conversions.ToString(CashAccountId) + "   AND a.penjKode = 0    AND d.pbDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'   AND d.pbDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			if (SalesId > 0)
			{
				text = text + " AND d.salesId = " + Conversions.ToString(SalesId);
			}
			text += ") AS a, wilayah b  WHERE a.wilId = b.wilId ";
			if (SearchType == 1)
			{
				text += " GROUP BY wilName,salesName,wilId,pbDate ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 11, 0, 0, CURDATE(),  'Pelunasan Piutang', '', COALESCE(SUM(pbAmount),0),  0, 2, 1 ") : (text + " SELECT 11, b.wilId, salesId, pbDate,  CONCAT('Pelunasan Piutang: ',wilName), '', SUM(pbAmount),  0, 2, 1 "));
			text = text + " FROM  (SELECT c.salesId, c.salesName, d.pbDate,   d.pbAmount, e.wilId   FROM penjualan a, sales c, penjBayar d, customer e  WHERE a.custId = e.custId   AND d.salesId = c.salesId   AND a.penjId = d.penjId   AND d.pkId = 1   AND d.accountId = " + Conversions.ToString(CashAccountId) + "   AND a.penjKode = 1   AND d.pbDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'   AND d.pbDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
			if (SalesId > 0)
			{
				text = text + " AND d.salesId = " + Conversions.ToString(SalesId);
			}
			text += ") AS a, wilayah b  WHERE a.wilId = b.wilId ";
			if (SearchType == 1)
			{
				text += " GROUP BY wilName, salesName, b.wilId, pbDate ";
			}
		}
		if ((AccountId == -2 && SalesId == 0) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 20, 0, 0, CURDATE(),  'Pembayaran Supplier', '', 0,  COALESCE(SUM(IF(d.currencyId = c.currencyId, payAmount, payAmount * a.currencyRate)),0), 2, 2 ") : (text + " SELECT 20, b.supId, 0, payDate,  CONCAT('Pembayaran: ',supName), '', 0,  SUM(IF(d.currencyId = c.currencyId, payAmount, payAmount * a.currencyRate)), 2, 2 "));
			text = text + " FROM purchaseinvoices_payments a, suppliers b,purchaseinvoices c, account d  WHERE pcId = 1  AND a.accountId = d.accountId  AND b.supId = c.supId  AND a.invId = c.invId  AND a.accountId = " + Conversions.ToString(CashAccountId) + " AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND payDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "' ";
			if (SearchType == 1)
			{
				text += " GROUP BY payDate,supName ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 12, 0, 0, a.pbgDate,  CONCAT('Pembayaran customer ',custName,' belum teralokasi'), '', a.pbgAmount-a.allocatedAmount,  0, 2, 2  FROM PenjBayarGroup a, customer b  WHERE a.custId = b.custId AND pbgAmount <> allocatedAmount  AND pkId = 1  AND a.accountId = " + Conversions.ToString(CashAccountId) + " AND a.pbgDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.pbgDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' ";
			if (SalesId > 0)
			{
				text = text + " AND a.salesId = " + Conversions.ToString(SalesId);
			}
		}
		if ((AccountId == -2 && SalesId == 0) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 22, 0, 0, a.mpayDate,  CONCAT('Pembayaran supplier ', supName, ' belum teralokasi'), '',  0, IF(c.currencyId = b.currencyId, a.mpayAmount-a.mpayAllocated, (a.mpayAmount-a.mpayAllocated) * a.currencyRate),  2, 1  FROM purchaseinvoices_multipayments a, suppliers b, account c  WHERE a.supId = b.supId  AND a.accountId = c.accountId  AND mpayAmount <> mpayAllocated  AND pcId = 1  AND a.accountId = " + Conversions.ToString(CashAccountId) + " AND a.mpayDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' ";
		}
		if ((AccountId == -2 && SalesId == 0) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 30, 0, 0, proDate,  CONCAT('Biaya produksi: ', itemName), '7777', 0,  pexCost, 2, 2  FROM processes a, processextras b, items c  WHERE a.itemId = c.itemId  AND a.proId = b.proId  AND b.kgId = " + Conversions.ToString(CashAccountId) + " AND proDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND proDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' ";
		}
		text += " ORDER BY orderby1, cashBookDate, orderby2, accountNumber, description ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable CustomerPayment(DateTime FirstDate, DateTime LastDate, int CashAccountId, int SalesId, int AreaId, int PaymentType)
	{
		string text = " SELECT a.penjId, pbDate, custName,  penjFaktur, pbAmount, penjBsType  FROM penjualan a,penjBayar b, customer c  WHERE a.penjId = b.penjId  AND a.custID = c.custID  AND b.pkId = 1  AND b.accountId = " + Conversions.ToString(CashAccountId) + "  AND b.pbDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "'  AND b.pbDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "' ";
		text = ((PaymentType != 1) ? (text + " AND a.penjKode = 1 ") : (text + " AND a.penjKode = 0 "));
		if (AreaId > 0)
		{
			text = text + " AND c.wilId = " + Conversions.ToString(AreaId);
		}
		if (SalesId > 0)
		{
			text = text + " AND b.salesId = " + Conversions.ToString(SalesId);
		}
		text += " ORDER BY pbDate, penjFaktur ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SupplierPayment(DateTime FirstDate, DateTime LastDate, int CashAccountId, int SupplierId)
	{
		string text = " SELECT a.invId, payDate, supName,  invNumber, payAmount, invIsReturn  FROM purchaseinvoices_payments a, suppliers b,purchaseinvoices c  WHERE pcId = 1  AND b.supId = c.supId  AND a.invId = c.invId  AND a.accountId = " + Conversions.ToString(CashAccountId) + " AND payDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "'  AND payDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "' ";
		if (SupplierId > 0)
		{
			text = text + " AND b.supId = " + Conversions.ToString(SupplierId);
		}
		text += " ORDER BY invDate, invNumber ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
