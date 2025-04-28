using System;

namespace GCUv2;

public class cPurchaseInvoiceItem
{
	private double _id;

	private double _itemId;

	private double _storageId;

	private string _storageName;

	private string _itemName;

	private string _description;

	private double _invoiceQty;

	private double _stockQty;

	private double _parkedQty;

	private double _deduction;

	private double _netQty;

	private double _price;

	private double _extraPrice;

	private double _total;

	private string _generalType;

	private string _longName;

	private string _packaging;

	private string _largeUnit;

	private double _riId;

	private string _riNumber;

	private double _riItemId;

	private int _currencyId;

	private double _currencyRate;

	private string _currencyName;

	private double _unitId;

	private string _unitName;

	private string _baseUnitName;

	private int _inventoryAccountId;

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
			return checked((int)Math.Round(_itemId));
		}
		set
		{
			_itemId = value;
		}
	}

	public int StorageId
	{
		get
		{
			return checked((int)Math.Round(_storageId));
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

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

	public double InvoiceQty
	{
		get
		{
			return _invoiceQty;
		}
		set
		{
			_invoiceQty = value;
		}
	}

	public double StockQty
	{
		get
		{
			return _stockQty;
		}
		set
		{
			_stockQty = value;
		}
	}

	public double ParkedQty
	{
		get
		{
			return _parkedQty;
		}
		set
		{
			_parkedQty = value;
		}
	}

	public double Deduction
	{
		get
		{
			return _deduction;
		}
		set
		{
			_deduction = value;
		}
	}

	public double NetQty
	{
		get
		{
			return _netQty;
		}
		set
		{
			_netQty = value;
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

	public double ExtraPrice
	{
		get
		{
			return _extraPrice;
		}
		set
		{
			_extraPrice = value;
		}
	}

	public double Total
	{
		get
		{
			return _total;
		}
		set
		{
			_total = value;
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
			_longName = value;
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
			_packaging = value;
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

	public double RiId
	{
		get
		{
			return _riId;
		}
		set
		{
			_riId = value;
		}
	}

	public string RiNumber
	{
		get
		{
			return _riNumber;
		}
		set
		{
			_riNumber = value;
		}
	}

	public double RiItemId
	{
		get
		{
			return _riItemId;
		}
		set
		{
			_riItemId = value;
		}
	}

	public int CurrencyId
	{
		get
		{
			return _currencyId;
		}
		set
		{
			_currencyId = value;
		}
	}

	public string CurrencyName
	{
		get
		{
			return _currencyName;
		}
		set
		{
			_currencyName = value;
		}
	}

	public double CurrencyRate
	{
		get
		{
			return _currencyRate;
		}
		set
		{
			_currencyRate = value;
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
}
