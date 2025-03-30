using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private valuetype System.DateTime _adjustmentDate;
        private string _description;
        private double _qty;
        private int32 _categoryId;
        private int32 _type;
        private string _typeName;
        private int32 _itemId;
        private string _itemName;
        private int32 _storageId;
        private string _storageName;
        private int32 _currentItem;
        private int32 _currentStorage;
        private valuetype System.DateTime _currentDate;
        private double _currentQty;
        private int32 _currentType;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_403335: nop
          loc_403336: ldarg.0
          loc_403337: ldarg.1
          loc_403338: stfld GCUv2.cAccount::_id
          loc_40333D: ret
        }

        public specialname valuetype System.DateTime get_AdjustmentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_AdjustmentDate(valuetype System.DateTime value) {

          loc_403359: nop
          loc_40335A: ldarg.0
          loc_40335B: ldarg.1
          loc_40335C: stfld GCUv2.cAdjustment::_adjustmentDate
          loc_403361: ret
        }

        public specialname string get_Description() {

          string str_1;

        }

        public specialname void set_Description(string value) {

          loc_40337D: nop
          loc_40337E: ldarg.0
          loc_40337F: ldarg.1
          loc_403380: call string GCUv2.Module1::cleanString(string)
          loc_403385: stfld GCUv2.cAdjustment::_description
          loc_40338A: ret
        }

        public specialname double get_Qty() {

          double flt_1;

        }

        public specialname void set_Qty(double value) {

          loc_4033A5: nop
          loc_4033A6: ldarg.0
          loc_4033A7: ldarg.1
          loc_4033A8: stfld GCUv2.cAdjustment::_qty
          loc_4033AD: ret
        }

        public specialname int32 get_CategoryId() {

          int32 num_1;

        }

        public specialname void set_CategoryId(int32 value) {

          loc_4033C9: nop
          loc_4033CA: ldarg.0
          loc_4033CB: ldarg.1
          loc_4033CC: stfld GCUv2.cAdjustment::_categoryId
          loc_4033D1: ret
        }

        public specialname int32 get_Type() {

          int32 num_1;

        }

        public specialname void set_Type(int32 value) {

          loc_4033ED: nop
          loc_4033EE: ldarg.0
          loc_4033EF: ldarg.1
          loc_4033F0: stfld GCUv2.cAdjustment::_type
          loc_4033F5: ret
        }

        public specialname string get_TypeName() {

          string str_1;

        }

        public specialname void set_TypeName(string value) {

          loc_403411: nop
          loc_403412: ldarg.0
          loc_403413: ldarg.1
          loc_403414: stfld GCUv2.cAdjustment::_typeName
          loc_403419: ret
        }

        public specialname int32 get_ItemId() {

          int32 num_1;

        }

        public specialname void set_ItemId(int32 value) {

          loc_403435: nop
          loc_403436: ldarg.0
          loc_403437: ldarg.1
          loc_403438: stfld GCUv2.cAdjustment::_itemId
          loc_40343D: ret
        }

        public specialname string get_ItemName() {

          string str_1;

        }

        public specialname void set_ItemName(string value) {

          loc_403459: nop
          loc_40345A: ldarg.0
          loc_40345B: ldarg.1
          loc_40345C: stfld GCUv2.cAdjustment::_itemName
          loc_403461: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_40347D: nop
          loc_40347E: ldarg.0
          loc_40347F: ldarg.1
          loc_403480: stfld GCUv2.cAdjustment::_storageId
          loc_403485: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_4034A1: nop
          loc_4034A2: ldarg.0
          loc_4034A3: ldarg.1
          loc_4034A4: stfld GCUv2.cAdjustment::_storageName
          loc_4034A9: ret
        }

        public specialname int32 get_CurrentItem() {

          int32 num_1;

        }

        public specialname void set_CurrentItem(int32 value) {

          loc_4034C5: nop
          loc_4034C6: ldarg.0
          loc_4034C7: ldarg.1
          loc_4034C8: stfld GCUv2.cAdjustment::_currentItem
          loc_4034CD: ret
        }

        public specialname int32 get_CurrentStorage() {

          int32 num_1;

        }

        public specialname void set_CurrentStorage(int32 value) {

          loc_4034E9: nop
          loc_4034EA: ldarg.0
          loc_4034EB: ldarg.1
          loc_4034EC: stfld GCUv2.cAdjustment::_currentStorage
          loc_4034F1: ret
        }

        public specialname valuetype System.DateTime get_CurrentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_CurrentDate(valuetype System.DateTime value) {

          loc_40350D: nop
          loc_40350E: ldarg.0
          loc_40350F: ldarg.1
          loc_403510: stfld GCUv2.cAdjustment::_currentDate
          loc_403515: ret
        }

        public specialname double get_CurrentQty() {

          double flt_1;

        }

        public specialname void set_CurrentQty(double value) {

          loc_403531: nop
          loc_403532: ldarg.0
          loc_403533: ldarg.1
          loc_403534: stfld GCUv2.cAdjustment::_currentQty
          loc_403539: ret
        }

        public specialname int32 get_CurrentType() {

          int32 num_1;

        }

        public specialname void set_CurrentType(int32 value) {

          loc_403555: nop
          loc_403556: ldarg.0
          loc_403557: ldarg.1
          loc_403558: stfld GCUv2.cAdjustment::_currentType
          loc_40355D: ret
        }

        public void cAdjustment(double AdjustmentId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;
          boolean var_4;

        }

        public void save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        public static class DataTable Search(int32 intRange, valuetype System.DateTime dateFirst, valuetype System.DateTime dateLast, int32 CategoryId, int32 TypeId, int32 ItemCategoryId, int32 ItemId, int32 StorageId, int32 GroupId, int32 BranchId) {

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

        }

        public void Delete() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          boolean var_2;
          boolean var_3;

        }

    }
}
