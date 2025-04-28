using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cAdjustment
{
	private double _id;

	private DateTime _adjustmentDate;

	private string _description;

	private double _qty;

	private int _categoryId;

	private int _type;

	private string _typeName;

	private int _itemId;

	private string _itemName;

	private int _storageId;

	private string _storageName;

	private int _currentItem;

	private int _currentStorage;

	private DateTime _currentDate;

	private double _currentQty;

	private int _currentType;

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

	public DateTime AdjustmentDate
	{
		get
		{
			return _adjustmentDate;
		}
		set
		{
			_adjustmentDate = value;
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = Module1.cleanString(value);
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

	public int CategoryId
	{
		get
		{
			return _categoryId;
		}
		set
		{
			_categoryId = value;
		}
	}

	public int Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
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

	public int CurrentItem
	{
		get
		{
			return _currentItem;
		}
		set
		{
			_currentItem = value;
		}
	}

	public int CurrentStorage
	{
		get
		{
			return _currentStorage;
		}
		set
		{
			_currentStorage = value;
		}
	}

	public DateTime CurrentDate
	{
		get
		{
			return _currentDate;
		}
		set
		{
			_currentDate = value;
		}
	}

	public double CurrentQty
	{
		get
		{
			return _currentQty;
		}
		set
		{
			_currentQty = value;
		}
	}

	public int CurrentType
	{
		get
		{
			return _currentType;
		}
		set
		{
			_currentType = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cAdjustment(double AdjustmentId)
	{
		if (!(AdjustmentId > 0.0))
		{
			return;
		}
		_id = AdjustmentId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*, b.itemName, c.storeName  FROM adjustments a, items b, storages c WHERE adjId = " + Conversions.ToString(_id) + " AND a.itemId = b.itemId  AND a.storeId = c.storeId";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_adjustmentDate = Conversions.ToDate(dataTable.Rows[0]["adjDate"]);
			_description = Conversions.ToString(dataTable.Rows[0]["adjDesc"]);
			_qty = Conversions.ToDouble(dataTable.Rows[0]["adjMainQty"]);
			_categoryId = Conversions.ToInteger(dataTable.Rows[0]["adjCategory"]);
			if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[0]["adjType"], true, TextCompare: false))
			{
				_type = 1;
				_typeName = "Kurang";
			}
			else
			{
				_type = 0;
				_typeName = "Tambah";
			}
			_itemId = Conversions.ToInteger(dataTable.Rows[0]["itemId"]);
			_itemName = Conversions.ToString(dataTable.Rows[0]["itemName"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Penyesuaian tidak ditemukan. Kemungkinan telah dihapus.");
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
					ProjectData.ClearProjectError();
					num2 = 2;
					val = Module1.connectData.BeginTransaction();
					if (_id == 0.0)
					{
						string strSql = " INSERT INTO adjustments  (adjDate,adjMainQty,adjDesc,  adjValue,adjType,itemId,  storeId,adjCategory,adjCreated) VALUES  ('" + Strings.Format(_adjustmentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(_qty)) + ",'" + _description + "', 0," + Conversions.ToString(_type) + "," + Conversions.ToString(_itemId) + "," + Conversions.ToString(StorageId) + "," + Conversions.ToString(CategoryId) + ",'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "')";
						Module1.sqlNonQuery(strSql, "data");
					}
					else
					{
						string strSql = " UPDATE adjustments  SET adjDate = '" + Strings.Format(_adjustmentDate, "yyyy-MM-dd") + "',  adjMainQty = " + Module1.unformatNumber(Conversions.ToString(_qty)) + ", adjDesc = '" + _description + "', adjType = " + Conversions.ToString(_type) + ", adjCategory = " + Conversions.ToString(_categoryId) + ", itemId = " + Conversions.ToString(_itemId) + ", storeId = " + Conversions.ToString(_storageId) + " WHERE adjId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							cDailyStock.add(_currentItem, _currentStorage, _currentDate, Conversions.ToDouble(Interaction.IIf(_currentType == 0, _currentQty * -1.0, _currentQty)));
						}
					}
					if (Module1.pubActivateDailyStockCode)
					{
						cDailyStock.add(_itemId, _storageId, _adjustmentDate, Conversions.ToDouble(Interaction.IIf(_type == 0, _qty, _qty * -1.0)));
					}
					val.Commit();
					goto end_IL_0001;
				case 793:
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
				goto IL_034f;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 793;
				continue;
			}
			break;
			IL_034f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int CategoryId, int TypeId, int ItemCategoryId, int ItemId, int StorageId, int GroupId, int BranchId)
	{
		string text = " SELECT adjId, adjDate, storeName,  prodName as itemName, adjTypeName as adjCategory, IF(adjType=0,'+','-') as adjType,  adjMainQty, adjDesc, 0 AS orderBy ";
		string text2 = " FROM adjustments a, produk b, adjustment_types c, storages d  WHERE a.adjCategory = c.adjTypeId  AND a.itemId = b.prodId  AND a.storeid = d.storeId  AND b.typeId = 1 ";
		if (intRange == 1)
		{
			text2 = text2 + " AND adjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND adjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		}
		if (CategoryId > 0)
		{
			text2 = text2 + " AND a.adjCategory = " + Conversions.ToString(CategoryId);
		}
		if (TypeId != 99)
		{
			text2 = text2 + " AND a.adjType = " + Conversions.ToString(TypeId);
		}
		text2 = ((ItemId > 0) ? (text2 + " AND a.itemId = " + Conversions.ToString(ItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND b.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")") : (text2 + " AND b.catId = " + Conversions.ToString(ItemCategoryId))));
		if (StorageId > 0)
		{
			text2 = text2 + " AND a.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text2 = text2 + " AND a.storeId IN  (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
			if (BranchId > 0)
			{
				text2 = text2 + " AND a.storeId IN  (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			}
		}
		text += text2;
		text += " UNION ALL  SELECT 0, CURDATE(), storeName,  prodName as itemName, adjTypeName as adjCategory, IF(adjType=0,'+','-') as adjType,  SUM(adjMainQty), '', 1 AS orderBy ";
		text += text2;
		text += " GROUP BY storeName, itemName, adjCategory, adjType ";
		text = ((intRange != 2) ? (text + " ORDER BY orderBy, adjDate, storeName, itemName ") : (text + " ORDER BY adjId DESC LIMIT 100 "));
		return Module1.sqlTable(text, "data", Clone: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Delete()
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
					string strSql = " DELETE FROM adjustments WHERE adjId = " + Conversions.ToString(_id);
					Module1.sqlNonQuery(strSql, "data");
					if (Module1.pubActivateDailyStockCode)
					{
						cDailyStock.add(_currentItem, _currentStorage, _currentDate, Conversions.ToDouble(Interaction.IIf(_currentType == 0, _currentQty * -1.0, _currentQty)));
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 249:
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
				goto IL_012f;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 249;
				continue;
			}
			break;
			IL_012f:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
