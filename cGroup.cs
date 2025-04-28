using System;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MySql.Data.MySqlClient;

namespace GCUv2;

public class cGroup
{
	private int _id;

	private int[] _catId;

	private int[] _pageId;

	private int[] _permissionType1;

	private int[] _supplierId;

	private string[] _userName;

	private cGroupPermission[] _permission;

	private cGroupCashAccount[] _groupCashAccount;

	private cGroupBankAccount[] _groupBankAccount;

	private cGroupStorage[] _groupStorage;

	private cGroupBranch[] _groupBranch;

	public object Id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = Conversions.ToInteger(value);
		}
	}

	public int[] CatId
	{
		get
		{
			return _catId;
		}
		set
		{
			_catId = value;
		}
	}

	public int[] PageId
	{
		get
		{
			return _pageId;
		}
		set
		{
			_pageId = value;
		}
	}

	public int[] PermissionType1
	{
		get
		{
			return _permissionType1;
		}
		set
		{
			_permissionType1 = value;
		}
	}

	public int[] SupplierId
	{
		get
		{
			return _supplierId;
		}
		set
		{
			_supplierId = value;
		}
	}

	public string[] UserName
	{
		get
		{
			return _userName;
		}
		set
		{
			_userName = value;
		}
	}

	public cGroupPermission[] Permission
	{
		get
		{
			return _permission;
		}
		set
		{
			_permission = value;
		}
	}

	public cGroupCashAccount[] GroupCashAccount
	{
		get
		{
			return _groupCashAccount;
		}
		set
		{
			_groupCashAccount = value;
		}
	}

	public cGroupBankAccount[] GroupBankAccount
	{
		get
		{
			return _groupBankAccount;
		}
		set
		{
			_groupBankAccount = value;
		}
	}

	public cGroupStorage[] GroupStorage
	{
		get
		{
			return _groupStorage;
		}
		set
		{
			_groupStorage = value;
		}
	}

	public cGroupBranch[] GroupBranch
	{
		get
		{
			return _groupBranch;
		}
		set
		{
			_groupBranch = value;
		}
	}

	public cGroup(int GroupId)
	{
		if (GroupId <= 0)
		{
			return;
		}
		_id = GroupId;
		string strSql = " SELECT * FROM groups_pages  WHERE groupId = " + Conversions.ToString(_id);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		checked
		{
			int num;
			if (dataTable.Rows.Count > 0)
			{
				_pageId = new int[dataTable.Rows.Count - 1 + 1];
				num = 0;
				foreach (DataRow row in dataTable.Rows)
				{
					_pageId[num] = Conversions.ToInteger(row["pageId"]);
					num++;
				}
			}
			strSql = " SELECT * FROM groups_permissions  WHERE groupId = " + Conversions.ToString(_id) + " AND permId IN (SELECT permId FROM permissions WHERE permType = 1) ";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_permissionType1 = new int[dataTable.Rows.Count - 1 + 1];
				num = 0;
				foreach (DataRow row2 in dataTable.Rows)
				{
					_permissionType1[num] = Conversions.ToInteger(row2["permId"]);
					num++;
				}
			}
			strSql = " SELECT a.permId, a.permDesc, b.permValue  FROM permissions a LEFT OUTER JOIN groups_permissions b ON a.permId = b.permId  AND groupId = " + Conversions.ToString(_id) + " WHERE permType = 2 ";
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_permission = new cGroupPermission[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row3 in dataTable.Rows)
			{
				_permission[num] = new cGroupPermission();
				_permission[num].Id = Conversions.ToInteger(row3["permId"]);
				_permission[num].Description = Conversions.ToString(row3["permDesc"]);
				_permission[num].PermissionValue = Conversions.ToInteger(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row3["permValue"])) ? ((object)0) : row3["permValue"]);
				num++;
			}
			strSql = " SELECT * FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_supplierId = new int[dataTable.Rows.Count - 1 + 1];
				num = 0;
				foreach (DataRow row4 in dataTable.Rows)
				{
					_supplierId[num] = Conversions.ToInteger(row4["supId"]);
					num++;
				}
			}
			strSql = " SELECT * FROM group_itemcategory  WHERE groupId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_catId = new int[dataTable.Rows.Count - 1 + 1];
				num = 0;
				foreach (DataRow row5 in dataTable.Rows)
				{
					_catId[num] = Conversions.ToInteger(row5["catId"]);
					num++;
				}
			}
			strSql = " SELECT * FROM userlist  WHERE groupId = " + Conversions.ToString(_id);
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			if (dataTable.Rows.Count > 0)
			{
				_userName = new string[dataTable.Rows.Count - 1 + 1];
				num = 0;
				foreach (DataRow row6 in dataTable.Rows)
				{
					_userName[num] = Conversions.ToString(Operators.ConcatenateObject(row6["userLogin"], Interaction.IIf(Operators.ConditionalCompareObjectEqual(row6["userStatus"], 0, TextCompare: false), "(N/A)", "")));
					num++;
				}
			}
			strSql = " SELECT a.accountId, accountName, generalDropDown,  defaultDropDown, transactionDropDown, showBalance  FROM (SELECT * FROM account WHERE accountCashBank = 1) as a LEFT OUTER JOIN groupkg b  ON a.accountId = b.kgId  AND groupid = " + Conversions.ToString(_id) + " ORDER BY accountName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_groupCashAccount = new cGroupCashAccount[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row7 in dataTable.Rows)
			{
				_groupCashAccount[num] = new cGroupCashAccount();
				_groupCashAccount[num].CashAccountId = Conversions.ToInteger(row7["accountId"]);
				_groupCashAccount[num].CashAccountName = Conversions.ToString(row7["accountName"]);
				_groupCashAccount[num].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row7["generalDropDown"])), 0, RuntimeHelpers.GetObjectValue(row7["generalDropDown"])));
				_groupCashAccount[num].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row7["defaultDropDown"])), 0, RuntimeHelpers.GetObjectValue(row7["defaultDropDown"])));
				_groupCashAccount[num].TransactionDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row7["transactionDropDown"])), 0, RuntimeHelpers.GetObjectValue(row7["transactionDropDown"])));
				_groupCashAccount[num].ShowBalance = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row7["showBalance"])), 0, RuntimeHelpers.GetObjectValue(row7["showBalance"])));
				num++;
			}
			strSql = " SELECT a.accountId, accountName, generalDropDown,  defaultDropDown, transactionDropDown, showBalance  FROM (SELECT * FROM account WHERE accountCashBank = 2) as a  LEFT OUTER JOIN grouptg b  ON a.accountId = b.tgId  AND accountCashBank = 2  AND groupid = " + Conversions.ToString(_id) + " ORDER BY accountName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_groupBankAccount = new cGroupBankAccount[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row8 in dataTable.Rows)
			{
				_groupBankAccount[num] = new cGroupBankAccount();
				_groupBankAccount[num].BankAccountId = Conversions.ToInteger(row8["accountId"]);
				_groupBankAccount[num].BankAccountName = Conversions.ToString(row8["accountName"]);
				_groupBankAccount[num].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row8["generalDropDown"])), 0, RuntimeHelpers.GetObjectValue(row8["generalDropDown"])));
				_groupBankAccount[num].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row8["defaultDropDown"])), 0, RuntimeHelpers.GetObjectValue(row8["defaultDropDown"])));
				_groupBankAccount[num].TransactionDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row8["transactionDropDown"])), 0, RuntimeHelpers.GetObjectValue(row8["transactionDropDown"])));
				_groupBankAccount[num].ShowBalance = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row8["showBalance"])), 0, RuntimeHelpers.GetObjectValue(row8["showBalance"])));
				num++;
			}
			strSql = " SELECT a.storeId, storeName, generalDropDown,  defaultDropDown  FROM (SELECT * FROM storages WHERE storeActive = 1) as a  LEFT OUTER JOIN groupstorage b  ON a.storeId = b.storeId  AND groupid = " + Conversions.ToString(_id) + " ORDER BY storeName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_groupStorage = new cGroupStorage[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row9 in dataTable.Rows)
			{
				_groupStorage[num] = new cGroupStorage();
				_groupStorage[num].StorageId = Conversions.ToInteger(row9["storeId"]);
				_groupStorage[num].StorageName = Conversions.ToString(row9["storeName"]);
				_groupStorage[num].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row9["generalDropDown"])), 0, RuntimeHelpers.GetObjectValue(row9["generalDropDown"])));
				_groupStorage[num].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row9["defaultDropDown"])), 0, RuntimeHelpers.GetObjectValue(row9["defaultDropDown"])));
				num++;
			}
			strSql = " SELECT a.branchId, branchName, generalDropDown,  defaultDropDown  FROM (SELECT * FROM Branches WHERE branchActive = 1) as a  LEFT OUTER JOIN groups_branches b  ON a.branchId = b.branchId  AND groupId = " + Conversions.ToString(_id) + " ORDER BY branchName ";
			num = 0;
			dataTable = Module1.sqlTable(strSql, "data", Clone: false);
			_groupBranch = new cGroupBranch[dataTable.Rows.Count - 1 + 1];
			foreach (DataRow row10 in dataTable.Rows)
			{
				_groupBranch[num] = new cGroupBranch();
				_groupBranch[num].BranchId = Conversions.ToInteger(row10["branchId"]);
				_groupBranch[num].BranchName = Conversions.ToString(row10["branchName"]);
				_groupBranch[num].GeneralDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row10["generalDropDown"])), 0, RuntimeHelpers.GetObjectValue(row10["generalDropDown"])));
				_groupBranch[num].DefaultDropDown = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(row10["defaultDropDown"])), 0, RuntimeHelpers.GetObjectValue(row10["defaultDropDown"])));
				num++;
			}
		}
	}

	public static DataTable dtGroup()
	{
		string strSql = " SELECT groupId,groupName FROM groups ORDER BY groupName ";
		return Module1.sqlTable(strSql, "read", Clone: false);
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
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						val = Module1.connectData.BeginTransaction();
						string strSql = " DELETE FROM group_itemcategory  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groupkg  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groups_branches  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groups_pages  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groups_permissions  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM groupstorage  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						strSql = " DELETE FROM grouptg  WHERE groupId = " + Conversions.ToString(_id);
						Module1.sqlNonQuery(strSql, "data");
						int num3 = _pageId.Count() - 1;
						for (int i = 0; i <= num3; i++)
						{
							strSql = " INSERT INTO groups_pages(groupId,pageId) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(_pageId[i]) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						int num4 = _supplierId.Count() - 1;
						for (int i = 0; i <= num4; i++)
						{
							strSql = " INSERT INTO groups_suppliers(groupId,supId) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(_supplierId[i]) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						int num5 = _catId.Count() - 1;
						for (int i = 0; i <= num5; i++)
						{
							strSql = " INSERT INTO group_itemcategory(groupId,catId) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(_catId[i]) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						int num6 = _permissionType1.Count() - 1;
						for (int i = 0; i <= num6; i++)
						{
							strSql = " INSERT INTO groups_permissions(groupId,permId) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(_permissionType1[i]) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cGroupPermission[] permission = _permission;
						foreach (cGroupPermission cGroupPermission2 in permission)
						{
							strSql = " INSERT INTO groups_permissions  (groupId,permId,permValue) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(cGroupPermission2.Id) + "," + Conversions.ToString(cGroupPermission2.PermissionValue) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cGroupCashAccount[] groupCashAccount = _groupCashAccount;
						foreach (cGroupCashAccount cGroupCashAccount2 in groupCashAccount)
						{
							strSql = " INSERT INTO groupkg  (groupId,kgId,generalDropDown, defaultDropDown,transactionDropDown,showBalance) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(cGroupCashAccount2.CashAccountId) + "," + Conversions.ToString(cGroupCashAccount2.GeneralDropDown) + "," + Conversions.ToString(cGroupCashAccount2.DefaultDropDown) + "," + Conversions.ToString(cGroupCashAccount2.TransactionDropDown) + "," + Conversions.ToString(cGroupCashAccount2.ShowBalance) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cGroupBankAccount[] groupBankAccount = _groupBankAccount;
						foreach (cGroupBankAccount cGroupBankAccount2 in groupBankAccount)
						{
							strSql = " INSERT INTO grouptg  (groupId,tgId,generalDropDown, defaultDropDown,transactionDropDown,showBalance) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(cGroupBankAccount2.BankAccountId) + "," + Conversions.ToString(cGroupBankAccount2.GeneralDropDown) + "," + Conversions.ToString(cGroupBankAccount2.DefaultDropDown) + "," + Conversions.ToString(cGroupBankAccount2.TransactionDropDown) + "," + Conversions.ToString(cGroupBankAccount2.ShowBalance) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cGroupStorage[] groupStorage = _groupStorage;
						foreach (cGroupStorage cGroupStorage2 in groupStorage)
						{
							strSql = " INSERT INTO groupstorage  (groupId,storeId,generalDropDown, defaultDropDown) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(cGroupStorage2.StorageId) + "," + Conversions.ToString(cGroupStorage2.GeneralDropDown) + "," + Conversions.ToString(cGroupStorage2.DefaultDropDown) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						cGroupBranch[] groupBranch = _groupBranch;
						foreach (cGroupBranch cGroupBranch2 in groupBranch)
						{
							strSql = " INSERT INTO groups_branches  (groupId,branchId,generalDropDown, defaultDropDown) VALUES  (" + Conversions.ToString(_id) + "," + Conversions.ToString(cGroupBranch2.BranchId) + "," + Conversions.ToString(cGroupBranch2.GeneralDropDown) + "," + Conversions.ToString(cGroupBranch2.DefaultDropDown) + ")";
							Module1.sqlNonQuery(strSql, "data");
						}
						val.Commit();
						goto end_IL_0001;
					}
					case 1768:
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
					goto IL_071e;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1768;
				continue;
			}
			break;
			IL_071e:
			throw ProjectData.CreateProjectError(-2146828237);
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void SaveGroupName(int GroupId, string GroupName)
	{
		if (GroupId == 0)
		{
			string strSql = "INSERT INTO groups(groupName) VALUES ('" + GroupName + "')";
			Module1.sqlNonQuery(strSql, "data");
		}
		else
		{
			string strSql = "UPDATE groups SET groupName = '" + GroupName + "'WHERE groupId = " + Conversions.ToString(GroupId);
		}
	}

	public static bool NameIsUsed(int GroupId, string GroupName)
	{
		string text = " SELECT groupId FROM groups  WHERE groupName = '" + GroupName + "'";
		if (GroupId > 0)
		{
			text = text + " AND groupId <> " + Conversions.ToString(GroupId);
		}
		DataTable dataTable = Module1.sqlTable(text, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			return true;
		}
		return false;
	}

	public static void Delete(int GroupId)
	{
		string strSql = " DELETE FROM group_itemcategory  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groupkg  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groups_branches  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groups_pages  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groups_permissions  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groups_suppliers  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groupstorage  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM grouptg  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
		strSql = " DELETE FROM groups  WHERE groupId = " + Conversions.ToString(GroupId);
		Module1.sqlNonQuery(strSql, "data");
	}

	public static bool ShowCashBalance(int GroupId, int AccountId)
	{
		bool flag = false;
		string strSql = " SELECT showBalance FROM groupKg  WHERE groupId = " + Conversions.ToString(GroupId) + " AND kgId = " + Conversions.ToString(AccountId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return Conversions.ToBoolean(dataTable.Rows[0]["showBalance"]);
	}

	public static bool ShowBankBalance(int GroupId, int AccountId)
	{
		bool flag = false;
		string strSql = " SELECT showBalance FROM groupTg  WHERE groupId = " + Conversions.ToString(GroupId) + " AND tgId = " + Conversions.ToString(AccountId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		return Conversions.ToBoolean(dataTable.Rows[0]["showBalance"]);
	}

	public static bool HasUser(int GroupId)
	{
		string strSql = " SELECT * FROM userList  WHERE groupId = " + Conversions.ToString(GroupId);
		DataTable dataTable = Module1.sqlTable(strSql, "data", Clone: false);
		if (dataTable.Rows.Count > 0)
		{
			return true;
		}
		return false;
	}
}
