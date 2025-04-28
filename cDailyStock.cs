using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cDailyStock
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static void add(int itemId, int storeId, DateTime stockDate, double stockTotal)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					string strSql = " UPDATE dailystock  SET stockTotal = stockTotal + " + Module1.unformatNumber(Conversions.ToString(stockTotal)) + " WHERE itemId = " + Conversions.ToString(itemId) + " AND storeId = " + Conversions.ToString(storeId) + "  AND stockDate = '" + Strings.Format(stockDate, "yyyy-MM-dd") + "'";
					if (Module1.sqlNonQuery(strSql, "data") == 0)
					{
						strSql = " INSERT INTO dailystock(itemId, storeId, stockDate, stockTotal)  VALUES  (" + Conversions.ToString(itemId) + ", " + Conversions.ToString(storeId) + ", '" + Strings.Format(stockDate, "yyyy-MM-dd") + "', " + Module1.unformatNumber(Conversions.ToString(stockTotal)) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					goto end_IL_0001;
				}
				case 286:
					num = -1;
					switch (num2)
					{
					case 2:
						Information.Err().Raise(513, null, Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 286;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
