namespace GCUv2;

public class cSalesPriceCodeItem
{
	private int _itemId;

	private string _itemName;

	private double _price;

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
