namespace GCUv2
{
    public class 
    {

        public void cCashAccount() {

          loc_403253: ldarg.0
          loc_403254: call instance void System.Object::.ctor()
          loc_403259: ret
        }

        public static class DataTable dtCashAccount(int32 BranchId, int32 GroupId, boolean Active, string PermissionType, int32 Currency) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static object getBalance(valuetype System.DateTime FirstBalanceDate, valuetype System.DateTime BalanceDate, int32 AccountId) {

          object var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        public static class DataTable CashBook(valuetype System.DateTime FirstBalanceDate, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 CashAccountId, int32 AccountId, int32 SalesId, string Description, int32 GroupId, int32 SearchType, boolean ShowBalance) {

          class DataTable var_1;
          string str_1;
          double flt_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;
          boolean var_27;

        }

        public static class DataTable CustomerPayment(valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, int32 CashAccountId, int32 SalesId, int32 AreaId, int32 PaymentType) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable SupplierPayment(valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, int32 CashAccountId, int32 SupplierId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

    }
}
