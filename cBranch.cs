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

          loc_405661: nop
          loc_405662: ldarg.0
          loc_405663: ldarg.1
          loc_405664: stfld GCUv2.cBank::_id
          loc_405669: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_405685: nop
          loc_405686: ldarg.0
          loc_405687: ldarg.1
          loc_405688: call string GCUv2.Module1::cleanString(string)
          loc_40568D: stfld GCUv2.cBranch::_name
          loc_405692: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_4056AD: nop
          loc_4056AE: ldarg.0
          loc_4056AF: ldarg.1
          loc_4056B0: stfld GCUv2.cBranch::_active
          loc_4056B5: ret
        }

        public void cBranch(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void save() {

          string str_1;
          boolean var_1;

        }

        public static class DataTable Search(int32 GroupId, int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static boolean IsExist(int32 BranchId, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
