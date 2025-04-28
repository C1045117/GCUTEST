namespace GCUv2;

public class cVoucherAccount
{
	private int _voucherDebitCredit;

	private double _voucherAmount;

	private int _accountId;

	private string _accountNumber;

	private string _accountName;

	private int _counterAccountId;

	private string _counterAccountName;

	private double _voucherId;

	private int _voucherMain;

	private double _currencyRate;

	private string _currencyName;

	public int VoucherDebitCredit
	{
		get
		{
			return _voucherDebitCredit;
		}
		set
		{
			_voucherDebitCredit = value;
		}
	}

	public double VoucherAmount
	{
		get
		{
			return _voucherAmount;
		}
		set
		{
			_voucherAmount = value;
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

	public string AccountNumber
	{
		get
		{
			return _accountNumber;
		}
		set
		{
			_accountNumber = value;
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

	public int CounterAccountId
	{
		get
		{
			return _counterAccountId;
		}
		set
		{
			_counterAccountId = value;
		}
	}

	public string CounterAccountName
	{
		get
		{
			return _counterAccountName;
		}
		set
		{
			_counterAccountName = value;
		}
	}

	public double VoucherId
	{
		get
		{
			return _voucherId;
		}
		set
		{
			_voucherId = value;
		}
	}

	public int VoucherMain
	{
		get
		{
			return _voucherMain;
		}
		set
		{
			_voucherMain = value;
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
