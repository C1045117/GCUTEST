using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cBankAccount
{
	public static DataTable dtBankAccount(int BranchId, int GroupId, bool Active, string PermissionType, int Currency)
	{
		string text = " SELECT accountId, accountName  FROM account  WHERE accountCashBank = 2 ";
		if (Currency > 0)
		{
			text = text + " AND (currencyId = " + Conversions.ToString(Currency) + " OR currencyId = 1) ";
		}
		if (GroupId > 0)
		{
			text = ((Operators.CompareString(PermissionType, "GENERAL", TextCompare: false) != 0) ? (text + " AND accountId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1)") : (text + " AND accountId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)"));
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
		strSql = " SELECT SUM(gcAmount) as total FROM penjBayar a, pembKode c, girocek d  WHERE a.pkId = c.pkId  AND c.pkName = 'C/G' AND a.pbgId = 0 AND a.pbId = d.pbId  AND gcMasukDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND gcMasukDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(pbAmount) as total FROM penjBayar a, pembKode c, girocek d  WHERE a.pkId = c.pkId  AND c.pkName = 'C/G' AND a.pbgId> 0 AND a.pbgId = d.pbgId  AND gcMasukDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND gcMasukDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(pbgAmount-allocatedAmount) as total  FROM penjBayarGroup a, girocek b  WHERE a.pbgId = b.pbgId  AND a.pkId = 2  AND gcMasukDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND gcMasukDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(pbAmount) as total FROM penjBayar a  WHERE a.pkId = 3  AND pbDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND pbDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.AddObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(pbgAmount-allocatedAmount) as total  FROM PenjBayarGroup a  WHERE pbgAmount <> allocatedAmount  AND pkId = 3  AND pbgDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND pbgDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
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
		strSql = " SELECT SUM(IF(b.currencyId = c.currencyId, payAmount, payAmount * a.currencyRate)) as total  FROM purchaseinvoices_payments a, purchaseinvoices b, account c, chequesout d  WHERE pcId = 2  AND a.invId = b.invId  AND a.accountId = c.accountId  AND a.payId = d.payId  AND d.cheqDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND d.cheqDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(c.currencyId = d.currencyId, payAmount, payAmount * a.currencyRate)) as total  FROM purchaseinvoices_payments a, chequesout b, purchaseinvoices c, account d  WHERE pcId = 2  AND a.invId = c.invId  AND a.accountId = d.accountId  AND a.mpayId > 0  AND a.mpayId = b.mpayId  AND b.cheqDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND b.cheqDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(c.currencyId = d.currencyId, mpayAmount-mpayAllocated, (mpayAmount-mpayAllocated) * a.currencyRate)) AS total FROM purchaseinvoices_multipayments a, chequesout b, suppliers c, account d  WHERE a.mpayId = b.mpayId  AND a.supId = c.supId  AND a.accountId = d.accountId  AND pcId = 2  AND cheqDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND cheqDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(b.currencyId = c.currencyId, payAmount, payAmount * a.currencyRate)) as total  FROM purchaseinvoices_payments a, purchaseinvoices b, account c  WHERE a.invId = b.invId  AND a.accountId = c.accountId  AND pcId > 2  AND payDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND payDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		strSql = " SELECT SUM(IF(b.currencyId = c.currencyId, mpayAmount-mpayAllocated, (mpayAmount-mpayAllocated) * a.currencyRate)) AS total FROM purchaseinvoices_multipayments a, suppliers b, account c  WHERE pcId > 2  AND a.supId = b.supId  AND a.accountId = c.accountId  AND mpayDate < '" + Strings.Format(BalanceDate, "yyyy-MM-dd") + "'  AND mpayDate >= '" + Strings.Format(FirstBalanceDate, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(AccountId);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			obj = Operators.SubtractObject(obj, dataTable.Rows[0]["total"]);
		}
		return obj;
	}

	public static DataTable BankBook(DateTime FirstBalanceDate, DateTime dateFirst, DateTime dateLast, int BankAccountId, int AccountId, string Description, int GroupId, int SearchType, bool ShowBalance)
	{
		string text = "";
		if (((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0)) && ShowBalance)
		{
			double num = Conversions.ToDouble(getBalance(FirstBalanceDate, dateFirst, BankAccountId));
			text = " SELECT 0 as type, 0 as id, CURDATE() AS bankBookDate,  'Saldo Awal' AS description, '0' as accountNumber," + Module1.unformatNumber(Conversions.ToString(num)) + " AS debit,  0 AS credit, 1 AS orderby1, 1 as orderby2 ";
			text += " UNION ALL ";
		}
		text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 AS id, CURDATE() as bankBookDate,  d.accountName as description, d.accountNumber, 0 as debit,  COALESCE(SUM(b.voucherAmount),0) as credit, 2 as orderby1, 1 as orderby2 ") : (text + " SELECT voucherType as type, a.voucherId as id, a.voucherDate as bankBookDate,  CONCAT(d.accountName,': ',a.voucherDescription) as description, d.accountNumber, 0 as debit,  b.voucherAmount as credit, 2 as orderby1, 1 as orderby2 "));
		text = text + " FROM voucher a, voucher_account b, account c, account d  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND b.counterAccountId = d.accountId  AND b.voucherDebitCredit = 1  AND b.accountId = " + Conversions.ToString(BankAccountId) + " AND a.voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND a.voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (AccountId > 0)
		{
			text = text + " AND b.counterAccountId = " + Conversions.ToString(AccountId);
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
		text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE() AS bankBookDate,  d.accountName as description, d.accountNumber, COALESCE(SUM(b.voucherAmount),0) AS debit,  0 AS credit, 2 AS orderby1, 2 AS orderby2 ") : (text + " SELECT voucherType AS type, a.voucherId AS id, a.voucherDate AS bankBookDate,  CONCAT(d.accountName,': ', a.voucherDescription) AS description, d.accountNumber, b.voucherAmount AS debit,  0 AS credit, 2 AS orderby1, 2 AS orderby2 "));
		text = text + " FROM voucher a, voucher_account b, account c, account d  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND b.counterAccountId = d.accountId  AND b.voucherDebitCredit = 2  AND b.accountId = " + Conversions.ToString(BankAccountId) + " AND a.voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND a.voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (AccountId > 0)
		{
			text = text + " AND b.counterAccountId = " + Conversions.ToString(AccountId);
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
			text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE() as bankBookDate,  'Setoran Kliring' AS description, '', 0 as debit,  COALESCE(SUM(gcAmount),0) AS credit, 2 AS orderby1, 1 AS orderby2 ") : (text + " SELECT 0 as type, 0 as id, gcMasukDate as bankBookDate,  CONCAT('Setoran Kliring: ',custName) as description, '', 0 as debit,  gcAmount AS credit, 2 AS orderby1, 1 AS orderby2 "));
			text = text + " FROM customer c, girocek d  WHERE d.custId = c.custId  AND gcMasukDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND gcMasukDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND d.tgId = " + Conversions.ToString(BankAccountId);
			if (SearchType != 1)
			{
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 0 as type, 0 as id, pbgDate,  CONCAT('Cek/Giro belum teralokasi: ', custName), '', 0 as debit,  pbgAmount-allocatedAmount as credit, 2 as orderby1, 1 as orderby2  FROM penjBayarGroup a, girocek b, customer c  WHERE a.pbgId = b.pbgId  AND a.custId = c.custId  AND a.pkId = 2  AND pbgAmount <> allocatedAmount  AND gcMasukDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND gcMasukDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE(),  'NK-LLG', '', 0 as debit,  COALESCE(SUM(pbAmount),0) as credit, 2 as orderby1, 1 as orderby2 ") : (text + " SELECT 0 as type, 0 as id, pbDate,  CONCAT('NK-LLG: ', custName), '', 0 as debit,  SUM(pbAmount) as credit, 2 as orderby1, 1 as orderby2 "));
			text = text + " FROM penjualan a, penjBayar b, customer c  WHERE a.penjId = b.penjId  AND a.custId = c.custId  AND b.pkId = 3  AND pbDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND pbDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND b.accountId = " + Conversions.ToString(BankAccountId);
			if (SearchType == 1)
			{
				text += " GROUP BY pbDate, custName ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 0 as type, 0 as id, pbgDate,  CONCAT('LLG belum teralokasi: ', custName), '', 0 AS debit,  pbgAmount-allocatedAmount AS credit, 2 AS orderby1, 1 AS orderby2  FROM penjBayarGroup a, customer b  WHERE a.custId = b.custId  AND a.pkId = 3  AND pbgAmount <> allocatedAmount  AND pbgDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND pbgDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE(),  'C/G Supplier', '', COALESCE(SUM(IF(c.currencyId = e.currencyId, payAmount, payAmount * a.currencyRate)),0) as debit,  0 as credit, 2 as orderby1, 2 as orderby2 ") : (text + " SELECT 0 as type, 0 as id, cheqDate,  CONCAT('C/G Supplier: ', supName), '', SUM(IF(c.currencyId = e.currencyId, payAmount, payAmount * a.currencyRate)) as debit,  0 as credit, 2 as orderby1, 2 as orderby2 "));
			text = text + " FROM purchaseinvoices_payments a, suppliers b, purchaseinvoices c, chequesout d, account e  WHERE a.invId = c.invId  AND a.accountId = e.accountId  AND a.mpayId = 0  AND a.payId = d.payId  AND b.supId = c.supId  AND a.pcId = 2  AND cheqDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND cheqDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
			if (SearchType == 1)
			{
				text += " GROUP BY cheqDate, supName ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE(),  'C/G Supplier (M-)', '', COALESCE(SUM(IF(c.currencyId = e.currencyId, payAmount, payAmount * a.currencyRate)),0) AS debit,  0 as credit, 2 as orderby1, 2 as orderby2 ") : (text + " SELECT 0 as type, 0 as id, cheqDate,  CONCAT('C/G Supplier: ', supName), '', SUM(IF(c.currencyId = e.currencyId, payAmount, payAmount * a.currencyRate)) AS debit,  0 as credit, 2 as orderby1, 2 as orderby2 "));
			text = text + " FROM purchaseinvoices_payments a, suppliers b, purchaseinvoices c, chequesout d, account e  WHERE a.invId = c.invId  AND a.accountId = e.accountId  AND a.mpayId > 0  AND a.mpayId = d.mpayId  AND b.supId = c.supId  AND a.pcId = 2  AND cheqDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND cheqDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
			if (SearchType == 1)
			{
				text += " GROUP BY cheqDate, supName ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 0 as type, 0 as id, cheqDate,  CONCAT('C/G belum teralokasi: ', supName), '', IF(b.currencyId = d.currencyId, mpayAmount-mpayAllocated, (mpayAmount-mpayAllocated) * a.currencyRate) AS DEBIT,  0 as credit, 2 as orderby1, 2 as orderby2  FROM purchaseinvoices_multipayments a, suppliers b, chequesout c, account d  WHERE a.mpayId = c.mpayId  AND a.accountId = d.accountId  AND a.supId = b.supId  AND mpayAmount <> mpayAllocated  AND a.pcId = 2  AND cheqDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND cheqDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = ((SearchType != 1) ? (text + " SELECT 0 as type, 0 as id, CURDATE(),  'LLG Supplier', '', COALESCE(SUM(IF(c.currencyId = d.currencyId, payAmount, payAmount * a.currencyRate)),0) AS debit,  0 as credit, 2 as orderby1, 2 as orderby2 ") : (text + " SELECT 0 as type, 0 as id, payDate,  CONCAT('LLG Supplier: ', supName), '', SUM(IF(c.currencyId = d.currencyId, payAmount, payAmount * a.currencyRate)) AS debit,  0 as credit, 2 as orderby1, 2 as orderby2 "));
			text = text + " FROM purchaseinvoices_payments a, suppliers b, purchaseinvoices c, account d  WHERE a.invId = c.invId  AND a.accountId = d.accountId  AND b.supId = c.supId  AND a.pcId = 3  AND payDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND payDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
			if (SearchType == 1)
			{
				text += " GROUP BY payDate, supName ";
			}
		}
		if ((AccountId == -2) & (Operators.CompareString(Description, "", TextCompare: false) == 0))
		{
			text += " UNION ALL ";
			text = text + " SELECT 0 as type, 0 as id, mpayDate,  CONCAT('LLG belum teralokasi: ', supName), '', IF(b.currencyId = c.currencyId, mpayAmount-mpayAllocated, (mpayAmount-mpayAllocated) * a.currencyRate) AS DEBIT,  0 as credit, 2 as orderby1, 2 as orderby2  FROM purchaseinvoices_multipayments a, suppliers b, account c  WHERE a.supId = b.supId  AND a.accountId = c.accountId  AND mpayAmount <> mpayAllocated  AND a.pcId = 3  AND mpayDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'  AND mpayDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'  AND a.accountId = " + Conversions.ToString(BankAccountId);
		}
		text += " ORDER BY orderby1, bankBookDate, orderby2, accountNumber, description ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
