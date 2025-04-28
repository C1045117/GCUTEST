using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cVoucher
{
	private double _voucherId;

	private string _voucherNumber;

	private DateTime _voucherDate;

	private int _voucherType;

	private string _voucherDescription;

	private string _voucherNote;

	private int _salesId;

	private DateTime _voucherCreated;

	private cVoucherAccount[] _account;

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

	public string VoucherNumber
	{
		get
		{
			return _voucherNumber;
		}
		set
		{
			_voucherNumber = value;
		}
	}

	public DateTime VoucherDate
	{
		get
		{
			return _voucherDate;
		}
		set
		{
			_voucherDate = value;
		}
	}

	public int VoucherType
	{
		get
		{
			return _voucherType;
		}
		set
		{
			_voucherType = value;
		}
	}

	public string VoucherDescription
	{
		get
		{
			return _voucherDescription;
		}
		set
		{
			_voucherDescription = Module1.cleanString(value);
		}
	}

	public string VoucherNote
	{
		get
		{
			return _voucherNote;
		}
		set
		{
			_voucherNote = Module1.cleanStringKeepCrlf(value);
		}
	}

	public DateTime VoucherCreated
	{
		get
		{
			return _voucherCreated;
		}
		set
		{
			_voucherCreated = value;
		}
	}

	public int SalesId
	{
		get
		{
			return _salesId;
		}
		set
		{
			_salesId = value;
		}
	}

	public cVoucherAccount[] Account
	{
		get
		{
			return _account;
		}
		set
		{
			_account = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cVoucher(double VoucherId)
	{
		if (!(VoucherId > 0.0))
		{
			return;
		}
		_voucherId = VoucherId;
		string strSql = " SELECT voucherDate, CONCAT('VOU/',SUBSTR(YEAR(voucherDate),3),'/',voucherNumber) as voucherNumber, voucherType,  voucherDescription, voucherNote, salesId  FROM voucher a  WHERE voucherId = " + Conversions.ToString(_voucherId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_voucherDate = Conversions.ToDate(dataTable.Rows[0]["voucherDate"]);
			_voucherNumber = Conversions.ToString(dataTable.Rows[0]["voucherNumber"]);
			_voucherType = Conversions.ToInteger(dataTable.Rows[0]["voucherType"]);
			_voucherDescription = Conversions.ToString(dataTable.Rows[0]["voucherDescription"]);
			_voucherNote = Conversions.ToString(dataTable.Rows[0]["voucherNote"]);
			_salesId = Conversions.ToInteger(dataTable.Rows[0]["salesId"]);
		}
		else
		{
			_voucherId = 0.0;
			Information.Err().Raise(513, null, "Data tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.*, b.accountName, b.accountNumber, c.accountName as counterAccountName,  b.currencyId, a.currencyRate, d.currencyName  FROM voucher_account a, account b, account c, currency d  WHERE a.accountId = b.accountId  AND a.counterAccountId = c.accountId  AND b.currencyId = d.currencyId  AND voucherId = " + Conversions.ToString(_voucherId);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_account = new cVoucherAccount[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_account[num] = new cVoucherAccount();
				_account[num].VoucherId = Conversions.ToDouble(row["voucherId"]);
				_account[num].AccountId = Conversions.ToInteger(row["accountId"]);
				_account[num].AccountNumber = Conversions.ToString(row["accountNumber"]);
				_account[num].AccountName = Conversions.ToString(row["accountName"]);
				_account[num].CounterAccountId = Conversions.ToInteger(row["counterAccountId"]);
				_account[num].CounterAccountName = Conversions.ToString(row["counterAccountName"]);
				_account[num].VoucherDebitCredit = Conversions.ToInteger(row["voucherDebitCredit"]);
				_account[num].VoucherAmount = Conversions.ToDouble(row["voucherAmount"]);
				_account[num].VoucherMain = Conversions.ToInteger(row["voucherMain"]);
				_account[num].CurrencyName = Conversions.ToString(row["currencyName"]);
				_account[num].CurrencyRate = Conversions.ToDouble(row["currencyRate"]);
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void save()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					val = Module1.connectData.BeginTransaction();
					if (_voucherId == 0.0)
					{
						_voucherNumber = GenerateNewNumber();
						string strSql = " INSERT INTO voucher(voucherDate, voucherNumber, voucherType,  voucherDescription, voucherNote, salesId,  voucherCreated)  VALUES ('" + Strings.Format(_voucherDate, "yyyy-MM-dd") + "','" + _voucherNumber + "'," + Conversions.ToString(_voucherType) + ",'" + _voucherDescription + "','" + _voucherNote + "'," + Conversions.ToString(_salesId) + ",'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "')";
						Module1.sqlNonQuery(strSql, "data");
						_voucherId = cDatabase.LastId("data");
					}
					else
					{
						string strSql = " UPDATE voucher  SET voucherDate = '" + Strings.Format(_voucherDate, "yyyy-MM-dd") + "',  voucherType = " + Conversions.ToString(_voucherType) + ",  voucherDescription = '" + _voucherDescription + "',  voucherNote = '" + _voucherNote + "',  salesId = " + Conversions.ToString(_salesId) + " WHERE voucherId = " + Conversions.ToString(_voucherId);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM voucher_account  WHERE voucherId = " + Conversions.ToString(_voucherId);
						Module1.sqlNonQuery(strSql, "data");
					}
					cVoucherAccount[] account = _account;
					foreach (cVoucherAccount cVoucherAccount2 in account)
					{
						string strSql = " INSERT INTO voucher_account  (voucherDebitCredit, voucherAmount, accountId,  counterAccountId, voucherMain, voucherId,  currencyRate) VALUES  ( " + Conversions.ToString(cVoucherAccount2.VoucherDebitCredit) + "," + Module1.unformatNumber(Conversions.ToString(cVoucherAccount2.VoucherAmount)) + "," + Conversions.ToString(cVoucherAccount2.AccountId) + "," + Conversions.ToString(cVoucherAccount2.CounterAccountId) + "," + Conversions.ToString(cVoucherAccount2.VoucherMain) + "," + Conversions.ToString(_voucherId) + "," + Module1.unformatNumber(Conversions.ToString(cVoucherAccount2.CurrencyRate)) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 838:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
						{
							val.Rollback();
						}
						Information.Err().Raise(513, null, Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_037c;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 838;
				continue;
			}
			break;
			IL_037c:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void Delete()
	{
		string strSql = " DELETE FROM voucher WHERE voucherId = " + Conversions.ToString(_voucherId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM voucher_account WHERE voucherId = " + Conversions.ToString(_voucherId);
		Module1.sqlNonQuery(strSql, "data");
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int VoucherType, int AccountId, string Description)
	{
		string text = " SELECT a.voucherId, voucherDate, CONCAT('VOU/',SUBSTR(YEAR(voucherDate),3),'/',voucherNumber) as voucherNumber,  voucherType, voucherDescription, voucherDebitCredit,  voucherAmount, c.accountName, c.accountNumber,  c.currencyId, d.currencyName, b.currencyRate  FROM voucher a, voucher_account b, account c, currency d  WHERE a.voucherId = b.voucherId  AND b.accountId = c.accountId  AND c.currencyId = d.currencyId  AND a.voucherType = " + Conversions.ToString(VoucherType);
		if (intRange == 1)
		{
			text = text + " AND voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		}
		if (AccountId > 0)
		{
			text = text + " AND c.accountId = " + Conversions.ToString(AccountId);
		}
		if (Operators.CompareString(Description, "", TextCompare: false) != 0)
		{
			text = text + " AND a.voucherDescription LIKE '%" + Description + "%'";
		}
		text = ((intRange != 2) ? (text + " ORDER BY voucherDate, voucherId, voucherDebitCredit ") : (text + " ORDER BY voucherId DESC, voucherDebitCredit LIMIT 100 "));
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchCashBank(int intRange, DateTime dateFirst, DateTime dateLast, int VoucherType, int AccountId, int CounterAccountId, int DebitCredit, int SalesId, string Description, int GroupId)
	{
		string text = " SELECT a.voucherId, voucherDate, CONCAT('VOU/',SUBSTR(YEAR(voucherDate),3),'/',voucherNumber) as voucherNumber,  voucherType, voucherDescription, voucherDebitCredit,  voucherAmount, mainAccount.accountName, counterAccount.accountNumber as counterAccountNumber,  counterAccount.accountName as counterAccountName, salesName  FROM voucher a LEFT OUTER JOIN sales ON a.salesId = sales.salesId, voucher_account b, account mainAccount, account counterAccount  WHERE a.voucherId = b.voucherId  AND b.accountId = mainAccount.accountId  AND b.counterAccountId = counterAccount.accountId  AND b.voucherMain = 1  AND a.voucherType = " + Conversions.ToString(VoucherType);
		switch (intRange)
		{
		case 1:
			text = text + " AND voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND voucherDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 2:
			text = text + " AND voucherDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'";
			break;
		}
		if (VoucherType == 2 && GroupId > 0)
		{
			text = text + " AND b.accountId IN (SELECT kgId FROM groupkg  WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1) ";
		}
		else if (VoucherType == 3 && GroupId > 0)
		{
			text = text + " AND b.accountId IN (SELECT tgId FROM grouptg  WHERE groupId = " + Conversions.ToString(GroupId) + " AND transactionDropDown = 1) ";
		}
		if (AccountId > 0)
		{
			text = text + " AND mainAccount.accountId = " + Conversions.ToString(AccountId);
		}
		if (CounterAccountId > 0)
		{
			text = text + " AND counterAccount.accountId = " + Conversions.ToString(CounterAccountId);
		}
		if (DebitCredit > 0)
		{
			text = text + " AND b.voucherDebitCredit = " + Conversions.ToString(DebitCredit);
		}
		if (SalesId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesId);
		}
		if (Operators.CompareString(Description, "", TextCompare: false) != 0)
		{
			text = text + " AND a.voucherDescription LIKE '%" + Description + "%'";
		}
		text = ((intRange != 2) ? (text + " ORDER BY voucherDate ") : (text + " ORDER BY voucherId DESC LIMIT 100 "));
		return Module1.sqlTable(text, "data", Clone: true);
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM Voucher  WHERE YEAR(voucherDate) = " + Conversions.ToString(DateAndTime.Year(_voucherDate)) + " AND voucherType = " + Conversions.ToString(_voucherType) + " ORDER BY voucherId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["voucherNumber"]), 5)) + 1.0))).ToString("00000");
	}
}
