using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cTransfer
{
	private double _id;

	private string _transferNumber;

	private int _storageFromId;

	private string _storageFromName;

	private int _storageToId;

	private string _storageToName;

	private cTransferItem[] _item;

	private DateTime _transferDate;

	private DateTime _createdDate;

	private int _currentStorageFrom;

	private int _currentStorageTo;

	private DateTime _currentDate;

	private cTransferItem[] _currentItem;

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

	public string TransferNumber
	{
		get
		{
			return _transferNumber;
		}
		set
		{
			_transferNumber = value;
		}
	}

	public int StorageFromId
	{
		get
		{
			return _storageFromId;
		}
		set
		{
			_storageFromId = value;
		}
	}

	public string StorageFromName
	{
		get
		{
			return _storageFromName;
		}
		set
		{
			_storageFromName = value;
		}
	}

	public int StorageToId
	{
		get
		{
			return _storageToId;
		}
		set
		{
			_storageToId = value;
		}
	}

	public string StorageToName
	{
		get
		{
			return _storageToName;
		}
		set
		{
			_storageToName = value;
		}
	}

	public DateTime TransferDate
	{
		get
		{
			return _transferDate;
		}
		set
		{
			_transferDate = value;
		}
	}

	public cTransferItem[] Item
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

	public cTransferItem[] CurrentItem
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

	public int CurrentStorageFrom
	{
		get
		{
			return _currentStorageFrom;
		}
		set
		{
			_currentStorageFrom = value;
		}
	}

	public int CurrentStorageTo
	{
		get
		{
			return _currentStorageTo;
		}
		set
		{
			_currentStorageTo = value;
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cTransfer(double TransferId)
	{
		if (!(TransferId > 0.0))
		{
			return;
		}
		_id = TransferId;
		string strSql = " SELECT CONCAT('TRF/',CAST(storageFromId AS CHAR),'/',SUBSTR(YEAR(transferDate),3),'/',transferNumber) as transferNumber,  transferDate, storageFromId, storageToId, transferCreated,  b.storeName as storageFromName, c.storeName as storageToName  FROM transfer a, storages b, storages c  WHERE a.storageFromId = b.storeId  AND a.storageToId = c.storeId  AND transferId = " + Conversions.ToString(_id);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_transferNumber = Conversions.ToString(dataTable.Rows[0]["transferNumber"]);
			_transferDate = Conversions.ToDate(dataTable.Rows[0]["transferDate"]);
			_storageFromId = Conversions.ToInteger(dataTable.Rows[0]["storageFromId"]);
			_storageFromName = Conversions.ToString(dataTable.Rows[0]["storageFromName"]);
			_storageToId = Conversions.ToInteger(dataTable.Rows[0]["storageToId"]);
			_storageToName = Conversions.ToString(dataTable.Rows[0]["storageToName"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["transferCreated"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Transfer tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT b.*, prodName as itemName  FROM produk a, transfer_item b  WHERE a.prodId = b.itemId  AND transferId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cTransferItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cTransferItem();
				_item[num].TransferId = Conversions.ToDouble(row["transferId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].Qty = Conversions.ToDouble(row["transferQty"]);
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
							_transferNumber = GenerateNewNumber();
							string strSql = " INSERT INTO transfer(transferNumber, storageFromId, storageToId, transferDate, transferCreated)  VALUES ('" + _transferNumber + "'," + Conversions.ToString(_storageFromId) + "," + Conversions.ToString(_storageToId) + ",'" + Strings.Format(_transferDate, "yyyy-MM-dd") + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "')";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE transfer  SET storageFromId = " + Conversions.ToString(_storageFromId) + ",  storageToId = " + Conversions.ToString(_storageToId) + ",  transferDate = '" + Strings.Format(_transferDate, "yyyy-MM-dd") + "'  WHERE transferId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentStorageFrom, _currentDate, _currentItem[i].Qty);
									cDailyStock.add(_currentItem[i].ItemId, _currentStorageTo, _currentDate, _currentItem[i].Qty * -1.0);
								}
							}
							strSql = " DELETE FROM transfer_item  WHERE transferId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
						}
						cTransferItem[] item = _item;
						foreach (cTransferItem cTransferItem2 in item)
						{
							string strSql = " INSERT INTO transfer_item  (itemId, transferQty, transferId) VALUES  ( " + Conversions.ToString(cTransferItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cTransferItem2.Qty)) + "," + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(cTransferItem2.ItemId, _storageFromId, _transferDate, cTransferItem2.Qty * -1.0);
								cDailyStock.add(cTransferItem2.ItemId, _storageToId, _transferDate, cTransferItem2.Qty);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 891:
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
					goto IL_03b1;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 891;
				continue;
			}
			break;
			IL_03b1:
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
						string strSql = " DELETE FROM transfer WHERE transferId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM transfer_item WHERE transferId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								cDailyStock.add(_currentItem[i].ItemId, _currentStorageFrom, _currentDate, _currentItem[i].Qty);
								cDailyStock.add(_currentItem[i].ItemId, _currentStorageTo, _currentDate, _currentItem[i].Qty * -1.0);
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

	public static DataTable Search(int intRange, int intMonth, int intYear, DateTime dateFirst, DateTime dateLast, int intItemId, int ItemCategoryId, int intStoreFromId, int intStoreToId, int intGroupId, int intBranchId, int intStepId)
	{
		string text = " SELECT a.transferId, transferDate, d.storeName as storageFromName,   CONCAT('TRF/',CAST(storageFromId AS CHAR),'/',SUBSTR(YEAR(transferDate),3),'/',transferNumber) as transferNumber, e.storeName AS storageToName, c.prodName as itemName,  transferQty, 0 AS orderBy ";
		string text2 = " FROM transfer a, transfer_item b, produk c, storages d, storages e  WHERE a.transferId = b.transferId  AND b.itemId = c.prodId  AND a.storageFromId = d.storeId  AND a.storageToId = e.storeId  AND c.typeId = 1 ";
		switch (intRange)
		{
		case 0:
			text2 = text2 + " AND MONTH(transferDate) = " + Conversions.ToString(intMonth) + " AND YEAR(transferDate) = " + Conversions.ToString(intYear);
			break;
		case 1:
			text2 = text2 + " AND transferDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND transferDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 2:
			text2 = text2 + " AND transferDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "'";
			break;
		}
		text2 = ((intStoreFromId > 0) ? (text2 + " AND a.storageFromId = " + Conversions.ToString(intStoreFromId)) : ((intBranchId <= 0) ? (text2 + " AND a.storageFromId IN (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)") : (text2 + " AND a.storageFromId IN (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(intBranchId) + ")")));
		text2 = ((intStoreToId > 0) ? (text2 + " AND a.storageToId = " + Conversions.ToString(intStoreToId)) : ((intBranchId <= 0) ? (text2 + " AND a.storageToId IN (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(intGroupId) + " AND generalDropDown = 1)") : (text2 + " AND a.storageToId IN (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(intBranchId) + ")")));
		text2 = ((intItemId > 0) ? (text2 + " AND b.itemId = " + Conversions.ToString(intItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND c.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(intGroupId) + ")") : (text2 + " AND c.catId = " + Conversions.ToString(ItemCategoryId))));
		text += text2;
		if (intRange != 2)
		{
			text += " UNION ALL  SELECT 0, CURDATE(), d.storeName as storageFromName,   '', e.storeName AS storageToName, c.prodName as itemName,  SUM(transferQty), 1 AS orderBy ";
			text += text2;
			text += " GROUP BY storageFromName, storageToName, itemName ";
		}
		text = ((intRange != 2) ? (text + " ORDER BY orderBy, transferDate, itemName ") : (text + " ORDER BY transferId DESC LIMIT 100 "));
		return Module1.sqlTable(text, "data", Clone: true);
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM Transfer  WHERE YEAR(transferDate) = " + Conversions.ToString(DateAndTime.Year(_transferDate)) + " AND storageFromId = " + Conversions.ToString(StorageFromId) + " ORDER BY transferId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		int num = ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["transferNumber"]), 5)) + 1.0)));
		string text = Strings.Trim(Strings.Left(_storageFromName, 3)) + _storageFromId.ToString("0000") + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(_transferDate)), 2) + "/" + num.ToString("00000");
		return num.ToString("00000");
	}
}
