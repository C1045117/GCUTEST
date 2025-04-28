using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cAccount
{
	private int _id;

	private string _name;

	private string _number;

	private int _typeId;

	private string _typeName;

	private int _cashBank;

	private int _currencyId;

	private string _currencyName;

	private double _currencyRate;

	private int _cashIncome;

	private int _cashExpense;

	private int _bankIncome;

	private int _bankExpense;

	private int _parentId;

	private double _balanceAmount;

	private DateTime _balanceDate;

	private int _active;

	private int _branchId;

	private int _builtIn;

	private int _level;

	private int _isParent;

	public int Id
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

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
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

	public int TypeId
	{
		get
		{
			return _typeId;
		}
		set
		{
			_typeId = value;
		}
	}

	public string TypeName
	{
		get
		{
			return _typeName;
		}
		set
		{
			_typeName = value;
		}
	}

	public int CashBank
	{
		get
		{
			return _cashBank;
		}
		set
		{
			_cashBank = value;
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

	public int CashIncome
	{
		get
		{
			return _cashIncome;
		}
		set
		{
			_cashIncome = value;
		}
	}

	public int CashExpense
	{
		get
		{
			return _cashExpense;
		}
		set
		{
			_cashExpense = value;
		}
	}

	public int BankIncome
	{
		get
		{
			return _bankIncome;
		}
		set
		{
			_bankIncome = value;
		}
	}

	public int BankExpense
	{
		get
		{
			return _bankExpense;
		}
		set
		{
			_bankExpense = value;
		}
	}

	public int ParentId
	{
		get
		{
			return _parentId;
		}
		set
		{
			_parentId = value;
		}
	}

	public double BalanceAmount
	{
		get
		{
			return _balanceAmount;
		}
		set
		{
			_balanceAmount = value;
		}
	}

	public DateTime BalanceDate
	{
		get
		{
			return _balanceDate;
		}
		set
		{
			_balanceDate = value;
		}
	}

	public int Active
	{
		get
		{
			return _active;
		}
		set
		{
			_active = value;
		}
	}

	public int BranchId
	{
		get
		{
			return _branchId;
		}
		set
		{
			_branchId = value;
		}
	}

	public int BuiltIn
	{
		get
		{
			return _builtIn;
		}
		set
		{
			_builtIn = value;
		}
	}

	public int Level
	{
		get
		{
			return _level;
		}
		set
		{
			_level = value;
		}
	}

	public int IsParent
	{
		get
		{
			return _isParent;
		}
		set
		{
			_isParent = value;
		}
	}

	public cAccount(int AccountId)
	{
		if (AccountId > 0)
		{
			_id = AccountId;
			string strSql = " SELECT *  FROM account a, accountType b, currency c  WHERE a.accountTypeId = b.accountTypeId  AND a.currencyId = c.currencyId  AND accountId = " + Conversions.ToString(_id);
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["accountName"]);
				_number = Conversions.ToString(dataTable.Rows[0]["accountNumber"]);
				_typeId = Conversions.ToInteger(dataTable.Rows[0]["accountTypeId"]);
				_typeName = Conversions.ToString(dataTable.Rows[0]["accountTypeName"]);
				_cashBank = Conversions.ToInteger(dataTable.Rows[0]["accountCashBank"]);
				_currencyId = Conversions.ToInteger(dataTable.Rows[0]["currencyId"]);
				_currencyName = Conversions.ToString(dataTable.Rows[0]["currencyName"]);
				_currencyRate = Conversions.ToDouble(dataTable.Rows[0]["currencyRate"]);
				_cashIncome = Conversions.ToInteger(dataTable.Rows[0]["accountCashIncome"]);
				_cashExpense = Conversions.ToInteger(dataTable.Rows[0]["accountCashExpense"]);
				_bankIncome = Conversions.ToInteger(dataTable.Rows[0]["accountBankIncome"]);
				_bankExpense = Conversions.ToInteger(dataTable.Rows[0]["accountBankExpense"]);
				_parentId = Conversions.ToInteger(dataTable.Rows[0]["accountParentId"]);
				_balanceAmount = Conversions.ToDouble(dataTable.Rows[0]["accountBalanceAmount"]);
				_balanceDate = Conversions.ToDate(dataTable.Rows[0]["accountBalanceDate"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["accountActive"]);
				_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
				_builtIn = Conversions.ToInteger(dataTable.Rows[0]["accountBuiltIn"]);
				_level = Conversions.ToInteger(dataTable.Rows[0]["accountLevel"]);
				_isParent = Conversions.ToInteger(dataTable.Rows[0]["accountIsParent"]);
			}
		}
	}

	public void Save()
	{
		string strSql;
		if (_id == 0)
		{
			strSql = " INSERT INTO account  (accountName,accountNumber,accountTypeId,  currencyId, accountCashIncome, accountCashExpense, accountBankIncome, accountBankExpense, accountParentId,  accountBalanceAmount, accountBalanceDate, branchId,  accountIsParent, accountActive  ) VALUES  ('" + _name + "','" + _number + "', " + Conversions.ToString(_typeId) + "," + Conversions.ToString(_currencyId) + "," + Conversions.ToString(_cashIncome) + "," + Conversions.ToString(_cashExpense) + "," + Conversions.ToString(_bankIncome) + "," + Conversions.ToString(_bankExpense) + "," + Conversions.ToString(_parentId) + "," + Conversions.ToString(_balanceAmount) + ",'" + Strings.Format(_balanceDate, "yyyy-MM-dd") + "'," + Conversions.ToString(_branchId) + "," + Conversions.ToString(_isParent) + "," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
			_id = checked((int)Math.Round(cDatabase.LastId("data")));
			if (_parentId == 0)
			{
				strSql = " UPDATE account SET  accountParentId = " + Conversions.ToString(_id) + " WHERE accountId = " + Conversions.ToString(_id);
				Module1.sqlNonQuery(strSql, "data");
				_parentId = _id;
			}
		}
		else
		{
			strSql = " UPDATE account  SET accountName = '" + _name + "',  accountNumber = '" + _number + "',  accountTypeId = " + Conversions.ToString(_typeId) + ", currencyId = " + Conversions.ToString(_currencyId) + ", accountCashIncome = " + Conversions.ToString(_cashIncome) + ", accountCashExpense = " + Conversions.ToString(_cashExpense) + ", accountBankIncome = " + Conversions.ToString(_bankIncome) + ", accountBankExpense = " + Conversions.ToString(_bankExpense) + ", accountParentId = " + Conversions.ToString(_parentId) + ", accountBalanceAmount = " + Module1.unformatNumber(Conversions.ToString(_balanceAmount)) + ", accountBalanceDate = '" + Strings.Format(_balanceDate, "yyyy-MM-dd") + "', branchId = " + Conversions.ToString(_branchId) + ", accountIsParent = " + Conversions.ToString(_isParent) + ", accountActive = " + Conversions.ToString(_active) + " WHERE accountId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
		int num = _parentId;
		int num2;
		if (_id != _parentId)
		{
			num2 = 1;
			bool flag = default(bool);
			while (!(num == 1 || num == 2 || flag))
			{
				strSql = " SELECT *  FROM account  WHERE accountId = " + Conversions.ToString(num);
				DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
				num2 = checked(num2 + 1);
				if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["accountId"], dataTable.Rows[0]["accountParentId"], TextCompare: false))
				{
					_cashBank = 0;
					flag = true;
				}
				else
				{
					num = Conversions.ToInteger(dataTable.Rows[0]["accountParentId"]);
				}
			}
		}
		else
		{
			num2 = 0;
		}
		_level = num2;
		if (((num2 > 0) & (_isParent == 0)) && num == 1)
		{
			_cashBank = 1;
		}
		else if (((num2 > 0) & (_isParent == 0)) && num == 2)
		{
			_cashBank = 2;
		}
		else
		{
			_cashBank = 0;
		}
		strSql = " UPDATE account  SET accountCashBank = " + Conversions.ToString(_cashBank) + ", accountLevel = " + Conversions.ToString(_level) + " WHERE accountId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
	}

	public static DataTable Search(int AccountTypeId, int AccountIsParent, int CurrentAccountId, int AccountCashBank, int AccountCashIncomeExpense, int AccountBankIncomeExpense, int CurrencyId, int Active)
	{
		string text = " SELECT *  FROM account a, accountType b  WHERE a.accountTypeId = b.accountTypeId ";
		if (AccountTypeId > 0)
		{
			text = text + " AND a.accountTypeId = " + Conversions.ToString(AccountTypeId);
		}
		switch (AccountIsParent)
		{
		case 1:
			text += " AND accountIsParent = 1 ";
			break;
		case 0:
			text += " AND accountIsParent = 0 ";
			break;
		}
		if (CurrentAccountId > 0)
		{
			text = text + " AND accountId <> " + Conversions.ToString(CurrentAccountId);
		}
		switch (AccountCashBank)
		{
		case 1:
			text += " AND accountCashBank = 1 ";
			break;
		case 2:
			text += " AND accountCashBank = 2 ";
			break;
		case 0:
			text += " AND accountCashBank = 0 ";
			break;
		}
		switch (AccountCashIncomeExpense)
		{
		case 1:
			text += " AND accountCashIncome = 1 ";
			break;
		case 2:
			text += " AND accountCashExpense = 1 ";
			break;
		case 3:
			text += " AND (accountCashIncome = 1 OR accountCashExpense = 1) ";
			break;
		}
		switch (AccountBankIncomeExpense)
		{
		case 1:
			text += " AND accountBankIncome = 1 ";
			break;
		case 2:
			text += " AND accountBankExpense = 1 ";
			break;
		case 3:
			text += " AND (accountBankIncome = 1 OR accountBankExpense = 1) ";
			break;
		}
		if (CurrencyId > 0)
		{
			text = text + " AND currencyId = " + Conversions.ToString(CurrencyId);
		}
		switch (Active)
		{
		case 0:
			text += " AND accountActive = 0 ";
			break;
		case 1:
			text += " AND accountActive = 1 ";
			break;
		}
		text += " ORDER BY accountNumber ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable SearchForTransaction(int CurrentAccountId, int AccountCashIncomeExpense, int AccountBankIncomeExpense, int CurrencyId, int GroupId, int Active)
	{
		string text = " SELECT *  FROM account a, accountType b  WHERE a.accountTypeId = b.accountTypeId  AND accountIsParent = 0  AND accountCashBank = 0 ";
		switch (AccountCashIncomeExpense)
		{
		case 1:
			text += " AND accountCashIncome = 1 ";
			break;
		case 2:
			text += " AND accountCashExpense = 1 ";
			break;
		case 3:
			text += " AND (accountCashIncome = 1 OR accountCashExpense = 1) ";
			break;
		}
		switch (AccountBankIncomeExpense)
		{
		case 1:
			text += " AND accountBankIncome = 1 ";
			break;
		case 2:
			text += " AND accountBankExpense = 1 ";
			break;
		case 3:
			text += " AND (accountBankIncome = 1 OR accountBankExpense = 1) ";
			break;
		}
		if (CurrencyId > 0)
		{
			text = text + " AND currencyId = " + Conversions.ToString(CurrencyId);
		}
		switch (Active)
		{
		case 0:
			text += " AND accountActive = 0 ";
			break;
		case 1:
			text += " AND accountActive = 1 ";
			break;
		}
		text += " UNION ALL  SELECT *  FROM account a, accountType b  WHERE a.accountTypeId = b.accountTypeId  AND accountCashBank > 0 ";
		if (CurrentAccountId > 0)
		{
			text = text + " AND accountId <> " + Conversions.ToString(CurrentAccountId);
		}
		switch (AccountCashIncomeExpense)
		{
		case 1:
			text += " AND accountCashIncome = 1 ";
			break;
		case 2:
			text += " AND accountCashExpense = 1 ";
			break;
		case 3:
			text += " AND (accountCashIncome = 1 OR accountCashExpense = 1) ";
			break;
		}
		switch (AccountBankIncomeExpense)
		{
		case 1:
			text += " AND accountBankIncome = 1 ";
			break;
		case 2:
			text += " AND accountBankExpense = 1 ";
			break;
		case 3:
			text += " AND (accountBankIncome = 1 OR accountBankExpense = 1) ";
			break;
		}
		if (CurrencyId > 0)
		{
			text = text + " AND currencyId = " + Conversions.ToString(CurrencyId);
		}
		switch (Active)
		{
		case 0:
			text += " AND accountActive = 0 ";
			break;
		case 1:
			text += " AND accountActive = 1 ";
			break;
		}
		if (GroupId > 0)
		{
			text = text + " AND (accountId IN (SELECT kgId FROM groupKg WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1)  OR accountId IN (SELECT tgId FROM groupTg WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1)) ";
		}
		text += " ORDER BY accountNumber ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable GetAccountType()
	{
		string strSql = " SELECT *  FROM accountType  ORDER BY accountTypeId ";
		return Module1.sqlTable(strSql, "read", Clone: false);
	}
}
