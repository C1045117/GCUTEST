using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _processDate;
        private double _qty;
        private int32 _itemId;
        private string _itemName;
        private int32 _storageId;
        private string _storageName;
        private valuetype System.DateTime _createdDate;
        private class GCUv2.cComponent[] _component;
        private int32 _currentStorage;
        private class GCUv2.cComponent[] _currentComponent;
        private valuetype System.DateTime _currentDate;
        private int32 _currentItem;
        private double _currentQty;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_415CE1: nop
          loc_415CE2: ldarg.0
          loc_415CE3: ldarg.1
          loc_415CE4: stfld GCUv2.cComboItemMenu::_id
          loc_415CE9: ret
        }

        public specialname valuetype System.DateTime get_ProcessDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ProcessDate(valuetype System.DateTime value) {

          loc_415D05: nop
          loc_415D06: ldarg.0
          loc_415D07: ldarg.1
          loc_415D08: stfld GCUv2.cProcess::_processDate
          loc_415D0D: ret
        }

        public specialname double get_Qty() {

          double flt_1;

        }

        public specialname void set_Qty(double value) {

          loc_415D29: nop
          loc_415D2A: ldarg.0
          loc_415D2B: ldarg.1
          loc_415D2C: stfld GCUv2.cProcess::_qty
          loc_415D31: ret
        }

        public specialname int32 get_ItemId() {

          int32 num_1;

        }

        public specialname void set_ItemId(int32 value) {

          loc_415D4D: nop
          loc_415D4E: ldarg.0
          loc_415D4F: ldarg.1
          loc_415D50: stfld GCUv2.cProcess::_itemId
          loc_415D55: ret
        }

        public specialname string get_ItemName() {

          string str_1;

        }

        public specialname void set_ItemName(string value) {

          loc_415D71: nop
          loc_415D72: ldarg.0
          loc_415D73: ldarg.1
          loc_415D74: stfld GCUv2.cProcess::_itemName
          loc_415D79: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_415D95: nop
          loc_415D96: ldarg.0
          loc_415D97: ldarg.1
          loc_415D98: stfld GCUv2.cProcess::_storageId
          loc_415D9D: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_415DB9: nop
          loc_415DBA: ldarg.0
          loc_415DBB: ldarg.1
          loc_415DBC: stfld GCUv2.cProcess::_storageName
          loc_415DC1: ret
        }

        public specialname valuetype System.DateTime get_CreatedDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CreatedDate(valuetype System.DateTime value) {

          loc_415DDD: nop
          loc_415DDE: ldarg.0
          loc_415DDF: ldarg.1
          loc_415DE0: stfld GCUv2.cProcess::_createdDate
          loc_415DE5: ret
        }

        public specialname class GCUv2.cComponent[] get_Component() {

          class GCUv2.cComponent[] var_1;

        }

        public specialname void set_Component(class GCUv2.cComponent[] value) {

          loc_415E01: nop
          loc_415E02: ldarg.0
          loc_415E03: ldarg.1
          loc_415E04: stfld GCUv2.cProcess::_component
          loc_415E09: ret
        }

        public specialname class GCUv2.cComponent[] get_CurrentComponent() {

          class GCUv2.cComponent[] var_1;

        }

        public specialname void set_CurrentComponent(class GCUv2.cComponent[] value) {

          loc_415E25: nop
          loc_415E26: ldarg.0
          loc_415E27: ldarg.1
          loc_415E28: stfld GCUv2.cProcess::_currentComponent
          loc_415E2D: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_415E49: nop
          loc_415E4A: ldarg.0
          loc_415E4B: ldarg.1
          loc_415E4C: stfld GCUv2.cProcess::_currentStorage
          loc_415E51: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_415E6D: nop
          loc_415E6E: ldarg.0
          loc_415E6F: ldarg.1
          loc_415E70: stfld GCUv2.cProcess::_currentDate
          loc_415E75: ret
        }

        public specialname int32 get_CurrentItem() {

          int32 num_1;

        }

        public specialname void set_CurrentItem(int32 value) {

          loc_415E91: nop
          loc_415E92: ldarg.0
          loc_415E93: ldarg.1
          loc_415E94: stfld GCUv2.cProcess::_currentItem
          loc_415E99: ret
        }

        public specialname double get_CurrentQty() {

          double flt_1;

        }

        public specialname void set_CurrentQty(double value) {

          loc_415EB5: nop
          loc_415EB6: ldarg.0
          loc_415EB7: ldarg.1
          loc_415EB8: stfld GCUv2.cProcess::_currentQty
          loc_415EBD: ret
        }

        public void cProcess(double ProcessId) {

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
          int32 num_3;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          boolean var_3;
          int32 num_4;
          boolean var_4;
          class GCUv2.cComponent[] var_5;
          int32 num_5;
          class GCUv2.cComponent var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          int32 num_3;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          int32 num_4;
          boolean var_3;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 intItemId, int32 intStepId, int32 intStoreId, int32 intBranchId, int32 intGroupId, boolean blnShowComponent) {

          class DataTable var_1;
          string str_1;
          string str_2;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;

        }

    }
}
