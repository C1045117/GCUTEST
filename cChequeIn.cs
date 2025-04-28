using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cChequeIn
{
	private double _id;

	private double _paymentId;

	private double _multiPaymentId;

	private string _number;

	private DateTime _chequeDate;

	private double _amount;

	private DateTime _depositDate;

	private DateTime _clearingDate;

	private int _bankId;

	private string _bankName;

	private string _accountName;

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

	public double Amount
	{
		get
		{
			return _amount;
		}
		set
		{
			_amount = value;
		}
	}

	public DateTime DepositDate
	{
		get
		{
			return _depositDate;
		}
		set
		{
			_depositDate = value;
		}
	}

	public DateTime ClearingDate
	{
		get
		{
			return _clearingDate;
		}
		set
		{
			_clearingDate = value;
		}
	}

	public int BankId
	{
		get
		{
			return _bankId;
		}
		set
		{
			_bankId = value;
		}
	}

	public string BankName
	{
		get
		{
			return _bankName;
		}
		set
		{
			_bankName = value;
		}
	}

	public string AccountName
	{
		get
		{
			return _accountName;
		}
		set
		{
			_accountName = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cChequeIn(double ChequeId, double PaymentId, double MultiPaymentId)
	{
		string strSql;
		if (ChequeId > 0.0)
		{
			_id = ChequeId;
			strSql = " SELECT a.*, b.bankName, accountName  FROM girocek a, bank b, account c WHERE gcId = " + Conversions.ToString(_id) + " AND a.bankId = b.bankId  AND a.tgId = c.accountId ";
		}
		else if (MultiPaymentId > 0.0)
		{
			this.MultiPaymentId = MultiPaymentId;
			strSql = " SELECT a.*, b.bankName, accountName  FROM girocek a, bank b, account c WHERE pbgId = " + Conversions.ToString(_multiPaymentId) + " AND a.bankId = b.bankId  AND a.tgId = c.accountId ";
		}
		else
		{
			_paymentId = PaymentId;
			strSql = " SELECT a.*, b.bankName, accountName  FROM girocek a, bank b, account c WHERE pbId = " + Conversions.ToString(_paymentId) + " AND a.bankId = b.bankId  AND a.tgId = c.accountId ";
		}
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_id = Conversions.ToDouble(dataTable.Rows[0]["gcId"]);
			_number = Conversions.ToString(dataTable.Rows[0]["gcNo"]);
			_chequeDate = Conversions.ToDate(dataTable.Rows[0]["gcDate"]);
			_amount = Conversions.ToDouble(dataTable.Rows[0]["gcAmount"]);
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["gcSetorDate"])))
			{
				_depositDate = Conversions.ToDate(dataTable.Rows[0]["gcSetorDate"]);
			}
			if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["gcMasukDate"])))
			{
				_clearingDate = Conversions.ToDate(dataTable.Rows[0]["gcMasukDate"]);
			}
			_bankId = Conversions.ToInteger(dataTable.Rows[0]["bankId"]);
			_bankName = Conversions.ToString(dataTable.Rows[0]["bankName"]);
			_accountName = Conversions.ToString(dataTable.Rows[0]["accountName"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Cek tidak ditemukan. Kemungkinan telah dihapus.");
		}
	}

	public static void SaveDepositClearingDate(double ChequeId, bool Deposit, DateTime DepositDate, bool Clearing, DateTime ClearingDate)
	{
		string text = " UPDATE girocek SET ";
		text = (Deposit ? (text + " gcSetorDate = '" + Strings.Format(DepositDate, "yyyy-MM-dd") + "',") : (text + " gcSetorDate = NULL, "));
		text = (Clearing ? (text + " gcMasukDate = '" + Strings.Format(ClearingDate, "yyyy-MM-dd") + "'") : (text + " gcMasukDate = NULL "));
		text = text + " WHERE gcId = " + Conversions.ToString(ChequeId);
		Module1.sqlNonQuery(text, "data");
	}

	public static DataTable Search(int Range, DateTime FirstDate, DateTime LastDate, string ChequeNo, int BankAccountId, int GroupId)
	{
		string text = " SELECT a.*,b.bankName,c.custName,d.accountName  FROM GiroCek a,Bank b,Customer c, account d  WHERE a.bankId = b.bankId  AND a.custId = c.custId  AND a.tgId = d.accountId ";
		switch (Range)
		{
		case 1:
			text = text + " AND gcReceivedDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND gcReceivedDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'";
			break;
		case 3:
			text = text + " AND gcDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND gcDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'";
			break;
		case 4:
			text = text + " AND gcSetorDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND gcSetorDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'";
			break;
		case 5:
			text = text + " AND gcMasukDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND gcMasukDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'";
			break;
		case 6:
			text += " AND gcSetorDate IS NULL ";
			break;
		case 7:
			text += " AND gcSetorDate IS NOT NULL AND gcMasukDate IS NULL ";
			break;
		case 8:
			text = text + " AND gcNo LIKE '%" + ChequeNo + "%'";
			break;
		}
		text = ((BankAccountId <= 0) ? (text + " AND a.tgId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text + " AND a.tgId = " + Conversions.ToString(BankAccountId)));
		text += " ORDER BY gcReceivedDate ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
