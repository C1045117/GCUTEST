using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GCUv2;

public class cCombo
{
	public static void getMonth(ref ComboBox combo, bool blnAll)
	{
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("SEMUA", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Jan", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Feb", Conversions.ToString(2)));
		combo.Items.Add(new cComboItem("Mar", Conversions.ToString(3)));
		combo.Items.Add(new cComboItem("Apr", Conversions.ToString(4)));
		combo.Items.Add(new cComboItem("May", Conversions.ToString(5)));
		combo.Items.Add(new cComboItem("Jun", Conversions.ToString(6)));
		combo.Items.Add(new cComboItem("Jul", Conversions.ToString(7)));
		combo.Items.Add(new cComboItem("Aug", Conversions.ToString(8)));
		combo.Items.Add(new cComboItem("Sep", Conversions.ToString(9)));
		combo.Items.Add(new cComboItem("Oct", Conversions.ToString(10)));
		combo.Items.Add(new cComboItem("Nov", Conversions.ToString(11)));
		combo.Items.Add(new cComboItem("Dec", Conversions.ToString(12)));
		combo.SelectedIndex = checked(DateAndTime.Month(DateAndTime.Now) - 1);
	}

	public static void getYear(ref ComboBox combo, bool blnAll, int StartingYear, int AdditionalYear)
	{
		int i = StartingYear;
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		checked
		{
			for (; DateAndTime.Year(DateAndTime.Now) + AdditionalYear >= i; i++)
			{
				combo.Items.Add(new cComboItem(Conversions.ToString(i), Conversions.ToString(i)));
			}
			combo.Text = Conversions.ToString(DateAndTime.Year(DateAndTime.Now));
		}
	}

	public static void getYesNo(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(99)));
		}
		combo.Items.Add(new cComboItem("Ya", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tidak", Conversions.ToString(0)));
	}

	public static void getPaymentStatus(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(99)));
		}
		combo.Items.Add(new cComboItem("Lunas", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Belum Lunas", Conversions.ToString(2)));
	}

	public static bool getBranch(ref ComboBox combo, int intGroupId, bool blnAll)
	{
		DataTable dataTable = cBranch.Search(intGroupId, 1);
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["branchName"]), Conversions.ToString(row["branchId"])));
		}
		if (dataTable.Rows.Count > 0)
		{
			return true;
		}
		return false;
	}

	public static void getProductionStep(ref ComboBox combo, int intGroupId, bool blnAll)
	{
		DataTable step = cStep.GetStep();
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in step.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["stepName"]), Conversions.ToString(row["stepId"])));
		}
	}

	public static void getStorage(ref ComboBox combo, int intGroupId, int intBranchId, string StorageType, bool blnAll, int Active)
	{
		DataTable dataTable = cStorage.Search(intGroupId, intBranchId, StorageType, Active);
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			if (intBranchId == 0)
			{
				combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["storeName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3))), Conversions.ToString(row["storeId"])));
			}
			else
			{
				combo.Items.Add(new cComboItem(Conversions.ToString(row["storeName"]), Conversions.ToString(row["storeId"])));
			}
		}
	}

	public static void getGroup(ref ComboBox combo)
	{
		DataTable dataTable = cGroup.dtGroup();
		combo.Items.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["groupName"]), Conversions.ToString(row["groupid"])));
		}
	}

	public static void getSupplier(ref ComboBox combo, int GroupId, bool All, bool FlowerOnly, bool IncludeParent, bool Active)
	{
		DataTable dataTable = cSupplier.dtSupplier(GroupId, FlowerOnly, IncludeParent, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["supName"]), Conversions.ToString(row["supId"])));
		}
	}

	public static void getReportPurchaseInvoiceFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Tgl. Faktur", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tgl. F. Pajak", Conversions.ToString(3)));
		combo.Items.Add(new cComboItem("No Faktur", Conversions.ToString(4)));
		combo.Items.Add(new cComboItem("No F. Pajak", Conversions.ToString(5)));
	}

	public static void getReportReceivableFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Tgl. Faktur", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tgl. Piutang", Conversions.ToString(2)));
	}

	public static void getReportReceivedItemFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Belum dikaitkan ke Faktur", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Sudah dikaitkan ke Faktur", Conversions.ToString(2)));
	}

	public static void getReportInvoiceNumberFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Faktur Komersial", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Faktur Pajak", Conversions.ToString(2)));
	}

	public static void getSalesInvoiceType(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Penjualan", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Retur", Conversions.ToString(2)));
	}

	public static void getPurchaseInvoiceType(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Pembelian", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Retur", Conversions.ToString(2)));
	}

	public static void getReportSalesInvoiceFilter(ref ComboBox combo, bool IsReturn)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Tgl. Faktur", Conversions.ToString(1)));
		if (!IsReturn)
		{
			combo.Items.Add(new cComboItem("Tgl. F. Pajak", Conversions.ToString(3)));
		}
		combo.Items.Add(new cComboItem("Tgl. Lunas", Conversions.ToString(4)));
		if (!IsReturn)
		{
			combo.Items.Add(new cComboItem("Tgl. TF", Conversions.ToString(5)));
			combo.Items.Add(new cComboItem("No Faktur", Conversions.ToString(6)));
		}
	}

	public static void getReportSalesOrderFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Tgl. Pesanan", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tgl. Expired", Conversions.ToString(3)));
	}

	public static void getReportChequeOutFilter(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Tgl. Bayar", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tgl. Cek/Giro", Conversions.ToString(3)));
		combo.Items.Add(new cComboItem("No. Cek/Giro", Conversions.ToString(4)));
	}

	public static void getReportChequeInFilter(ref ComboBox combo, bool Report)
	{
		combo.Items.Clear();
		if (Report)
		{
			combo.Items.Add(new cComboItem("Tgl. Bayar", Conversions.ToString(1)));
			combo.Items.Add(new cComboItem("Tgl. Cek/Giro", Conversions.ToString(3)));
			combo.Items.Add(new cComboItem("Tgl. Setor", Conversions.ToString(4)));
			combo.Items.Add(new cComboItem("Tgl. Masuk", Conversions.ToString(5)));
		}
		combo.Items.Add(new cComboItem("Belum disetor", Conversions.ToString(6)));
		combo.Items.Add(new cComboItem("Belum masuk", Conversions.ToString(7)));
		if (Report)
		{
			combo.Items.Add(new cComboItem("No. Cek/Giro", Conversions.ToString(8)));
		}
	}

	public static void getBank(ref ComboBox combo, bool All, bool Active)
	{
		DataTable dataTable = cBank.Search(0 - (Active ? 1 : 0));
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["bankName"]), Conversions.ToString(row["bankId"])));
		}
	}

	public static void getPaymentCode(ref ComboBox combo, bool All, bool ShowCheque)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Cash", Conversions.ToString(1)));
		if (ShowCheque)
		{
			combo.Items.Add(new cComboItem("C/G", Conversions.ToString(2)));
		}
		combo.Items.Add(new cComboItem("LLG", Conversions.ToString(3)));
	}

	public static void getCashAccount(ref ComboBox combo, int BranchId, int GroupId, bool All, bool GroupDefault, bool Active, string PermissionType, int Currency)
	{
		DataTable dataTable = cCashAccount.dtCashAccount(BranchId, GroupId, Active, PermissionType, Currency);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		if (GroupDefault)
		{
			combo.Items.Add(new cComboItem("Default Group", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["accountName"]), Conversions.ToString(row["accountId"])));
		}
	}

	public static void getBankAccount(ref ComboBox combo, int BranchId, int GroupId, bool All, bool GroupDefault, bool Active, string PermissionType, int Currency)
	{
		DataTable dataTable = cBankAccount.dtBankAccount(BranchId, GroupId, Active, PermissionType, Currency);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		if (GroupDefault)
		{
			combo.Items.Add(new cComboItem("Default Group", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["accountName"]), Conversions.ToString(row["accountId"])));
		}
	}

	public static void getAdjustmentType(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(99)));
		}
		combo.Items.Add(new cComboItem("Tambah", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Kurang", Conversions.ToString(1)));
	}

	public static void getAdjustmentCategory(ref ComboBox combo, bool All, bool Active)
	{
		DataTable dataTable = cAdjustmentCategory.dtCategory(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["adjTypeName"]), Conversions.ToString(row["adjTypeId"])));
		}
	}

	public static void getItemCategory(ref ComboBox combo, int GroupId, bool All, bool Active)
	{
		DataTable itemCategory = cItemCategory.getItemCategory(GroupId, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in itemCategory.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["catName"]), Conversions.ToString(row["catId"])));
		}
	}

	public static void getItemAll(ref ComboBox combo, int AllowPurchase, int AllowProduction, int ProductionStep, int IsComponent, int ProductionItemId, int ProductionStepId, int AllowSell, int ItemTypeId, int ItemCategoryId, int SupplierId, int StorageId1, int StorageId2, double CustomerId, bool CanBeUsedAsGroupMember, int GroupId, bool All, bool Active)
	{
		DataTable dataTable = cItem.Search(AllowPurchase, AllowProduction, ProductionStep, IsComponent, ProductionItemId, ProductionStepId, AllowSell, ItemTypeId, ItemCategoryId, SupplierId, StorageId1, StorageId2, CustomerId, CanBeUsedAsGroupMember, GroupId, 0, 0 - (Active ? 1 : 0));
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["itemName"]), Conversions.ToString(row["itemId"])));
		}
	}

	public static void getArea(ref ComboBox combo, int BranchId, int GroupId, bool All, bool Active)
	{
		DataTable dataTable = cArea.Search(BranchId, GroupId, 0 - (Active ? 1 : 0));
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["wilName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3))), Conversions.ToString(row["wilid"])));
		}
	}

	public static void getAreaList(ref CheckedListBox ListBox, int BranchId, int GroupId, bool Active)
	{
		DataTable dataTable = cArea.Search(BranchId, GroupId, 0 - (Active ? 1 : 0));
		ListBox.Items.Clear();
		foreach (DataRow row in dataTable.Rows)
		{
			ListBox.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["wilName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3))), Conversions.ToString(row["wilid"])));
		}
	}

	public static void getCustomerCode(ref ComboBox combo, bool All, int Active)
	{
		DataTable dataTable = cCustomerCode.Search(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["ckName"]), Conversions.ToString(row["ckId"])));
		}
	}

	public static void getPriceCode(ref ComboBox combo, bool All, int Active)
	{
		DataTable dataTable = cSalesPriceCode.Search(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["hargaKode"]), Conversions.ToString(row["hargaId"])));
		}
	}

	public static void getDiscount(ref ComboBox combo, bool All, bool Active)
	{
		DataTable dataTable = cDiscount.Search(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["discName"]), Conversions.ToString(row["discId"])));
		}
	}

	public static void getSalesPerson(ref ComboBox combo, string PersonType, int SalesId, int Donation, int BranchId, int GroupId, bool All, bool Dash, int Active)
	{
		DataTable dataTable = cSalesPerson.Search(PersonType, SalesId, Donation, BranchId, GroupId, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		else if (Dash)
		{
			combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["salesName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3))), Conversions.ToString(row["salesId"])));
		}
	}

	public static void getParentSupplier(ref ComboBox combo, int GroupId, bool All, bool Dash)
	{
		DataTable parentSupplier = cSupplier.GetParentSupplier(GroupId);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		else if (Dash)
		{
			combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		}
		foreach (DataRow row in parentSupplier.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["supName"]), Conversions.ToString(row["supId"])));
		}
	}

	public static void getActive(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(2)));
		}
		combo.Items.Add(new cComboItem("Aktif", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Tidak Aktif", Conversions.ToString(0)));
	}

	public static void getGroupCustomer(ref ComboBox combo, int BranchId, int GroupId, bool None, bool All, bool Active)
	{
		DataTable groupCustomer = cGroupCustomer.getGroupCustomer(BranchId, GroupId != 0, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(-2)));
		}
		if (None)
		{
			combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		}
		foreach (DataRow row in groupCustomer.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["custName"], " - "), Strings.Left(Conversions.ToString(row["branchName"]), 3))), Conversions.ToString(row["custId"])));
		}
	}

	public static void getInvoiceCode(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(2)));
		}
		combo.Items.Add(new cComboItem("Tunai", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Kredit", Conversions.ToString(1)));
	}

	public static void getItemType(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Persediaan", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Non-Persediaan", Conversions.ToString(2)));
		combo.Items.Add(new cComboItem("Jasa", Conversions.ToString(3)));
		combo.Items.Add(new cComboItem("Grup", Conversions.ToString(4)));
	}

	public static void getStorageType(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Barang Baik", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("BS", Conversions.ToString(2)));
	}

	public static void getMarketingStorageType(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Barang Marketing", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Barang BS", Conversions.ToString(2)));
	}

	public static void getAccountType(ref ComboBox combo, bool All)
	{
		DataTable accountType = cAccount.GetAccountType();
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in accountType.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["accountTypeName"]), Conversions.ToString(row["accountTypeId"])));
		}
	}

	public static void getAccount(ref ComboBox combo, bool All, int None, int AccountTypeId, int AccountIsParent, int CurrentAccount, int AccountCashBank, int AccountCashIncomeExpense, int AccountBankIncomeExpense, int CurrencyId, int Active)
	{
		DataTable dataTable = cAccount.Search(AccountTypeId, AccountIsParent, CurrentAccount, AccountCashBank, AccountCashIncomeExpense, AccountBankIncomeExpense, CurrencyId, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(-2)));
		}
		if (None == -1)
		{
			combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["accountNumber"], " - "), row["accountName"])), Conversions.ToString(row["accountId"])));
		}
	}

	public static void getAccountForTransaction(ref ComboBox combo, bool All, int None, int CurrentAccount, int AccountCashIncomeExpense, int AccountBankIncomeExpense, int CurrencyId, int GroupId, int Active)
	{
		DataTable dataTable = cAccount.SearchForTransaction(CurrentAccount, AccountCashIncomeExpense, AccountBankIncomeExpense, CurrencyId, GroupId, Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(-2)));
		}
		if (None == -1)
		{
			combo.Items.Add(new cComboItem("-", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(row["accountNumber"], " - "), row["accountName"])), Conversions.ToString(row["accountId"])));
		}
	}

	public static void getCustomer(ref ComboBox combo, int BranchId, int GroupId, bool All, int Active)
	{
		DataTable dataTable = cCustomer.Search("", "", 0, 0, 0, 0, 0, Active, BelongToGroup: false, 0, Module1.pubGroupId, BranchId, 0, 0, 0);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(-2)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["custName"]), Conversions.ToString(row["custId"])));
		}
	}

	public static void getCurrency(ref ComboBox combo, bool All, int Active)
	{
		DataTable dataTable = cCurrency.Search(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(-2)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["currencyName"]), Conversions.ToString(row["currencyId"])));
		}
	}

	public static void getIncomeExpense(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Pendapatan", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Pengeluaran", Conversions.ToString(2)));
	}

	public static void getDebitCredit(ref ComboBox combo, bool All)
	{
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		combo.Items.Add(new cComboItem("Debit", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Kredit", Conversions.ToString(2)));
	}

	public static void getSearchType(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Rincian", Conversions.ToString(1)));
		combo.Items.Add(new cComboItem("Rangkuman", Conversions.ToString(2)));
	}

	public static void getUser(ref ComboBox combo, bool All, int Active)
	{
		DataTable dataTable = cUser.Search(Active);
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["userLogin"]), Conversions.ToString(row["userId"])));
		}
	}

	public static void getHistoryType(ref ComboBox combo, bool All)
	{
		DataTable historyType = cHistory.GetHistoryType();
		combo.Items.Clear();
		if (All)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in historyType.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["historyTypeName"]), Conversions.ToString(row["historyTypeId"])));
		}
	}

	public static void getItemUnit(ref ComboBox combo, int ItemId, int SupplierId, bool blnAll)
	{
		DataTable dataTable = cItem.SearchItemUnit(ItemId, SupplierId);
		combo.Items.Clear();
		if (blnAll)
		{
			combo.Items.Add(new cComboItem("--SEMUA--", Conversions.ToString(0)));
		}
		foreach (DataRow row in dataTable.Rows)
		{
			combo.Items.Add(new cComboItem(Conversions.ToString(row["unitName"]), Conversions.ToString(row["unitId"])));
		}
	}

	public static void getDiscountType(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Persentasi", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Jumlah Barang", Conversions.ToString(1)));
	}

	public static void getReportProductionPredictionType(ref ComboBox combo)
	{
		combo.Items.Clear();
		combo.Items.Add(new cComboItem("Teh", Conversions.ToString(0)));
		combo.Items.Add(new cComboItem("Kemasan", Conversions.ToString(1)));
	}
}
