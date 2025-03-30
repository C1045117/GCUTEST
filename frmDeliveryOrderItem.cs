using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private boolean _currentData;
        private class GCUv2.cDeliveryOrderItem[] _DOItem;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_44C591: ldarg.0
          loc_44C592: ldfld GCUv2.frmDeliveryOrderItem::_btnDelete
          loc_44C597: br.s loc_44C599
          loc_44C599: // Referenced from: loc_44C597
          loc_44C599: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_44C5E0: ldarg.0
          loc_44C5E1: ldfld GCUv2.frmDeliveryOrderItem::_btnSave
          loc_44C5E6: br.s loc_44C5E8
          loc_44C5E8: // Referenced from: loc_44C5E6
          loc_44C5E8: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_44C630: ldarg.0
          loc_44C631: ldfld GCUv2.frmDeliveryOrderItem::_txtQty
          loc_44C636: br.s loc_44C638
          loc_44C638: // Referenced from: loc_44C636
          loc_44C638: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_44C63A: ldarg.0
          loc_44C63B: ldarg.1
          loc_44C63C: stfld GCUv2.frmDeliveryOrderItem::_txtQty
          loc_44C641: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_44C643: ldarg.0
          loc_44C644: ldfld GCUv2.frmDeliveryOrderItem::_Label6
          loc_44C649: br.s loc_44C64B
          loc_44C64B: // Referenced from: loc_44C649
          loc_44C64B: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_44C64D: ldarg.0
          loc_44C64E: ldarg.1
          loc_44C64F: stfld GCUv2.frmDeliveryOrderItem::_Label6
          loc_44C654: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_44C656: ldarg.0
          loc_44C657: ldfld GCUv2.frmDeliveryOrderItem::_cboItem
          loc_44C65C: br.s loc_44C65E
          loc_44C65E: // Referenced from: loc_44C65C
          loc_44C65E: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_44C660: ldarg.0
          loc_44C661: ldarg.1
          loc_44C662: stfld GCUv2.frmDeliveryOrderItem::_cboItem
          loc_44C667: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_44C669: ldarg.0
          loc_44C66A: ldfld GCUv2.frmDeliveryOrderItem::_Label5
          loc_44C66F: br.s loc_44C671
          loc_44C671: // Referenced from: loc_44C66F
          loc_44C671: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_44C673: ldarg.0
          loc_44C674: ldarg.1
          loc_44C675: stfld GCUv2.frmDeliveryOrderItem::_Label5
          loc_44C67A: ret
        }

        public specialname class GCUv2.cDeliveryOrderItem[] get_DOItem() {

          class GCUv2.cDeliveryOrderItem[] var_1;

        }

        public specialname void set_DOItem(class GCUv2.cDeliveryOrderItem[] value) {

          loc_44C695: nop
          loc_44C696: ldarg.0
          loc_44C697: ldarg.1
          loc_44C698: stfld GCUv2.frmDeliveryOrderItem::_DOItem
          loc_44C69D: ret
        }

        public void frmDeliveryOrderItem(boolean CurrentData, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmDeliveryOrderItem_KeyDown(object sender, class KeyEventArgs e) {

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
          class GCUv2.cDeliveryOrderItem[] var_7;
          int32 num_5;
          class GCUv2.cDeliveryOrderItem var_8;
          boolean var_9;
          boolean var_10;
          int32 num_6;
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
