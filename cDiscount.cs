namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _type;
        private string _percentage;
        private int32 _canBeOverwritten;
        private valuetype DiscountQty[] _qty;
        private int32 _active;

        public struct DiscountQty
        {
            public double _begin;
            public double _end;
            public double _value;
        }


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_40D481: nop
          loc_40D482: ldarg.0
          loc_40D483: ldarg.1
          loc_40D484: stfld GCUv2.cDeliveryOrderItem::_id
          loc_40D489: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_40D4A5: nop
          loc_40D4A6: ldarg.0
          loc_40D4A7: ldarg.1
          loc_40D4A8: call string GCUv2.Module1::cleanString(string)
          loc_40D4AD: stfld GCUv2.cDiscount::_name
          loc_40D4B2: ret
        }

        public specialname int32 get_Type() {

          int32 num_1;

        }

        public specialname void set_Type(int32 value) {

          loc_40D4CD: nop
          loc_40D4CE: ldarg.0
          loc_40D4CF: ldarg.1
          loc_40D4D0: stfld GCUv2.cDiscount::_type
          loc_40D4D5: ret
        }

        public specialname string get_Percentage() {

          string str_1;

        }

        public specialname void set_Percentage(string value) {

          loc_40D4F1: nop
          loc_40D4F2: ldarg.0
          loc_40D4F3: ldarg.1
          loc_40D4F4: stfld GCUv2.cDiscount::_percentage
          loc_40D4F9: ret
        }

        public specialname int32 get_CanBeOverwritten() {

          int32 num_1;

        }

        public specialname void set_CanBeOverwritten(int32 value) {

          loc_40D515: nop
          loc_40D516: ldarg.0
          loc_40D517: ldarg.1
          loc_40D518: stfld GCUv2.cDiscount::_canBeOverwritten
          loc_40D51D: ret
        }

        public specialname valuetype DiscountQty[] get_Qty() {

          valuetype DiscountQty[] var_1;

        }

        public specialname void set_Qty(valuetype DiscountQty[] value) {

          loc_40D539: nop
          loc_40D53A: ldarg.0
          loc_40D53B: ldarg.1
          loc_40D53C: stfld GCUv2.cDiscount::_qty
          loc_40D541: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_40D55D: nop
          loc_40D55E: ldarg.0
          loc_40D55F: ldarg.1
          loc_40D560: stfld GCUv2.cDiscount::_active
          loc_40D565: ret
        }

        public void cDiscount(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          boolean var_3;
          valuetype DiscountQty[] var_4;
          int32 num_3;
          valuetype DiscountQty var_5;
          boolean var_6;
          boolean var_7;

        }

        public static class DataTable Search(boolean Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

        public static boolean IsExist(int32 Id, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public static double CalculateDiscount(int32 discountId, double totalPrice, double totalItem) {

          double flt_1;
          class GCUv2.cDiscount var_1;
          double flt_2;
          boolean var_2;
          string[] var_3;
          string str_1;
          double flt_3;
          string[] var_4;
          int32 num_1;
          boolean var_5;
          boolean var_6;
          valuetype DiscountQty[] var_7;
          int32 num_2;
          valuetype DiscountQty var_8;
          boolean var_9;
          boolean var_10;

        }

    }
}
