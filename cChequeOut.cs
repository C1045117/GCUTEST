using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cChequeOut
{
	private double _id;

	private double _paymentId;

	private double _multiPaymentId;

	private string _number;

	private DateTime _chequeDate;

	public double Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public double PaymentId
	{
		get
		{
			return _paymentId;
		}
		set
		{
			_paymentId = value;
		}
	}

	public double MultiPaymentId
	{
		get
		{
			return _multiPaymentId;
		}
		set
		{
			_multiPaymentId = value;
		}
	}

	public string Number
	{
		get
		{
			return _number;
		}
		set
		{
			_number = value;
		}
	}

	public DateTime ChequeDate
	{
		get
		{
			return _chequeDate;
		}
		set
		{
			_chequeDate = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cChequeOut(double PaymentId, double MultiPaymentId)
	{
		string strSql;
		if (MultiPaymentId > 0.0)
		{
			this.MultiPaymentId = MultiPaymentId;
			strSql = " SELECT a.*  FROM chequesout a  WHERE mpayId = " + Conversions.ToString(_multiPaymentId);
		}
		else
		{
			_paymentId = PaymentId;
			strSql = " SELECT a.*  FROM chequesout a  WHERE payId = " + Conversions.ToString(_paymentId);
		}
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_id = Conversions.ToDouble(dataTable.Rows[0]["cheqId"]);
			_number = Conversions.ToString(dataTable.Rows[0]["cheqNumber"]);
			_chequeDate = Conversions.ToDate(dataTable.Rows[0]["cheqDate"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Cek tidak ditemukan. Kemungkinan telah dihapus.");
		}
	}

	public static DataTable Search(int Range, DateTime FirstDate, DateTime LastDate, string ChequeNo, int BankAccountId, int GroupId)
	{
		string text = " SELECT c.invId, 0 as mpayId, payDate AS payDate,  supName, cheqDate AS chequeDate, cheqNumber AS chequeNumber,  payAmount as chequeAmount, accountName  FROM chequesout a, purchaseinvoices_payments b, purchaseinvoices c, account d, suppliers e  WHERE a.payId > 0  AND a.payId = b.payId  AND b.invId = c.invId  AND c.supId = e.supId  AND b.accountId = d.accountId  AND c.supId IN (SELECT supId FROM groups_suppliers WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		text = Range switch
		{
			1 => text + " AND payDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND payDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'", 
			3 => text + " AND cheqDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND cheqDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'", 
			_ => text + " AND a.cheqNumber LIKE '%" + ChequeNo + "%'", 
		};
		text = ((BankAccountId <= 0) ? (text + " AND b.accountId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND b.accountId = " + Conversions.ToString(BankAccountId)));
		text = text + " UNION SELECT 0, b.mpayId, mpaydate as payDate,  supName, cheqDate AS chequeDate, cheqNumber AS chequeNumber,  mpayAmount as chequeAmount, accountName  FROM chequesout a, purchaseinvoices_multipayments b, account c, suppliers d  WHERE a.mpayId > 0  AND a.mpayId = b.mpayId  AND b.supId = d.supId  AND b.accountId = c.accountId  AND b.supId IN (SELECT supId FROM groups_suppliers WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		text = Range switch
		{
			1 => text + " AND mpayDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND mpayDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'", 
			3 => text + " AND cheqDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND cheqDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'", 
			_ => text + " AND a.cheqNumber LIKE '%" + ChequeNo + "%'", 
		};
		text = ((BankAccountId <= 0) ? (text + " AND b.accountId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND b.accountId = " + Conversions.ToString(BankAccountId)));
		text += " ORDER BY chequeDate, chequeNumber ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
