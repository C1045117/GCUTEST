namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _active;
        private boolean _used;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_415955: nop
          loc_415956: ldarg.0
          loc_415957: ldarg.1
          loc_415958: stfld GCUv2.cItem::_id
          loc_41595D: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_415979: nop
          loc_41597A: ldarg.0
          loc_41597B: ldarg.1
          loc_41597C: stfld GCUv2.cItemCategory::_name
          loc_415981: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_41599D: nop
          loc_41599E: ldarg.0
          loc_41599F: ldarg.1
          loc_4159A0: stfld GCUv2.cItemCategory::_active
          loc_4159A5: ret
        }

        public specialname boolean get_Used() {

          boolean var_1;

        }

        public specialname void set_Used(boolean value) {

          loc_4159C1: nop
          loc_4159C2: ldarg.0
          loc_4159C3: ldarg.1
          loc_4159C4: stfld GCUv2.cItemCategory::_used
          loc_4159C9: ret
        }

        public override strict string ToString() {

          string str_1;

        }

        public void cItemCategory(int32 CatId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable getItemCategory(int32 GroupId, boolean Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public void Save() {

          string str_1;
          boolean var_1;

        }

        public void Delete() {

          string str_1;
          boolean var_1;

        }

    }
}
