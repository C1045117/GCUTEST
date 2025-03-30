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
        private class GCUv2.cTransferItem[] _TransferItem;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_5464D7: ldarg.0
          loc_5464D8: ldfld GCUv2.frmTransferItem::_btnDelete
          loc_5464DD: br.s loc_5464DF
          loc_5464DF: // Referenced from: loc_5464DD
          loc_5464DF: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_546524: ldarg.0
          loc_546525: ldfld GCUv2.frmTransferItem::_btnSave
          loc_54652A: br.s loc_54652C
          loc_54652C: // Referenced from: loc_54652A
          loc_54652C: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_546574: ldarg.0
          loc_546575: ldfld GCUv2.frmTransferItem::_txtQty
          loc_54657A: br.s loc_54657C
          loc_54657C: // Referenced from: loc_54657A
          loc_54657C: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_54657E: ldarg.0
          loc_54657F: ldarg.1
          loc_546580: stfld GCUv2.frmTransferItem::_txtQty
          loc_546585: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_546587: ldarg.0
          loc_546588: ldfld GCUv2.frmTransferItem::_Label6
          loc_54658D: br.s loc_54658F
          loc_54658F: // Referenced from: loc_54658D
          loc_54658F: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_546591: ldarg.0
          loc_546592: ldarg.1
          loc_546593: stfld GCUv2.frmTransferItem::_Label6
          loc_546598: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_54659A: ldarg.0
          loc_54659B: ldfld GCUv2.frmTransferItem::_cboItem
          loc_5465A0: br.s loc_5465A2
          loc_5465A2: // Referenced from: loc_5465A0
          loc_5465A2: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_5465A4: ldarg.0
          loc_5465A5: ldarg.1
          loc_5465A6: stfld GCUv2.frmTransferItem::_cboItem
          loc_5465AB: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_5465AD: ldarg.0
          loc_5465AE: ldfld GCUv2.frmTransferItem::_Label5
          loc_5465B3: br.s loc_5465B5
          loc_5465B5: // Referenced from: loc_5465B3
          loc_5465B5: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_5465B7: ldarg.0
          loc_5465B8: ldarg.1
          loc_5465B9: stfld GCUv2.frmTransferItem::_Label5
          loc_5465BE: ret
        }

        public specialname class GCUv2.cTransferItem[] get_TransferItem() {

          class GCUv2.cTransferItem[] var_1;

        }

        public specialname void set_TransferItem(class GCUv2.cTransferItem[] value) {

          loc_5465D9: nop
          loc_5465DA: ldarg.0
          loc_5465DB: ldarg.1
          loc_5465DC: stfld GCUv2.frmTransferItem::_TransferItem
          loc_5465E1: ret
        }

        public void frmTransferItem(boolean CurrentData, int32 StorageFromId, int32 StorageToId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmTransferItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          double flt_1;
          int32 num_3;
          int32 num_4;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          class GCUv2.cTransferItem[] var_7;
          int32 num_5;
          class GCUv2.cTransferItem var_8;
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
