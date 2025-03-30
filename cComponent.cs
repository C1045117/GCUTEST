using mscorlib;

namespace GCUv2
{
    public class 
    {

        private double _id;
        private int32 _itemId;
        private string _itemName;
        private valuetype System.DateTime _componentDate;
        private double _qty;
        private int32 _storageId;
        private string _storageName;
        private double _processId;


        public specialname double get_Id() {

          double flt_1;

        }

        public specialname void set_Id(double value) {

          loc_409931: nop
          loc_409932: ldarg.0
          loc_409933: ldarg.1
          loc_409934: stfld GCUv2.cChequeOut::_id
          loc_409939: ret
        }

        public specialname int32 get_ItemId() {

          int32 num_1;

        }

        public specialname void set_ItemId(int32 value) {

          loc_409955: nop
          loc_409956: ldarg.0
          loc_409957: ldarg.1
          loc_409958: stfld GCUv2.cComponent::_itemId
          loc_40995D: ret
        }

        public specialname string get_ItemName() {

          string str_1;

        }

        public specialname void set_ItemName(string value) {

          loc_409979: nop
          loc_40997A: ldarg.0
          loc_40997B: ldarg.1
          loc_40997C: stfld GCUv2.cComponent::_itemName
          loc_409981: ret
        }

        public specialname double get_Qty() {

          double flt_1;

        }

        public specialname void set_Qty(double value) {

          loc_40999D: nop
          loc_40999E: ldarg.0
          loc_40999F: ldarg.1
          loc_4099A0: stfld GCUv2.cComponent::_qty
          loc_4099A5: ret
        }

        public specialname valuetype System.DateTime get_ComponentDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ComponentDate(valuetype System.DateTime value) {

          loc_4099C1: nop
          loc_4099C2: ldarg.0
          loc_4099C3: ldarg.1
          loc_4099C4: stfld GCUv2.cComponent::_componentDate
          loc_4099C9: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_4099E5: nop
          loc_4099E6: ldarg.0
          loc_4099E7: ldarg.1
          loc_4099E8: stfld GCUv2.cComponent::_storageId
          loc_4099ED: ret
        }

        public specialname string get_StorageName() {

          string str_1;

        }

        public specialname void set_StorageName(string value) {

          loc_409A09: nop
          loc_409A0A: ldarg.0
          loc_409A0B: ldarg.1
          loc_409A0C: stfld GCUv2.cComponent::_storageName
          loc_409A11: ret
        }

        public specialname double get_ProcessId() {

          double flt_1;

        }

        public specialname void set_ProcessId(double value) {

          loc_409A2D: nop
          loc_409A2E: ldarg.0
          loc_409A2F: ldarg.1
          loc_409A30: stfld GCUv2.cComponent::_processId
          loc_409A35: ret
        }

        public void cComponent(double ComponentId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          boolean var_3;

        }

        public static class DataTable GetStandardComponent(int32 ItemId, int32 StorageId, double Qty, valuetype System.DateTime ProcessDate) {

          class DataTable var_1;
          string str_1;
          boolean var_2;

        }

        public static class DataTable Search(valuetype System.DateTime FirstDate, valuetype System.DateTime LastDate, int32 ItemId, int32 ItemCategoryId, int32 StorageId, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          string str_2;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

    }
}
