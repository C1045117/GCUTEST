using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cSalesInvoicePayment
{
	private double _paymentId;

	private double _multiPaymentId;

	private byte _paymentCodeId;

	private string _paymentCodeName;

	private int _salesPersonId;

	private string _salesPersonName;

	private DateTime _paymentDate;

	private double _amount;

	private int _bankId;

	private string _bankName;

	private double _chequeId;

	private DateTime _chequeDate;

	private string _chequeNumber;

	private DateTime _chequeDepositDate;

	private DateTime _chequeClearingDate;

	private DateTime _createdDate;

	private string _accountName;

	private int _accountId;

	private double _invoiceId;

	private DateTime _invoiceDate;

	private string _invoiceNumber;

	private double _invoiceReceivable;

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

	public byte PaymentCodeId
	{
		get
		{
			return _paymentCodeId;
		}
		set
		{
			_paymentCodeId = value;
		}
	}

	public string PaymentCodeName
	{
		get
		{
			return _paymentCodeName;
		}
		set
		{
			_paymentCodeName = value;
		}
	}

	public int SalesPersonId
	{
		get
		{
			return _salesPersonId;
		}
		set
		{
			_salesPersonId = value;
		}
	}

	public string SalesPersonName
	{
		get
		{
			return _salesPersonName;
		}
		set
		{
			_salesPersonName = value;
		}
	}

	public DateTime PaymentDate
	{
		get
		{
			return _paymentDate;
		}
		set
		{
			_paymentDate = value;
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

	public double ChequeId
	{
		get
		{
			return _chequeId;
		}
		set
		{
			_chequeId = value;
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

	public string ChequeNumber
	{
		get
		{
			return _chequeNumber;
		}
		set
		{
			_chequeNumber = value;
		}
	}

	public DateTime ChequeDepositDate
	{
		get
		{
			return _chequeDepositDate;
		}
		set
		{
			_chequeDepositDate = value;
		}
	}

	public DateTime ChequeClearingDate
	{
		get
		{
			return _chequeClearingDate;
		}
		set
		{
			_chequeClearingDate = value;
		}
	}

	public DateTime CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}

	public int AccountId
	{
		get
		{
			return _accountId;
		}
		set
		{
			_accountId = value;
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

	public DateTime InvoiceDate
	{
		get
		{
			return _invoiceDate;
		}
		set
		{
			_invoiceDate = value;
		}
	}

	public string InvoiceNumber
	{
		get
		{
			return _invoiceNumber;
		}
		set
		{
			_invoiceNumber = value;
		}
	}

	public double InvoiceReceivable
	{
		get
		{
			return _invoiceReceivable;
		}
		set
		{
			_invoiceReceivable = value;
		}
	}

	public static DataTable Search(int Range, DateTime DateFirst, DateTime DateLast, double CustomerId, int PaymentCodeId, int SalesPersonId, int IsReturn, int StorageId, int BranchId, int GroupId)
	{
		string text = "";
		string text2 = "";
		text = " SELECT 0 AS penjId, pbgId, pbgDate AS paymentDate,  custName, CONCAT('M-',b.pkName) AS pkName, pbgAmount AS paymentAmount,  pbgAmount-allocatedAmount AS paymentRemainder, salesName, '0' AS type, createdDate  FROM PenjBayarGroup a, pembKode b, sales c, customer d  WHERE a.pkId = b.pkId  AND a.salesId = c.salesId  AND a.custId = d.custId ";
		if (Range == 1)
		{
			text = text + " AND pbgDate >= '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND pbgDate <= '" + Strings.Format(DateLast, "yyyy-MM-dd") + "' ";
		}
		if (CustomerId > 0.0)
		{
			text2 = text2 + " AND (d.custId = " + Conversions.ToString(CustomerId) + " OR d.custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		text2 = ((StorageId <= 0) ? (text2 + " AND d.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ") : (text2 + " AND d.storeId = " + Conversions.ToString(StorageId) + " "));
		if (BranchId > 0)
		{
			text2 = text2 + " AND d.branchId = " + Conversions.ToString(BranchId);
		}
		if (PaymentCodeId > 0)
		{
			text2 = text2 + " AND a.pkId = " + Conversions.ToString(PaymentCodeId);
		}
		if (SalesPersonId > 0)
		{
			text2 = text2 + " AND a.salesId = " + Conversions.ToString(SalesPersonId);
		}
		text += text2;
		if (IsReturn == 1)
		{
			text = "";
		}
		if (Operators.CompareString(text, "", TextCompare: false) != 0)
		{
			text += " UNION ";
		}
		text = text + " SELECT a.penjId AS penjId, 0 AS pbgId, pbDate AS paymentDate,  custName, b.pkName, IF(penjBsType>0,pbAmount*-1,pbAmount) AS paymentAmount,  0 AS paymentRemainder, salesName, '1' AS type, createdDate  FROM PenjBayar a, pembKode b, sales c, customer d, penjualan e  WHERE a.pkId = b.pkId  AND a.salesId = c.salesId  AND a.penjId = e.penjId  AND e.custId = d.custId  AND pbgId = 0  AND e.penjBsType = " + Conversions.ToString(IsReturn);
		switch (Range)
		{
		case 1:
			text = text + " AND pbDate >= '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND pbDate <= '" + Strings.Format(DateLast, "yyyy-MM-dd") + "' ";
			break;
		case 2:
			text = text + " AND pbDate >= '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'";
			break;
		}
		text += text2;
		return Module1.sqlTable(Range switch
		{
			2 => text + " ORDER BY createdDate DESC LIMIT 100", 
			3 => text + " ORDER BY paymentDate DESC ", 
			_ => text + " ORDER BY paymentDate ", 
		}, "data", Clone: false);
	}
}
