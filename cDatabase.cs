using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cDatabase
{
	public static double LastId(string DbName)
	{
		DataTable dataTable = Module1.sqlTable("SELECT last_insert_id() as lastId;", DbName, Clone: false);
		return Conversions.ToDouble(dataTable.Rows[0]["lastid"]);
	}

	public static bool CheckSlaveStatus()
	{
		bool result = true;
		if (Operators.CompareString(Module1.pubHostRead, Module1.pubHostUpdate, TextCompare: false) != 0)
		{
			string strSql = "SHOW SLAVE STATUS";
			DataTable dataTable = Module1.sqlTable(strSql, "read", Clone: false);
			string left = ((Operators.CompareString(dataTable.Rows[0]["Last_Error"].GetType().Name, "Byte[]", TextCompare: false) != 0) ? Conversions.ToString(dataTable.Rows[0]["Last_Error"]) : Module1.ByteToString((byte[])dataTable.Rows[0]["Last_Error"]));
			string left2 = ((Operators.CompareString(dataTable.Rows[0]["Last_IO_Error"].GetType().Name, "Byte[]", TextCompare: false) != 0) ? Conversions.ToString(dataTable.Rows[0]["Last_IO_Error"]) : Module1.ByteToString((byte[])dataTable.Rows[0]["Last_IO_Error"]));
			if ((Operators.CompareString(left, "", TextCompare: false) != 0) | (Operators.CompareString(left2, "", TextCompare: false) != 0))
			{
				result = false;
			}
		}
		return result;
	}
}
