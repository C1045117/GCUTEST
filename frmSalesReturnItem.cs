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

          loc_4FF133: ldarg.0
          loc_4FF134: ldfld GCUv2.frmSalesReturnItem::_txtPrice
          loc_4FF139: br.s loc_4FF13B
          loc_4FF13B: // Referenced from: loc_4FF139
          loc_4FF13B: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4FF13D: ldarg.0
          loc_4FF13E: ldarg.1
          loc_4FF13F: stfld GCUv2.frmSalesReturnItem::_txtPrice
          loc_4FF144: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_4FF146: ldarg.0
          loc_4FF147: ldfld GCUv2.frmSalesReturnItem::_Label8
          loc_4FF14C: br.s loc_4FF14E
          loc_4FF14E: // Referenced from: loc_4FF14C
          loc_4FF14E: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_4FF150: ldarg.0
          loc_4FF151: ldarg.1
          loc_4FF152: stfld GCUv2.frmSalesReturnItem::_Label8
          loc_4FF157: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4FF159: ldarg.0
          loc_4FF15A: ldfld GCUv2.frmSalesReturnItem::_btnDelete
          loc_4FF15F: br.s loc_4FF161
          loc_4FF161: // Referenced from: loc_4FF15F
          loc_4FF161: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4FF1A8: ldarg.0
          loc_4FF1A9: ldfld GCUv2.frmSalesReturnItem::_btnSave
          loc_4FF1AE: br.s loc_4FF1B0
          loc_4FF1B0: // Referenced from: loc_4FF1AE
          loc_4FF1B0: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_4FF1F8: ldarg.0
          loc_4FF1F9: ldfld GCUv2.frmSalesReturnItem::_txtQty
          loc_4FF1FE: br.s loc_4FF200
          loc_4FF200: // Referenced from: loc_4FF1FE
          loc_4FF200: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4FF202: ldarg.0
          loc_4FF203: ldarg.1
          loc_4FF204: stfld GCUv2.frmSalesReturnItem::_txtQty
          loc_4FF209: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_4FF20B: ldarg.0
          loc_4FF20C: ldfld GCUv2.frmSalesReturnItem::_Label6
          loc_4FF211: br.s loc_4FF213
          loc_4FF213: // Referenced from: loc_4FF211
          loc_4FF213: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4FF215: ldarg.0
          loc_4FF216: ldarg.1
          loc_4FF217: stfld GCUv2.frmSalesReturnItem::_Label6
          loc_4FF21C: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_4FF21E: ldarg.0
          loc_4FF21F: ldfld GCUv2.frmSalesReturnItem::_cboItem
          loc_4FF224: br.s loc_4FF226
          loc_4FF226: // Referenced from: loc_4FF224
          loc_4FF226: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_4FF26C: ldarg.0
          loc_4FF26D: ldfld GCUv2.frmSalesReturnItem::_Label5
          loc_4FF272: br.s loc_4FF274
          loc_4FF274: // Referenced from: loc_4FF272
          loc_4FF274: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4FF276: ldarg.0
          loc_4FF277: ldarg.1
          loc_4FF278: stfld GCUv2.frmSalesReturnItem::_Label5
          loc_4FF27D: ret
        }

        public specialname class GCUv2.cSalesInvoiceItem[] get_Item() {

          class GCUv2.cSalesInvoiceItem[] var_1;

        }

        public specialname void set_Item(class GCUv2.cSalesInvoiceItem[] value) {

          loc_4FF299: nop
          loc_4FF29A: ldarg.0
          loc_4FF29B: ldarg.1
          loc_4FF29C: stfld GCUv2.frmSalesReturnItem::_item
          loc_4FF2A1: ret
        }

        public void frmSalesReturnItem(boolean CurrentData, double CustomerId, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;
          boolean var_3;

        }

        private void frmSalesReturnItem_KeyDown(object sender, class KeyEventArgs e) {

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
          boolean var_4;
          boolean var_5;
          class GCUv2.cSalesInvoiceItem[] var_6;
          int32 num_5;
          class GCUv2.cSalesInvoiceItem var_7;
          boolean var_8;
          boolean var_9;
          int32 num_6;
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
          class GCUv2.cItem var_20;
          class GCUv2.cItemGroup[] var_21;
          int32 num_7;
          class GCUv2.cItemGroup var_22;
          boolean var_23;
          class GCUv2.cSalesInvoiceItem[] var_24;
          int32 num_8;
          class GCUv2.cSalesInvoiceItem var_25;
          boolean var_26;
          boolean var_27;
          boolean var_28;
          boolean var_29;

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
          boolean var_2;

        }

    }
}
