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
        private class GCUv2.FilteredTextBox _txtPrice;
        private class Label _Label1;
        private boolean _currentData;
        private double _customerId;
        private class GCUv2.cSalesOrderItem[] _SOItem;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_49B22E: ldarg.0
          loc_49B22F: ldfld GCUv2.frmSalesOrderItem::_btnDelete
          loc_49B234: br.s loc_49B236
          loc_49B236: // Referenced from: loc_49B234
          loc_49B236: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_49B27C: ldarg.0
          loc_49B27D: ldfld GCUv2.frmSalesOrderItem::_btnSave
          loc_49B282: br.s loc_49B284
          loc_49B284: // Referenced from: loc_49B282
          loc_49B284: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_49B2CC: ldarg.0
          loc_49B2CD: ldfld GCUv2.frmSalesOrderItem::_txtQty
          loc_49B2D2: br.s loc_49B2D4
          loc_49B2D4: // Referenced from: loc_49B2D2
          loc_49B2D4: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_49B2D6: ldarg.0
          loc_49B2D7: ldarg.1
          loc_49B2D8: stfld GCUv2.frmSalesOrderItem::_txtQty
          loc_49B2DD: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_49B2DF: ldarg.0
          loc_49B2E0: ldfld GCUv2.frmSalesOrderItem::_Label6
          loc_49B2E5: br.s loc_49B2E7
          loc_49B2E7: // Referenced from: loc_49B2E5
          loc_49B2E7: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_49B2E9: ldarg.0
          loc_49B2EA: ldarg.1
          loc_49B2EB: stfld GCUv2.frmSalesOrderItem::_Label6
          loc_49B2F0: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_49B2F2: ldarg.0
          loc_49B2F3: ldfld GCUv2.frmSalesOrderItem::_cboItem
          loc_49B2F8: br.s loc_49B2FA
          loc_49B2FA: // Referenced from: loc_49B2F8
          loc_49B2FA: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_49B340: ldarg.0
          loc_49B341: ldfld GCUv2.frmSalesOrderItem::_Label5
          loc_49B346: br.s loc_49B348
          loc_49B348: // Referenced from: loc_49B346
          loc_49B348: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_49B34A: ldarg.0
          loc_49B34B: ldarg.1
          loc_49B34C: stfld GCUv2.frmSalesOrderItem::_Label5
          loc_49B351: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtPrice() {

          loc_49B353: ldarg.0
          loc_49B354: ldfld GCUv2.frmSalesOrderItem::_txtPrice
          loc_49B359: br.s loc_49B35B
          loc_49B35B: // Referenced from: loc_49B359
          loc_49B35B: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_49B35D: ldarg.0
          loc_49B35E: ldarg.1
          loc_49B35F: stfld GCUv2.frmSalesOrderItem::_txtPrice
          loc_49B364: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_49B366: ldarg.0
          loc_49B367: ldfld GCUv2.frmSalesOrderItem::_Label1
          loc_49B36C: br.s loc_49B36E
          loc_49B36E: // Referenced from: loc_49B36C
          loc_49B36E: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_49B370: ldarg.0
          loc_49B371: ldarg.1
          loc_49B372: stfld GCUv2.frmSalesOrderItem::_Label1
          loc_49B377: ret
        }

        public specialname class GCUv2.cSalesOrderItem[] get_SOItem() {

          class GCUv2.cSalesOrderItem[] var_1;

        }

        public specialname void set_SOItem(class GCUv2.cSalesOrderItem[] value) {

          loc_49B391: nop
          loc_49B392: ldarg.0
          loc_49B393: ldarg.1
          loc_49B394: stfld GCUv2.frmSalesOrderItem::_SOItem
          loc_49B399: ret
        }

        public void frmSalesOrderItem(boolean CurrentData, double CustomerId, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSalesOrderItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          int32 num_3;
          boolean var_2;
          boolean var_3;
          int32 num_4;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

        private void cboItem_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;

        }

    }
}
