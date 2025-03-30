namespace GCUv2
{
    public class 
    {

        private int32 _id;
        private string _name;
        private int32 _processType;
        private int32 _allowPurchase;
        private int32 _allowComponent;
        private int32 _allowProcess;
        private int32 _allowEditStockQty;
        private int32 _hasParkedQty;
        private int32 _hasDeduction;
        private int32 _hasExtraPrice;
        private int32 _catId;
        private int32 _productionStepId;
        private int32 _typeId;
        private int32 _flower;
        private int32 _active;
        private class GCUv2.cItemStorage[] _storage;
        private class GCUv2.cItemPurchasePrice[] _purchasePrice;
        private class GCUv2.cItemComponent[] _component;
        private class GCUv2.cItemStandardComponent[] _standardComponent;
        private class GCUv2.cItemStandardUsage[] _standardUsage;
        private class GCUv2.cItemGroup[] _group;
        private string _generalType;
        private string _longName;
        private string _packaging;
        private int32 _isTehGopek;
        private int32 _allowSell;
        private string _largeUnit;
        private string _unitName1;
        private string _unitName2;
        private string _unitName3;
        private string _unitName4;
        private double _unitQty2;
        private double _unitQty3;
        private double _unitQty4;
        private int32 _inventoryAccountId;


        public specialname int32 get_Id() {

          int32 num_1;

        }

        public specialname void set_Id(int32 value) {

          loc_41336D: nop
          loc_41336E: ldarg.0
          loc_41336F: ldarg.1
          loc_413370: stfld GCUv2.cPurchaseInvoiceReturn::_id
          loc_413375: ret
        }

        public specialname string get_Name() {

          string str_1;

        }

        public specialname void set_Name(string value) {

          loc_413391: nop
          loc_413392: ldarg.0
          loc_413393: ldarg.1
          loc_413394: call string GCUv2.Module1::cleanString(string)
          loc_413399: stfld GCUv2.cItem::_name
          loc_41339E: ret
        }

        public specialname int32 get_ProcessType() {

          int32 num_1;

        }

        public specialname void set_ProcessType(int32 value) {

          loc_4133B9: nop
          loc_4133BA: ldarg.0
          loc_4133BB: ldarg.1
          loc_4133BC: stfld GCUv2.cItem::_processType
          loc_4133C1: ret
        }

        public specialname int32 get_AllowPurchase() {

          int32 num_1;

        }

        public specialname void set_AllowPurchase(int32 value) {

          loc_4133DD: nop
          loc_4133DE: ldarg.0
          loc_4133DF: ldarg.1
          loc_4133E0: stfld GCUv2.cItem::_allowPurchase
          loc_4133E5: ret
        }

        public specialname int32 get_AllowComponent() {

          int32 num_1;

        }

        public specialname void set_AllowComponent(int32 value) {

          loc_413401: nop
          loc_413402: ldarg.0
          loc_413403: ldarg.1
          loc_413404: stfld GCUv2.cItem::_allowComponent
          loc_413409: ret
        }

        public specialname int32 get_AllowProcess() {

          int32 num_1;

        }

        public specialname void set_AllowProcess(int32 value) {

          loc_413425: nop
          loc_413426: ldarg.0
          loc_413427: ldarg.1
          loc_413428: stfld GCUv2.cItem::_allowProcess
          loc_41342D: ret
        }

        public specialname int32 get_AllowEditStockQty() {

          int32 num_1;

        }

        public specialname void set_AllowEditStockQty(int32 value) {

          loc_413449: nop
          loc_41344A: ldarg.0
          loc_41344B: ldarg.1
          loc_41344C: stfld GCUv2.cItem::_allowEditStockQty
          loc_413451: ret
        }

        public specialname int32 get_HasParkedQty() {

          int32 num_1;

        }

        public specialname void set_HasParkedQty(int32 value) {

          loc_41346D: nop
          loc_41346E: ldarg.0
          loc_41346F: ldarg.1
          loc_413470: stfld GCUv2.cItem::_hasParkedQty
          loc_413475: ret
        }

        public specialname int32 get_HasDeduction() {

          int32 num_1;

        }

        public specialname void set_HasDeduction(int32 value) {

          loc_413491: nop
          loc_413492: ldarg.0
          loc_413493: ldarg.1
          loc_413494: stfld GCUv2.cItem::_hasDeduction
          loc_413499: ret
        }

        public specialname int32 get_HasExtraPrice() {

          int32 num_1;

        }

        public specialname void set_HasExtraPrice(int32 value) {

          loc_4134B5: nop
          loc_4134B6: ldarg.0
          loc_4134B7: ldarg.1
          loc_4134B8: stfld GCUv2.cItem::_hasExtraPrice
          loc_4134BD: ret
        }

        public specialname int32 get_CatId() {

          int32 num_1;

        }

        public specialname void set_CatId(int32 value) {

          loc_4134D9: nop
          loc_4134DA: ldarg.0
          loc_4134DB: ldarg.1
          loc_4134DC: stfld GCUv2.cItem::_catId
          loc_4134E1: ret
        }

        public specialname int32 get_ProductionStepId() {

          int32 num_1;

        }

        public specialname void set_ProductionStepId(int32 value) {

          loc_4134FD: nop
          loc_4134FE: ldarg.0
          loc_4134FF: ldarg.1
          loc_413500: stfld GCUv2.cItem::_productionStepId
          loc_413505: ret
        }

        public specialname int32 get_TypeId() {

          int32 num_1;

        }

        public specialname void set_TypeId(int32 value) {

          loc_413521: nop
          loc_413522: ldarg.0
          loc_413523: ldarg.1
          loc_413524: stfld GCUv2.cItem::_typeId
          loc_413529: ret
        }

        public specialname int32 get_Flower() {

          int32 num_1;

        }

        public specialname void set_Flower(int32 value) {

          loc_413545: nop
          loc_413546: ldarg.0
          loc_413547: ldarg.1
          loc_413548: stfld GCUv2.cItem::_flower
          loc_41354D: ret
        }

        public specialname int32 get_Active() {

          int32 num_1;

        }

        public specialname void set_Active(int32 value) {

          loc_413569: nop
          loc_41356A: ldarg.0
          loc_41356B: ldarg.1
          loc_41356C: stfld GCUv2.cItem::_active
          loc_413571: ret
        }

        public specialname class GCUv2.cItemStorage[] get_Storage() {

          class GCUv2.cItemStorage[] var_1;

        }

        public specialname void set_Storage(class GCUv2.cItemStorage[] value) {

          loc_41358D: nop
          loc_41358E: ldarg.0
          loc_41358F: ldarg.1
          loc_413590: stfld GCUv2.cItem::_storage
          loc_413595: ret
        }

        public specialname class GCUv2.cItemPurchasePrice[] get_PurchasePrice() {

          class GCUv2.cItemPurchasePrice[] var_1;

        }

        public specialname void set_PurchasePrice(class GCUv2.cItemPurchasePrice[] value) {

          loc_4135B1: nop
          loc_4135B2: ldarg.0
          loc_4135B3: ldarg.1
          loc_4135B4: stfld GCUv2.cItem::_purchasePrice
          loc_4135B9: ret
        }

        public specialname class GCUv2.cItemComponent[] get_Component() {

          class GCUv2.cItemComponent[] var_1;

        }

        public specialname void set_Component(class GCUv2.cItemComponent[] value) {

          loc_4135D5: nop
          loc_4135D6: ldarg.0
          loc_4135D7: ldarg.1
          loc_4135D8: stfld GCUv2.cItem::_component
          loc_4135DD: ret
        }

        public specialname class GCUv2.cItemStandardComponent[] get_StandardComponent() {

          class GCUv2.cItemStandardComponent[] var_1;

        }

        public specialname void set_StandardComponent(class GCUv2.cItemStandardComponent[] value) {

          loc_4135F9: nop
          loc_4135FA: ldarg.0
          loc_4135FB: ldarg.1
          loc_4135FC: stfld GCUv2.cItem::_standardComponent
          loc_413601: ret
        }

        public specialname class GCUv2.cItemStandardUsage[] get_StandardUsage() {

          class GCUv2.cItemStandardUsage[] var_1;

        }

        public specialname void set_StandardUsage(class GCUv2.cItemStandardUsage[] value) {

          loc_41361D: nop
          loc_41361E: ldarg.0
          loc_41361F: ldarg.1
          loc_413620: stfld GCUv2.cItem::_standardUsage
          loc_413625: ret
        }

        public specialname class GCUv2.cItemGroup[] get_Group() {

          class GCUv2.cItemGroup[] var_1;

        }

        public specialname void set_Group(class GCUv2.cItemGroup[] value) {

          loc_413641: nop
          loc_413642: ldarg.0
          loc_413643: ldarg.1
          loc_413644: stfld GCUv2.cItem::_group
          loc_413649: ret
        }

        public specialname string get_GeneralType() {

          string str_1;

        }

        public specialname void set_GeneralType(string value) {

          loc_413665: nop
          loc_413666: ldarg.0
          loc_413667: ldarg.1
          loc_413668: stfld GCUv2.cItem::_generalType
          loc_41366D: ret
        }

        public specialname string get_LongName() {

          string str_1;

        }

        public specialname void set_LongName(string value) {

          loc_413689: nop
          loc_41368A: ldarg.0
          loc_41368B: ldarg.1
          loc_41368C: call string GCUv2.Module1::cleanString(string)
          loc_413691: stfld GCUv2.cItem::_longName
          loc_413696: ret
        }

        public specialname string get_Packaging() {

          string str_1;

        }

        public specialname void set_Packaging(string value) {

          loc_4136B1: nop
          loc_4136B2: ldarg.0
          loc_4136B3: ldarg.1
          loc_4136B4: call string GCUv2.Module1::cleanString(string)
          loc_4136B9: stfld GCUv2.cItem::_packaging
          loc_4136BE: ret
        }

        public specialname int32 get_AllowSell() {

          int32 num_1;

        }

        public specialname void set_AllowSell(int32 value) {

          loc_4136D9: nop
          loc_4136DA: ldarg.0
          loc_4136DB: ldarg.1
          loc_4136DC: stfld GCUv2.cItem::_allowSell
          loc_4136E1: ret
        }

        public specialname int32 get_IsTehGopek() {

          int32 num_1;

        }

        public specialname void set_IsTehGopek(int32 value) {

          loc_4136FD: nop
          loc_4136FE: ldarg.0
          loc_4136FF: ldarg.1
          loc_413700: stfld GCUv2.cItem::_isTehGopek
          loc_413705: ret
        }

        public specialname string get_LargeUnit() {

          string str_1;

        }

        public specialname void set_LargeUnit(string value) {

          loc_413721: nop
          loc_413722: ldarg.0
          loc_413723: ldarg.1
          loc_413724: stfld GCUv2.cItem::_largeUnit
          loc_413729: ret
        }

        public specialname string get_UnitName1() {

          string str_1;

        }

        public specialname void set_UnitName1(string value) {

          loc_413745: nop
          loc_413746: ldarg.0
          loc_413747: ldarg.1
          loc_413748: stfld GCUv2.cItem::_unitName1
          loc_41374D: ret
        }

        public specialname string get_UnitName2() {

          string str_1;

        }

        public specialname void set_UnitName2(string value) {

          loc_413769: nop
          loc_41376A: ldarg.0
          loc_41376B: ldarg.1
          loc_41376C: stfld GCUv2.cItem::_unitName2
          loc_413771: ret
        }

        public specialname string get_UnitName3() {

          string str_1;

        }

        public specialname void set_UnitName3(string value) {

          loc_41378D: nop
          loc_41378E: ldarg.0
          loc_41378F: ldarg.1
          loc_413790: stfld GCUv2.cItem::_unitName3
          loc_413795: ret
        }

        public specialname string get_UnitName4() {

          string str_1;

        }

        public specialname void set_UnitName4(string value) {

          loc_4137B1: nop
          loc_4137B2: ldarg.0
          loc_4137B3: ldarg.1
          loc_4137B4: stfld GCUv2.cItem::_unitName4
          loc_4137B9: ret
        }

        public specialname double get_UnitQty2() {

          double flt_1;

        }

        public specialname void set_UnitQty2(double value) {

          loc_4137D5: nop
          loc_4137D6: ldarg.0
          loc_4137D7: ldarg.1
          loc_4137D8: stfld GCUv2.cItem::_unitQty2
          loc_4137DD: ret
        }

        public specialname double get_UnitQty3() {

          double flt_1;

        }

        public specialname void set_UnitQty3(double value) {

          loc_4137F9: nop
          loc_4137FA: ldarg.0
          loc_4137FB: ldarg.1
          loc_4137FC: stfld GCUv2.cItem::_unitQty3
          loc_413801: ret
        }

        public specialname double get_UnitQty4() {

          double flt_1;

        }

        public specialname void set_UnitQty4(double value) {

          loc_41381D: nop
          loc_41381E: ldarg.0
          loc_41381F: ldarg.1
          loc_413820: stfld GCUv2.cItem::_unitQty4
          loc_413825: ret
        }

        public specialname int32 get_InventoryAccountId() {

          int32 num_1;

        }

        public specialname void set_InventoryAccountId(int32 value) {

          loc_413841: nop
          loc_413842: ldarg.0
          loc_413843: ldarg.1
          loc_413844: stfld GCUv2.cItem::_inventoryAccountId
          loc_413849: ret
        }

        public void cItem(int32 ItemId) {

          boolean var_1;
          class DataTable var_2;
          string str_1;
          int32 num_1;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class System.Collections.IEnumerator var_6;
          class DataRow var_7;
          boolean var_8;
          class System.Collections.IEnumerator var_9;
          class DataRow var_10;
          boolean var_11;
          class System.Collections.IEnumerator var_12;
          class DataRow var_13;
          boolean var_14;
          class System.Collections.IEnumerator var_15;
          class DataRow var_16;
          boolean var_17;
          class System.Collections.IEnumerator var_18;
          class DataRow var_19;
          boolean var_20;
          class System.Collections.IEnumerator var_21;
          class DataRow var_22;
          boolean var_23;

        }

        public double GetPurchasePrice(int32 SupplierId, valuetype System.DateTime PurchaseDate) {

          double flt_1;
          class GCUv2.cItemPurchasePrice[] var_1;
          int32 num_1;
          class GCUv2.cItemPurchasePrice var_2;
          boolean var_3;
          boolean var_4;

        }

        public void Save() {

          int32 num_1;
          int32 num_2;
          string str_1;
          class MySqlClient.MySqlTransaction var_1;
          class DataTable var_2;
          double flt_1;
          boolean var_3;
          class GCUv2.cItemStorage[] var_4;
          int32 num_3;
          class GCUv2.cItemStorage var_5;
          boolean var_6;
          class GCUv2.cItemPurchasePrice[] var_7;
          int32 num_4;
          class GCUv2.cItemPurchasePrice var_8;
          boolean var_9;
          boolean var_10;
          class GCUv2.cItemComponent[] var_11;
          int32 num_5;
          class GCUv2.cItemComponent var_12;
          boolean var_13;
          boolean var_14;
          class GCUv2.cItemStandardComponent[] var_15;
          int32 num_6;
          class GCUv2.cItemStandardComponent var_16;
          boolean var_17;
          boolean var_18;
          class GCUv2.cItemStandardUsage[] var_19;
          int32 num_7;
          class GCUv2.cItemStandardUsage var_20;
          boolean var_21;
          boolean var_22;
          class GCUv2.cItemGroup[] var_23;
          int32 num_8;
          class GCUv2.cItemGroup var_24;
          boolean var_25;
          boolean var_26;

        }

        public static boolean IsExist(int32 Id, string Name) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

        public static class DataTable getItem(int32 Active) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static class DataTable Search(int32 AllowPurchase, int32 AllowProduction, int32 StepId, int32 IsComponent, int32 ProductionItemId, int32 ProductionStepId, int32 AllowSell, int32 ItemTypeId, int32 ItemCategoryId, int32 SupplierId, int32 StorageId1, int32 StorageId2, double CustomerId, boolean CanBeUsedAsGroupMember, int32 GroupId, int32 BranchId, int32 Active) {

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
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;

        }

        public static class DataTable GetItemStorage(int32 ItemId, string StorageType, int32 BranchId, int32 GroupId) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public static int32 GetItemType(int32 itemId) {

          int32 num_1;
          string str_1;
          class DataTable var_1;
          boolean var_2;

        }

        public static class DataTable SearchItemUnit(int32 itemId, int32 SupplierId) {

          class DataTable var_1;
          string str_1;

        }

        public static int32 GetTypeId(int32 ItemId) {

          int32 num_1;
          string str_1;
          class DataTable var_1;

        }

        public static double GetItemId(string ItemName) {

          double flt_1;
          string str_1;
          class DataTable var_1;

        }

        public static int32 GetInventoryAccountId(int32 itemId) {

          int32 num_1;
          string str_1;
          class DataTable var_1;

        }

    }
}
