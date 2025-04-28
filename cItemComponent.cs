namespace GCUv2;

public class cItemComponent
{
	private int _itemId;

	private string _itemName;

	private bool _isMember;

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

	public bool IsMember
	{
		get
		{
			return _isMember;
		}
		set
		{
			_isMember = value;
		}
	}
}
