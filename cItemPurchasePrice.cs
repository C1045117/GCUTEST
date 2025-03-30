using mscorlib;

namespace GCUv2
{
    public class 
    {

        private int32 _itemId;
        private int32 _supplierId;
        private string _supplierName;
        private valuetype System.DateTime _purchaseDate;
        private double _price;
        private valuetype System.DateTime _validFromDate;
        private string _baseUnitName;
        private double _unitId;
        private int32 _unitNumber;
        private string _unitName;
        private double _unitQty;


        public specialname int32 get_ItemId() {

          int32 num_1;

        }

        public specialname void set_ItemId(int32 value) {

          loc_410F45: nop
          loc_410F46: ldarg.0
          loc_410F47: ldarg.1
          loc_410F48: stfld GCUv2.cItemPrintDetail::_itemId
          loc_410F4D: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_410F69: nop
          loc_410F6A: ldarg.0
          loc_410F6B: ldarg.1
          loc_410F6C: stfld GCUv2.cItemPurchasePrice::_supplierId
          loc_410F71: ret
        }

        public specialname string get_SupplierName() {

          string str_1;

        }

        public specialname void set_SupplierName(string value) {

          loc_410F8D: nop
          loc_410F8E: ldarg.0
          loc_410F8F: ldarg.1
          loc_410F90: stfld GCUv2.cItemPurchasePrice::_supplierName
          loc_410F95: ret
        }

        public specialname double get_Price() {

          double flt_1;

        }

        public specialname void set_Price(double value) {

          loc_410FB1: nop
          loc_410FB2: ldarg.0
          loc_410FB3: ldarg.1
          loc_410FB4: stfld GCUv2.cItemPurchasePrice::_price
          loc_410FB9: ret
        }

        public specialname valuetype System.DateTime get_ValidFromDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_ValidFromDate(valuetype System.DateTime value) {

          loc_410FD5: nop
          loc_410FD6: ldarg.0
          loc_410FD7: ldarg.1
          loc_410FD8: stfld GCUv2.cItemPurchasePrice::_validFromDate
          loc_410FDD: ret
        }

        public specialname string get_BaseUnitName() {

          string str_1;

        }

        public specialname void set_BaseUnitName(string value) {

          loc_410FF9: nop
          loc_410FFA: ldarg.0
          loc_410FFB: ldarg.1
          loc_410FFC: stfld GCUv2.cItemPurchasePrice::_baseUnitName
          loc_411001: ret
        }

        public specialname double get_UnitId() {

          double flt_1;

        }

        public specialname void set_UnitId(double value) {

          loc_41101D: nop
          loc_41101E: ldarg.0
          loc_41101F: ldarg.1
          loc_411020: stfld GCUv2.cItemPurchasePrice::_unitId
          loc_411025: ret
        }

        public specialname int32 get_UnitNumber() {

          int32 num_1;

        }

        public specialname void set_UnitNumber(int32 value) {

          loc_411041: nop
          loc_411042: ldarg.0
          loc_411043: ldarg.1
          loc_411044: stfld GCUv2.cItemPurchasePrice::_unitNumber
          loc_411049: ret
        }

        public specialname string get_UnitName() {

          string str_1;

        }

        public specialname void set_UnitName(string value) {

          loc_411065: nop
          loc_411066: ldarg.0
          loc_411067: ldarg.1
          loc_411068: stfld GCUv2.cItemPurchasePrice::_unitName
          loc_41106D: ret
        }

        public specialname double get_UnitQty() {

          double flt_1;

        }

        public specialname void set_UnitQty(double value) {

          loc_411089: nop
          loc_41108A: ldarg.0
          loc_41108B: ldarg.1
          loc_41108C: stfld 
          loc_411091: ret
        }

        public void cItemPurchasePrice(int32 ItemId, int32 SupplierId, valuetype System.DateTime PurchaseDate, double UnitId, string UnitName) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
