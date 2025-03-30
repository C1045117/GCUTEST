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

          loc_404255: nop
          loc_404256: ldarg.0
          loc_404257: ldarg.1
          loc_404258: stfld GCUv2.cArea::_id
          loc_40425D: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_404279: nop
          loc_40427A: ldarg.0
          loc_40427B: ldarg.1
          loc_40427C: call string GCUv2.Module1::cleanString(string)
          loc_404281: stfld GCUv2.cBank::_name
          loc_404286: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_4042A1: nop
          loc_4042A2: ldarg.0
          loc_4042A3: ldarg.1
          loc_4042A4: stfld GCUv2.cBank::_active
          loc_4042A9: ret
        }

        public void cBank(int32 Id) {

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
