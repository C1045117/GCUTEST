using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cComponent
{
	private double _id;

	private int _itemId;

	private string _itemName;

	private DateTime _componentDate;

	private double _qty;

	private int _storageId;

	private string _storageName;

	private double _processId;

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

	public int ItemId
	{
		get
		{
			return _itemId;
		}
		set
		{
			_itemId = value;
		}
	}

	public string ItemName
	{
		get
		{
			return _itemName;
		}
		set
		{
			_itemName = value;
		}
	}

	public double Qty
	{
		get
		{
			return _qty;
		}
		set
		{
			_qty = value;
		}
	}

	public DateTime ComponentDate
	{
		get
		{
			return _componentDate;
		}
		set
		{
			_componentDate = value;
		}
	}

	public int StorageId
	{
		get
		{
			return _storageId;
		}
		set
		{
			_storageId = value;
		}
	}

	public string StorageName
	{
		get
		{
			return _storageName;
		}
		set
		{
			_storageName = value;
		}
	}

	public double ProcessId
	{
		get
		{
			return _processId;
		}
		set
		{
			_processId = value;
		}
	}

	public cComponent(double ComponentId)
	{
		if (ComponentId > 0.0)
		{
			_id = ComponentId;
			string strSql = " SELECT a.*, b.itemName  FROM processcomponents a, items b  WHERE comId = " + Conversions.ToString(_id) + " AND a.itemId = b.itemId ";
			DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_itemName = Conversions.ToString(dataTable.Rows[0]["itemName"]);
			}
		}
	}

	public static DataTable GetStandardComponent(int ItemId, int StorageId, double Qty, DateTime ProcessDate)
	{
		string strSql = " SELECT b.itemId, a.storeId as storageId, b.itemName, c.storeName as storageName, a.standardQty*" + Module1.unformatNumber(Conversions.ToString(Qty)) + " as qty, b.itemProcessType  FROM standardcomponents a, items b, storages c, produk d  WHERE a.comId = b.itemId  AND a.storeId = c.storeId  AND a.itemId = " + Conversions.ToString(ItemId) + " AND a.storeId = " + Conversions.ToString(StorageId) + " AND b.itemId = d.prodId  AND d.typeId = 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count == 0)
		{
			strSql = " SELECT b.itemId, a.storeId as storageId, b.itemName, c.storeName as storageName, a.standardQty*" + Module1.unformatNumber(Conversions.ToString(Qty)) + " as qty, b.itemProcessType  FROM standardcomponents a, items b, storages c, produk d  WHERE a.comId = b.itemId  AND a.storeId = c.storeId  AND a.itemId = " + Conversions.ToString(ItemId) + " AND b.itemId = d.prodId  AND d.typeId = 1  AND c.branchId IN  (SELECT branchId FROM storages   WHERE storeId = " + Conversions.ToString(StorageId) + ")";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		}
		return dataTable;
	}

	public static DataTable Search(DateTime FirstDate, DateTime LastDate, int ItemId, int ItemCategoryId, int StorageId, int BranchId, int GroupId)
	{
		string text = " SELECT d.proId, comDate, storeName as storageName,  b.prodName as componentName, comMainQty, proDate,  e.prodName as productName, 0 AS orderBy ";
		string text2 = " FROM processComponents a, produk b, storages c, processes d, produk e  WHERE a.itemId = b.prodId  AND a.storeId = c.storeId  AND a.proId = d.proId  AND d.itemId = e.prodId  AND comDate >= '" + Strings.Format(FirstDate, "yyyy-MM-dd") + "' AND comDate <= '" + Strings.Format(LastDate, "yyyy-MM-dd") + "'";
		if (ItemId > 0)
		{
			text2 = text2 + " AND b.prodId = " + Conversions.ToString(ItemId);
		}
		if (ItemCategoryId > 0)
		{
			text2 = text2 + " AND b.catId = " + Conversions.ToString(ItemCategoryId);
		}
		else if (GroupId > 0)
		{
			text2 = text2 + " AND b.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		if (StorageId > 0)
		{
			text2 = text2 + " AND a.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text2 = text2 + " AND a.storeId IN (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
			if (BranchId > 0)
			{
				text2 = text2 + " AND a.storeId IN (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			}
		}
		text += text2;
		text += " UNION ALL  SELECT 0, CURDATE(), '',  b.prodName as componentName, SUM(comMainQty), CURDATE(),  '', 1 AS orderBy ";
		text += text2;
		text += " GROUP BY componentName ";
		text += " ORDER BY orderBy, comDate, componentName, productName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
