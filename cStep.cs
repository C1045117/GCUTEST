namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private class GCUv2.cStepItem[] _item;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_423FDD: nop
          loc_423FDE: ldarg.0
          loc_423FDF: ldarg.1
          loc_423FE0: stfld GCUv2.cSetting::_id
          loc_423FE5: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_424001: nop
          loc_424002: ldarg.0
          loc_424003: ldarg.1
          loc_424004: stfld GCUv2.cStep::_name
          loc_424009: ret
        }

        public specialname class GCUv2.cStepItem[] get_Item() {

          class GCUv2.cStepItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cStepItem[] value) {

          loc_424025: nop
          loc_424026: ldarg.0
          loc_424027: ldarg.1
          loc_424028: stfld GCUv2.cStep::_item
          loc_42402D: ret
        }

        public void cStep(double StepId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          class System.Collections.IEnumerator var_4;
          class DataRow var_5;
          boolean var_6;

        }

        public void save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          class GCUv2.cStepItem[] var_3;
          int32 num_3;
          class GCUv2.cStepItem var_4;
          boolean var_5;
          boolean var_6;

        }

        public static class DataTable GetStep() {

          class DataTable var_1;
          string str_1;

        }

        public static class DataTable GetComponent(int32 StepId) {

          class DataTable var_1;
          string str_1;

        }

    }
}
