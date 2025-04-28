namespace GCUv2;

public class cGroupBankAccount
{
	private int _bankAccountId;

	private string _bankAccountName;

	private int _generalDropDown;

	private int _defaultDropDown;

	private int _transactionDropDown;

	private int _showBalance;

	public int BankAccountId
	{
		get
		{
			return _bankAccountId;
		}
		set
		{
			_bankAccountId = value;
		}
	}

	public string BankAccountName
	{
		get
		{
			return _bankAccountName;
		}
		set
		{
			_bankAccountName = value;
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
