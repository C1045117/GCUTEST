namespace GCUv2
{
    public class 
    {

        private int32 _salesPersonId;
        private int32 _year;
        private double _latestNumber;
        private valuetype NumberRange[] _range;
        private string _salesPersonCode;

        public struct NumberRange
        {
            public double _begin;
            public double _end;
        }


        public specialname int32 get_SalesPersonId() {

          int32 num_1;

        }

        public specialname void set_SalesPersonId(int32 value) {

          loc_40FD25: nop
          loc_40FD26: ldarg.0
          loc_40FD27: ldarg.1
          loc_40FD28: stfld GCUv2.cHistory::_salesPersonId
          loc_40FD2D: ret
        }

        public specialname int32 get_Year() {

          int32 num_1;

        }

        public specialname void set_Year(int32 value) {

          loc_40FD49: nop
          loc_40FD4A: ldarg.0
          loc_40FD4B: ldarg.1
          loc_40FD4C: stfld GCUv2.cInvoiceNumber::_year
          loc_40FD51: ret
        }

        public specialname double get_LatestNumber() {

          double flt_1;

        }

        public specialname void set_LatestNumber(double value) {

          loc_40FD6D: nop
          loc_40FD6E: ldarg.0
          loc_40FD6F: ldarg.1
          loc_40FD70: stfld GCUv2.cInvoiceNumber::_latestNumber
          loc_40FD75: ret
        }

        public specialname valuetype NumberRange[] get_Range() {

          valuetype NumberRange[] var_1;

        }

        public specialname void set_Range(valuetype NumberRange[] value) {

          loc_40FD91: nop
          loc_40FD92: ldarg.0
          loc_40FD93: ldarg.1
          loc_40FD94: stfld GCUv2.cInvoiceNumber::_range
          loc_40FD99: ret
        }

        public specialname string get_SalesPersonCode() {

          string str_1;

        }

        public specialname void set_SalesPersonCode(string value) {

          loc_40FDB5: nop
          loc_40FDB6: ldarg.0
          loc_40FDB7: ldarg.1
          loc_40FDB8: stfld GCUv2.cInvoiceNumber::_salesPersonCode
          loc_40FDBD: ret
        }

        public void cInvoiceNumber(int32 SalesPersonId, int32 Year) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          valuetype NumberRange[] var_2;
          int32 num_3;
          valuetype NumberRange var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable SearchInvoiceNumber(int32 intSales, int32 intYear, boolean blnAll, int32 intBranchId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

        public static double GetLatestNumber(int32 intYear, int32 intSalesId, int32 intBranchId, int32 intType) {

          double flt_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static boolean IsUsed(class DataTable MyData, class DataGridView dgvList) {

          boolean var_1;
          int32 num_1;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          int32 num_2;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        public static boolean isExist(string strFaktur, boolean blnFP, valuetype System.DateTime datInput, double intId) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          string str_2;
          class System.Collections.IEnumerator var_6;
          class DataRow var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;

        }

        public static boolean isMyNumber(string strFaktur, boolean blnFP, int32 intSalesId, int32 intYear) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        public static boolean isMyCode(string strFaktur, boolean blnFP, int32 intSalesId) {

          boolean var_1;
          string str_1;
          string str_2;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

    }
}
