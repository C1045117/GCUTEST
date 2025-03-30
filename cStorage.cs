namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _isMarketing;
        private int32 _isReturn;
        private int32 _branchId;
        private string _branchName;
        private int32 _active;
        private boolean _used;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_427B79: nop
          loc_427B7A: ldarg.0
          loc_427B7B: ldarg.1
          loc_427B7C: stfld GCUv2.cStepItem::_id
          loc_427B81: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_427B9D: nop
          loc_427B9E: ldarg.0
          loc_427B9F: ldarg.1
          loc_427BA0: call string GCUv2.Module1::cleanString(string)
          loc_427BA5: stfld GCUv2.cStorage::_name
          loc_427BAA: ret
        }

        public specialname int32 get_IsMarketing() {

          int32 num_1;

        }

        public specialname void set_IsMarketing(int32 value) {

          loc_427BC5: nop
          loc_427BC6: ldarg.0
          loc_427BC7: ldarg.1
          loc_427BC8: stfld GCUv2.cStorage::_isMarketing
          loc_427BCD: ret
        }

        public specialname int32 get_IsReturn() {

          int32 num_1;

        }

        public specialname void set_IsReturn(int32 value) {

          loc_427BE9: nop
          loc_427BEA: ldarg.0
          loc_427BEB: ldarg.1
          loc_427BEC: stfld GCUv2.cStorage::_isReturn
          loc_427BF1: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_427C0D: nop
          loc_427C0E: ldarg.0
          loc_427C0F: ldarg.1
          loc_427C10: stfld GCUv2.cStorage::_branchId
          loc_427C15: ret
        }

        public specialname string get_BranchName() {

          string str_1;

        }

        public specialname void set_BranchName(string value) {

          loc_427C31: nop
          loc_427C32: ldarg.0
          loc_427C33: ldarg.1
          loc_427C34: stfld GCUv2.cStorage::_name
          loc_427C39: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_427C55: nop
          loc_427C56: ldarg.0
          loc_427C57: ldarg.1
          loc_427C58: stfld GCUv2.cStorage::_active
          loc_427C5D: ret
        }

        public specialname boolean get_Used() {

          boolean var_1;

        }

        public specialname void set_Used(boolean value) {

          loc_427C79: nop
          loc_427C7A: ldarg.0
          loc_427C7B: ldarg.1
          loc_427C7C: stfld GCUv2.cStorage::_used
          loc_427C81: ret
        }

        public void cStorage(int32 Id) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;
          boolean var_4;

        }

        public void Save() {

          string str_1;
          boolean var_1;

        }

        public static class DataTable Search(int32 intGroupId, int32 intBranchId, string StorageType, int32 Active) {

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

        }

        public static boolean IsExist(int32 Id, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public void Delete() {

          string str_1;
          boolean var_1;

        }

    }
}
