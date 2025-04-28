namespace GCUv2;

public class cGroupBranch
{
	private int _branchId;

	private string _branchName;

	private int _generalDropDown;

	private int _defaultDropDown;

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
