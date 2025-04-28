namespace GCUv2;

public class cGroupStorage
{
	private int _storageId;

	private string _storageName;

	private int _generalDropDown;

	private int _defaultDropDown;

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

	public int GeneralDropDown
	{
		get
		{
			return _generalDropDown;
		}
		set
		{
			_generalDropDown = value;
		}
	}

	public int DefaultDropDown
	{
		get
		{
			return _defaultDropDown;
		}
		set
		{
			_defaultDropDown = value;
		}
	}
}
