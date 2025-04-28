using System;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cStep
{
	private int _id;

	private string _name;

	private cStepItem[] _item;

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
			_name = value;
		}
	}

	public cStepItem[] Item
	{
		get
		{
			return _item;
		}
		set
		{
			_item = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public cStep(double StepId)
	{
		if (!(StepId > 0.0))
		{
			return;
		}
		checked
		{
			_id = (int)Math.Round(StepId);
			DataTable dataTable = new DataTable();
			string strSql = " SELECT *  FROM steps  WHERE stepId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_name = Conversions.ToString(dataTable.Rows[0]["stepName"]);
			}
			else
			{
				_id = 0;
				Information.Err().Raise(513, null, "Urutan Produksi tidak ditemukan. Kemungkinan telah dihapus.");
			}
			strSql = " SELECT a.itemId, itemName, b.stepId  FROM items as a LEFT OUTER JOIN steps_items b  ON a.itemId = b.itemId  AND b.stepid = " + Conversions.ToString(_id) + " WHERE a.itemAllowComponent = 1  ORDER BY itemName ";
			int num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_item = new cStepItem[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row in dataTable.Rows)
			{
				_item[num] = new cStepItem();
				_item[num].ItemId = Conversions.ToInteger(row["itemId"]);
				_item[num].ItemName = Conversions.ToString(row["itemName"]);
				_item[num].IsMember = !Information.IsDBNull(RuntimeHelpers.GetObjectValue(row["stepId"]));
				num++;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void save()
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
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					val = Module1.connectData.BeginTransaction();
					if (_id == 0)
					{
						string strSql = " INSERT INTO steps  (stepName) VALUES  ('" + _name + "')";
						Module1.sqlNonQuery(strSql, "data");
						_id = checked((int)Math.Round(cDatabase.LastId("data")));
					}
					else
					{
						string strSql = " UPDATE steps  SET stepName = '" + _name + "' WHERE stepId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM steps_items  WHERE stepId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
					}
					cStepItem[] item = _item;
					foreach (cStepItem cStepItem2 in item)
					{
						string strSql = " INSERT INTO steps_items  (stepId, itemId) VALUES  ( " + Conversions.ToString(_id) + "," + Conversions.ToString(cStepItem2.ItemId) + ")";
						Module1.sqlNonQuery(strSql, "data");
					}
					val.Commit();
					goto end_IL_0001;
				}
				case 400:
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
				goto IL_01c6;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 400;
				continue;
			}
			break;
			IL_01c6:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static DataTable GetStep()
	{
		string text = " SELECT *  FROM steps ";
		text += " ORDER BY stepName ";
		return Module1.sqlTable(text, "read", Clone: false);
	}

	public static DataTable GetComponent(int StepId)
	{
		string strSql = " SELECT *  FROM items a, steps_items b  WHERE a.itemId = b.itemId  AND b.stepId = " + Conversions.ToString(StepId) + " ORDER BY itemName ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}
}
