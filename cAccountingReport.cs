using System;
using System.Data;
using Microsoft.VisualBasic;

namespace GCUv2;

public class cAccountingReport
{
	public static DataTable GeneralJournal(DateTime dateFirst, DateTime dateLast)
	{
		string text = " SELECT 0 as type, 0 as id, voucherDate as journalDate,  voucherType, CONCAT(accountNumber,' - ',accountName) as description, voucherDebitCredit as journalDebitCredit,  voucherAmount as journalAmount, voucherMain,'' AS title,  b.currencyRate, 1 as orderBy1, a.voucherId as orderBy2,  voucherDebitCredit as orderBy3  FROM voucher a, voucher_account b, account c  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND a.voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND a.voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		text = text + " UNION  SELECT 0 as type, 0 as id, journalDate,  4, accountName, journalDebitCredit,  journalAmount, 0, journalDescription,  1, 1, id,  1  FROM journal a, journaldetail b, account c WHERE a.journalId = b.journalId  AND b.accountId = c.accountId  AND journalDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND journalDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		text += " ORDER BY journalDate, orderBy1, orderBy2, orderBy3 ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
