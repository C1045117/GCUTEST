using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cItem
{
	private int _id;

	private string _name;

	private int _processType;

	private int _allowPurchase;

	private int _allowComponent;

	private int _allowProcess;

	private int _allowEditStockQty;

	private int _hasParkedQty;

	private int _hasDeduction;

	private int _hasExtraPrice;

	private int _catId;

	private int _productionStepId;

	private int _typeId;

	private int _flower;

	private int _active;

	private cItemStorage[] _storage;

	private cItemPurchasePrice[] _purchasePrice;

	private cItemComponent[] _component;

	private cItemStandardComponent[] _standardComponent;

	private cItemStandardUsage[] _standardUsage;

	private cItemGroup[] _group;

	private string _generalType;

	private string _longName;

	private string _packaging;

	private int _isTehGopek;

	private int _allowSell;

	private string _largeUnit;

	private string _unitName1;

	private string _unitName2;

	private string _unitName3;

	private string _unitName4;

	private double _unitQty2;

	private double _unitQty3;

	private double _unitQty4;

	private int _inventoryAccountId;

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

	public int ProcessType
	{
		get
		{
			return _processType;
		}
		set
		{
			_processType = value;
		}
	}

	public int AllowPurchase
	{
		get
		{
			return _allowPurchase;
		}
		set
		{
			_allowPurchase = value;
		}
	}

	public int AllowComponent
	{
		get
		{
			return _allowComponent;
		}
		set
		{
			_allowComponent = value;
		}
	}

	public int AllowProcess
	{
		get
		{
			return _allowProcess;
		}
		set
		{
			_allowProcess = value;
		}
	}

	public int AllowEditStockQty
	{
		get
		{
			return _allowEditStockQty;
		}
		set
		{
			_allowEditStockQty = value;
		}
	}

	public int HasParkedQty
	{
		get
		{
			return _hasParkedQty;
		}
		set
		{
			_hasParkedQty = value;
		}
	}

	public int HasDeduction
	{
		get
		{
			return _hasDeduction;
		}
		set
		{
			_hasDeduction = value;
		}
	}

	public int HasExtraPrice
	{
		get
		{
			return _hasExtraPrice;
		}
		set
		{
			_hasExtraPrice = value;
		}
	}

	public int CatId
	{
		get
		{
			return _catId;
		}
		set
		{
			_catId = value;
		}
	}

	public int ProductionStepId
	{
		get
		{
			return _productionStepId;
		}
		set
		{
			_productionStepId = value;
		}
	}

	public int TypeId
	{
		get
		{
			return _typeId;
		}
		set
		{
			_typeId = value;
		}
	}

	public int Flower
	{
		get
		{
			return _flower;
		}
		set
		{
			_flower = value;
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

	public cItemStorage[] Storage
	{
		get
		{
			return _storage;
		}
		set
		{
			_storage = value;
		}
	}

	public cItemPurchasePrice[] PurchasePrice
	{
		get
		{
			return _purchasePrice;
		}
		set
		{
			_purchasePrice = value;
		}
	}

	public cItemComponent[] Component
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

	public cItemStandardComponent[] StandardComponent
	{
		get
		{
			return _standardComponent;
		}
		set
		{
			_standardComponent = value;
		}
	}

	public cItemStandardUsage[] StandardUsage
	{
		get
		{
			return _standardUsage;
		}
		set
		{
			_standardUsage = value;
		}
	}

	public cItemGroup[] Group
	{
		get
		{
			return _group;
		}
		set
		{
			_group = value;
		}
	}

	public string GeneralType
	{
		get
		{
			return _generalType;
		}
		set
		{
			_generalType = value;
		}
	}

	public string LongName
	{
		get
		{
			return _longName;
		}
		set
		{
			_longName = Module1.cleanString(value);
		}
	}

	public string Packaging
	{
		get
		{
			return _packaging;
		}
		set
		{
			_packaging = Module1.cleanString(value);
		}
	}

	public int AllowSell
	{
		get
		{
			return _allowSell;
		}
		set
		{
			_allowSell = value;
		}
	}

	public int IsTehGopek
	{
		get
		{
			return _isTehGopek;
		}
		set
		{
			_isTehGopek = value;
		}
	}

	public string LargeUnit
	{
		get
		{
			return _largeUnit;
		}
		set
		{
			_largeUnit = value;
		}
	}

	public string UnitName1
	{
		get
		{
			return _unitName1;
		}
		set
		{
			_unitName1 = value;
		}
	}

	public string UnitName2
	{
		get
		{
			return _unitName2;
		}
		set
		{
			_unitName2 = value;
		}
	}

	public string UnitName3
	{
		get
		{
			return _unitName3;
		}
		set
		{
			_unitName3 = value;
		}
	}

	public string UnitName4
	{
		get
		{
			return _unitName4;
		}
		set
		{
			_unitName4 = value;
		}
	}

	public double UnitQty2
	{
		get
		{
			return _unitQty2;
		}
		set
		{
			_unitQty2 = value;
		}
	}

	public double UnitQty3
	{
		get
		{
			return _unitQty3;
		}
		set
		{
			_unitQty3 = value;
		}
	}

	public double UnitQty4
	{
		get
		{
			return _unitQty4;
		}
		set
		{
			_unitQty4 = value;
		}
	}

	public int InventoryAccountId
	{
		get
		{
			return _inventoryAccountId;
		}
		set
		{
			_inventoryAccountId = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cItem(int ItemId)
	{
		if (ItemId <= 0)
		{
			return;
		}
		_id = ItemId;
		string strSql = " SELECT produk.*, IF(prodTea=1,'Teh GOPEK','') as generalType FROM produk  WHERE prodId = " + Conversions.ToString(_id);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_name = Conversions.ToString(dataTable.Rows[0]["prodName"]);
			_catId = Conversions.ToInteger(dataTable.Rows[0]["catId"]);
			_typeId = Conversions.ToInteger(dataTable.Rows[0]["typeId"]);
			_active = Conversions.ToInteger(dataTable.Rows[0]["prodStatus"]);
			_generalType = Conversions.ToString(dataTable.Rows[0]["generalType"]);
			_isTehGopek = Conversions.ToInteger(dataTable.Rows[0]["prodTea"]);
			_allowSell = Conversions.ToInteger(dataTable.Rows[0]["prodAllowSell"]);
			_longName = Conversions.ToString(dataTable.Rows[0]["prodLongName"]);
			_packaging = Conversions.ToString(dataTable.Rows[0]["prodBox"]);
		}
		else
		{
			_id = 0;
			Information.Err().Raise(513, null, "Barang tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT a.*  FROM items a  WHERE itemId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_processType = Conversions.ToInteger(dataTable.Rows[0]["itemProcessType"]);
			_allowPurchase = Conversions.ToInteger(dataTable.Rows[0]["itemAllowPurchase"]);
			_allowComponent = Conversions.ToInteger(dataTable.Rows[0]["itemAllowComponent"]);
			_allowProcess = Conversions.ToInteger(dataTable.Rows[0]["itemAllowProcess"]);
			_allowEditStockQty = Conversions.ToInteger(dataTable.Rows[0]["itemHasStockQty"]);
			_hasParkedQty = Conversions.ToInteger(dataTable.Rows[0]["itemHasParkedQty"]);
			_hasDeduction = Conversions.ToInteger(dataTable.Rows[0]["itemHasDeduction"]);
			_hasExtraPrice = Conversions.ToInteger(dataTable.Rows[0]["itemHasExtraPrice"]);
			if ((_hasParkedQty != 0) & (_hasDeduction != 0) & (_hasExtraPrice != 0))
			{
				_flower = 1;
			}
			else
			{
				_flower = 0;
			}
			_productionStepId = Conversions.ToInteger(dataTable.Rows[0]["stepId"]);
			_inventoryAccountId = Conversions.ToInteger(dataTable.Rows[0]["inventoryAccountId"]);
		}
		int num = 0;
		strSql = " SELECT a.storeId, storeName, branchName, psAvailable, psQty, psPrice  FROM storages a LEFT OUTER JOIN produkstorages b  ON a.storeId = b.storeId  AND b.prodId = " + Conversions.ToString(_id) + ", branches c  WHERE storeActive = 1  AND a.branchId = c.branchId  ORDER BY branchName, storeName ";
		dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		checked
		{
			_storage = new cItemStorage[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_storage[num] = new cItemStorage();
				_storage[num].StorageId = Conversions.ToInteger(row["storeId"]);
				_storage[num].StorageName = Conversions.ToString(row["storeName"]);
				_storage[num].BranchName = Conversions.ToString(row["branchName"]);
				_storage[num].IsMember = Conversions.ToBoolean(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["psAvailable"])) ? ((object)false) : row["psAvailable"]);
				_storage[num].Qty = Conversions.ToDouble(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["psQty"])) ? ((object)0) : row["psQty"]);
				_storage[num].Price = Conversions.ToDouble(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["psPrice"])) ? ((object)0) : row["psPrice"]);
				num++;
			}
			strSql = " SELECT *  FROM itemUnit  WHERE itemId = " + Conversions.ToString(_id) + " ORDER BY unitNumber ";
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_unitName1 = Conversions.ToString(dataTable.Rows[0]["unitName"]);
			_unitName2 = Conversions.ToString(dataTable.Rows[1]["unitName"]);
			_unitName3 = Conversions.ToString(dataTable.Rows[2]["unitName"]);
			_unitName4 = Conversions.ToString(dataTable.Rows[3]["unitName"]);
			_unitQty2 = Conversions.ToDouble(dataTable.Rows[1]["unitQty"]);
			_unitQty3 = Conversions.ToDouble(dataTable.Rows[2]["unitQty"]);
			_unitQty4 = Conversions.ToDouble(dataTable.Rows[3]["unitQty"]);
			strSql = " SELECT a.*, b.supName, c.unitNumber, c.unitName  FROM purchaseprice a, suppliers b, itemUnit c  WHERE a.supId = b.supId  AND a.unitId = c.unitId  AND a.itemId = " + Conversions.ToString(_id) + " ORDER BY validFromDate DESC, supName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_purchasePrice = new cItemPurchasePrice[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row2 in dataTable.Rows)
			{
				_purchasePrice[num] = new cItemPurchasePrice(0, 0, DateAndTime.Now, 0.0, "");
				_purchasePrice[num].ItemId = Conversions.ToInteger(row2["itemId"]);
				_purchasePrice[num].SupplierId = Conversions.ToInteger(row2["supId"]);
				_purchasePrice[num].SupplierName = Conversions.ToString(row2["supName"]);
				_purchasePrice[num].UnitNumber = Conversions.ToInteger(row2["unitNumber"]);
				_purchasePrice[num].UnitName = Conversions.ToString(row2["unitName"]);
				_purchasePrice[num].Price = Conversions.ToDouble(row2["itemPrice"]);
				_purchasePrice[num].ValidFromDate = Conversions.ToDate(row2["validFromDate"]);
				num++;
			}
			strSql = " SELECT a.itemId, itemName, b.comId  FROM (SELECT i.itemId, i.itemName  FROM items i, steps_items s WHERE i.itemId = s.itemId  AND s.stepId = " + Conversions.ToString(_productionStepId) + ") as a  LEFT OUTER JOIN itemcomponents b  ON a.itemId = b.comId  AND b.itemId = " + Conversions.ToString(_id) + " ORDER BY itemName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_component = new cItemComponent[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row3 in dataTable.Rows)
			{
				_component[num] = new cItemComponent();
				_component[num].ItemId = Conversions.ToInteger(row3["itemId"]);
				_component[num].ItemName = Conversions.ToString(row3["itemName"]);
				_component[num].IsMember = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row3["comId"]));
				num++;
			}
			strSql = " SELECT comId as componentId, itemName as componentName, a.storeId,  storeName, standardQty  FROM standardcomponents a, items b, storages c  WHERE a.comId = b.itemId  AND a.storeId = c.storeId  AND a.itemId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_standardComponent = new cItemStandardComponent[dataTable.Rows.Count - 1 + 1];
			num = 0;
			foreach (DataRow row4 in dataTable.Rows)
			{
				_standardComponent[num] = new cItemStandardComponent();
				_standardComponent[num].ComponentId = Conversions.ToInteger(row4["componentId"]);
				_standardComponent[num].ComponentName = Conversions.ToString(row4["componentName"]);
				_standardComponent[num].StorageId = Conversions.ToInteger(row4["storeId"]);
				_standardComponent[num].StorageName = Conversions.ToString(row4["storeName"]);
				_standardComponent[num].Qty = Conversions.ToDouble(row4["standardQty"]);
				num++;
			}
			strSql = " SELECT comId as componentId, itemName as componentName, a.branchId,  branchName, qty  FROM standardUsage a, items b, branches c  WHERE a.comId = b.itemId  AND a.branchId = c.branchId  AND a.itemId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_standardUsage = new cItemStandardUsage[dataTable.Rows.Count - 1 + 1];
			num = 0;
			foreach (DataRow row5 in dataTable.Rows)
			{
				_standardUsage[num] = new cItemStandardUsage();
				_standardUsage[num].ComponentId = Conversions.ToInteger(row5["componentId"]);
				_standardUsage[num].ComponentName = Conversions.ToString(row5["componentName"]);
				_standardUsage[num].BranchId = Conversions.ToInteger(row5["branchId"]);
				_standardUsage[num].BranchName = Conversions.ToString(row5["branchName"]);
				_standardUsage[num].Qty = Conversions.ToDouble(row5["qty"]);
				num++;
			}
			strSql = " SELECT comId AS componentId, itemName AS componentName, qty  FROM itemGroup a, items b  WHERE a.comId = b.itemId  AND a.itemId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			_group = new cItemGroup[dataTable.Rows.Count - 1 + 1];
			num = 0;
			foreach (DataRow row6 in dataTable.Rows)
			{
				_group[num] = new cItemGroup();
				_group[num].ComponentId = Conversions.ToInteger(row6["componentId"]);
				_group[num].ComponentName = Conversions.ToString(row6["componentName"]);
				_group[num].Qty = Conversions.ToDouble(row6["qty"]);
				num++;
			}
		}
	}

	public double GetPurchasePrice(int SupplierId, DateTime PurchaseDate)
	{
		double result = 0.0;
		cItemPurchasePrice[] purchasePrice = _purchasePrice;
		foreach (cItemPurchasePrice cItemPurchasePrice2 in purchasePrice)
		{
			if ((cItemPurchasePrice2.SupplierId == SupplierId) & (DateTime.Compare(cItemPurchasePrice2.ValidFromDate, PurchaseDate) <= 0))
			{
				result = cItemPurchasePrice2.Price;
				break;
			}
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Save()
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
					string strSql;
					if (_id == 0)
					{
						strSql = " INSERT INTO produk(prodName, catId, typeId,  prodTea, prodAllowSell, prodLongName,  prodBox, prodStatus) VALUES ('" + _name + "'," + Conversions.ToString(_catId) + "," + Conversions.ToString(_typeId) + "," + Conversions.ToString(_isTehGopek) + "," + Conversions.ToString(_allowSell) + ",'" + _longName + "','" + _packaging + "'," + Conversions.ToString(_active) + ")";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " INSERT INTO items(itemName,itemAllowPurchase,itemAllowComponent,  itemAllowProcess, itemHasStockQty, itemHasParkedQty,  itemHasDeduction, itemHasExtraPrice, stepId,  unitName,inventoryAccountId,itemActive) VALUES ( '" + _name + "'," + Conversions.ToString(_allowPurchase) + "," + Conversions.ToString(_allowComponent) + "," + Conversions.ToString(_allowProcess) + "," + Conversions.ToString(_allowEditStockQty) + "," + Conversions.ToString(_hasParkedQty) + "," + Conversions.ToString(_hasDeduction) + "," + Conversions.ToString(_hasExtraPrice) + "," + Conversions.ToString(_productionStepId) + ",'" + _unitName1 + "'," + Conversions.ToString(_inventoryAccountId) + "," + Conversions.ToString(_active) + ")";
						Module1.sqlNonQuery(strSql, "data");
						_id = checked((int)Math.Round(cDatabase.LastId("data")));
						strSql = " INSERT INTO itemUnit(unitNumber,unitName,unitQty,itemId) VALUES  (1,'" + _unitName1 + "',1," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " INSERT INTO itemUnit(unitNumber,unitName,unitQty,itemId) VALUES  (2,'" + _unitName2 + "'," + Module1.unformatNumber(Conversions.ToString(_unitQty2)) + "," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " INSERT INTO itemUnit(unitNumber,unitName,unitQty,itemId) VALUES  (3,'" + _unitName3 + "'," + Module1.unformatNumber(Conversions.ToString(_unitQty3)) + "," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " INSERT INTO itemUnit(unitNumber,unitName,unitQty,itemId) VALUES  (4,'" + _unitName4 + "'," + Module1.unformatNumber(Conversions.ToString(_unitQty4)) + "," + Conversions.ToString(_id) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					else
					{
						strSql = " UPDATE produk  SET prodName = '" + _name + "',  catId = " + Conversions.ToString(_catId) + ",  typeId = " + Conversions.ToString(_typeId) + ",  prodTea = " + Conversions.ToString(_isTehGopek) + ", prodAllowSell = " + Conversions.ToString(_allowSell) + ", prodLongName = '" + _longName + "', prodBox = '" + _packaging + "', prodStatus = " + Conversions.ToString(_active) + " WHERE prodId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " UPDATE items  SET itemName = '" + _name + "',  itemAllowPurchase = " + Conversions.ToString(_allowPurchase) + ", itemAllowComponent = " + Conversions.ToString(_allowComponent) + ", itemAllowProcess = " + Conversions.ToString(_allowProcess) + ", itemHasStockQty = " + Conversions.ToString(_allowEditStockQty) + ", itemHasParkedQty = " + Conversions.ToString(_flower) + ", itemHasDeduction = " + Conversions.ToString(_flower) + ", itemHasExtraPrice = " + Conversions.ToString(_flower) + ", stepId = " + Conversions.ToString(_productionStepId) + ",  unitName = '" + _unitName1 + "', inventoryAccountId = " + Conversions.ToString(_inventoryAccountId) + ", itemActive = " + Conversions.ToString(_active) + " WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " UPDATE itemUnit  SET unitName = '" + _unitName1 + "' WHERE unitNumber = 1  AND itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " UPDATE itemUnit  SET unitName = '" + _unitName2 + "', unitQty = " + Module1.unformatNumber(Conversions.ToString(_unitQty2)) + " WHERE unitNumber = 2  AND itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " UPDATE itemUnit  SET unitName = '" + _unitName3 + "', unitQty = " + Module1.unformatNumber(Conversions.ToString(_unitQty3)) + " WHERE unitNumber = 3  AND itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " UPDATE itemUnit  SET unitName = '" + _unitName4 + "', unitQty = " + Module1.unformatNumber(Conversions.ToString(_unitQty4)) + " WHERE unitNumber = 4  AND itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM produkstorages WHERE prodId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM purchaseprice WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM itemcomponents WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM standardcomponents WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM standardusage WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = "DELETE FROM itemGroup WHERE itemId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
					}
					strSql = " SELECT unitId  FROM itemUnit  WHERE unitQty > 0  AND itemId = " + Conversions.ToString(_id) + " ORDER BY unitQty ASC ";
					DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
					double num3 = Conversions.ToDouble(dataTable.Rows[0]["unitId"]);
					strSql = " UPDATE produk  SET taxInvoiceUnitId = " + Conversions.ToString(num3) + " WHERE prodId = " + Conversions.ToString(_id);
					Module1.sqlNonQuery(strSql, "data");
					cItemStorage[] storage = _storage;
					foreach (cItemStorage cItemStorage2 in storage)
					{
						strSql = " INSERT INTO produkstorages  (prodId, storeId, psAvailable, psQty, psPrice) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemStorage2.StorageId) + "," + Conversions.ToString(cItemStorage2.IsMember ? 1 : 0) + "," + Module1.unformatNumber(Conversions.ToString(cItemStorage2.Qty)) + "," + Module1.unformatNumber(Conversions.ToString(cItemStorage2.Price)) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					cItemPurchasePrice[] purchasePrice = _purchasePrice;
					foreach (cItemPurchasePrice cItemPurchasePrice2 in purchasePrice)
					{
						strSql = " SELECT unitId  FROM itemUnit  WHERE unitNumber = " + Conversions.ToString(cItemPurchasePrice2.UnitNumber) + " AND itemId = " + Conversions.ToString(_id);
						dataTable = Module1.sqlTable(strSql, "data", Clone: false);
						num3 = Conversions.ToDouble(dataTable.Rows[0]["unitId"]);
						strSql = " INSERT INTO purchaseprice  (itemId, supId, itemPrice,  validFromDate, unitId) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemPurchasePrice2.SupplierId) + "," + Module1.unformatNumber(Conversions.ToString(cItemPurchasePrice2.Price)) + ",'" + Strings.Format(cItemPurchasePrice2.ValidFromDate, "yyyy-MM-dd") + "'," + Conversions.ToString(num3) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					if (!Information.IsNothing(_component))
					{
						cItemComponent[] component = _component;
						foreach (cItemComponent cItemComponent2 in component)
						{
							strSql = " INSERT INTO itemcomponents  (itemId,comId) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemComponent2.ItemId) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
					}
					if (!Information.IsNothing(_standardComponent))
					{
						cItemStandardComponent[] standardComponent = _standardComponent;
						foreach (cItemStandardComponent cItemStandardComponent2 in standardComponent)
						{
							strSql = " INSERT INTO standardcomponents  (itemId,comId,storeId,standardQty) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemStandardComponent2.ComponentId) + "," + Conversions.ToString(cItemStandardComponent2.StorageId) + "," + Module1.unformatNumber(Conversions.ToString(cItemStandardComponent2.Qty)) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
					}
					if (!Information.IsNothing(_standardUsage))
					{
						cItemStandardUsage[] standardUsage = _standardUsage;
						foreach (cItemStandardUsage cItemStandardUsage2 in standardUsage)
						{
							strSql = " INSERT INTO standardUsage  (itemId,comId,branchId,qty) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemStandardUsage2.ComponentId) + "," + Conversions.ToString(cItemStandardUsage2.BranchId) + "," + Module1.unformatNumber(Conversions.ToString(cItemStandardUsage2.Qty)) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
					}
					if (!Information.IsNothing(_group))
					{
						cItemGroup[] group = _group;
						foreach (cItemGroup cItemGroup2 in group)
						{
							strSql = " INSERT INTO itemGroup  (itemId,comId,qty) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cItemGroup2.ComponentId) + "," + Module1.unformatNumber(Conversions.ToString(cItemGroup2.Qty)) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 3445:
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
				goto IL_0dab;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3445;
				continue;
			}
			break;
			IL_0dab:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM items  WHERE itemName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND itemId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static DataTable getItem(int Active)
	{
		string text = " SELECT *  FROM produk ";
		switch (Active)
		{
		case 0:
			text += " WHERE prodStatus = 0 ";
			break;
		case 1:
			text += " WHERE prodStatus = 1 ";
			break;
		}
		text += " ORDER BY prodName";
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable Search(int AllowPurchase, int AllowProduction, int StepId, int IsComponent, int ProductionItemId, int ProductionStepId, int AllowSell, int ItemTypeId, int ItemCategoryId, int SupplierId, int StorageId1, int StorageId2, double CustomerId, bool CanBeUsedAsGroupMember, int GroupId, int BranchId, int Active)
	{
		string text = " SELECT *  FROM produk a, items b  WHERE a.prodId = b.itemId ";
		switch (AllowPurchase)
		{
		case 0:
			text += " AND itemAllowPurchase = 0 ";
			break;
		case 1:
			text += " AND itemAllowPurchase = 1 ";
			break;
		}
		switch (AllowProduction)
		{
		case 0:
			text += " AND itemAllowProcess = 0 ";
			break;
		case 1:
			text += " AND itemAllowProcess = 1 ";
			break;
		}
		if (IsComponent == 1 && ProductionItemId > 0)
		{
			text = text + " AND itemAllowComponent = 1 AND itemId IN  (SELECT comId FROM itemComponents   WHERE itemId = " + Conversions.ToString(ProductionItemId) + ")";
		}
		else if (IsComponent == 1 && ProductionStepId > 0)
		{
			text = text + " AND itemAllowComponent = 1 AND itemId IN  (SELECT itemId FROM steps_items   WHERE stepId = " + Conversions.ToString(ProductionStepId) + ")";
		}
		else if (IsComponent == 1)
		{
			text += " AND itemAllowComponent = 1 ";
		}
		if (StepId > 0)
		{
			text = text + " AND b.stepId = " + Conversions.ToString(StepId);
		}
		switch (AllowSell)
		{
		case 0:
			text += " AND prodAllowSell = 0 ";
			break;
		case 1:
			text += " AND prodAllowSell = 1 ";
			if (CustomerId > 0.0)
			{
				text = text + " AND prodId IN (SELECT prodId from ProdHarga  WHERE HargaId = (select hargaId from customer  where custId = " + Conversions.ToString(CustomerId) + ")  AND phAmount > 0) ";
			}
			break;
		}
		if (ItemTypeId > 0)
		{
			text = text + " AND typeId = " + Conversions.ToString(ItemTypeId);
		}
		if (CanBeUsedAsGroupMember)
		{
			text += " AND (typeId =1 OR typeId = 2)";
		}
		if (ItemCategoryId > 0)
		{
			text = text + " AND catId = " + Conversions.ToString(ItemCategoryId);
		}
		else if (GroupId > 0)
		{
			text = text + " AND catId IN (SELECT catId FROM group_itemcategory WHERE groupId = " + Conversions.ToString(GroupId) + ")";
		}
		if (SupplierId > 0)
		{
			text = text + " AND prodId IN ( SELECT itemId FROM purchaseprice  WHERE supId = " + Conversions.ToString(SupplierId) + ")";
		}
		if (StorageId1 > 0)
		{
			text = text + " AND prodId IN ( SELECT prodId FROM produkstorages  WHERE storeId = " + Conversions.ToString(StorageId1) + " AND psAvailable = 1) ";
		}
		else if (BranchId > 0)
		{
			text = text + " AND prodId IN ( SELECT prodId FROM produkstorages  WHERE psAvailable = 1  AND storeId IN (SELECT storeId FROM storages WHERE branchId = " + Conversions.ToString(BranchId) + ") AND storeId IN  (SELECT storeId FROM groupstorage   WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1))";
		}
		if (StorageId2 > 0)
		{
			text = text + " AND prodId IN ( SELECT prodId FROM produkstorages  WHERE storeId = " + Conversions.ToString(StorageId2) + " AND psAvailable = 1) ";
		}
		if (Active == -1)
		{
			text += " AND prodStatus = 1 ";
		}
		text += " ORDER BY prodName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable GetItemStorage(int ItemId, string StorageType, int BranchId, int GroupId)
	{
		string text = " SELECT a.storeId, storeName  FROM storages a, produkstorages b WHERE a.storeId = b.storeId  AND psAvailable = 1  AND prodId = " + Conversions.ToString(ItemId) + " AND a.branchId = " + Conversions.ToString(BranchId) + " AND a.storeId IN (SELECT storeId FROM groupStorage WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
		if (Operators.CompareString(StorageType, "Good", TextCompare: false) == 0)
		{
			text += " AND a.storeReturn = 0 ";
		}
		else if (Operators.CompareString(StorageType, "Return", TextCompare: false) == 0)
		{
			text += " AND a.storeReturn = 1 ";
		}
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static int GetItemType(int itemId)
	{
		int result = 0;
		string strSql = " SELECT typeId FROM produk  WHERE prodId = " + Conversions.ToString(itemId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = Conversions.ToInteger(dataTable.Rows[0]["typeId"]);
		}
		return result;
	}

	public static DataTable SearchItemUnit(int itemId, int SupplierId)
	{
		string strSql = " SELECT *  FROM itemUnit  WHERE unitQty > 0  AND itemId = " + Conversions.ToString(itemId) + " AND unitId IN (SELECT unitId FROM purchasePrice WHERE supId = " + Conversions.ToString(SupplierId) + ") ORDER BY unitNumber ";
		return Module1.sqlTable(strSql, "read", Clone: false);
	}

	public static int GetTypeId(int ItemId)
	{
		string strSql = " SELECT typeId FROM produk  WHERE prodId = " + Conversions.ToString(ItemId);
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		return Conversions.ToInteger(dataTable.Rows[0]["typeId"]);
	}

	public static double GetItemId(string ItemName)
	{
		string strSql = " SELECT itemId FROM items  WHERE itemName = '" + ItemName + "'";
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		return Conversions.ToDouble(dataTable.Rows[0]["itemId"]);
	}

	public static int GetInventoryAccountId(int itemId)
	{
		string strSql = " SELECT inventoryAccountId FROM items  WHERE itemId = " + Conversions.ToString(itemId);
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		return Conversions.ToInteger(dataTable.Rows[0]["inventoryAccountId"]);
	}
}
