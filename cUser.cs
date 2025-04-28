using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cUser
{
	private int _id;

	private string _name;

	private string _password;

	private int _groupId;

	private string _groupName;

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

	public string Password
	{
		get
		{
			return _password;
		}
		set
		{
			_password = Module1.cleanString(value);
		}
	}

	public int GroupId
	{
		get
		{
			return _groupId;
		}
		set
		{
			_groupId = value;
		}
	}

	public string GroupName
	{
		get
		{
			return _groupName;
		}
		set
		{
			_groupName = value;
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
	public cUser(int UserId)
	{
		if (UserId > 0)
		{
			_id = UserId;
			DataTable dataTable = new DataTable();
			string strSql = " SELECT a.*, b.groupName  FROM userList a, groups b WHERE a.groupId = b.groupId  AND userId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_id = Conversions.ToInteger(dataTable.Rows[0]["userId"]);
				_name = Conversions.ToString(dataTable.Rows[0]["userLogin"]);
				_password = Conversions.ToString(dataTable.Rows[0]["userPassword"]);
				_groupId = Conversions.ToInteger(dataTable.Rows[0]["groupId"]);
				_groupName = Conversions.ToString(dataTable.Rows[0]["groupName"]);
				_active = Conversions.ToInteger(dataTable.Rows[0]["userStatus"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "User tidak ditemukan. Kemungkinan telah dihapus.");
			}
		}
	}

	public void Save()
	{
		if (_id == 0)
		{
			string strSql = " INSERT INTO userList(userLogin,userPassword,groupId,  userStatus)  VALUES  ('" + _name + "','" + _password + "','" + Conversions.ToString(_groupId) + "'," + Conversions.ToString(_active) + ")";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = " UPDATE userList  SET userLogin = '" + _name + "',  userPassword = '" + _password + "',  groupId = " + Conversions.ToString(_groupId) + ",  userStatus = " + Conversions.ToString(_active) + "  WHERE userId = " + Conversions.ToString(_id) + " ";
			Module1.sqlNonQuery(strSql, "data");
		}
	}

	public static void Delete(int UserId)
	{
		string strSql = "DELETE FROM userList WHERE userId = " + Conversions.ToString(UserId);
		Module1.sqlNonQuery(strSql, "data");
	}

	public static DataTable Search(int Active)
	{
		string text = " SELECT a.*, groupName  FROM userList a, groups b WHERE a.groupId = b.groupId ";
		switch (Active)
		{
		case 0:
			text += " AND userStatus = 0 ";
			break;
		case 1:
			text += " AND userStatus = 1 ";
			break;
		}
		text += " ORDER BY userLogin ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(string Name)
	{
		bool result = false;
		string strSql = " SELECT * FROM userList  WHERE userLogin = '" + Name + "'";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static DataTable Login(string UserName, string Password)
	{
		string strSql = " SELECT userId, b.*  FROM userList a, groups b   WHERE a.groupId = b.groupId  AND userLogin = '" + UserName + "'  AND userPassword = '" + Password + "'  AND userStatus = 1 ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public static int GetUserPermission(string UserName, string Permission)
	{
		int result = 0;
		string strSql = " SELECT * FROM permissions a, groups_permissions b WHERE a.permId = b.permId  AND permName = '" + Permission + "' AND b.groupId IN (SELECT groupId FROM userList WHERE userLogin = '" + UserName + "')";
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = 1;
		}
		return result;
	}
}
