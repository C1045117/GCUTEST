using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cGroupCustomer
{
	public static DataTable getGroupCustomer(int BranchId, bool GroupId, bool Active)
	{
		string text = " SELECT custId, custName, branchName  FROM customer a, branches b WHERE a.branchId = b.branchId  AND isParent = 1 ";
		if (Active)
		{
			text += " AND custActive = 1 ";
		}
		text = ((BranchId <= 0) ? (text + " AND a.branchId IN (  SELECT branchId FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId) + " AND generalDropDown = 1)") : (text + " AND a.branchId = " + Conversions.ToString(BranchId)));
		text += " ORDER BY branchName, custName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}
}
