using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cDeliveryOrder
{
	private double _id;

	private DateTime _doDate;

	private string _number;

	private string _note;

	private DateTime _createdDate;

	private int _storageId;

	private string _storageName;

	private cDeliveryOrderItem[] _item;

	private double _customerId;

	private string _customerName;

	private string _customerAddress;

	private double _invoiceId;

	private string _invoiceNumber;

	private cDeliveryOrderItem[] _currentItem;

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

	public DateTime DODate
	{
		get
		{
			return _doDate;
		}
		set
		{
			_doDate = value;
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

	public cDeliveryOrderItem[] Item
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

	public cDeliveryOrderItem[] CurrentItem
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
	public cDeliveryOrder(double DOId)
	{
		if (!(DOId > 0.0))
		{
			return;
		}
		_id = DOId;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT doDate,CONCAT('DO/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(doDate),3),'/',doNumber) as doNumber,doNote,  doCreated, a.storeId, a.custId,  b.storeName, c.custName, c.custAddress  FROM deliveryOrder a, storages b, customer c WHERE doId = " + Conversions.ToString(_id) + " AND a.storeId = b.storeId  AND a.custId = c.custId ";
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_doDate = Conversions.ToDate(dataTable.Rows[0]["doDate"]);
			_number = Conversions.ToString(dataTable.Rows[0]["doNumber"]);
			_note = Conversions.ToString(dataTable.Rows[0]["doNote"]);
			_createdDate = Conversions.ToDate(dataTable.Rows[0]["doCreated"]);
			_storageId = Conversions.ToInteger(dataTable.Rows[0]["storeId"]);
			_storageName = Conversions.ToString(dataTable.Rows[0]["storeName"]);
			_customerId = Conversions.ToDouble(dataTable.Rows[0]["custId"]);
			_customerName = Conversions.ToString(dataTable.Rows[0]["custName"]);
			_customerAddress = Conversions.ToString(dataTable.Rows[0]["custAddress"]);
		}
		else
		{
			_id = 0.0;
			Information.Err().Raise(513, null, "Pengiriman Pesanan tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT doId, a.itemId, doQty,  prodName as itemName, IF(b.prodTea=1,'Teh GOPEK','') as generalType, b.prodLongName,  b.prodBox, c.unitName  FROM deliveryorder_item a, produk b, itemUnit c  WHERE a.itemId = b.prodId  AND b.prodId = c.itemId  AND c.unitQty = 1  AND doId = " + Conversions.ToString(_id);
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			_item = new cDeliveryOrderItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cDeliveryOrderItem();
				_item[num].DOId = Conversions.ToDouble(row["doId"]);
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].DOQty = Conversions.ToDouble(row["doQty"]);
				_item[num].GeneralType = Conversions.ToString(row["generalType"]);
				_item[num].LongName = Conversions.ToString(row["prodLongName"]);
				_item[num].Packaging = Conversions.ToString(row["prodBox"]);
				_item[num].LargeUnit = Conversions.ToString(row["unitName"]);
				num++;
			}
			strSql = " SELECT a.penjId,penjFaktur FROM penjprod a, penjualan b WHERE a.penjId = b.penjId  AND doId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_invoiceId = Conversions.ToDouble(dataTable.Rows[0]["penjId"]);
				_invoiceNumber = Conversions.ToString(dataTable.Rows[0]["penjFaktur"]);
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
							string strSql = " INSERT INTO deliveryOrder  (doDate,doNumber,doNote,  doCreated,storeId,custId) VALUES  ('" + Strings.Format(_doDate, "yyyy-MM-dd") + "','" + _number + "','" + _note + "','" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "'," + Conversions.ToString(StorageId) + "," + Conversions.ToString(CustomerId) + ")";
							Module1.sqlNonQuery(strSql, "data");
							_id = cDatabase.LastId("data");
						}
						else
						{
							string strSql = " UPDATE deliveryOrder  SET doDate = '" + Strings.Format(_doDate, "yyyy-MM-dd") + "',  doNote = '" + _note + "', storeId = " + Conversions.ToString(_storageId) + ", custId = " + Conversions.ToString(_customerId) + " WHERE doId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							strSql = " DELETE FROM deliveryOrder_item  WHERE doId = " + Conversions.ToString(_id);
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								int num3 = _currentItem.Length - 1;
								for (int i = 0; i <= num3; i++)
								{
									cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].DOQty);
								}
							}
						}
						cDeliveryOrderItem[] item = _item;
						foreach (cDeliveryOrderItem cDeliveryOrderItem2 in item)
						{
							string strSql = " INSERT INTO deliveryOrder_item  (doId, itemId, doQty) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cDeliveryOrderItem2.ItemId) + "," + Module1.unformatNumber(Conversions.ToString(cDeliveryOrderItem2.DOQty)) + ")";
							Module1.sqlNonQuery(strSql, "data");
							if (Module1.pubActivateDailyStockCode)
							{
								cDailyStock.add(cDeliveryOrderItem2.ItemId, _storageId, _doDate, cDeliveryOrderItem2.DOQty * -1.0);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 838:
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
					goto IL_037c;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 838;
				continue;
			}
			break;
			IL_037c:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(int intRange, DateTime dateFirst, DateTime dateLast, double CustomerId, int StorageId, int GroupId, int BranchId, double InvoiceId, int ItemCategoryId, int ItemId)
	{
		string text = ((intRange != 4) ? " SELECT a.doId, doDate, CONCAT('DO/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(doDate),3),'/',doNumber) as doNumber,  custName, storeName, prodName as itemName, doQty, 0 AS orderBy " : " SELECT DISTINCT a.doId, doDate, CONCAT('DO/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(doDate),3),'/',doNumber) AS doNumber ");
		string text2 = " FROM deliveryOrder a, deliveryOrder_item b, storages c, customer d, produk e  WHERE a.storeId = c.storeId  AND a.custId = d.custId  AND b.itemId = e.prodId  AND a.doId = b.doId ";
		switch (intRange)
		{
		case 1:
			text2 = text2 + " AND doDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND doDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + "'";
			break;
		case 4:
			text2 = ((!(InvoiceId > 0.0)) ? (text2 + " AND a.doId NOT IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL) ") : (text2 + " AND (a.doId NOT IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL)  OR a.doId IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL AND penjId = " + Conversions.ToString(InvoiceId) + "))"));
			break;
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
		if (CustomerId > 0.0)
		{
			text2 = text2 + " AND (a.custId = " + Conversions.ToString(CustomerId) + " OR custParentId = " + Conversions.ToString(CustomerId) + ")";
		}
		text2 = ((ItemId > 0) ? (text2 + " AND e.prodId = " + Conversions.ToString(ItemId)) : ((ItemCategoryId <= 0) ? (text2 + " AND e.catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")") : (text2 + " AND e.catId = " + Conversions.ToString(ItemCategoryId))));
		text += text2;
		if (intRange == 1)
		{
			text += " UNION ALL  SELECT 0, CURDATE(), '',  '', '', prodName as itemName, SUM(doQty), 1 AS orderBy ";
			text += text2;
			text += " GROUP BY itemName ";
		}
		return Module1.sqlTable(intRange switch
		{
			2 => text + " ORDER BY doId DESC LIMIT 100 ", 
			3 => text + " ORDER BY doDate DESC ", 
			4 => text + " ORDER BY doDate ", 
			_ => text + " ORDER BY orderBy, doDate, custName, itemName ", 
		}, "data", Clone: false);
	}

	public static DataTable SearchAvailableDO(double CustomerId, double InvoiceId)
	{
		string text = " SELECT DISTINCT a.doId, doDate, CONCAT('DO/',CAST(a.storeId AS CHAR),'/',SUBSTR(YEAR(doDate),3),'/',doNumber) AS doNumber  FROM deliveryOrder a ";
		text = string.Concat(text, " WHERE a.custId = " + Conversions.ToString(CustomerId));
		text = ((!(InvoiceId > 0.0)) ? (text + " AND a.doId NOT IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL) ") : (text + " AND (a.doId NOT IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL)  OR a.doId IN (SELECT doId FROM penjprod WHERE doId IS NOT NULL AND penjId = " + Conversions.ToString(InvoiceId) + "))"));
		text += " ORDER BY doDate ";
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
						string strSql = " DELETE FROM deliveryOrder WHERE doId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM deliveryOrder_item WHERE doId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						if (Module1.pubActivateDailyStockCode)
						{
							int num3 = _currentItem.Length - 1;
							for (int i = 0; i <= num3; i++)
							{
								cDailyStock.add(_currentItem[i].ItemId, _currentStorage, _currentDate, _currentItem[i].DOQty);
							}
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 280:
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
					goto IL_014e;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 280;
				continue;
			}
			break;
			IL_014e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private string GenerateNewNumber()
	{
		string strSql = " SELECT * FROM DeliveryOrder  WHERE YEAR(doDate) = " + Conversions.ToString(DateAndTime.Year(_doDate)) + " AND storeId = " + Conversions.ToString(StorageId) + " ORDER BY doId DESC LIMIT 1 ";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return ((dataTable.Rows.Count <= 0) ? 1 : checked((int)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(dataTable.Rows[0]["doNumber"]), 5)) + 1.0))).ToString("00000");
	}
}
