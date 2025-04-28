using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cBranch
{
	private int _id;

	private string _name;

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
	public cBranch(int Id)
	{
		if (Id > 0)
		{
			_id = Id;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM branches  WHERE branchId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_id = Conversions.ToInteger(dataTable.Rows[0]["branchId"]);
				_name = Conversions.ToString(dataTable.Rows[0]["branchName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["branchActive"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Cabang tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO branches(branchName, branchActive)  VALUES  ('" + _name + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE branches  SET branchName = '" + _name + "',  branchActive = " + Conversions.ToString(_active) + "  WHERE branchId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static DataTable Search(int GroupId, int Active)
	{
		string text = " SELECT * FROM branches  WHERE branchActive = branchActive ";
		if (GroupId > 0)
		{
			text = text + " AND branchId IN (SELECT branchId FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)";
		}
		switch (Active)
		{
		case 0:
			text += " AND branchActive = 0 ";
			break;
		case 1:
			text += " AND branchActive = 1 ";
			break;
		}
		text += " ORDER BY branchName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int BranchId, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM branches  WHERE branchName = '" + Name + "'";
		if (BranchId > 0)
		{
			text = text + " AND branchId <> " + Conversions.ToString(BranchId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}
}
