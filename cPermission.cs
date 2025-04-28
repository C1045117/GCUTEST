using System.Data;

namespace GCUv2;

public class cPermission
{
	public static DataTable Search(int PermissionType)
	{
		string text = " SELECT *  FROM permissions ";
		switch (PermissionType)
		{
		case 1:
			text += " WHERE permType = 1 ";
			break;
		case 2:
			text += " WHERE permType = 2 ";
			break;
		}
		text += " ORDER BY permPriority, permDesc ";
		return Module1.sqlTable(text, "data", Clone: false);
	}
}
