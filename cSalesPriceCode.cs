namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private class GCUv2.cSalesPriceCodeItem[] _item;
        private int32 _active;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_422D05: nop
          loc_422D06: ldarg.0
          loc_422D07: ldarg.1
          loc_422D08: stfld GCUv2.cSalesPerson::_id
          loc_422D0D: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_422D29: nop
          loc_422D2A: ldarg.0
          loc_422D2B: ldarg.1
          loc_422D2C: call string GCUv2.Module1::cleanString(string)
          loc_422D31: stfld GCUv2.cSalesPriceCode::_name
          loc_422D36: ret
        }

        public specialname class GCUv2.cSalesPriceCodeItem[] get_Item() {

          class GCUv2.cSalesPriceCodeItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cSalesPriceCodeItem[] value) {

          loc_422D51: nop
          loc_422D52: ldarg.0
          loc_422D53: ldarg.1
          loc_422D54: stfld GCUv2.cSalesPriceCode::_item
          loc_422D59: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_422D75: nop
          loc_422D76: ldarg.0
          loc_422D77: ldarg.1
          loc_422D78: stfld GCUv2.cSalesPriceCode::_active
          loc_422D7D: ret
        }

        public void cSalesPriceCode(int32 Id) {

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

          string str_1;
          boolean var_1;
          class GCUv2.cSalesPriceCodeItem[] var_2;
          int32 num_1;
          class GCUv2.cSalesPriceCodeItem var_3;
          boolean var_4;

        }

        public static class DataTable Search(int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static boolean IsExist(int32 Id, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public static double GetPrice(int32 ItemId, double CustomerId) {

          double flt_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;

        }

    }
}
