using System;

namespace GCUv2;

public class cSalesInvoiceItem
{
	private double _id;

	private double _itemId;

	private string _name;

	private string _description;

	private string _generalType;

	private string _longName;

	private string _packaging;

	private double _qty;

	private double _missingQty;

	private double _price;

	private double _basePrice;

	private double _total;

	private string _smallUnit;

	private double _smallQtyMultiplier;

	private string _largeUnit;

	private string _poNumber;

	private double _soId;

	private string _doNumber;

	private double _doId;

	private int _parentItemId;

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

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
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

	public double MissingQty
	{
		get
		{
			return _missingQty;
		}
		set
		{
			_missingQty = value;
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

	public double BasePrice
	{
		get
		{
			return _basePrice;
		}
		set
		{
			_basePrice = value;
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

	public string SmallUnit
	{
		get
		{
			return _smallUnit;
		}
		set
		{
			_smallUnit = value;
		}
	}

	public double SmallQtyMultiplier
	{
		get
		{
			return _smallQtyMultiplier;
		}
		set
		{
			_smallQtyMultiplier = value;
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

	public string PONumber
	{
		get
		{
			return _poNumber;
		}
		set
		{
			_poNumber = value;
		}
	}

	public double SOId
	{
		get
		{
			return _soId;
		}
		set
		{
			_soId = value;
		}
	}

	public string DONumber
	{
		get
		{
			return _doNumber;
		}
		set
		{
			_doNumber = value;
		}
	}

	public double DOId
	{
		get
		{
			return _doId;
		}
		set
		{
			_doId = value;
		}
	}

	public int ParentItemId
	{
		get
		{
			return _parentItemId;
		}
		set
		{
			_parentItemId = value;
		}
	}
}
