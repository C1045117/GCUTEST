using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cUsage
{
	private double _id;

	private DateTime _usageDate;

	private string _usageNumber;

	private string _note;

	private DateTime _createdDate;

	private int _storageId;

	private string _storageName;

	private cUsageItem[] _item;

	private cUsageItem[] _currentItem;

	private int _currentStorage;

	private DateTime _currentDate;

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

	public DateTime UsageDate
	{
		get
		{
			return _usageDate;
		}
		set
		{
			_usageDate = value;
		}
	}

	public string UsageNumber
	{
		get
		{
			return _usageNumber;
		}
		set
		{
			_usageNumber = value;
		}
	}

	public string Note
	{
		get
		{
			return _note;
		}
		set
		{
			_note = Module1.cleanString(value);
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

	public cUsageItem[] Item
	{
		get
		{
			return _item;
		}
		set
		{
			_item = value;
		}
	}

	public cUsageItem[] CurrentItem
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cUsage(double UsageId)
	{
		if (!(UsageId > 0.0))
		{
			return;
		}
		_id = UsageId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT usageDate, CONCAT('USE/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(usageDate),3),'/',usageNumber) as usageNumber, usageNote,  usageCreated, a.storeId, b.storeName  FROM usages a, storages b WHERE usageId = " + Conversions.ToString(_id) + " AND a.storeId = b.storeId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_usageDate = Conversions.ToDate(dataTable.Rows[0]["usageDate"]);
			_usageNumber = Conversions.ToString(dataTable.Rows[0]["usageNumber"]);
			_note = Conversions.ToString(dataTable.Rows[0]["usageNote"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["usageCreated"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Penggunaan tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT IFNULL(usageId,0) as usageId, IFNULL(useQty,0) as useQty, IFNULL(wasteQty,0) as wasteQty, a.prodId as itemId, prodName as itemName  FROM (SELECT DISTINCT prodId, prodName FROM produk a, items b  WHERE a.prodId = b.itemId  AND a.typeId = 1  AND b.itemAllowComponent = 1  AND prodId IN (SELECT prodId FROM produkstorages WHERE psAvailable = 1 AND storeId = " + Conversions.ToString(StorageId) + ") UNION SELECT itemId, prodName FROM produk, usage_item WHERE produk.prodId = usage_item.itemId AND usageId = " + Conversions.ToString(_id) + ") a LEFT OUTER JOIN (SELECT * FROM usage_item WHERE usageId = " + Conversions.ToString(_id) + ") b ON a.prodId = b.itemId  ORDER BY itemName ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cUsageItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cUsageItem();
				_item[num].UsageId = Conversions.ToDouble(row["usageId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].UseQty = Conversions.ToDouble(row["useQty"]);
				_item[num].WasteQty = Conversions.ToDouble(row["wasteQty"]);
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
							_usageNumber = GenerateNewNumber();
							string strSql = " INSERT INTO usages  (usageNumber,usageDate,usageNote,  usageCreated,storeId) VALUES  ('" + _usageNumber + "','" + Strings.Format(_usageDate, "yyyy-MM-dd") + "','" + _note + "',  '" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Conversions.ToString(StorageId) + ")";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE usages  SET usageDate = '" + Strings.Format(_usageDate, "yyyy-MM-dd") + "',  usageNote = '" + _note + "', storeId = " + Conversions.ToString(_storageId) + " WHERE usageId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM usage_item  WHERE usageId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									if ((CurrentItem[i].UseQty > 0.0) | (_currentItem[i].WasteQty > 0.0))
									{
										cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].UseQty + _currentItem[i].WasteQty);
									}
								}
							}
						}
						cUsageItem[] item = _item;
						foreach (cUsageItem cUsageItem2 in item)
						{
							string strSql = " INSERT INTO usage_item  (usageId, itemId, useQty,  wasteQty) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cUsageItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cUsageItem2.UseQty)) + "," + Module1.unformatNumber(Conversions.ToString(cUsageItem2.WasteQty)) + ")";
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(cUsageItem2.ItemId, _storageId, _usageDate, (cUsageItem2.UseQty + cUsageItem2.WasteQty) * -1.0);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 908:
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
					goto IL_03c2;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 908;
				continue;
			}
			break;
			IL_03c2:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM usages  WHERE YEAR(usageDate) = " + Conversions.ToString(DateAndTime.Year(_usageDate)) + " AND storeId = " + Conversions.ToString(StorageId) + " ORDER BY usageId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["usageNumber"]), 5)) + 1.0))).ToString("00000");
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int StorageId, int GroupId, int BranchId)
	{
		string text = " SELECT a.usageId, usageDate, CONCAT('USE/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(usageDate),3),'/',usageNumber) as usageNumber,  storeName, prodName as itemName, useQty, wasteQty, useQty+wasteQty as total, 0 AS orderBy ";
		string text2 = " FROM usages a, usage_item b, storages c, produk d  WHERE a.storeId = c.storeId  AND b.itemId = d.prodId  AND a.usageId = b.usageId  AND d.typeId = 1 ";
		if (intRange == 1)
		{
			text2 = text2 + " AND usageDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND usageDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		}
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
		if (intRange != 2)
		{
			text += " UNION ALL  SELECT 0, CURDATE(), '',  '', prodName as itemName, SUM(useQty), SUM(wasteQty), SUM(useQty+wasteQty) AS total, 1 AS orderBy ";
			text += text2;
			text += " GROUP BY itemName ";
		}
		text = ((intRange != 2) ? (text + " ORDER BY orderBy, usageDate, itemName ") : (text + " ORDER BY usageId DESC LIMIT 100 "));
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						string strSql = " DELETE FROM usages WHERE usageId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM usage_item WHERE usageId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								if ((CurrentItem[i].UseQty > 0.0) | (_currentItem[i].WasteQty > 0.0))
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].UseQty + _currentItem[i].WasteQty);
								}
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 354:
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
					goto IL_0198;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 354;
				continue;
			}
			break;
			IL_0198:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable SearchStandard(DateTime dateFirst, DateTime dateLast, int StorageId, int GroupId, int BranchId)
	{
		string text = " SELECT d.prodId, a.prodName AS itemName, d.prodName AS componentName,SUM(ppAmount*c.qty) AS totalUsage, 0 AS orderBy  FROM produk a, penjprod b, standardUsage c, produk d, penjualan e  WHERE a.prodId IN (SELECT prodId FROM produk WHERE typeid=2) AND a.prodId = b.prodId  AND a.prodId = c.itemid  AND c.comId = d.prodId  AND c.branchId = " + Conversions.ToString(BranchId) + " AND b.penjId = e.penjId  AND penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (StorageId > 0)
		{
			text = text + " AND e.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND e.storeId IN  (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
			if (BranchId > 0)
			{
				text = text + " AND e.storeId IN  (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			}
		}
		text += " GROUP BY a.prodId,d.prodId ";
		text = text + " UNION ALL SELECT d.prodId, '', d.prodName AS componentName,SUM(ppAmount*c.qty) AS totalUsage, 1 AS orderBy  FROM produk a, penjprod b, standardUsage c, produk d, penjualan e  WHERE a.prodId IN (SELECT prodId FROM produk WHERE typeid=2) AND a.prodId = b.prodId  AND a.prodId = c.itemid  AND c.comId = d.prodId  AND c.branchId = " + Conversions.ToString(BranchId) + " AND b.penjId = e.penjId  AND penjDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND penjDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (StorageId > 0)
		{
			text = text + " AND e.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND e.storeId IN  (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
			if (BranchId > 0)
			{
				text = text + " AND e.storeId IN  (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			}
		}
		text += " GROUP BY d.prodId ";
		text += " ORDER BY orderBy, itemName, componentName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable SearchVariance(DateTime dateFirst, DateTime dateLast, int StorageId, int GroupId, int BranchId)
	{
		string text = " SELECT c.itemId, itemName, SUM(useQty+wasteQty) AS totalUsage  FROM usages a, usage_item b, items c  WHERE a.usageId = b.usageId  AND b.itemId = c.itemId  AND usageDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND usageDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
		if (StorageId > 0)
		{
			text = text + " AND a.storeId = " + Conversions.ToString(StorageId);
		}
		else
		{
			text = text + " AND a.storeId IN  (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
			if (BranchId > 0)
			{
				text = text + " AND a.storeId IN  (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
			}
		}
		text += " GROUP BY itemId  ORDER BY itemName ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
