namespace GCUv2;

public class cReceivedItemItem
{
	private double _id;

	private double _riId;

	private int _itemId;

	private string _itemName;

	private double _riQty;

	private double _stockQty;

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

	public double RIId
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

	public double RIQty
	{
		get
		{
			return _riQty;
		}
		set
		{
			_riQty = value;
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
