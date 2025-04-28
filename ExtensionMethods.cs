using System;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

[StandardModule]
internal sealed class ExtensionMethods
{
	public static void DoubleBuffered(DataGridView dgv, bool setting)
	{
		Type type = dgv.GetType();
		PropertyInfo property = type.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
		property.SetValue(dgv, setting, null);
	}
}
