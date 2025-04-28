using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cCurrency
{
	private int _id;

	private string _name;

	private string _symbol;

	private double _rate;

	private int _active;

	private int _accountPayableId;

	private int _accountReceivableId;

	private int _advancePurchaseId;

	private int _advanceSalesId;

	private int _realizeGainLossId;

	private int _unrealizeGainLossId;

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
			_name = Module1.cleanString(value);
		}
	}

	public string Symbol
	{
		get
		{
			return _symbol;
		}
		set
		{
			_symbol = Module1.cleanString(value);
		}
	}

	public double Rate
	{
		get
		{
			return _rate;
		}
		set
		{
			_rate = value;
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

	public int AccountPayableId
	{
		get
		{
			return _accountPayableId;
		}
		set
		{
			_accountPayableId = value;
		}
	}

	public int AccountReceivableId
	{
		get
		{
			return _accountReceivableId;
		}
		set
		{
			_accountReceivableId = value;
		}
	}

	public int AdvancePurchaseId
	{
		get
		{
			return _advancePurchaseId;
		}
		set
		{
			_advancePurchaseId = value;
		}
	}

	public int AdvanceSalesId
	{
		get
		{
			return _advanceSalesId;
		}
		set
		{
			_advanceSalesId = value;
		}
	}

	public int RealizeGainLossId
	{
		get
		{
			return _realizeGainLossId;
		}
		set
		{
			_realizeGainLossId = value;
		}
	}

	public int UnrealizeGainLossId
	{
		get
		{
			return _unrealizeGainLossId;
		}
		set
		{
			_unrealizeGainLossId = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cCurrency(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM currency  WHERE currencyId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["currencyName"]);
				_symbol = Conversions.ToString(dataTable.Rows[0]["currencySymbol"]);
				_rate = Conversions.ToDouble(dataTable.Rows[0]["currencyRate"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["currencyActive"]);
				_accountPayableId = Conversions.ToInteger(dataTable.Rows[0]["accountPayableId"]);
				_accountReceivableId = Conversions.ToInteger(dataTable.Rows[0]["accountReceivableId"]);
				_advancePurchaseId = Conversions.ToInteger(dataTable.Rows[0]["advancePurchaseId"]);
				_advanceSalesId = Conversions.ToInteger(dataTable.Rows[0]["advanceSalesId"]);
				_realizeGainLossId = Conversions.ToInteger(dataTable.Rows[0]["realizeGainLossId"]);
				_unrealizeGainLossId = Conversions.ToInteger(dataTable.Rows[0]["unrealizeGainLossId"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Mata uang tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void Save()
	{
		string strSql;
		if (_id == 0)
		{
			strSql = " INSERT INTO currency(currencyName, currencySymbol, currencyRate, currencyActive)  VALUES  ('" + _name + "', '" + _symbol + "'," + Module1.unformatNumber(Conversions.ToString(_rate)) + "," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
			_id = checked((int)Math.Round(cDatabase.LastId("data")));
			CreateDefaultAccount();
		}
		else
		{
			strSql = " UPDATE currency  SET currencyName = '" + _name + "',  currencySymbol = '" + _symbol + "', currencyRate = " + Module1.unformatNumber(Conversions.ToString(_rate)) + ",  currencyActive = " + Conversions.ToString(_active) + " WHERE currencyId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
		strSql = " UPDATE currency  SET accountPayableId = " + Conversions.ToString(_accountPayableId) + ",  accountReceivableId = " + Conversions.ToString(_accountReceivableId) + ",  advancePurchaseId = " + Conversions.ToString(_advancePurchaseId) + ",  advanceSalesId = " + Conversions.ToString(_advanceSalesId) + ",  realizeGainLossId = " + Conversions.ToString(_realizeGainLossId) + ",  unrealizeGainLossId = " + Conversions.ToString(_unrealizeGainLossId) + " WHERE currencyId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
	}

	private void CreateDefaultAccount()
	{
		cAccount cAccount2 = new cAccount(0);
		cAccount2.Id = 0;
		cAccount2.Name = "Hutang Usaha " + _name;
		cAccount2.Number = "???";
		cAccount2.TypeId = 8;
		cAccount2.CurrencyId = _id;
		cAccount2.ParentId = 0;
		cAccount2.IsParent = 0;
		cAccount2.BalanceAmount = 0.0;
		cAccount2.BalanceDate = DateAndTime.Now;
		cAccount2.BranchId = 0;
		cAccount2.CashIncome = 0;
		cAccount2.CashExpense = 0;
		cAccount2.BankIncome = 0;
		cAccount2.BankExpense = 0;
		cAccount2.Active = 1;
		cAccount2.Save();
		_accountPayableId = cAccount2.Id;
		cAccount2.Id = 0;
		cAccount2.Name = "Piutang Usaha " + _name;
		cAccount2.Number = "???";
		cAccount2.ParentId = 0;
		cAccount2.TypeId = 2;
		cAccount2.Save();
		_accountReceivableId = cAccount2.Id;
		cAccount2.Id = 0;
		cAccount2.Name = "Uang Muka Pembelian " + _name;
		cAccount2.Number = "???";
		cAccount2.ParentId = 0;
		cAccount2.TypeId = 8;
		cAccount2.Save();
		_advancePurchaseId = cAccount2.Id;
		cAccount2.Id = 0;
		cAccount2.Name = "Uang Muka Penjualan " + _name;
		cAccount2.Number = "???";
		cAccount2.ParentId = 0;
		cAccount2.TypeId = 2;
		cAccount2.Save();
		_advanceSalesId = cAccount2.Id;
		cAccount2.Id = 0;
		cAccount2.Name = "Laba/Rugi Terealisir " + _name;
		cAccount2.Number = "???";
		cAccount2.ParentId = 0;
		cAccount2.TypeId = 14;
		cAccount2.Save();
		_realizeGainLossId = cAccount2.Id;
		cAccount2.Id = 0;
		cAccount2.Name = "Laba/Rugi Belum Terealisir " + _name;
		cAccount2.Number = "???";
		cAccount2.ParentId = 0;
		cAccount2.TypeId = 14;
		cAccount2.Save();
		_unrealizeGainLossId = cAccount2.Id;
	}

	public static DataTable Search(int Active)
	{
		string text = " SELECT *  FROM currency ";
		switch (Active)
		{
		case 0:
			text += " WHERE currencyActive = 0 ";
			break;
		case 1:
			text += " WHERE currencyActive = 1 ";
			break;
		}
		text += " ORDER BY currencyName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name, string Symbol)
	{
		bool result = false;
		string text = " SELECT * FROM currency  WHERE (currencyName = '" + Name + "' OR currencySymbol = '" + Symbol + "')";
		if (Id > 0)
		{
			text = text + " AND currencyId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static DataTable GetCurrencyOfAccount(int AccountId)
	{
		string strSql = " SELECT * FROM currency  WHERE currencyId IN (SELECT currencyId FROM account WHERE accountId = " + Conversions.ToString(AccountId) + ")";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static int GetAccountPayableId(int CurrencyId)
	{
		string strSql = " SELECT accountPayableId  FROM currency  WHERE currencyId = " + Conversions.ToString(CurrencyId);
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		return Conversions.ToInteger(dataTable.Rows[0]["accountPayableId"]);
	}
}
