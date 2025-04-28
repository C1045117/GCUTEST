namespace GCUv2;

public class cGroupCashAccount
{
	private int _cashAccountId;

	private string _cashAccountName;

	private int _generalDropDown;

	private int _defaultDropDown;

	private int _transactionDropDown;

	private int _showBalance;

	public int CashAccountId
	{
		get
		{
			return _cashAccountId;
		}
		set
		{
			_cashAccountId = value;
		}
	}

	public string CashAccountName
	{
		get
		{
			return _cashAccountName;
		}
		set
		{
			_cashAccountName = value;
		}
	}

	public int GeneralDropDown
	{
		get
		{
			return _generalDropDown;
		}
		set
		{
			_generalDropDown = value;
		}
	}

	public int DefaultDropDown
	{
		get
		{
			return _defaultDropDown;
		}
		set
		{
			_defaultDropDown = value;
		}
	}

	public int TransactionDropDown
	{
		get
		{
			return _transactionDropDown;
		}
		set
		{
			_transactionDropDown = value;
		}
	}

	public int ShowBalance
	{
		get
		{
			return _showBalance;
		}
		set
		{
			_showBalance = value;
		}
	}
}
