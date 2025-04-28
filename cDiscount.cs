using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cDiscount
{
	public struct DiscountQty
	{
		public double _begin;

		public double _end;

		public double _value;
	}

	private int _id;

	private string _name;

	private int _type;

	private string _percentage;

	private int _canBeOverwritten;

	private DiscountQty[] _qty;

	private int _active;

	public int Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = Module1.cleanString(value);
		}
	}

	public int Type
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
		}
	}

	public string Percentage
	{
		get
		{
			return _percentage;
		}
		set
		{
			_percentage = value;
		}
	}

	public int CanBeOverwritten
	{
		get
		{
			return _canBeOverwritten;
		}
		set
		{
			_canBeOverwritten = value;
		}
	}

	public DiscountQty[] Qty
	{
		get
		{
			return _qty;
		}
		set
		{
			_qty = value;
		}
	}

	public int Active
	{
		get
		{
			return _active;
		}
		set
		{
			_active = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cDiscount(int Id)
	{
		if (Id <= 0)
		{
			return;
		}
		_id = Id;
		DataTable dataTable = new DataTable();
		string strSql = " SELECT *  FROM discount  WHERE discId = " + Conversions.ToString(_id);
		dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			_name = Conversions.ToString(dataTable.Rows[0]["discName"]);
			_type = Conversions.ToInteger(dataTable.Rows[0]["discType"]);
			_percentage = Conversions.ToString(dataTable.Rows[0]["discPct"]);
			_canBeOverwritten = Conversions.ToInteger(dataTable.Rows[0]["discOverwrite"]);
			_active = Conversions.ToInteger(dataTable.Rows[0]["discStatus"]);
		}
		else
		{
			_id = 0;
			Information.Err().Raise(513, null, "Diskon tidak ditemukan. Kemungkinan telah dihapus.");
		}
		strSql = " SELECT *  FROM discQty  WHERE discId = " + Conversions.ToString(_id) + " ORDER BY dqBegin ";
		int num = 0;
		dataTable = Module1.sqlTable(strSql, "read", Clone: false);
		checked
		{
			_qty = new DiscountQty[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_qty[num]._begin = Conversions.ToDouble(row["dqBegin"]);
				_qty[num]._end = Conversions.ToDouble(row["dqEnd"]);
				_qty[num]._value = Conversions.ToDouble(row["dqValue"]);
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void Save()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		MySqlTransaction val = default(MySqlTransaction);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					val = Module1.connectData.BeginTransaction();
					if (_id == 0)
					{
						string strSql = " INSERT INTO discount(discName, discType, discOverwrite,  discPct, discStatus)  VALUES  ('" + _name + "', " + Conversions.ToString(_type) + "," + Conversions.ToString(_canBeOverwritten) + ",'" + _percentage + "'," + Conversions.ToString(_active) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					else
					{
						string strSql = " UPDATE discount  SET discName = '" + _name + "',  discType = " + Conversions.ToString(_type) + ", discOverwrite = " + Conversions.ToString(_canBeOverwritten) + ", discPct = '" + _percentage + "', discStatus = " + Conversions.ToString(_active) + "  WHERE discId = " + Conversions.ToString(_id) + " ";
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM discqty  WHERE discId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
					}
					if (!Information.IsNothing(_qty))
					{
						DiscountQty[] qty = _qty;
						for (int i = 0; i < qty.Length; i = checked(i + 1))
						{
							DiscountQty discountQty = qty[i];
							string strSql = " INSERT INTO discqty  (dqBegin, dqEnd, dqValue,  discId) VALUES  ( " + Module1.unformatNumber(Conversions.ToString(discountQty._begin)) + "," + Module1.unformatNumber(Conversions.ToString(discountQty._end)) + "," + Module1.unformatNumber(Conversions.ToString(discountQty._value)) + "," + Conversions.ToString(_id) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
					}
					val.Commit();
					goto end_IL_0001;
				case 699:
					num = -1;
					switch (num2)
					{
					case 2:
						if (Operators.CompareString(Information.Err().Description, "Fatal error encountered during command execution.", TextCompare: false) != 0 && Operators.CompareString(Information.Err().Description, "The connection is not open.", TextCompare: false) != 0)
						{
							val.Rollback();
						}
						Information.Err().Raise(513, null, Information.Err().Description);
						goto end_IL_0001;
					}
					break;
				}
				goto IL_02f1;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 699;
				continue;
			}
			break;
			IL_02f1:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable Search(bool Active)
	{
		string text = " SELECT *, IF(discType=0,'Persentasi','Jumlah Barang') AS typeName  FROM discount ";
		if (Active)
		{
			text += " WHERE discStatus = 1 ";
		}
		text += " ORDER BY discName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static bool IsExist(int Id, string Name)
	{
		bool result = false;
		string text = " SELECT * FROM discount  WHERE discName = '" + Name + "'";
		if (Id > 0)
		{
			text = text + " AND discId <> " + Conversions.ToString(Id);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			result = true;
		}
		return result;
	}

	public static double CalculateDiscount(int discountId, double totalPrice, double totalItem)
	{
		cDiscount cDiscount2 = new cDiscount(discountId);
		double number = default(double);
		if (cDiscount2.Type == 0)
		{
			totalPrice = Conversion.Val(Module1.unformatNumber(Conversions.ToString(totalPrice)));
			string[] array = cDiscount2.Percentage.Split('+');
			double num = totalPrice;
			string[] array2 = array;
			foreach (string inputStr in array2)
			{
				num -= Conversion.Val(inputStr) / 100.0 * num;
			}
			number = totalPrice - num;
		}
		else if (cDiscount2.Type == 1)
		{
			number = 0.0;
			DiscountQty[] qty = cDiscount2.Qty;
			for (int j = 0; j < qty.Length; j = checked(j + 1))
			{
				DiscountQty discountQty = qty[j];
				if ((totalItem >= discountQty._begin) & (totalItem < discountQty._end + 1.0))
				{
					number = totalItem * discountQty._value;
				}
			}
		}
		return Module1.RoundMoney(number);
	}
}
