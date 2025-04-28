using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cArea
{
	private int _id;

	private string _name;

	private int _branchId;

	private string _branchName;

	private int _active;

	public int Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = Module1.cleanString(value);
		}
	}

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

	public int Active
	{
		get
		{
			return _active;
		}
		set
		{
			_active = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cArea(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT a.*, b.branchName  FROM wilayah a, branches b  WHERE a.branchId = b.branchId  AND wilId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["wilName"]);
				_branchId = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
				_branchName = Conversions.ToString(dataTable.Rows[0]["branchName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["wilStatus"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Wilayah tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void Save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO wilayah(wilName, branchId, wilStatus)  VALUES  ('" + _name + "', " + Conversions.ToString(_branchId) + "," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE wilayah  SET wilName = '" + _name + "',  branchId = " + Conversions.ToString(_branchId) + ", wilStatus = " + Conversions.ToString(_active) + "  WHERE wilId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int BranchId, int GroupId, int Active)
	{
		string text = " SELECT a.*, branchName  FROM wilayah a, branches b WHERE a.branchId = b.branchId ";
		switch (Active)
		{
		case 0:
			text += " AND wilStatus = 0 ";
			break;
		case 1:
			text += " AND wilStatus = 1 ";
			break;
		}
		text = ((BranchId <= 0) ? (text + " AND a.branchId IN (  SELECT branchId FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)") : (text + " AND a.branchId = " + Conversions.ToString(BranchId)));
		text += " ORDER BY branchName, wilName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, int BranchId, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM wilayah  WHERE wilName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND wilId <> " + Conversions.ToString(Id);
		}
		if (BranchId > 0)
		{
			text = text + " AND branchId = " + Conversions.ToString(BranchId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}
}
