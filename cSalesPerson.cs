using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cSalesPerson
{
	private int _id;

	private string _name;

	private string _code;

	private int _isCollector;

	private int _isDonator;

	private int _branchId;

	private string _branchName;

	private int _active;

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

	public string Code
	{
		get
		{
			return _code;
		}
		set
		{
			_code = value;
		}
	}

	public int IsCollector
	{
		get
		{
			return _isCollector;
		}
		set
		{
			_isCollector = value;
		}
	}

	public int IsDonator
	{
		get
		{
			return _isDonator;
		}
		set
		{
			_isDonator = value;
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

	public string BranchName
	{
		get
		{
			return _branchName;
		}
		set
		{
			_branchName = value;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cSalesPerson(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT a.*, b.branchName  FROM sales a, branches b  WHERE a.branchId = b.branchId  AND salesId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["salesName"]);
				_code = Conversions.ToString(dataTable.Rows[0]["salesFakNo"]);
				_isCollector = Conversions.ToInteger(dataTable.Rows[0]["salesKol"]);
				_isDonator = Conversions.ToInteger(dataTable.Rows[0]["salesDonation"]);
				_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
				_branchName = Conversions.ToString(dataTable.Rows[0]["branchName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["salesStatus"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Sales tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO sales(salesName, salesKol, salesDonation,  branchId, salesStatus)  VALUES  ('" + _name + "', " + Conversions.ToString(_isCollector) + "," + Conversions.ToString(_isDonator) + "," + Conversions.ToString(_branchId) + "," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE sales  SET salesName = '" + _name + "',  salesKol = " + Conversions.ToString(_isCollector) + ", salesDonation = " + Conversions.ToString(_isDonator) + ", branchId = " + Conversions.ToString(_branchId) + ", salesStatus = " + Conversions.ToString(_active) + "  WHERE salesId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(string PersonType, int SalesId, int Donator, int BranchId, int GroupId, int Active)
	{
		string text = " SELECT a.*, branchName  FROM sales a, branches b  WHERE a.branchId = b.branchId ";
		switch (Active)
		{
		case 0:
			text += " AND salesStatus = 0 ";
			break;
		case 1:
			text += " AND salesStatus = 1 ";
			break;
		}
		switch (PersonType)
		{
		case "SALESPERSON":
			text += " AND salesKol = 0 ";
			break;
		case "COLLECTOR":
			text += " AND salesKol = 1 ";
			break;
		case "SALESPERSON_COLLECTOR":
			text = text + " AND (salesKol = 1 OR salesId = " + Conversions.ToString(SalesId) + ")";
			break;
		}
		switch (Donator)
		{
		case 0:
			text += " AND salesDonation = 0 ";
			break;
		case 1:
			text += " AND salesDonation = 1 ";
			break;
		}
		text = ((BranchId <= 0) ? (text + " AND a.branchId IN (SELECT branchId FROM groups_branches WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)") : (text + " AND a.branchId = " + Conversions.ToString(BranchId)));
		text += " ORDER BY branchName, salesName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, int BranchId, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM sales  WHERE salesName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND salesId <> " + Conversions.ToString(Id);
		}
		if (BranchId > 0)
		{
			text = text + " AND branchId = " + Conversions.ToString(BranchId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static DataTable SearchSalesItem(DateTime DateFirst, int SalesPersonId, int BranchId, int GroupId)
	{
		string text = " SELECT SUM(ppAmount) AS amount,prodName,ppPrice, SUM(ppAmount)*ppPrice AS total  FROM penjProd a,produk b  WHERE a.prodId = b.prodId  AND penjId IN (  SELECT penjId FROM penjualan a, customer d  WHERE a.custId = d.custId  AND a.penjDate = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND penjBsType = 0  AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		if (BranchId > 0)
		{
			text = text + " AND d.branchId = " + Conversions.ToString(BranchId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesPersonId);
		}
		text += ") GROUP BY a.prodId,ppPrice,prodname ";
		text = " SELECT SUM(ppAmount) AS amount,prodName,ppPrice, SUM(ppAmount)*ppPrice AS total  FROM penjProd a,produk b,  (  SELECT penjId FROM penjualan e, customer f  WHERE e.custId = f.custId  AND e.penjDate = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND e.penjBsType = 0  AND e.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		if (BranchId > 0)
		{
			text = text + " AND f.branchId = " + Conversions.ToString(BranchId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND e.salesId = " + Conversions.ToString(SalesPersonId);
		}
		text += ") c  WHERE a.prodId = b.prodId  AND a.penjId = c.penjId  GROUP BY a.prodId,ppPrice,prodname ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable SearchExpense(DateTime DateFirst, int SalesPersonId, int BranchId, int GroupId)
	{
		string text = " SELECT voucherDate, voucherAmount, voucherDescription  FROM voucher a, voucher_account b  WHERE a.voucherId = b.voucherId  AND voucherMain = 1  AND voucherDebitCredit = 2  AND voucherDate = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "' ";
		text = ((SalesPersonId > 0) ? (text + " AND a.salesId = " + Conversions.ToString(SalesPersonId)) : ((BranchId <= 0) ? (text + " AND a.salesId IN (SELECT salesId FROM sales  WHERE branchId IN (SELECT branchId FROM groups_branches WHERE groupId = " + Conversions.ToString(Module1.pubGroupId) + " AND generalDropDown = 1))") : (text + " AND a.salesId IN (SELECT salesId FROM sales WHERE branchId = " + Conversions.ToString(BranchId) + ") ")));
		text += " ORDER BY a.voucherDescription ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchInvoice(DateTime DateFirst, int SalesPersonId, int BranchId, int GroupId)
	{
		string text = " SELECT a.*  FROM penjualan a, customer b  WHERE a.custId = b.custId  AND a.penjDate = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND penjId NOT IN (SELECT penjBsId FROM penjBs)  AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		if (BranchId > 0)
		{
			text = text + " AND b.branchId = " + Conversions.ToString(BranchId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND a.salesId = " + Conversions.ToString(SalesPersonId);
		}
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchPayment(DateTime DateFirst, int SalesPersonId, int BranchId, int GroupId)
	{
		string text = " SELECT a.penjKode,a.penjBsType,b.*  FROM penjualan a, penjBayar b, customer c  WHERE a.penjID = b.penjID  AND a.custId = c.custId  AND pbDate = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)  AND a.penjId NOT IN (SELECT penjBsId FROM penjBs) ";
		if (BranchId > 0)
		{
			text = text + " AND c.branchId = " + Conversions.ToString(BranchId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND b.salesId = " + Conversions.ToString(SalesPersonId);
		}
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static double GetCreditPaymentDiscount(DateTime DateFirst, int SalesPersonId, int BranchId, int GroupId)
	{
		double result = 0.0;
		string text = " SELECT SUM(penjPot) AS total  FROM penjualan a,customer b  WHERE a.custId = b.custId  AND a.penjKode = 1  AND a.penjLunas = '" + Strings.Format(DateFirst, "yyyy-MM-dd") + "'  AND a.penjBsType = 0  AND a.storeId IN (SELECT storeId FROM GroupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1) ";
		if (BranchId > 0)
		{
			text = text + " AND b.branchId = " + Conversions.ToString(BranchId);
		}
		if (SalesPersonId > 0)
		{
			text = text + " AND b.salesId = " + Conversions.ToString(SalesPersonId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["total"])))
		{
			result = Conversions.ToDouble(dataTable.Rows[0]["total"]);
		}
		return result;
	}
}
