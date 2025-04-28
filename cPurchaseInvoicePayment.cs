using System;

namespace GCUv2;

public class cPurchaseInvoicePayment
{
	private double _paymentId;

	private double _multiPaymentId;

	private double _invoiceId;

	private DateTime _invoiceDate;

	private string _invoiceNumber;

	private double _invoicePayable;

	private byte _paymentCodeId;

	private string _paymentCodeName;

	private DateTime _paymentDate;

	private double _Amount;

	private byte _InFront;

	private double _chequeId;

	private DateTime _chequeDate;

	private string _chequeNumber;

	private DateTime _createdDate;

	private string _accountName;

	private int _accountId;

	private int _currencyId;

	private double _currencyRate;

	private string _currencyName;

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

	public double InvoicePayable
	{
		get
		{
			return _invoicePayable;
		}
		set
		{
			_invoicePayable = value;
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
			return _Amount;
		}
		set
		{
			_Amount = value;
		}
	}

	public byte InFront
	{
		get
		{
			return _InFront;
		}
		set
		{
			_InFront = value;
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

	public int CurrencyId
	{
		get
		{
			return _currencyId;
		}
		set
		{
			_currencyId = value;
		}
	}

	public string CurrencyName
	{
		get
		{
			return _currencyName;
		}
		set
		{
			_currencyName = value;
		}
	}

	public double CurrencyRate
	{
		get
		{
			return _currencyRate;
		}
		set
		{
			_currencyRate = value;
		}
	}
}
