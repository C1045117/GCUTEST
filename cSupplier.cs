using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cSupplier
{
	private int _id;

	private string _name;

	private string _address;

	private string _NPWP;

	private int _cashAccountId;

	private int _bankAccountId;

	private int _active;

	private int _parentId;

	private int _isParent;

	private int _currencyId;

	private string _currencyName;

	private double _currencyRate;

	private string[] _memberName;

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

	public string NPWP
	{
		get
		{
			return _NPWP;
		}
		set
		{
			_NPWP = Module1.cleanString(value);
		}
	}

	public string Address
	{
		get
		{
			return _address;
		}
		set
		{
			_address = Module1.cleanString(value);
		}
	}

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

	public string[] MemberName
	{
		get
		{
			return _memberName;
		}
		set
		{
			_memberName = value;
		}
	}

	public override string ToString()
	{
		return _name;
	}

	public cSupplier(int SupplierId)
	{
		if (SupplierId <= 0)
		{
			return;
		}
		_id = SupplierId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT *  FROM suppliers a, currency b  WHERE a.currencyId = b.currencyId  AND supId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_id = Conversions.ToInteger(dataTable.Rows[0]["supId"]);
			_name = Conversions.ToString(dataTable.Rows[0]["supName"]);
			_address = Conversions.ToString(dataTable.Rows[0]["supAddress"]);
			_NPWP = Conversions.ToString(dataTable.Rows[0]["supNPWP"]);
			_cashAccountId = Conversions.ToInteger(dataTable.Rows[0]["kgId"]);
			_bankAccountId = Conversions.ToInteger(dataTable.Rows[0]["tgId"]);
			_active = Conversions.ToInteger(Conversion.Int(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["supActive"])));
			_parentId = Conversions.ToInteger(dataTable.Rows[0]["supParentId"]);
			_isParent = Conversions.ToInteger(dataTable.Rows[0]["isParent"]);
			_currencyId = Conversions.ToInteger(dataTable.Rows[0]["currencyId"]);
			_currencyName = Conversions.ToString(dataTable.Rows[0]["currencyName"]);
			_currencyRate = Conversions.ToDouble(dataTable.Rows[0]["currencyRate"]);
		}
		strSql = " SELECT * FROM suppliers  WHERE isParent = 0  AND supParentId = " + Conversions.ToString(_id) + " ORDER BY supName ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count <= 0)
		{
			return;
		}
		checked
		{
			_memberName = new string[dataTable.Rows.Count - 1 + 1];
			int num = 0;
			foreach (DataRow row in dataTable.Rows)
			{
				_memberName[num] = Conversions.ToString(row["supName"]);
				num++;
			}
		}
	}

	public void save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO suppliers(supName,supAddress,supNPWP,  kgId,tgId,supActive, supParentId,isParent,supCode,  currencyId) VALUES  ('" + _name + "','" + _address + "','" + _NPWP + "'," + Conversions.ToString(_cashAccountId) + "," + Conversions.ToString(_bankAccountId) + ", " + Conversions.ToString(_active) + "," + Conversions.ToString(_parentId) + "," + Conversions.ToString(_isParent) + ",'', " + Conversions.ToString(_currencyId) + ")";
			Module1.sqlNonQuery(strSql, "data");
			_id = checked((int)Math.Round(cDatabase.LastId("data")));
			if (_parentId == 0)
			{
				strSql = " UPDATE suppliers SET  supParentId = " + Conversions.ToString(_id) + " WHERE supId = " + Conversions.ToString(_id);
				Module1.sqlNonQuery(strSql, "data");
			}
		}
		else
		{
			string strSql = " UPDATE suppliers  SET supName = '" + _name + "',  supAddress = '" + _address + "',  supNPWP = '" + _NPWP + "', kgId = " + Conversions.ToString(_cashAccountId) + ",  tgId = " + Conversions.ToString(_bankAccountId) + ",  supActive = " + Conversions.ToString(_active) + ",  supParentId = " + Conversions.ToString(_parentId) + ",  isParent = " + Conversions.ToString(_isParent) + ",  currencyId = " + Conversions.ToString(_currencyId) + " WHERE supId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(string Name, int GroupId, int IsParent)
	{
		string text = " SELECT *  FROM suppliers  WHERE supId = supId ";
		if (GroupId > 0)
		{
			text = text + " AND supId IN ( SELECT supId FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		if (Operators.CompareString(Name, "", TextCompare: false) != 0)
		{
			text = text + " AND supName like '%" + Name + "%'";
		}
		switch (IsParent)
		{
		case 0:
			text += " AND isParent = 0 ";
			break;
		case 1:
			text += " AND isParent = 1 ";
			break;
		}
		text += " ORDER BY supName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable dtSupplier(int GroupId, bool FlowerOnly, bool IncludeParent, bool Active)
	{
		string text = " SELECT supId, supName FROM suppliers  WHERE supId IN (SELECT supId FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		if (FlowerOnly)
		{
			text += " AND supId IN (SELECT supId FROM purchaseprice  WHERE itemId IN (SELECT itemId FROM items WHERE itemName LIKE 'Bunga%')) ";
		}
		if (!IncludeParent)
		{
			text += " AND isParent = 0 ";
		}
		if (Active)
		{
			text += " AND supActive = 1 ";
		}
		text += " ORDER BY supName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable GetParentSupplier(int GroupId)
	{
		string strSql = " SELECT * FROM suppliers  WHERE isParent = 1  AND supId IN (SELECT supId FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(GroupId) + ")  ORDER BY supName ";
		return Module1.sqlTable(strSql, "read", Clone: false);
	}
}
