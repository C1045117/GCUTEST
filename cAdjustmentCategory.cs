using System.Data;

namespace GCUv2;

public class cAdjustmentCategory
{
	public static DataTable dtCategory(bool Active)
	{
		string text = " SELECT adjTypeId, adjTypeName  FROM adjustment_types ";
		if (Active)
		{
			text += " WHERE adjTypeActive = 1 ";
		}
		text += " ORDER BY adjTypeName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}
}
