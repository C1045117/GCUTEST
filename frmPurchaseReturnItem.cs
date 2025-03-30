using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GCUv2.FilteredTextBox _txtPrice;
        private class Label _Label8;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private class Label _lblBaseUnit;
        private class GCUv2.FilteredTextBox _txtStockQty;
        private class Label _Label1;
        private class ComboBox _cboUnit;
        private boolean _currentData;
        private int32 _supplierId;
        private int32 _storageId;
        private valuetype System.DateTime _purchaseDate;
        private boolean _AllowEditStockQty;
        private string _generalType;
        private string _longName;
        private string _packaging;
        private string _largeUnit;
        private double _unitId;
        private double _unitQty;
        private class GCUv2.cPurchaseInvoiceItem[] _item;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtPrice() {

          loc_45DB1C: ldarg.0
          loc_45DB1D: ldfld GCUv2.frmPurchaseReturnItem::_txtPrice
          loc_45DB22: br.s loc_45DB24
          loc_45DB24: // Referenced from: loc_45DB22
          loc_45DB24: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_45DB26: ldarg.0
          loc_45DB27: ldarg.1
          loc_45DB28: stfld GCUv2.frmPurchaseReturnItem::_txtPrice
          loc_45DB2D: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_45DB2F: ldarg.0
          loc_45DB30: ldfld GCUv2.frmPurchaseReturnItem::_Label8
          loc_45DB35: br.s loc_45DB37
          loc_45DB37: // Referenced from: loc_45DB35
          loc_45DB37: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_45DB39: ldarg.0
          loc_45DB3A: ldarg.1
          loc_45DB3B: stfld GCUv2.frmPurchaseReturnItem::_Label8
          loc_45DB40: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_45DB42: ldarg.0
          loc_45DB43: ldfld GCUv2.frmPurchaseReturnItem::_btnDelete
          loc_45DB48: br.s loc_45DB4A
          loc_45DB4A: // Referenced from: loc_45DB48
          loc_45DB4A: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_45DB90: ldarg.0
          loc_45DB91: ldfld GCUv2.frmPurchaseReturnItem::_btnSave
          loc_45DB96: br.s loc_45DB98
          loc_45DB98: // Referenced from: loc_45DB96
          loc_45DB98: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_45DBE0: ldarg.0
          loc_45DBE1: ldfld GCUv2.frmPurchaseReturnItem::_txtQty
          loc_45DBE6: br.s loc_45DBE8
          loc_45DBE8: // Referenced from: loc_45DBE6
          loc_45DBE8: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class GCUv2.FilteredTextBox var_2;

        }

        assem override strict specialname class Label get_Label6() {

          loc_45DC30: ldarg.0
          loc_45DC31: ldfld GCUv2.frmPurchaseReturnItem::_Label6
          loc_45DC36: br.s loc_45DC38
          loc_45DC38: // Referenced from: loc_45DC36
          loc_45DC38: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_45DC3A: ldarg.0
          loc_45DC3B: ldarg.1
          loc_45DC3C: stfld GCUv2.frmPurchaseReturnItem::_Label6
          loc_45DC41: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_45DC43: ldarg.0
          loc_45DC44: ldfld GCUv2.frmPurchaseReturnItem::_cboItem
          loc_45DC49: br.s loc_45DC4B
          loc_45DC4B: // Referenced from: loc_45DC49
          loc_45DC4B: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_45DC90: ldarg.0
          loc_45DC91: ldfld GCUv2.frmPurchaseReturnItem::_Label5
          loc_45DC96: br.s loc_45DC98
          loc_45DC98: // Referenced from: loc_45DC96
          loc_45DC98: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_45DC9A: ldarg.0
          loc_45DC9B: ldarg.1
          loc_45DC9C: stfld GCUv2.frmPurchaseReturnItem::_Label5
          loc_45DCA1: ret
        }

        assem override strict specialname class Label get_lblBaseUnit() {

          loc_45DCA3: ldarg.0
          loc_45DCA4: ldfld GCUv2.frmPurchaseReturnItem::_lblBaseUnit
          loc_45DCA9: br.s loc_45DCAB
          loc_45DCAB: // Referenced from: loc_45DCA9
          loc_45DCAB: ret
        }

        assem override strict specialname void set_lblBaseUnit(class Label WithEventsValue) {

          loc_45DCAD: ldarg.0
          loc_45DCAE: ldarg.1
          loc_45DCAF: stfld GCUv2.frmPurchaseReturnItem::_lblBaseUnit
          loc_45DCB4: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtStockQty() {

          loc_45DCB6: ldarg.0
          loc_45DCB7: ldfld GCUv2.frmPurchaseReturnItem::_txtStockQty
          loc_45DCBC: br.s loc_45DCBE
          loc_45DCBE: // Referenced from: loc_45DCBC
          loc_45DCBE: ret
        }

        assem override strict specialname void set_txtStockQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_45DCC0: ldarg.0
          loc_45DCC1: ldarg.1
          loc_45DCC2: stfld GCUv2.frmPurchaseReturnItem::_txtStockQty
          loc_45DCC7: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_45DCC9: ldarg.0
          loc_45DCCA: ldfld GCUv2.frmPurchaseReturnItem::_Label1
          loc_45DCCF: br.s loc_45DCD1
          loc_45DCD1: // Referenced from: loc_45DCCF
          loc_45DCD1: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_45DCD3: ldarg.0
          loc_45DCD4: ldarg.1
          loc_45DCD5: stfld GCUv2.frmPurchaseReturnItem::_Label1
          loc_45DCDA: ret
        }

        assem override strict specialname class ComboBox get_cboUnit() {

          loc_45DCDC: ldarg.0
          loc_45DCDD: ldfld GCUv2.frmPurchaseReturnItem::_cboUnit
          loc_45DCE2: br.s loc_45DCE4
          loc_45DCE4: // Referenced from: loc_45DCE2
          loc_45DCE4: ret
        }

        assem override strict specialname void set_cboUnit(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        public specialname class GCUv2.cPurchaseInvoiceItem[] get_item() {

          class GCUv2.cPurchaseInvoiceItem[] var_1;

        }

        public specialname void set_item(class GCUv2.cPurchaseInvoiceItem[] value) {

          loc_45DD45: nop
          loc_45DD46: ldarg.0
          loc_45DD47: ldarg.1
          loc_45DD48: stfld GCUv2.frmPurchaseReturnItem::_item
          loc_45DD4D: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_45DD69: nop
          loc_45DD6A: ldarg.0
          loc_45DD6B: ldarg.1
          loc_45DD6C: stfld GCUv2.frmPurchaseReturnItem::_supplierId
          loc_45DD71: ret
        }

        public specialname valuetype System.DateTime get_PurchaseDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_PurchaseDate(valuetype System.DateTime value) {

          loc_45DD8D: nop
          loc_45DD8E: ldarg.0
          loc_45DD8F: ldarg.1
          loc_45DD90: stfld GCUv2.frmPurchaseReturnItem::_purchaseDate
          loc_45DD95: ret
        }

        public void frmPurchaseReturnItem(boolean CurrentData, int32 SupplierId, valuetype System.DateTime PurchaseDate, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmPurchaseReturnItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboItem_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class GCUv2.cItem var_3;
          class ComboBox var_4;
          boolean var_5;

        }

        private void cboUnit_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          double flt_1;
          boolean var_3;
          class GCUv2.cItemPurchasePrice var_4;
          boolean var_5;
          boolean var_6;
          class ComboBox var_7;
          boolean var_8;

        }

        private void txtQty_TextChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          double flt_1;
          double flt_2;
          int32 num_1;
          int32 num_2;
          boolean var_3;
          class GCUv2.cItem var_4;
          boolean var_5;
          boolean var_6;
          class GCUv2.cPurchaseInvoiceItem[] var_7;
          int32 num_3;
          class GCUv2.cPurchaseInvoiceItem var_8;
          boolean var_9;
          boolean var_10;
          int32 num_4;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

    }
}
