namespace GCUv2;

public class cItemStorage
{
	private int _storageId;

	private string _storageName;

	private string _branchName;

	private bool _isMember;

	private double _qty;

	private double _price;

	public int StorageId
	{
		get
		{
			return _storageId;
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

	public string BranchName
	{
		get
		{
			return _branchName;
		}
		set
		{
			_branchName = value;
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
