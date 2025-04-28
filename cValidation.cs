using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cValidation
{
	public static bool isDateWithinRange(DateTime dateInput, int intGroupId, int DaysLimit)
	{
		DateTime t = Conversions.ToDate(Strings.FormatDateTime(DateAndTime.DateAdd(DateInterval.Day, checked(-DaysLimit), DateAndTime.Now), DateFormat.ShortDate));
		DateTime t2 = Conversions.ToDate(Strings.FormatDateTime(DateAndTime.DateAdd(DateInterval.Day, DaysLimit, DateAndTime.Now), DateFormat.ShortDate));
		if ((DateTime.Compare(dateInput, t) >= 0) & (DateTime.Compare(dateInput, t2) <= 0))
		{
			return true;
		}
		return false;
	}

	public static bool isInStock(bool CheckStock, DateTime BalanceDate, DateTime dateStock, string StockType, DateTime dateOriginal, int intItemId, int intOriginalItemId, double dblQty, double dblOriginalQty, int intStoreId, int intOriginalStoreId, int intGroupId, int CheckType)
	{
		if (!CheckStock)
		{
			return true;
		}
		dateStock = DateAndTime.DateAdd(DateInterval.Day, 1.0, dateStock);
		if (cItem.GetItemType(intItemId) != 1)
		{
			return true;
		}
		double stock = cStock.getStock(intItemId, BalanceDate, dateStock, StockType, intStoreId, intGroupId, 0, Module1.pubUseNewGetStockCode);
		if ((CheckType != 3) & ((intItemId != intOriginalItemId || intStoreId != intOriginalStoreId) | (DateTime.Compare(DateAndTime.DateAdd(DateInterval.Day, -1.0, dateStock), dateOriginal) < 0)))
		{
			dblOriginalQty = 0.0;
		}
		if (CheckType == 3 && stock - dblOriginalQty < 0.0)
		{
			return false;
		}
		if (CheckType == 2 && dblQty > dblOriginalQty && dblQty > stock + dblOriginalQty)
		{
			return false;
		}
		if (CheckType == 1 && dblQty < dblOriginalQty && dblOriginalQty - dblQty > stock)
		{
			return false;
		}
		return true;
	}
}
