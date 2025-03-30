namespace GCUv2
{
    public class 
    {

        public void cCombo() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public static void getMonth(class ComboBox& combo, boolean blnAll) {

          boolean var_1;

        }

        public static void getYear(class ComboBox& combo, boolean blnAll, int32 StartingYear, int32 AdditionalYear) {

          int32 num_1;
          boolean var_1;
          boolean var_2;

        }

        public static void getYesNo(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getPaymentStatus(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static boolean getBranch(class ComboBox& combo, int32 intGroupId, boolean blnAll) {

          boolean var_1;
          class DataTable var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;
          boolean var_7;

        }

        public static void getProductionStep(class ComboBox& combo, int32 intGroupId, boolean blnAll) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getStorage(class ComboBox& combo, int32 intGroupId, int32 intBranchId, string StorageType, boolean blnAll, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

        public static void getGroup(class ComboBox& combo) {

          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        public static void getSupplier(class ComboBox& combo, int32 GroupId, boolean All, boolean FlowerOnly, boolean IncludeParent, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getReportPurchaseInvoiceFilter(class ComboBox& combo) {


        }

        public static void getReportReceivableFilter(class ComboBox& combo) {


        }

        public static void getReportReceivedItemFilter(class ComboBox& combo) {


        }

        public static void getReportInvoiceNumberFilter(class ComboBox& combo) {


        }

        public static void getSalesInvoiceType(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getPurchaseInvoiceType(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getReportSalesInvoiceFilter(class ComboBox& combo, boolean IsReturn) {

          boolean var_1;
          boolean var_2;

        }

        public static void getReportSalesOrderFilter(class ComboBox& combo) {


        }

        public static void getReportChequeOutFilter(class ComboBox& combo) {


        }

        public static void getReportChequeInFilter(class ComboBox& combo, boolean Report) {

          boolean var_1;
          boolean var_2;

        }

        public static void getBank(class ComboBox& combo, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getPaymentCode(class ComboBox& combo, boolean All, boolean ShowCheque) {

          boolean var_1;
          boolean var_2;

        }

        public static void getCashAccount(class ComboBox& combo, int32 BranchId, int32 GroupId, boolean All, boolean GroupDefault, boolean Active, string PermissionType, int32 Currency) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getBankAccount(class ComboBox& combo, int32 BranchId, int32 GroupId, boolean All, boolean GroupDefault, boolean Active, string PermissionType, int32 Currency) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getAdjustmentType(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getAdjustmentCategory(class ComboBox& combo, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getItemCategory(class ComboBox& combo, int32 GroupId, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getItemAll(class ComboBox& combo, int32 AllowPurchase, int32 AllowProduction, int32 ProductionStep, int32 IsComponent, int32 ProductionItemId, int32 ProductionStepId, int32 AllowSell, int32 ItemTypeId, int32 ItemCategoryId, int32 SupplierId, int32 StorageId1, int32 StorageId2, double CustomerId, boolean CanBeUsedAsGroupMember, int32 GroupId, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getArea(class ComboBox& combo, int32 BranchId, int32 GroupId, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getAreaList(class CheckedListBox& ListBox, int32 BranchId, int32 GroupId, boolean Active) {

          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        public static void getCustomerCode(class ComboBox& combo, boolean All, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getPriceCode(class ComboBox& combo, boolean All, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getDiscount(class ComboBox& combo, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getSalesPerson(class ComboBox& combo, string PersonType, int32 SalesId, int32 Donation, int32 BranchId, int32 GroupId, boolean All, boolean Dash, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getParentSupplier(class ComboBox& combo, int32 GroupId, boolean All, boolean Dash) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getActive(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getGroupCustomer(class ComboBox& combo, int32 BranchId, int32 GroupId, boolean None, boolean All, boolean Active) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getInvoiceCode(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getItemType(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getStorageType(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getMarketingStorageType(class ComboBox& combo) {


        }

        public static void getAccountType(class ComboBox& combo, boolean All) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getAccount(class ComboBox& combo, boolean All, int32 None, int32 AccountTypeId, int32 AccountIsParent, int32 CurrentAccount, int32 AccountCashBank, int32 AccountCashIncomeExpense, int32 AccountBankIncomeExpense, int32 CurrencyId, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getAccountForTransaction(class ComboBox& combo, boolean All, int32 None, int32 CurrentAccount, int32 AccountCashIncomeExpense, int32 AccountBankIncomeExpense, int32 CurrencyId, int32 GroupId, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public static void getCustomer(class ComboBox& combo, int32 BranchId, int32 GroupId, boolean All, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getCurrency(class ComboBox& combo, boolean All, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getIncomeExpense(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getDebitCredit(class ComboBox& combo, boolean All) {

          boolean var_1;

        }

        public static void getSearchType(class ComboBox& combo) {


        }

        public static void getUser(class ComboBox& combo, boolean All, int32 Active) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getHistoryType(class ComboBox& combo, boolean All) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getItemUnit(class ComboBox& combo, int32 ItemId, int32 SupplierId, boolean blnAll) {

          class DataTable var_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public static void getDiscountType(class ComboBox& combo) {


        }

        public static void getReportProductionPredictionType(class ComboBox& combo) {


        }

    }
}
