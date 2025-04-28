using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cProcess
{
	private double _id;

	private DateTime _processDate;

	private double _qty;

	private int _itemId;

	private string _itemName;

	private int _storageId;

	private string _storageName;

	private DateTime _createdDate;

	private cComponent[] _component;

	private int _currentStorage;

	private cComponent[] _currentComponent;

	private DateTime _currentDate;

	private int _currentItem;

	private double _currentQty;

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

	public DateTime ProcessDate
	{
		get
		{
			return _processDate;
		}
		set
		{
			_processDate = value;
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

	public DateTime CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}

	public cComponent[] Component
	{
		get
		{
			return _component;
		}
		set
		{
			_component = value;
		}
	}

	public cComponent[] CurrentComponent
	{
		get
		{
			return _currentComponent;
		}
		set
		{
			_currentComponent = value;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cProcess(double ProcessId)
	{
		if (!(ProcessId > 0.0))
		{
			return;
		}
		_id = ProcessId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT a.*, b.itemName, c.storeName  FROM processes a, items b, storages c  WHERE proId = " + Conversions.ToString(_id) + " AND a.itemId = b.itemId  AND a.storeId = c.storeId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_processDate = Conversions.ToDate(dataTable.Rows[0]["proDate"]);
			_qty = Conversions.ToDouble(dataTable.Rows[0]["proMainQty"]);
			_itemId = Conversions.ToInteger(dataTable.Rows[0]["itemId"]);
			_itemName = Conversions.ToString(dataTable.Rows[0]["itemName"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["proCreated"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Produksi tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.*, b.itemName, c.storeName  FROM processcomponents a, items b, storages c, produk d  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND proId = " + Conversions.ToString(_id) + " AND b.itemId = d.prodId  AND d.typeId = 1  ORDER BY b.itemName ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_component = new cComponent[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_component[num] = new cComponent(0.0);
				_component[num].Id = Conversions.ToDouble(row["comId"]);
				_component[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_component[num].ItemName = Conversions.ToString(row["itemName"]);
				_component[num].ComponentDate = Conversions.ToDate(row["comDate"]);
				_component[num].Qty = Conversions.ToDouble(row["comMainQty"]);
				_component[num].StorageId = Conversions.ToInteger(row["storeId"]);
				_component[num].StorageName = Conversions.ToString(row["storeName"]);
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						if (_id == 0.0)
						{
							string strSql = " INSERT INTO processes  (proDate,proMainQty,itemId,storeId,proCreated) VALUES  ('" + Strings.Format(_processDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(_qty)) + "," + Conversions.ToString(_itemId) + "," + Conversions.ToString(_storageId) + ",'" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "')";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE processes  SET proDate = '" + Strings.Format(_processDate, "yyyy-MM-dd") + "',  proMainQty = " + Module1.unformatNumber(Conversions.ToString(Qty)) + ", itemId = " + Conversions.ToString(_itemId) + ", storeId = " + Conversions.ToString(_storageId) + " WHERE proId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(_currentItem, _currentStorage, _currentDate, _currentQty * -1.0);
								int num3 = _currentComponent.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									cDailyStock.add(_currentComponent[i].ItemId, _currentComponent[i].StorageId, _currentComponent[i].ComponentDate, _currentComponent[i].Qty);
								}
							}
							strSql = " DELETE FROM processComponents  WHERE proId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
						}
						if (Module1.pubActivateDailyStockCode)
						{
							cDailyStock.add(_itemId, _storageId, _processDate, _qty);
						}
						cComponent[] component = _component;
						foreach (cComponent cComponent2 in component)
						{
							string strSql = " INSERT INTO processComponents  (comDate, comMainQty, itemId, storeId, proId) VALUES  (' " + Strings.Format(cComponent2.ComponentDate, "yyyy-MM-dd") + "'," + Module1.unformatNumber(Conversions.ToString(cComponent2.Qty)) + ", " + Conversions.ToString(cComponent2.ItemId) + "," + Conversions.ToString(cComponent2.StorageId) + ", " + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(cComponent2.ItemId, cComponent2.StorageId, cComponent2.ComponentDate, cComponent2.Qty * -1.0);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 984:
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
					goto IL_040e;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 984;
				continue;
			}
			break;
			IL_040e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						string strSql = " DELETE FROM processes  WHERE proId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM processcomponents  WHERE proId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							cDailyStock.add(_currentItem, _currentStorage, _currentDate, _currentQty * -1.0);
							int num3 = _currentComponent.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								cDailyStock.add(_currentComponent[i].ItemId, _currentComponent[i].StorageId, _currentComponent[i].ComponentDate, _currentComponent[i].Qty);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 334:
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
					goto IL_0184;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 334;
				continue;
			}
			break;
			IL_0184:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int intItemId, int intStepId, int intStoreId, int intBranchId, int intGroupId, bool blnShowComponent)
	{
		string text = " SELECT proId, proDate, storeName,   itemName, proMainQty, proDate as origDate,  0 as orderBy, 0 as orderBy2  FROM processes a, items b, storages c, produk d  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND b.itemId = d.prodId  AND d.typeId = 1 ";
		if (intRange == 1)
		{
			text = text + " AND proDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND proDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		}
		if (intStoreId > 0)
		{
			text = text + " AND a.storeId = " + Conversions.ToString(intStoreId);
		}
		else
		{
			text = text + " AND a.storeId IN (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
			if (intBranchId > 0)
			{
				text = text + " AND a.storeId IN (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
			}
		}
		text = ((intItemId > 0) ? (text + " AND a.itemId = " + Conversions.ToString(intItemId)) : ((intStepId <= 0) ? (text + " AND b.itemId IN (SELECT prodId FROM produk WHERE catId IN  (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(intGroupId) + "))") : (text + " AND b.stepId = " + Conversions.ToString(intStepId))));
		if (blnShowComponent)
		{
			string text2 = text;
			text = text + " UNION SELECT a.proId, comDate as proDate, storeName,  itemName, comMainQty as proMainQty, proDate as origDate,  0 as orderBy, 1 as orderBy2  FROM processcomponents a, items b, storages c, processes d, produk e  WHERE a.proId IN(SELECT proId FROM (" + text2 + ") as processid)  AND a.itemId = b.itemId  AND a.storeId = c.storeId  AND a.proId = d.proId  AND b.itemId = e.prodId  AND e.typeId = 1 ";
			text = text + " UNION SELECT 0 as proId, comDate as proDate, '' as storeName,  itemName, SUM(comMainQty) as proMainQty, '' as origDate,  1 as orderBy, 3 as orderBy2  FROM processcomponents a, items b, storages c, processes d, produk e  WHERE a.proId IN(SELECT proId FROM (" + text2 + ") as processid)  AND a.itemId = b.itemId  AND a.storeId = c.storeId  AND a.proId = d.proId  AND b.itemId = e.prodId  AND e.typeId = 1  GROUP BY itemName ";
		}
		if (intRange != 2)
		{
			text += " UNION SELECT 0 as proId, proDate, '' as storeName,   itemName, SUM(proMainQty), '' as origDate,  1 as orderBy, 2 as orderBy2  FROM processes a, items b, storages c, produk d  WHERE a.itemId = b.itemId  AND a.storeId = c.storeId  AND b.itemId = d.prodId  AND d.typeId = 1 ";
			if (intRange == 1)
			{
				text = text + " AND proDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND proDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			}
			if (intStoreId > 0)
			{
				text = text + " AND a.storeId = " + Conversions.ToString(intStoreId);
			}
			else
			{
				text = text + " AND a.storeId IN (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)";
				if (intBranchId > 0)
				{
					text = text + " AND a.storeId IN (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(intBranchId) + ")";
				}
			}
			text = ((intItemId > 0) ? (text + " AND a.itemId = " + Conversions.ToString(intItemId)) : ((intStepId <= 0) ? (text + " AND b.itemId IN (SELECT prodId FROM produk WHERE catId IN  (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(intGroupId) + "))") : (text + " AND b.stepId = " + Conversions.ToString(intStepId))));
			text += " GROUP BY itemName ";
		}
		text = ((intRange != 2) ? (text + " ORDER BY orderBy,origDate,proId,orderBy2,itemName ") : (text + " ORDER BY proId DESC LIMIT 100 "));
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
