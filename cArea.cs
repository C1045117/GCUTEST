namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _branchId;
        private string _branchName;
        private int32 _active;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_403E81: nop
          loc_403E82: ldarg.0
          loc_403E83: ldarg.1
          loc_403E84: stfld GCUv2.cAdjustment::_id
          loc_403E89: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_403EA5: nop
          loc_403EA6: ldarg.0
          loc_403EA7: ldarg.1
          loc_403EA8: call string GCUv2.Module1::cleanString(string)
          loc_403EAD: stfld GCUv2.cArea::_name
          loc_403EB2: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_403ECD: nop
          loc_403ECE: ldarg.0
          loc_403ECF: ldarg.1
          loc_403ED0: stfld GCUv2.cArea::_branchId
          loc_403ED5: ret
        }

        public specialname string get_BranchName() {

          string str_1;

        }

        public specialname void set_BranchName(string value) {

          loc_403EF1: nop
          loc_403EF2: ldarg.0
          loc_403EF3: ldarg.1
          loc_403EF4: stfld GCUv2.cArea::_branchName
          loc_403EF9: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_403F15: nop
          loc_403F16: ldarg.0
          loc_403F17: ldarg.1
          loc_403F18: stfld GCUv2.cArea::_active
          loc_403F1D: ret
        }

        public void cArea(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public void Save() {

          string str_1;
          boolean var_1;

        }

        public static class DataTable Search(int32 BranchId, int32 GroupId, int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        public static boolean IsExist(int32 Id, int32 BranchId, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

    }
}
