using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cGroupPermission
{
	private int _id;

	private string _description;

	private int _permissionValue;

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

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

	public int PermissionValue
	{
		get
		{
			return _permissionValue;
		}
		set
		{
			_permissionValue = value;
		}
	}

	public static int getPermissionValue(int GroupId, string PermissionName)
	{
		string strSql = " SELECT permValue  FROM groups_permissions a, permissions b  WHERE a.groupId = " + Conversions.ToString(GroupId) + " AND a.permId = b.permId  AND permName = '" + PermissionName + "'";
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			return Conversions.ToInteger(dataTable.Rows[0]["permValue"]);
		}
		return 0;
	}

	public static bool IsAllowed(int GroupId, string PermissionName)
	{
		string strSql = " SELECT * FROM groups_permissions  WHERE groupId = " + Conversions.ToString(GroupId) + " AND permId =  (SELECT permId FROM permissions where permName = '" + PermissionName + "')";
		DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			return true;
		}
		return false;
	}
}
