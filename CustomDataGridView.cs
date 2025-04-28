using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class CustomDataGridView : DataGridView
{
	protected override void OnSortCompare(DataGridViewSortCompareEventArgs e)
	{
		base.OnSortCompare(e);
		if (Operators.ConditionalCompareObjectEqual(base.Rows[e.RowIndex1].Tag, "total", TextCompare: false))
		{
			e.SortResult = ((base.SortOrder == SortOrder.Ascending) ? 1 : (-1));
		}
		else if (Operators.ConditionalCompareObjectEqual(base.Rows[e.RowIndex2].Tag, "total", TextCompare: false))
		{
			e.SortResult = ((base.SortOrder != SortOrder.Ascending) ? 1 : (-1));
		}
		else if (Operators.ConditionalCompareObjectEqual(base.Columns[e.Column.Index].Tag, "numeric", TextCompare: false))
		{
			e.SortResult = ((Conversions.ToDouble(e.CellValue1) > Conversions.ToDouble(e.CellValue2)) ? 1 : (-1));
		}
		else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(base.Columns[e.Column.Index].Tag, "date", TextCompare: false), Operators.CompareString(e.CellValue1.ToString(), "-", TextCompare: false) == 0)))
		{
			e.SortResult = ((base.SortOrder == SortOrder.Ascending) ? 1 : (-1));
		}
		else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(base.Columns[e.Column.Index].Tag, "date", TextCompare: false), Operators.CompareString(e.CellValue2.ToString(), "-", TextCompare: false) == 0)))
		{
			e.SortResult = ((base.SortOrder != SortOrder.Ascending) ? 1 : (-1));
		}
		else if (Operators.ConditionalCompareObjectEqual(base.Columns[e.Column.Index].Tag, "date", TextCompare: false))
		{
			e.SortResult = DateTime.Compare(Conversions.ToDate(e.CellValue1), Conversions.ToDate(e.CellValue2));
		}
		else
		{
			e.SortResult = string.Compare(e.CellValue1.ToString(), e.CellValue2.ToString());
		}
		e.Handled = true;
	}
}
