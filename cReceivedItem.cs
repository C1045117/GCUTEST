using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cReceivedItem
{
	private double _id;

	private DateTime _riDate;

	private string _number;

	private string _note;

	private DateTime _createdDate;

	private int _storageId;

	private string _storageName;

	private cReceivedItemItem[] _item;

	private int _supplierId;

	private string _supplierName;

	private double _invoiceId;

	private string _invoiceNumber;

	private cReceivedItemItem[] _currentItem;

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

	public DateTime RIDate
	{
		get
		{
			return _riDate;
		}
		set
		{
			_riDate = value;
		}
	}

	public string Number
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

	public cReceivedItemItem[] Item
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

	public int SupplierId
	{
		get
		{
			return _supplierId;
		}
		set
		{
			_supplierId = value;
		}
	}

	public string SupplierName
	{
		get
		{
			return _supplierName;
		}
		set
		{
			_supplierName = value;
		}
	}

	public double InvoiceId
	{
		get
		{
			return _invoiceId;
		}
		set
		{
			_invoiceId = value;
		}
	}

	public string InvoiceNumber
	{
		get
		{
			return _invoiceNumber;
		}
		set
		{
			_invoiceNumber = value;
		}
	}

	public cReceivedItemItem[] CurrentItem
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

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cReceivedItem(double RIId)
	{
		if (!(RIId > 0.0))
		{
			return;
		}
		_id = RIId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT riDate,CONCAT('RI/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(riDate),3),'/',riNumber) as riNumber,riNote,  riCreated, a.storeId, a.supId, b.storeName, c.supName  FROM receivedItem a, storages b, suppliers c  WHERE riId = " + Conversions.ToString(_id) + " AND a.supId = c.supId  AND a.storeId = b.storeId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_riDate = Conversions.ToDate(dataTable.Rows[0]["riDate"]);
			_number = Conversions.ToString(dataTable.Rows[0]["riNumber"]);
			_note = Conversions.ToString(dataTable.Rows[0]["riNote"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["riCreated"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
			_supplierId = Conversions.ToInteger(dataTable.Rows[0]["supId"]);
			_supplierName = Conversions.ToString(dataTable.Rows[0]["supName"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Penerimaan Barang tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.invId,invNumber FROM purchaseinvoices_items a, purchaseinvoices b WHERE a.invId = b.invId  AND riId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_invoiceId = Conversions.ToDouble(dataTable.Rows[0]["invId"]);
			_invoiceNumber = Conversions.ToString(dataTable.Rows[0]["invNumber"]);
		}
		strSql = " SELECT riItemId, riId, riMainQty, riQty,  a.itemId, itemName, a.unitName AS baseUnitName,  b.unitName, a.inventoryAccountId  FROM items a, receivedItem_item b  WHERE a.itemId = b.itemId  AND riId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cReceivedItemItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cReceivedItemItem();
				_item[num].Id = Conversions.ToDouble(row["riItemId"]);
				_item[num].RIId = Conversions.ToDouble(row["riId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].RIQty = Conversions.ToDouble(row["riMainQty"]);
				_item[num].StockQty = Conversions.ToDouble(row["riQty"]);
				_item[num].UnitName = Conversions.ToString(row["unitName"]);
				_item[num].BaseUnitName = Conversions.ToString(row["baseUnitName"]);
				_item[num].InventoryAccountId = Conversions.ToInteger(row["inventoryAccountId"]);
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
							_number = GenerateNewNumber();
							string strSql = " INSERT INTO receivedItem  (riDate,riNumber,riNote,  riCreated,storeId,supId) VALUES  ('" + Strings.Format(_riDate, "yyyy-MM-dd") + "','" + _number + "','" + _note + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Conversions.ToString(_storageId) + "," + Conversions.ToString(_supplierId) + ")";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE receivedItem  SET riDate = '" + Strings.Format(_riDate, "yyyy-MM-dd") + "',  riNote = '" + _note + "', storeId = " + Conversions.ToString(_storageId) + ", supId = " + Conversions.ToString(_supplierId) + " WHERE riId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM receivedItem_item  WHERE riId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].StockQty * -1.0);
								}
							}
						}
						cReceivedItemItem[] item = _item;
						foreach (cReceivedItemItem cReceivedItemItem2 in item)
						{
							string strSql = " INSERT INTO receivedItem_item  (riId, itemId, riMainQty,  riQty, unitName) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cReceivedItemItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cReceivedItemItem2.RIQty)) + "," + Module1.unformatNumber(Conversions.ToString(cReceivedItemItem2.StockQty)) + ",'" + cReceivedItemItem2.UnitName + "')";
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(cReceivedItemItem2.ItemId, _storageId, _riDate, cReceivedItemItem2.StockQty);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 885:
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
					goto IL_03ab;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 885;
				continue;
			}
			break;
			IL_03ab:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, int SupplierId, int StorageId, int GroupId, int BranchId, double InvoiceId, int ItemCategoryId, int ItemId, int Status)
	{
		string text = ((intRange != 3) ? " SELECT a.riId, riDate, CONCAT('RI/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(riDate),3),'/',riNumber) as riNumber, supName,  storeName, prodName as itemName, riQty, 0 AS orderBy " : " SELECT DISTINCT a.riId, riDate, CONCAT('RI/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(riDate),3),'/',riNumber) as riNumber ");
		string text2 = " FROM receivedItem a, receivedItem_item b, storages c, produk d, suppliers e  WHERE a.storeId = c.storeId  AND b.itemId = d.prodId  AND a.riId = b.riId  AND a.supId = e.supId ";
		switch (intRange)
		{
		case 1:
			text2 = text2 + " AND riDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND riDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 3:
			text2 = ((!(InvoiceId > 0.0)) ? (text2 + " AND NOT EXISTS (SELECT riId FROM purchaseinvoices_items WHERE a.riId = riId) ") : (text2 + " AND (NOT EXISTS (SELECT riId FROM purchaseinvoices_items WHERE a.riId = riId)  OR a.riId IN (SELECT riId FROM purchaseinvoices_items WHERE invId = " + Conversions.ToString(InvoiceId) + "))"));
			break;
		}
		switch (Status)
		{
		case 1:
			text2 += " AND NOT EXISTS (SELECT riId FROM purchaseinvoices_items WHERE a.riId = riId) ";
			break;
		case 2:
			text2 += " AND EXISTS (SELECT riId FROM purchaseinvoices_items WHERE a.riId = riId) ";
			break;
		}
		if (SupplierId > 0)
		{
			text2 = text2 + " AND a.supId = " + Conversions.ToString(SupplierId);
		}
		text2 = ((StorageId <= 0) ? (text2 + " AND a.storeId IN  (SELECT storeId FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)") : (text2 + " AND a.storeId = " + Conversions.ToString(StorageId)));
		if (BranchId > 0)
		{
			text2 = text2 + " AND a.storeId IN  (SELECT storeId FROM storages  WHERE branchId = " + Conversions.ToString(BranchId) + ")";
		}
		text2 = ((ItemId > 0) ? (text2 + " AND d.prodId = " + Conversions.ToString(ItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND d.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")") : (text2 + " AND d.catId = " + Conversions.ToString(ItemCategoryId))));
		text += text2;
		if (intRange == 1)
		{
			text += " UNION ALL ";
			text += " SELECT 0, CURDATE(), '' as riNumber, '',  '', prodName as itemName, SUM(riQty), 1 AS orderBy ";
			text += text2;
			text += " GROUP BY itemName ";
		}
		return Module1.sqlTable(intRange switch
		{
			2 => text + " ORDER BY riId DESC LIMIT 100 ", 
			4 => text + " ORDER BY riDate DESC ", 
			3 => text + " ORDER BY riDate ", 
			_ => text + " ORDER BY orderBy, riDate, supName, itemName ", 
		}, "data", Clone: false);
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
						string strSql = " DELETE FROM receivedItem WHERE riId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM receivedItem_item WHERE riId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].StockQty * -1.0);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 290:
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
					goto IL_0158;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 290;
				continue;
			}
			break;
			IL_0158:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM ReceivedItem  WHERE YEAR(riDate) = " + Conversions.ToString(DateAndTime.Year(_riDate)) + " AND storeId = " + Conversions.ToString(StorageId) + " ORDER BY riId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		int num = ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["riNumber"]), 5)) + 1.0)));
		string text = Strings.Trim(Strings.Left(_storageName, 3)) + _storageId.ToString("0000") + "/" + Strings.Right(Conversions.ToString(DateAndTime.Year(_riDate)), 2) + "/" + num.ToString("00000");
		return num.ToString("00000");
	}
}
