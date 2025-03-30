namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _active;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_40BBDD: nop
          loc_40BBDE: ldarg.0
          loc_40BBDF: ldarg.1
          loc_40BBE0: stfld GCUv2.cCustomer::_id
          loc_40BBE5: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_40BC01: nop
          loc_40BC02: ldarg.0
          loc_40BC03: ldarg.1
          loc_40BC04: call string GCUv2.Module1::cleanString(string)
          loc_40BC09: stfld GCUv2.cCustomerCode::_name
          loc_40BC0E: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_40BC29: nop
          loc_40BC2A: ldarg.0
          loc_40BC2B: ldarg.1
          loc_40BC2C: stfld GCUv2.cCustomerCode::_active
          loc_40BC31: ret
        }

        public void cCustomerCode(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void save() {

          string str_1;
          boolean var_1;

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

    }
}
