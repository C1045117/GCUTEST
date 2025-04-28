namespace GCUv2;

public class cDeliveryOrderItem
{
	private double _doId;

	private int _itemId;

	private string _itemName;

	private double _doQty;

	private double _price;

	private string _generalType;

	private string _longName;

	private string _packaging;

	private string _largeUnit;

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

	public double DOQty
	{
		get
		{
			return _doQty;
		}
		set
		{
			_doQty = value;
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
}
