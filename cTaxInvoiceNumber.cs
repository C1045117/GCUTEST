namespace GCUv2
{
    public class 
    {

        private int32 _branchId;
        private int32 _year;
        private double _latestNumber;
        private valuetype NumberRange[] _range;

        public struct NumberRange
        {
            public double _begin;
            public double _end;
        }


        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_428AF1: nop
          loc_428AF2: ldarg.0
          loc_428AF3: ldarg.1
          loc_428AF4: stfld GCUv2.cSupplier::_branchId
          loc_428AF9: ret
        }

        public specialname int32 get_Year() {

          int32 num_1;

        }

        public specialname void set_Year(int32 value) {

          loc_428B15: nop
          loc_428B16: ldarg.0
          loc_428B17: ldarg.1
          loc_428B18: stfld GCUv2.cTaxInvoiceNumber::_year
          loc_428B1D: ret
        }

        public specialname double get_LatestNumber() {

          double flt_1;

        }

        public specialname void set_LatestNumber(double value) {

          loc_428B39: nop
          loc_428B3A: ldarg.0
          loc_428B3B: ldarg.1
          loc_428B3C: stfld GCUv2.cTaxInvoiceNumber::_latestNumber
          loc_428B41: ret
        }

        public specialname valuetype NumberRange[] get_Range() {

          valuetype NumberRange[] var_1;

        }

        public specialname void set_Range(valuetype NumberRange[] value) {

          loc_428B5D: nop
          loc_428B5E: ldarg.0
          loc_428B5F: ldarg.1
          loc_428B60: stfld GCUv2.cTaxInvoiceNumber::_range
          loc_428B65: ret
        }

        public void cTaxInvoiceNumber(int32 BranchId, int32 Year) {

          boolean var_1;
          class DataTable var_2;
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

        public static class DataTable SearchTaxInvoiceNumber(int32 BranchId, int32 Year, boolean All) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

    }
}
