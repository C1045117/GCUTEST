namespace GCUv2;

public class cUsageItem
{
	private double _usageId;

	private int _itemId;

	private string _itemName;

	private double _useQty;

	private double _wasteQty;

	public double UsageId
	{
		get
		{
			return _usageId;
		}
		set
		{
			_usageId = value;
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

	public double UseQty
	{
		get
		{
			return _useQty;
		}
		set
		{
			_useQty = value;
		}
	}

	public double WasteQty
	{
		get
		{
			return _wasteQty;
		}
		set
		{
			_wasteQty = value;
		}
	}
}
