namespace GCUv2;

public class cItemStandardUsage
{
	private int _branchId;

	private string _branchName;

	private int _componentId;

	private string _componentName;

	private double _qty;

	public int BranchId
	{
		get
		{
			return _branchId;
		}
		set
		{
			_branchId = value;
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
