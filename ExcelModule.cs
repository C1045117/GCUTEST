using Excel;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[StandardModule]
internal sealed class ExcelModule
{
	public static string ReadCell(Range range)
	{
		return Conversions.ToString(range.Text);
	}

	public static void formatBorder(Application xlApp)
	{
		object instance = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeLeft }, null, null, null);
		NewLateBinding.LateSetComplex(instance, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance = null;
		object instance2 = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeTop }, null, null, null);
		NewLateBinding.LateSetComplex(instance2, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance2, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance2, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance2 = null;
		object instance3 = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeBottom }, null, null, null);
		NewLateBinding.LateSetComplex(instance3, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance3, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance3, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance3 = null;
		object instance4 = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlEdgeRight }, null, null, null);
		NewLateBinding.LateSetComplex(instance4, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance4, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance4, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance4 = null;
		object instance5 = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideVertical }, null, null, null);
		NewLateBinding.LateSetComplex(instance5, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance5, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance5, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance5 = null;
		object instance6 = NewLateBinding.LateGet(xlApp.Selection, null, "Borders", new object[1] { XlBordersIndex.xlInsideHorizontal }, null, null, null);
		NewLateBinding.LateSetComplex(instance6, null, "LineStyle", new object[1] { XlLineStyle.xlContinuous }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance6, null, "Weight", new object[1] { XlBorderWeight.xlThin }, null, null, OptimisticSet: false, RValueBase: true);
		NewLateBinding.LateSetComplex(instance6, null, "ColorIndex", new object[1] { XlColorIndex.xlColorIndexAutomatic }, null, null, OptimisticSet: false, RValueBase: true);
		instance6 = null;
	}
}
