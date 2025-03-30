using System;
using System.Windows.Forms;

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
        private class RichTextBox _rtxDescription;
        private class Label _Label26;
        private boolean _currentData;
        private double _customerId;
        private double _basePrice;
        private class GCUv2.cSalesInvoiceItem[] _item;
        private boolean _isGroup;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtPrice() {

          loc_4DB1AA: ldarg.0
          loc_4DB1AB: ldfld GCUv2.frmSalesInvoiceItem::_txtPrice
          loc_4DB1B0: br.s loc_4DB1B2
          loc_4DB1B2: // Referenced from: loc_4DB1B0
          loc_4DB1B2: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4DB1B4: ldarg.0
          loc_4DB1B5: ldarg.1
          loc_4DB1B6: stfld GCUv2.frmSalesInvoiceItem::_txtPrice
          loc_4DB1BB: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_4DB1BD: ldarg.0
          loc_4DB1BE: ldfld GCUv2.frmSalesInvoiceItem::_Label8
          loc_4DB1C3: br.s loc_4DB1C5
          loc_4DB1C5: // Referenced from: loc_4DB1C3
          loc_4DB1C5: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_4DB1C7: ldarg.0
          loc_4DB1C8: ldarg.1
          loc_4DB1C9: stfld GCUv2.frmSalesInvoiceItem::_Label8
          loc_4DB1CE: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4DB1D0: ldarg.0
          loc_4DB1D1: ldfld GCUv2.frmSalesInvoiceItem::_btnDelete
          loc_4DB1D6: br.s loc_4DB1D8
          loc_4DB1D8: // Referenced from: loc_4DB1D6
          loc_4DB1D8: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4DB220: ldarg.0
          loc_4DB221: ldfld GCUv2.frmSalesInvoiceItem::_btnSave
          loc_4DB226: br.s loc_4DB228
          loc_4DB228: // Referenced from: loc_4DB226
          loc_4DB228: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_4DB270: ldarg.0
          loc_4DB271: ldfld GCUv2.frmSalesInvoiceItem::_txtQty
          loc_4DB276: br.s loc_4DB278
          loc_4DB278: // Referenced from: loc_4DB276
          loc_4DB278: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4DB27A: ldarg.0
          loc_4DB27B: ldarg.1
          loc_4DB27C: stfld GCUv2.frmSalesInvoiceItem::_txtQty
          loc_4DB281: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_4DB283: ldarg.0
          loc_4DB284: ldfld GCUv2.frmSalesInvoiceItem::_Label6
          loc_4DB289: br.s loc_4DB28B
          loc_4DB28B: // Referenced from: loc_4DB289
          loc_4DB28B: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4DB28D: ldarg.0
          loc_4DB28E: ldarg.1
          loc_4DB28F: stfld GCUv2.frmSalesInvoiceItem::_Label6
          loc_4DB294: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_4DB296: ldarg.0
          loc_4DB297: ldfld GCUv2.frmSalesInvoiceItem::_cboItem
          loc_4DB29C: br.s loc_4DB29E
          loc_4DB29E: // Referenced from: loc_4DB29C
          loc_4DB29E: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_4DB2E4: ldarg.0
          loc_4DB2E5: ldfld GCUv2.frmSalesInvoiceItem::_Label5
          loc_4DB2EA: br.s loc_4DB2EC
          loc_4DB2EC: // Referenced from: loc_4DB2EA
          loc_4DB2EC: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4DB2EE: ldarg.0
          loc_4DB2EF: ldarg.1
          loc_4DB2F0: stfld GCUv2.frmSalesInvoiceItem::_Label5
          loc_4DB2F5: ret
        }

        assem override strict specialname class RichTextBox get_rtxDescription() {

          loc_4DB2F7: ldarg.0
          loc_4DB2F8: ldfld GCUv2.frmSalesInvoiceItem::_rtxDescription
          loc_4DB2FD: br.s loc_4DB2FF
          loc_4DB2FF: // Referenced from: loc_4DB2FD
          loc_4DB2FF: ret
        }

        assem override strict specialname void set_rtxDescription(class RichTextBox WithEventsValue) {

          loc_4DB301: ldarg.0
          loc_4DB302: ldarg.1
          loc_4DB303: stfld GCUv2.frmSalesInvoiceItem::_rtxDescription
          loc_4DB308: ret
        }

        assem override strict specialname class Label get_Label26() {

          loc_4DB30A: ldarg.0
          loc_4DB30B: ldfld GCUv2.frmSalesInvoiceItem::_Label26
          loc_4DB310: br.s loc_4DB312
          loc_4DB312: // Referenced from: loc_4DB310
          loc_4DB312: ret
        }

        assem override strict specialname void set_Label26(class Label WithEventsValue) {

          loc_4DB314: ldarg.0
          loc_4DB315: ldarg.1
          loc_4DB316: stfld GCUv2.frmSalesInvoiceItem::_Label26
          loc_4DB31B: ret
        }

        public specialname class GCUv2.cSalesInvoiceItem[] get_Item() {

          class GCUv2.cSalesInvoiceItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cSalesInvoiceItem[] value) {

          loc_4DB335: nop
          loc_4DB336: ldarg.0
          loc_4DB337: ldarg.1
          loc_4DB338: stfld GCUv2.frmSalesInvoiceItem::_item
          loc_4DB33D: ret
        }

        public void frmSalesInvoiceItem(boolean CurrentData, double CustomerId, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSalesInvoiceItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          double flt_1;
          int32 num_3;
          int32 num_4;
          boolean var_3;
          class GCUv2.cItemPrintDetail var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          class GCUv2.cSalesInvoiceItem[] var_8;
          int32 num_5;
          class GCUv2.cSalesInvoiceItem var_9;
          boolean var_10;
          boolean var_11;
          int32 num_6;
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
          boolean var_22;
          class GCUv2.cItem var_23;
          class GCUv2.cItemGroup[] var_24;
          int32 num_7;
          class GCUv2.cItemGroup var_25;
          boolean var_26;
          class GCUv2.cSalesInvoiceItem[] var_27;
          int32 num_8;
          class GCUv2.cSalesInvoiceItem var_28;
          boolean var_29;
          boolean var_30;
          boolean var_31;
          boolean var_32;
          boolean var_33;

        }

        private void DeleteComponent() {

          boolean var_1;
          int32 num_1;
          boolean var_2;
          int32 num_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          int32 num_3;
          int32 num_4;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

        private void cboItem_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          double flt_1;
          int32 num_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
