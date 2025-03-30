namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private string _code;
        private int32 _isCollector;
        private int32 _isDonator;
        private int32 _branchId;
        private string _branchName;
        private int32 _active;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_42235D: nop
          loc_42235E: ldarg.0
          loc_42235F: ldarg.1
          loc_422360: stfld GCUv2.cSalesOrderItem::_id
          loc_422365: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_422381: nop
          loc_422382: ldarg.0
          loc_422383: ldarg.1
          loc_422384: call string GCUv2.Module1::cleanString(string)
          loc_422389: stfld GCUv2.cSalesPerson::_name
          loc_42238E: ret
        }

        public specialname string get_Code() {

          string str_1;

        }

        public specialname void set_Code(string value) {

          loc_4223A9: nop
          loc_4223AA: ldarg.0
          loc_4223AB: ldarg.1
          loc_4223AC: stfld GCUv2.cSalesPerson::_code
          loc_4223B1: ret
        }

        public specialname int32 get_IsCollector() {

          int32 num_1;

        }

        public specialname void set_IsCollector(int32 value) {

          loc_4223CD: nop
          loc_4223CE: ldarg.0
          loc_4223CF: ldarg.1
          loc_4223D0: stfld GCUv2.cSalesPerson::_isCollector
          loc_4223D5: ret
        }

        public specialname int32 get_IsDonator() {

          int32 num_1;

        }

        public specialname void set_IsDonator(int32 value) {

          loc_4223F1: nop
          loc_4223F2: ldarg.0
          loc_4223F3: ldarg.1
          loc_4223F4: stfld GCUv2.cSalesPerson::_isDonator
          loc_4223F9: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_422415: nop
          loc_422416: ldarg.0
          loc_422417: ldarg.1
          loc_422418: stfld GCUv2.cSalesPerson::_branchId
          loc_42241D: ret
        }

        public specialname string get_BranchName() {

          string str_1;

        }

        public specialname void set_BranchName(string value) {

          loc_422439: nop
          loc_42243A: ldarg.0
          loc_42243B: ldarg.1
          loc_42243C: stfld GCUv2.cSalesPerson::_branchName
          loc_422441: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_42245D: nop
          loc_42245E: ldarg.0
          loc_42245F: ldarg.1
          loc_422460: stfld GCUv2.cSalesPerson::_active
          loc_422465: ret
        }

        public void cSalesPerson(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void save() {

          string str_1;
          boolean var_1;

        }

        public static class DataTable Search(string PersonType, int32 SalesId, int32 Donator, int32 BranchId, int32 GroupId, int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        public static boolean IsExist(int32 Id, int32 BranchId, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchSalesItem(valuetype System.DateTime DateFirst, int32 SalesPersonId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchExpense(valuetype System.DateTime DateFirst, int32 SalesPersonId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static class DataTable SearchInvoice(valuetype System.DateTime DateFirst, int32 SalesPersonId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static class DataTable SearchPayment(valuetype System.DateTime DateFirst, int32 SalesPersonId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static double GetCreditPaymentDiscount(valuetype System.DateTime DateFirst, int32 SalesPersonId, int32 BranchId, int32 GroupId) {

          double flt_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
