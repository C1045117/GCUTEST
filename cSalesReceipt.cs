using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cSalesReceipt
{
	public struct SalesInvoice
	{
		public double _id;

		public string _number;

		public DateTime _date;

		public double _amount;
	}

	private double _id;

	private int _number;

	private int _month;

	private int _year;

	private DateTime _receiptDate;

	private double _amount;

	private string _receiveFrom;

	private string _name;

	private string _city;

	private SalesInvoice[] _invoice;

	private double _customerId;

	private string _customerName;

	private string _customerAddress;

	private string _customerPT;

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

	public int Number
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

	public int ReceiptMonth
	{
		get
		{
			return _month;
		}
		set
		{
			_month = value;
		}
	}

	public int ReceiptYear
	{
		get
		{
			return _year;
		}
		set
		{
			_year = value;
		}
	}

	public DateTime ReceiptDate
	{
		get
		{
			return _receiptDate;
		}
		set
		{
			_receiptDate = value;
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

	public string ReceiveFrom
	{
		get
		{
			return _receiveFrom;
		}
		set
		{
			_receiveFrom = value;
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

	public string City
	{
		get
		{
			return _city;
		}
		set
		{
			_city = Module1.cleanString(value);
		}
	}

	public SalesInvoice[] Invoice
	{
		get
		{
			return _invoice;
		}
		set
		{
			_invoice = value;
		}
	}

	public double CustomerId
	{
		get
		{
			return _customerId;
		}
		set
		{
			_customerId = value;
		}
	}

	public string CustomerName
	{
		get
		{
			return _customerName;
		}
		set
		{
			_customerName = value;
		}
	}

	public string CustomerAddress
	{
		get
		{
			return _customerAddress;
		}
		set
		{
			_customerAddress = value;
		}
	}

	public string CustomerPT
	{
		get
		{
			return _customerPT;
		}
		set
		{
			_customerPT = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cSalesReceipt(double Id)
	{
		if (!(Id > 0.0))
		{
			return;
		}
		_id = Id;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT *  FROM kuitansi  WHERE kuiId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_number = Conversions.ToInteger(dataTable.Rows[0]["kuiNo"]);
			_month = Conversions.ToInteger(dataTable.Rows[0]["kuiMonth"]);
			_year = Conversions.ToInteger(dataTable.Rows[0]["kuiYear"]);
			_receiptDate = Conversions.ToDate(dataTable.Rows[0]["kuiDate"]);
			_receiveFrom = Conversions.ToString(dataTable.Rows[0]["kuiReceived"]);
			_amount = Conversions.ToDouble(dataTable.Rows[0]["kuiAmount"]);
			_name = Conversions.ToString(dataTable.Rows[0]["kuiName"]);
			_city = Conversions.ToString(dataTable.Rows[0]["kuiCity"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Kuitansi tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT penjId, penjFaktur, penjDate,  penjTotal-penjDisc AS amount, a.custId, custName,  custAddress, custPT  FROM penjualan a, customer b WHERE a.custId = b.custId  AND penjId IN(  SELECT penjId FROM penjKui  WHERE kuiId = " + Conversions.ToString(_id) + ")";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_invoice = new SalesInvoice[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_invoice[num]._id = Conversions.ToDouble(row["penjId"]);
				_invoice[num]._date = Conversions.ToDate(row["penjDate"]);
				_invoice[num]._number = Conversions.ToString(row["penjFaktur"]);
				_invoice[num]._amount = Conversions.ToDouble(row["amount"]);
				_customerId = Conversions.ToDouble(row["custId"]);
				_customerName = Conversions.ToString(row["custName"]);
				_customerAddress = Conversions.ToString(row["custAddress"]);
				_customerPT = Conversions.ToString(row["custPT"]);
				num++;
			}
		}
	}

	public static DataTable Search(int Range, DateTime FirstDate, DateTime LastDate, double CustomerId, int StorageId, int BranchId, int GroupId)
	{
		string text = " SELECT DISTINCT a.*,IF(kuiAmount <= 250000,3000,6000) as meterai, d.custName, d.custPT, c.custId  FROM kuitansi a, penjKui b, penjualan c, customer d  WHERE a.kuiId = b.kuiId  AND b.penjId = c.penjId  AND c.custId = d.custId ";
		if (Range == 1)
		{
			text = text + " AND kuiDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "'  AND kuiDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "' ";
		}
		if (CustomerId > 0.0)
		{
			text = text + " AND (d.custId = " + Conversions.ToString(CustomerId) + " OR custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		if (StorageId > 0)
		{
			text = text + " AND c.storeId = " + Conversions.ToString(StorageId) + " ";
		}
		else
		{
			text = text + " AND c.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
			if (BranchId > 0)
			{
				text = text + " AND d.branchId = " + Conversions.ToString(BranchId) + " ";
			}
		}
		return Module1.sqlTable(Range switch
		{
			2 => text + " ORDER BY kuiId DESC LIMIT 100 ", 
			3 => text + " ORDER BY kuiDate DESC ", 
			_ => text + " ORDER BY kuiYear, kuiMonth, kuiNo ", 
		}, "data", Clone: false);
	}

	public static object FormatSalesReceiptNumber(string ReceiptCode, int ReceiptNumber, int Month, int Year)
	{
		return Conversions.ToString(ReceiptNumber) + "/" + ReceiptCode + "/" + Module1.ConvertToRoman(Month) + "/" + Conversions.ToString(Year);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Save()
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
					if (_id == 0.0)
					{
						_number = Conversions.ToInteger(GenerateNewNumber());
						string strSql = " INSERT INTO kuitansi  (kuiDate,kuiNo,kuiMonth,  kuiYear,kuiAmount,kuiReceived,  kuiName,kuiCity) VALUES  ('" + Strings.Format(_receiptDate, "yyyy-MM-dd") + "','" + Conversions.ToString(_number) + "'," + Conversions.ToString(_month) + "," + Conversions.ToString(_year) + "," + Module1.unformatNumber(Conversions.ToString(_amount)) + ",'" + _receiveFrom + "','" + _name + "','" + _city + "')";
						Module1.sqlNonQuery(strSql, "data");
						_id = cDatabase.LastId("data");
					}
					else
					{
						string strSql = " UPDATE kuitansi  SET kuiAmount = " + Module1.unformatNumber(Conversions.ToString(_amount)) + ", kuiName = '" + _name + "', kuiCity = '" + _city + "' WHERE kuiId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM penjKui  WHERE kuiId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
					}
					SalesInvoice[] invoice = _invoice;
					for (int i = 0; i < invoice.Length; i = checked(i + 1))
					{
						SalesInvoice salesInvoice = invoice[i];
						string strSql = " INSERT INTO penjKui  (penjId, kuiId) VALUES  ( " + Conversions.ToString(salesInvoice._id) + "," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 676:
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
				goto IL_02da;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 676;
				continue;
			}
			break;
			IL_02da:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void Delete()
	{
		string strSql = " DELETE FROM kuitansi WHERE kuiId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM penjKui WHERE kuiId = " + Conversions.ToString(_id);
		Module1.sqlNonQuery(strSql, "data");
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT kuiNo FROM kuitansi  WHERE YEAR(kuiDate) = " + Conversions.ToString(DateAndTime.Year(_receiptDate)) + " AND MONTH(kuiDate) = " + Conversions.ToString(DateAndTime.Month(_receiptDate)) + " ORDER BY kuiNo DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		int num = ((dataTable.Rows.Count <= 0) ? 1 : Conversions.ToInteger(Operators.AddObject(dataTable.Rows[0]["kuiNo"], 1)));
		return Conversions.ToString(num);
	}

	public static DataTable GetReceiptCandidate(int CustomerId, int GroupId)
	{
		string strSql = " SELECT penjId, penjDate, penjFaktur, penjTotal-penjDisc AS amount  FROM penjualan  WHERE custId = " + Conversions.ToString(CustomerId) + " AND (penjTotal-penjBs-penjDisc-penjPot-penjBayar) > 0  AND penjId NOT IN (SELECT penjId FROM penjKui)  AND storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) AND penjBsType = 0  ORDER BY penjDate DESC ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}
}
