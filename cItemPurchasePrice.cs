using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cItemPurchasePrice
{
	private int _itemId;

	private int _supplierId;

	private string _supplierName;

	private DateTime _purchaseDate;

	private double _price;

	private DateTime _validFromDate;

	private string _baseUnitName;

	private double _unitId;

	private int _unitNumber;

	private string _unitName;

	private double _unitQty;

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

	public double Price
	{
		get
		{
			return _price;
		}
		set
		{
			_price = value;
		}
	}

	public DateTime ValidFromDate
	{
		get
		{
			return _validFromDate;
		}
		set
		{
			_validFromDate = value;
		}
	}

	public string BaseUnitName
	{
		get
		{
			return _baseUnitName;
		}
		set
		{
			_baseUnitName = value;
		}
	}

	public double UnitId
	{
		get
		{
			return _unitId;
		}
		set
		{
			_unitId = value;
		}
	}

	public int UnitNumber
	{
		get
		{
			return _unitNumber;
		}
		set
		{
			_unitNumber = value;
		}
	}

	public string UnitName
	{
		get
		{
			return _unitName;
		}
		set
		{
			_unitName = value;
		}
	}

	public double UnitQty
	{
		get
		{
			return _unitQty;
		}
		set
		{
			_unitQty = value;
		}
	}

	public cItemPurchasePrice(int ItemId, int SupplierId, DateTime PurchaseDate, double UnitId, string UnitName)
	{
		if (ItemId > 0)
		{
			_itemId = ItemId;
			_supplierId = SupplierId;
			_purchaseDate = PurchaseDate;
			_unitId = UnitId;
			string text = " SELECT a.itemPrice, a.unitId, c.unitName AS baseUnitName, b.unitName, b.unitQty  FROM purchasePrice a, itemUnit b, items c WHERE a.itemId = " + Conversions.ToString(_itemId) + " AND a.unitId = b.unitId  AND a.itemId = c.itemId  AND supId = " + Conversions.ToString(_supplierId) + " AND validFromDate <= '" + Strings.Format(_purchaseDate, "yyyy-MM-dd") + "'";
			DataTable dataTable = Module1.sqlTable(((!(UnitId > 0.0)) ? (text + " AND b.unitName = '" + UnitName + "'") : (text + " AND b.unitId = " + Conversions.ToString(_unitId))) + " ORDER BY validFromDate DESC ", "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_price = Conversions.ToDouble(dataTable.Rows[0]["itemPrice"]);
				_baseUnitName = Conversions.ToString(dataTable.Rows[0]["baseUnitName"]);
				_unitId = Conversions.ToDouble(dataTable.Rows[0]["unitId"]);
				_unitName = Conversions.ToString(dataTable.Rows[0]["unitName"]);
				_unitQty = Conversions.ToDouble(dataTable.Rows[0]["unitQty"]);
			}
		}
	}
}
