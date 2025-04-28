namespace GCUv2;

public class cSalesOrderItem
{
	private double _soId;

	private int _itemId;

	private string _itemName;

	private double _qty;

	private double _price;

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
}
