using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cHistory
{
	private double _id;

	private DateTime _createdDate;

	private string _content;

	private string _description;

	private int _historyType;

	private int _userId;

	private string _userLogin;

	private double _fKeyId;

	public double Id
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

	public DateTime CreatedDate
	{
		get
		{
			return _createdDate;
		}
		set
		{
			_createdDate = value;
		}
	}

	public string Content
	{
		get
		{
			return _content;
		}
		set
		{
			_content = Module1.cleanString(value);
		}
	}

	public string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = Module1.cleanString(value);
		}
	}

	public int HistoryType
	{
		get
		{
			return _historyType;
		}
		set
		{
			_historyType = value;
		}
	}

	public int UserId
	{
		get
		{
			return _userId;
		}
		set
		{
			_userId = value;
		}
	}

	public string UserLogin
	{
		get
		{
			return _userLogin;
		}
		set
		{
			_userLogin = value;
		}
	}

	public double fKeyId
	{
		get
		{
			return _fKeyId;
		}
		set
		{
			_fKeyId = value;
		}
	}

	public static DataTable GetHistory(int intFkeyId, int HistoryType)
	{
		string strSql = " SELECT userLogin, histDate, histContent  FROM " + Module1.pubDbHistory + ".historyV2 a  WHERE histType = " + Conversions.ToString(HistoryType) + " AND fkeyId = " + Conversions.ToString(intFkeyId) + " ORDER BY histId DESC ";
		return Module1.sqlTable(strSql, "data", Clone: false);
	}

	public void Save()
	{
		string strSql = " INSERT INTO " + Module1.pubDbHistory + ".historyV2(histDate, histContent, histDescription, histType, userId, userLogin, fkeyId)  VALUES ('" + Strings.Format(DateAndTime.Now, "yyyy-MM-dd HH:mm:ss") + "','" + _content + "','" + _description + "' ," + Conversions.ToString(_historyType) + "," + Conversions.ToString(_userId) + ",'" + _userLogin + "'," + Conversions.ToString(_fKeyId) + ")";
		Module1.sqlNonQuery(strSql, "data");
	}

	public static DataTable Search(DateTime dateFirst, DateTime dateLast, string UserLogin, int HistoryTypeId)
	{
		string text = " SELECT histType as histTypeId, fkeyId, histDate, CONCAT(userLogin, ' ', histDescription) AS activity  FROM " + Module1.pubDbHistory + ".historyV2 a  WHERE histDate >= '" + Strings.Format(dateFirst, "yyyy-MM-dd") + "' AND histDate <= '" + Strings.Format(dateLast, "yyyy-MM-dd") + " 24:00:00'";
		if (Operators.CompareString(UserLogin, "--SEMUA--", TextCompare: false) != 0)
		{
			text = text + " AND userLogin = '" + UserLogin + "'";
		}
		if (HistoryTypeId > 0)
		{
			text = text + " AND a.histType = " + Conversions.ToString(HistoryTypeId);
		}
		return Module1.sqlTable(text, "data", Clone: false);
	}

	public static DataTable GetHistoryType()
	{
		string strSql = " SELECT * FROM historyType ORDER by historyTypeName ";
		return Module1.sqlTable(strSql, "read", Clone: false);
	}
}
