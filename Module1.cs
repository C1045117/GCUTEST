using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using GCUv2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

[StandardModule]
internal sealed class Module1
{
	public static MySqlConnection connectRead;

	public static MySqlConnection connectData;

	public static string pubHostRead;

	public static string pubHostUpdate;

	public static string pubDbData;

	public static string pubDbHistory;

	public static int pubGroupId;

	public static int pubBranchId;

	public static int pubStorageId;

	public static int pubCashAccountId;

	public static int pubBankAccountId;

	public static string pubLogin;

	public static int pubUserId;

	public static int pubDaysLimitForCashTransaction;

	public static int pubDaysLimitForBankTransaction;

	public static int pubDuplicateSalesInvoiceNumber;

	public static bool pubUseDeletedInvoiceNumber;

	public static bool pubUnlimitedCredit;

	public static bool pubInternal;

	public static bool pubCreateCustomer;

	public static bool pubUpdateCustomer;

	public static bool pubUpdateCreditLimit;

	public static bool pubUpdateTOP;

	public static bool pubPreviewReport;

	public static bool pubPrintReport;

	public static bool pubCreateSalesInvoice;

	public static bool pubUpdateSalesInvoice;

	public static bool pubModifyPriceInSalesInvoice;

	public static bool pubDeleteSalesInvoice;

	public static bool pubModifySalesInvoice;

	public static bool pubModifyPaymentInSalesInvoice;

	public static bool pubModifySalesInvoiceNumber;

	public static bool pubModifySalesTaxInvoiceNumber;

	public static bool pubCreateSalesReceipt;

	public static int pubDaysLimitForPaidSalesInvoice;

	public static int pubDaysLimitForCustomerPayment;

	public static int pubDaysLimitForSupplierPayment;

	public static int pubDaysLimit;

	public static bool pubCheckStock;

	public static string pubReportPredictionPath;

	public static DateTime pubBalanceDate;

	public static string pubSalesReceiptDescription;

	public static string pubSalesReceiptName;

	public static string pubSalesReceiptCity;

	public static string pubSalesReceiptCode;

	public static string pubCompany;

	public static int pubPurchaseReturnAccountId;

	public static bool pubViewReportPurchaseInvoicePrice;

	public static bool pubActivateDailyStockCode;

	public static bool pubUseNewGetStockCode;

	public static bool pubReportUseNewGetStockCode;

	public static bool pubCloseAccess;

	public static bool pubDatabaseIsConnected;

	public static string pubVersion;

	public static int pubCustomY;

	public static int pubCommandTimeout;

	private const int VK_STARTKEY = 91;

	private const int VK_M = 77;

	private const int KEYEVENTF_KEYUP = 2;

	public static void connectDatabaseData()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		connectData = new MySqlConnection("Server=" + pubHostUpdate + "; Database=" + pubDbData + "; uid=gcu; pwd=dookie123; Convert Zero Datetime=true;");
		connectData.Open();
		pubDatabaseIsConnected = true;
	}

	public static void connectDatabaseRead()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		connectRead = new MySqlConnection("Server=" + pubHostRead + "; Database=" + pubDbData + "; uid=gcu; pwd=dookie123; Convert Zero Datetime=true;");
		connectRead.Open();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static DataTable sqlTable(string strSql, string strDb, bool Clone)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		DataTable result = null;
		try
		{
			MySqlConnection val = null;
			if (Operators.CompareString(strDb, "data", TextCompare: false) == 0 && !Clone)
			{
				val = connectData;
			}
			else if (Operators.CompareString(strDb, "data", TextCompare: false) == 0 && Clone)
			{
				val = connectData.Clone();
			}
			else if (Operators.CompareString(strDb, "read", TextCompare: false) == 0 && !Clone)
			{
				val = connectRead;
			}
			else if (Operators.CompareString(strDb, "read", TextCompare: false) == 0 && Clone)
			{
				val = connectRead.Clone();
			}
			MySqlCommand val2 = new MySqlCommand(strSql, val);
			MySqlDataAdapter val3 = new MySqlDataAdapter();
			DataTable dataTable = new DataTable();
			val2.CommandTimeout = pubCommandTimeout;
			val3.SelectCommand = val2;
			((DbDataAdapter)(object)val3).Fill(dataTable);
			result = dataTable;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Information.Err().Raise(513, null, Information.Err().Description);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static int sqlNonQuery(string strSql, string strDb)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		int result = default(int);
		try
		{
			MySqlConnection val = null;
			if (Operators.CompareString(strDb, "data", TextCompare: false) == 0)
			{
				val = connectData;
			}
			MySqlCommand val2 = new MySqlCommand(strSql, val);
			val2.CommandTimeout = pubCommandTimeout;
			result = val2.ExecuteNonQuery();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Information.Err().Raise(513, null, Information.Err().Description);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void SaveDebug(string Content)
	{
		StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\debugV2.txt", append: true);
		streamWriter.WriteLine(Conversions.ToString(DateAndTime.Now) + " " + Content);
		streamWriter.Close();
	}

	public static int getDecimalLength(object strInput)
	{
		strInput = Convert.ToDecimal(Conversion.Val(unformatNumber(Conversions.ToString(strInput)))).ToString();
		int num = strInput.ToString().IndexOf(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
		if (num == -1)
		{
			return 0;
		}
		return checked(strInput.ToString().Length - 1 - num);
	}

	public static string formatCustomDecimal(string strInput, int maximumDigit)
	{
		int num = getDecimalLength(strInput);
		if (num > maximumDigit)
		{
			num = maximumDigit;
		}
		strInput = Conversions.ToString(Math.Round(Conversion.Val(unformatNumber(strInput)), num, MidpointRounding.AwayFromZero));
		strInput = Strings.FormatNumber(strInput, num);
		bool flag = false;
		int i = 1;
		for (int num2 = num; i <= num2 && !flag; i = checked(i + 1))
		{
			if (Conversion.Val(Strings.Right(strInput, i)) == 0.0)
			{
				num = checked(num - 1);
			}
			else
			{
				flag = true;
			}
		}
		return Strings.FormatNumber(strInput, num, TriState.UseDefault, TriState.UseDefault, TriState.True);
	}

	public static string unformatNumber(string strInput, bool canBeEmpty = false)
	{
		if (Operators.CompareString(Strings.Trim(strInput), "", TextCompare: false) == 0 && canBeEmpty)
		{
			return "";
		}
		if (Operators.CompareString(Strings.Trim(strInput), "-", TextCompare: false) == 0)
		{
			return "-";
		}
		if (!Versioned.IsNumeric(strInput))
		{
			return Conversions.ToString(Conversion.Val(strInput));
		}
		if (Operators.CompareString(Strings.Trim(strInput), "", TextCompare: false) == 0)
		{
			strInput = Conversions.ToString(0);
		}
		return Strings.Replace(Conversions.ToString(Conversions.ToDouble(strInput)), ",", ".");
	}

	public static bool comboBoundValue(ref ComboBox cboSource, double dblValue)
	{
		bool result = false;
		cboSource.SelectedIndex = -1;
		checked
		{
			int num = cboSource.Items.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				cComboItem cComboItem2 = (cComboItem)cboSource.Items[i];
				double num2 = Conversions.ToDouble(cComboItem2.Value);
				if (num2 == dblValue)
				{
					result = true;
					cboSource.SelectedIndex = i;
					break;
				}
			}
			return result;
		}
	}

	public static DateTime getFirstDateInMonth(DateTime dateInput)
	{
		return new DateTime(DateAndTime.Year(dateInput), DateAndTime.Month(dateInput), 1);
	}

	public static DateTime getLastDateInMonth(DateTime dateInput)
	{
		checked
		{
			if (DateAndTime.Month(dateInput) == 12)
			{
				return new DateTime(DateAndTime.Year(dateInput) + 1, 1, 1).AddDays(-1.0);
			}
			return new DateTime(DateAndTime.Year(dateInput), DateAndTime.Month(dateInput) + 1, 1).AddDays(-1.0);
		}
	}

	public static string removeCrlf(string strInput)
	{
		return Strings.Replace(Strings.Replace(strInput, "\n", ""), "\r", "");
	}

	public static string singleQuote(string strInput)
	{
		return Strings.Replace(strInput, "'", "''");
	}

	public static string removeTab(string strInput)
	{
		return Strings.Replace(strInput, "\t", "");
	}

	public static string escapeBackslash(string strInput)
	{
		return Strings.Replace(strInput, "\\", "\\\\");
	}

	public static string cleanString(string strInput)
	{
		return escapeBackslash(removeTab(removeCrlf(singleQuote(Strings.Trim(strInput)))));
	}

	public static string cleanStringKeepCrlf(string strInput)
	{
		return escapeBackslash(removeTab(singleQuote(Strings.Trim(strInput))));
	}

	public static double RoundHalf(double Number)
	{
		double result = Number;
		double num = Number - Math.Floor(Number);
		if (num < 0.25)
		{
			result = Math.Floor(Number);
		}
		else if (num >= 0.25 && num < 0.75)
		{
			result = Math.Floor(Number) + 0.5;
		}
		else if (num >= 0.75)
		{
			result = Math.Ceiling(Number);
		}
		return result;
	}

	public static double RoundMoney(double number)
	{
		if (number - Conversion.Int(number) >= 0.5)
		{
			return Conversion.Int(number) + 1.0;
		}
		return Conversion.Int(number);
	}

	public static void SaveError(ErrObject ErrorObject, string FormName, string ObjectName, string SQL)
	{
		string description = ErrorObject.Description;
		bool flag = default(bool);
		try
		{
			Bitmap bitmap = (Bitmap)TakeImage();
			if (!Information.IsNothing(bitmap))
			{
				string text = "debug/" + pubLogin + Strings.Format(DateAndTime.Now, "_dd-MMM_hh-mm-ss");
				bitmap.Save(text + ".jpg", ImageFormat.Jpeg);
				flag = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\error.txt", append: true);
		streamWriter.WriteLine(pubVersion + ", " + pubLogin + ", " + FormName + "." + ObjectName + ", " + Conversions.ToString(DateAndTime.Now) + ", " + description + ", " + SQL + ", Screenshot: " + Conversions.ToString(flag));
		streamWriter.Close();
		bool flag2 = false;
		bool flag3;
		try
		{
			MySqlTransaction val = connectData.BeginTransaction();
			val.Rollback();
			flag3 = true;
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			flag3 = false;
			ProjectData.ClearProjectError();
		}
		if (!flag3)
		{
			flag2 = true;
		}
		else
		{
			Interaction.MsgBox(description);
		}
		if (flag2)
		{
			pubDatabaseIsConnected = false;
			StreamWriter streamWriter2 = new StreamWriter(Application.StartupPath + "\\error.txt", append: true);
			streamWriter2.WriteLine(pubLogin + ", Masalah koneksi database, " + Conversions.ToString(DateAndTime.Now));
			streamWriter2.Close();
			Interaction.MsgBox("Koneksi ke Database terputus", MsgBoxStyle.Information);
		}
	}

	public static object TakeImage()
	{
		Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
		graphics.Dispose();
		return bitmap;
	}

	public static void DisableGridSorting(ref DataGridView grid)
	{
		checked
		{
			int num = grid.ColumnCount - 1;
			for (int i = 0; i <= num; i++)
			{
				grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}
	}

	public static string[] divideString(string strInput, int intMax)
	{
		string[] array = null;
		int num = 0;
		checked
		{
			while (Strings.Len(strInput) > 0)
			{
				array = (string[])Utils.CopyArray(array, new string[num + 1]);
				string value = Conversions.ToString(intMax);
				if (Strings.Len(strInput) > intMax)
				{
					while (Operators.CompareString(Strings.Mid(strInput, (int)Math.Round(Conversions.ToDouble(value) + 1.0), 1), " ", TextCompare: false) != 0)
					{
						value = Conversions.ToString(Conversions.ToDouble(value) - 1.0);
					}
					array[num] = Strings.Mid(strInput, 1, Conversions.ToInteger(value));
					strInput = Strings.Mid(strInput, (int)Math.Round(Conversions.ToDouble(value) + 2.0), (int)Math.Round((double)Strings.Len(strInput) - Conversions.ToDouble(value) - 1.0));
				}
				else
				{
					array[num] = strInput;
					strInput = "";
				}
				num++;
			}
			return array;
		}
	}

	public static string FormatInvoiceNumber(string strInput)
	{
		string text = "";
		bool flag = default(bool);
		while (!flag)
		{
			if ((Strings.Asc(Strings.Mid(strInput, 1, 1)) < 48) | (Strings.Asc(Strings.Mid(strInput, 1, 1)) > 57))
			{
				text += Strings.Mid(strInput, 1, 1);
				strInput = Strings.Right(strInput, checked(Strings.Len(strInput) - 1));
			}
			else
			{
				flag = true;
			}
			if (Strings.Len(strInput) == 0)
			{
				flag = true;
			}
		}
		string str = text + FormatTaxInvoiceNumber(Conversion.Str(Conversion.Val(strInput)));
		return Strings.Trim(str);
	}

	public static string FormatTaxInvoiceNumber(string strInput)
	{
		strInput = Strings.Trim(Conversions.ToString(Conversion.Val(strInput)));
		int num = Strings.Len(strInput);
		int num2 = 8;
		while (Strings.Len(strInput) < num2)
		{
			strInput = "0" + strInput;
		}
		return Strings.Trim(strInput);
	}

	public static bool FormIsOpen(string FormName)
	{
		bool result = false;
		foreach (object openForm in MyProject.Application.OpenForms)
		{
			object objectValue = RuntimeHelpers.GetObjectValue(openForm);
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(objectValue, null, "name", new object[0], null, null, null), FormName, TextCompare: false) && Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Visible", new object[0], null, null, null)))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	public static void UncheckDataGridView(ref DataGridView Dgv, int checkBoxColumn)
	{
		checked
		{
			int num = Dgv.Rows.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.ConditionalCompareObjectEqual(Dgv[checkBoxColumn, i].Value, true, TextCompare: false))
				{
					Dgv[checkBoxColumn, i].Value = false;
				}
			}
		}
	}

	public static string ConvertToRoman(int Number)
	{
		string result = "";
		switch (Number)
		{
		case 1:
			result = "I";
			break;
		case 2:
			result = "II";
			break;
		case 3:
			result = "III";
			break;
		case 4:
			result = "IV";
			break;
		case 5:
			result = "V";
			break;
		case 6:
			result = "VI";
			break;
		case 7:
			result = "VII";
			break;
		case 8:
			result = "VIII";
			break;
		case 9:
			result = "IX";
			break;
		case 10:
			result = "X";
			break;
		case 11:
			result = "XI";
			break;
		case 12:
			result = "XII";
			break;
		}
		return result;
	}

	public static string Terbilang(ref string Indx)
	{
		string[] array = new string[11];
		string[] array2 = new string[11];
		string[] array3 = new string[11];
		array[0] = "Nol";
		array[1] = "Satu";
		array[2] = "Dua";
		array[3] = "Tiga";
		array[4] = "Empat";
		array[5] = "Lima";
		array[6] = "Enam";
		array[7] = "Tujuh";
		array[8] = "Delapan";
		array[9] = "Sembilan";
		array2[0] = "Sepuluh";
		array2[1] = "Sebelas";
		array2[2] = "Dua belas";
		array2[3] = "Tiga belas";
		array2[4] = "Empat Belas";
		array2[5] = "Lima Belas";
		array2[6] = "Enam Belas";
		array2[7] = "Tujuh belas";
		array2[8] = "Delapan belas";
		array2[9] = "Sembilan belas";
		array3[2] = "Dua puluh";
		array3[3] = "Tiga puluh";
		array3[4] = "Empat puluh";
		array3[5] = "Lima puluh";
		array3[6] = "Enam Puluh";
		array3[7] = "Tujuh Puluh";
		array3[8] = "Delapan puluh";
		array3[9] = "Sembilan puluh";
		string text = "ratus";
		string text2 = "ribu";
		string text3 = "juta";
		string text4 = "millyar";
		string text5 = "trilliun";
		string text6 = Conversions.ToString(Conversion.Val(Indx));
		string text7 = "";
		switch (Strings.Len(text6))
		{
		case 1:
			text7 = array[Conversions.ToInteger(Indx)];
			break;
		case 2:
			if ((Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 1))) > 0.0) & (Conversions.ToDouble(Strings.Left(text6, 1)) > 1.0))
			{
				string Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 1))));
				text7 = Terbilang(ref Indx2);
			}
			if (Conversions.ToDouble(Strings.Left(text6, 1)) > 1.0)
			{
				text7 = array3[Conversions.ToInteger(Strings.Left(text6, 1))] + text7;
			}
			if (Conversions.ToDouble(Strings.Left(text6, 1)) == 1.0)
			{
				text7 = array2[Conversions.ToInteger(Strings.Right(text6, 1))];
			}
			text7 = Strings.Replace(text7, "Satu ribu", "Seribu");
			break;
		case 3:
		{
			text7 = array[10];
			string Indx2;
			if (Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 2))) > 0.0)
			{
				Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 2))));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 1))));
			text7 = Terbilang(ref Indx2) + text + text7;
			break;
		}
		case 4:
		{
			string Indx2;
			if (Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 3))) > 0.0)
			{
				Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 3))));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 1))));
			text7 = Terbilang(ref Indx2) + text2 + text7;
			text7 = Strings.Replace(text7, "Satu ribu", "Seribu");
			break;
		}
		case 5:
		{
			string Indx2;
			if (Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 3))) > 0.0)
			{
				Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Right(text6, 3))));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 2))));
			text7 = Terbilang(ref Indx2) + text2 + text7;
			break;
		}
		case 6:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 3)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 3)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 3))));
			text7 = Terbilang(ref Indx2) + text2 + text7;
			break;
		}
		case 7:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 6)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 6)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 1))));
			text7 = Terbilang(ref Indx2) + text3 + text7;
			break;
		}
		case 8:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 6)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 6)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 2))));
			text7 = Terbilang(ref Indx2) + text3 + text7;
			break;
		}
		case 9:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 6)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 6)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 3))));
			text7 = Terbilang(ref Indx2) + text3 + text7;
			break;
		}
		case 10:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 9)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 9)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 1))));
			text7 = Terbilang(ref Indx2) + text4 + text7;
			break;
		}
		case 11:
		{
			string Indx2;
			if (Conversions.ToInteger(Strings.Right(text6, 9)) > 0)
			{
				Indx2 = Conversions.ToString(Conversions.ToInteger(Strings.Right(text6, 9)));
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 2))));
			text7 = Terbilang(ref Indx2) + text4 + text7;
			break;
		}
		case 12:
		{
			string Indx2;
			if (Conversion.Val(Strings.Right(text6, 9)) > 0.0)
			{
				Indx2 = Strings.Right(text6, 9);
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 3))));
			text7 = Terbilang(ref Indx2) + text4 + text7;
			break;
		}
		case 13:
		{
			string Indx2;
			if (Conversion.Val(Strings.Right(text6, 12)) > 0.0)
			{
				Indx2 = Strings.Right(text6, 12);
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 1))));
			text7 = Terbilang(ref Indx2) + text5 + text7;
			break;
		}
		case 14:
		{
			string Indx2;
			if (Conversion.Val(Strings.Right(text6, 12)) > 0.0)
			{
				Indx2 = Strings.Right(text6, 12);
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 2))));
			text7 = Terbilang(ref Indx2) + text5 + text7;
			break;
		}
		case 15:
		{
			string Indx2;
			if (Conversion.Val(Strings.Right(text6, 12)) > 0.0)
			{
				Indx2 = Strings.Right(text6, 12);
				text7 = Terbilang(ref Indx2);
			}
			Indx2 = Conversions.ToString(Conversion.Int(Conversions.ToDouble(Strings.Left(text6, 3))));
			text7 = Terbilang(ref Indx2) + text5 + text7;
			break;
		}
		}
		text7 = Strings.Replace(text7, "Satu ratus", "Seratus");
		text7 = Strings.Trim(text7);
		string expression = " " + text7 + " ";
		return Strings.Replace(expression, " ", " ");
	}

	public static bool isAlreadyInGrid(DataGridView dgvList)
	{
		bool flag = false;
		checked
		{
			int num = dgvList.Rows.Count - 2;
			for (int i = 0; i <= num; i++)
			{
				int num2 = i + 1;
				int num3 = dgvList.Rows.Count - 2;
				int num4 = num2;
				while (num4 <= num3)
				{
					if ((Conversion.Val(unformatNumber(Conversions.ToString(dgvList[0, i].Value))) >= Conversion.Val(unformatNumber(Conversions.ToString(dgvList[0, num4].Value)))) & (Conversion.Val(unformatNumber(Conversions.ToString(dgvList[0, i].Value))) <= Conversion.Val(unformatNumber(Conversions.ToString(dgvList[1, num4].Value)))))
					{
						flag = true;
					}
					else if ((Conversion.Val(unformatNumber(Conversions.ToString(dgvList[1, i].Value))) >= Conversion.Val(unformatNumber(Conversions.ToString(dgvList[0, num4].Value)))) & (Conversion.Val(unformatNumber(Conversions.ToString(dgvList[1, i].Value))) <= Conversion.Val(unformatNumber(Conversions.ToString(dgvList[1, num4].Value)))))
					{
						flag = true;
					}
					if (!flag)
					{
						num4++;
						continue;
					}
					goto IL_0150;
				}
				continue;
				IL_0150:
				Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Kelompok nomer ", dgvList[0, i].Value), "-"), dgvList[1, i].Value), " termasuk dalam kelompok "), dgvList[0, num4].Value), "-"), dgvList[1, num4].Value), MsgBoxStyle.Information);
				break;
			}
			return flag;
		}
	}

	public static bool isBeginLessThanEnd(DataGridView dgvList)
	{
		bool result = true;
		checked
		{
			int num = dgvList.Rows.Count - 2;
			for (int i = 0; i <= num; i++)
			{
				if (Conversions.ToDouble(dgvList[0, i].Value) > Conversions.ToDouble(dgvList[1, i].Value))
				{
					Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Nomer awal (", dgvList[0, i].Value), ") harus lebih kecil dari nomer akhir ("), dgvList[1, i].Value), ")"), MsgBoxStyle.Information);
					result = false;
					break;
				}
			}
			return result;
		}
	}

	public static bool BeginWithChar(string strInput)
	{
		bool result = false;
		bool flag = default(bool);
		while (!flag & (Strings.Len(strInput) > 0))
		{
			if ((Strings.Asc(Strings.Mid(strInput, 1, 1)) < 48) | (Strings.Asc(Strings.Mid(strInput, 1, 1)) > 57))
			{
				result = true;
				flag = true;
			}
			else
			{
				strInput = Strings.Right(strInput, checked(Strings.Len(strInput) - 1));
			}
			if (Strings.Len(strInput) == 0)
			{
				flag = true;
			}
		}
		return result;
	}

	public static string RemoveChar(string strInput)
	{
		bool flag = default(bool);
		if (Operators.CompareString(strInput, "", TextCompare: false) == 0)
		{
			flag = true;
		}
		while (!flag)
		{
			if ((Strings.Asc(Strings.Mid(strInput, 1, 1)) < 48) | (Strings.Asc(Strings.Mid(strInput, 1, 1)) > 57))
			{
				strInput = Strings.Right(strInput, checked(Strings.Len(strInput) - 1));
			}
			else
			{
				flag = true;
			}
			if (Strings.Len(strInput) == 0)
			{
				flag = true;
			}
		}
		return strInput;
	}

	public static string GetStartingChar(string strInput)
	{
		string text = "";
		bool flag = default(bool);
		while (!flag)
		{
			if ((Strings.Asc(Strings.Mid(strInput, 1, 1)) < 48) | (Strings.Asc(Strings.Mid(strInput, 1, 1)) > 57))
			{
				text += Strings.Mid(strInput, 1, 1);
				strInput = Strings.Right(strInput, checked(Strings.Len(strInput) - 1));
			}
			else
			{
				flag = true;
			}
			if (Strings.Len(strInput) == 0)
			{
				flag = true;
			}
		}
		return text;
	}

	public static string ByteToString(byte[] Input)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return uTF8Encoding.GetString(Input);
	}

	public static object RoundUp(double dblInput, double dblRound)
	{
		if (Math.Round(dblInput) % dblRound == 0.0)
		{
			return dblInput;
		}
		int num = checked((int)Math.Round(Math.Round(dblInput) % dblRound));
		return Math.Round(dblInput) - (double)num + dblRound;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	public static void MinimiseAllWindows()
	{
		keybd_event(91, 0, 0, 0);
		keybd_event(77, 0, 0, 0);
		keybd_event(77, 0, 2, 0);
		keybd_event(91, 0, 2, 0);
	}

	public static bool canPingIP(string ipAddress)
	{
		Ping ping = new Ping();
		PingOptions pingOptions = new PingOptions();
		pingOptions.DontFragment = true;
		string s = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		int timeout = 120;
		bool result = false;
		try
		{
			int num = 1;
			do
			{
				PingReply pingReply = ping.Send(ipAddress, timeout, bytes, pingOptions);
				if (pingReply.Status == IPStatus.Success)
				{
					result = true;
					break;
				}
				num = checked(num + 1);
			}
			while (num <= 4);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox("Can't ping " + ipAddress);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
