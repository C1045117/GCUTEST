using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cStorage
{
	private int _id;

	private string _name;

	private int _isMarketing;

	private int _isReturn;

	private int _branchId;

	private string _branchName;

	private int _active;

	private bool _used;

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

	public int IsMarketing
	{
		get
		{
			return _isMarketing;
		}
		set
		{
			_isMarketing = value;
		}
	}

	public int IsReturn
	{
		get
		{
			return _isReturn;
		}
		set
		{
			_isReturn = value;
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
			return _name;
		}
		set
		{
			_name = value;
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

	public bool Used
	{
		get
		{
			return _used;
		}
		set
		{
			_used = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cStorage(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT a.*, b.branchName  FROM storages a, branches b WHERE a.branchId = b.branchId  AND storeId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_id = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
				_name = Conversions.ToString(dataTable.Rows[0]["storeName"]);
				_isMarketing = Conversions.ToInteger(dataTable.Rows[0]["storeMkt"]);
				_isReturn = Conversions.ToInteger(dataTable.Rows[0]["storeReturn"]);
				_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
				_branchName = Conversions.ToString(dataTable.Rows[0]["branchName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["storeActive"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Gudang tidak ditemukan. Kemungkinan telah dihapus.");
			}
			strSql = " SELECT storeId  FROM customer  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM adjustments  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM deliveryorder  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM penjualan  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM processes  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM processcomponents  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM purchaseinvoices_items  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM receiveditem  WHERE storeId = " + Conversions.ToString(_id) + " UNION  SELECT storageFromId  FROM transfer  WHERE storageFromId = " + Conversions.ToString(_id) + " UNION  SELECT storageToId  FROM transfer  WHERE storageToId = " + Conversions.ToString(_id) + " UNION  SELECT storeId  FROM usages  WHERE storeId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_used = true;
			}
			else
			{
				_used = false;
			}
		}
	}

	public void Save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO storages(storeName, storeMkt, storeReturn,  branchId, storeActive)  VALUES  ('" + _name + "', " + Conversions.ToString(_isMarketing) + "," + Conversions.ToString(_isReturn) + "," + Conversions.ToString(_branchId) + "," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE storages  SET storeName = '" + _name + "',  storeMkt = " + Conversions.ToString(_isMarketing) + ", storeReturn = " + Conversions.ToString(_isReturn) + ", branchId = " + Conversions.ToString(_branchId) + ", storeActive = " + Conversions.ToString(_active) + "  WHERE storeId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int intGroupId, int intBranchId, string StorageType, int Active)
	{
		string text = " SELECT a.*, b.branchName  FROM storages a, branches b WHERE a.branchId = b.branchId ";
		switch (Active)
		{
		case 0:
			text += " AND storeActive = 0 ";
			break;
		case 1:
			text += " AND storeActive = 1 ";
			break;
		}
		switch (StorageType)
		{
		case "MARKETING":
			text += " AND storeMkt = 1 ";
			break;
		case "RETURN":
			text += " AND storeReturn = 1 ";
			break;
		case "MARKETING_RETURN":
			text += " AND (storeMkt = 1 OR storeReturn = 1) ";
			break;
		case "NO_RETURN":
			text += " AND storeReturn = 0 ";
			break;
		}
		if (intGroupId > 0)
		{
			text = text + " AND storeId IN (SELECT storeId FROM groupStorage  WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
		}
		if (intBranchId > 0)
		{
			text = text + " AND a.branchId = " + Conversions.ToString(intBranchId);
		}
		text += " ORDER BY branchName, storeName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM storages  WHERE storeName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND storeId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public void Delete()
	{
		if (!_used)
		{
			string strSql = " DELETE FROM storages  WHERE storeId = " + Conversions.ToString(_id);
			Module1.sqlNonQuery(strSql, "data");
		}
	}
}
