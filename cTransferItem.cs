namespace GCUv2;

public class cTransferItem
{
	private double _transferId;

	private int _itemId;

	private string _itemName;

	private double _qty;

	public double TransferId
	{
		get
		{
			return _transferId;
		}
		set
		{
			_transferId = value;
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
}
