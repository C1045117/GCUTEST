namespace GCUv2;

public class cItemStandardComponent
{
	private int _storageId;

	private string _storageName;

	private int _componentId;

	private string _componentName;

	private double _qty;

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

	public int ComponentId
	{
		get
		{
			return _componentId;
		}
		set
		{
			_componentId = value;
		}
	}

	public string ComponentName
	{
		get
		{
			return _componentName;
		}
		set
		{
			_componentName = value;
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
