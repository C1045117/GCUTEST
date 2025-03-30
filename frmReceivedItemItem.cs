using System;
using System.Windows.Forms;
using mscorlib;

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
        private class GCUv2.FilteredTextBox _txtStockQty;
        private class Label _Label1;
        private class Label _lblBaseUnit;
        private class ComboBox _cboUnit;
        private boolean _currentData;
        private class GCUv2.cReceivedItemItem[] _RIItem;
        private int32 _supplierId;
        private valuetype System.DateTime _purchaseDate;
        private double _unitId;
        private double _unitQty;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4A21E0: ldarg.0
          loc_4A21E1: ldfld GCUv2.frmReceivedItemItem::_btnDelete
          loc_4A21E6: br.s loc_4A21E8
          loc_4A21E8: // Referenced from: loc_4A21E6
          loc_4A21E8: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4A2230: ldarg.0
          loc_4A2231: ldfld GCUv2.frmReceivedItemItem::_btnSave
          loc_4A2236: br.s loc_4A2238
          loc_4A2238: // Referenced from: loc_4A2236
          loc_4A2238: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_4A2280: ldarg.0
          loc_4A2281: ldfld GCUv2.frmReceivedItemItem::_txtQty
          loc_4A2286: br.s loc_4A2288
          loc_4A2288: // Referenced from: loc_4A2286
          loc_4A2288: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class GCUv2.FilteredTextBox var_2;

        }

        assem override strict specialname class Label get_Label6() {

          loc_4A22D0: ldarg.0
          loc_4A22D1: ldfld GCUv2.frmReceivedItemItem::_Label6
          loc_4A22D6: br.s loc_4A22D8
          loc_4A22D8: // Referenced from: loc_4A22D6
          loc_4A22D8: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4A22DA: ldarg.0
          loc_4A22DB: ldarg.1
          loc_4A22DC: stfld GCUv2.frmReceivedItemItem::_Label6
          loc_4A22E1: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_4A22E3: ldarg.0
          loc_4A22E4: ldfld GCUv2.frmReceivedItemItem::_cboItem
          loc_4A22E9: br.s loc_4A22EB
          loc_4A22EB: // Referenced from: loc_4A22E9
          loc_4A22EB: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_4A2330: ldarg.0
          loc_4A2331: ldfld GCUv2.frmReceivedItemItem::_Label5
          loc_4A2336: br.s loc_4A2338
          loc_4A2338: // Referenced from: loc_4A2336
          loc_4A2338: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4A233A: ldarg.0
          loc_4A233B: ldarg.1
          loc_4A233C: stfld GCUv2.frmReceivedItemItem::_Label5
          loc_4A2341: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtStockQty() {

          loc_4A2343: ldarg.0
          loc_4A2344: ldfld GCUv2.frmReceivedItemItem::_txtStockQty
          loc_4A2349: br.s loc_4A234B
          loc_4A234B: // Referenced from: loc_4A2349
          loc_4A234B: ret
        }

        assem override strict specialname void set_txtStockQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4A234D: ldarg.0
          loc_4A234E: ldarg.1
          loc_4A234F: stfld GCUv2.frmReceivedItemItem::_txtStockQty
          loc_4A2354: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4A2356: ldarg.0
          loc_4A2357: ldfld GCUv2.frmReceivedItemItem::_Label1
          loc_4A235C: br.s loc_4A235E
          loc_4A235E: // Referenced from: loc_4A235C
          loc_4A235E: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4A2360: ldarg.0
          loc_4A2361: ldarg.1
          loc_4A2362: stfld GCUv2.frmReceivedItemItem::_Label1
          loc_4A2367: ret
        }

        assem override strict specialname class Label get_lblBaseUnit() {

          loc_4A2369: ldarg.0
          loc_4A236A: ldfld GCUv2.frmReceivedItemItem::_lblBaseUnit
          loc_4A236F: br.s loc_4A2371
          loc_4A2371: // Referenced from: loc_4A236F
          loc_4A2371: ret
        }

        assem override strict specialname void set_lblBaseUnit(class Label WithEventsValue) {

          loc_4A2373: ldarg.0
          loc_4A2374: ldarg.1
          loc_4A2375: stfld GCUv2.frmReceivedItemItem::_lblBaseUnit
          loc_4A237A: ret
        }

        assem override strict specialname class ComboBox get_cboUnit() {

          loc_4A237C: ldarg.0
          loc_4A237D: ldfld GCUv2.frmReceivedItemItem::_cboUnit
          loc_4A2382: br.s loc_4A2384
          loc_4A2384: // Referenced from: loc_4A2382
          loc_4A2384: ret
        }

        assem override strict specialname void set_cboUnit(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        public specialname class GCUv2.cReceivedItemItem[] get_RIItem() {

          class GCUv2.cReceivedItemItem[] var_1;

        }

        public specialname void set_RIItem(class GCUv2.cReceivedItemItem[] value) {

          loc_4A23E5: nop
          loc_4A23E6: ldarg.0
          loc_4A23E7: ldarg.1
          loc_4A23E8: stfld GCUv2.frmReceivedItemItem::_RIItem
          loc_4A23ED: ret
        }

        public void frmReceivedItemItem(boolean CurrentData, int32 SupplierId, int32 StorageId, valuetype System.DateTime PurchaseDate) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmReceivedItemItem_KeyDown(object sender, class KeyEventArgs e) {

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
          boolean var_3;
          double flt_1;
          class GCUv2.cItemPurchasePrice var_4;
          boolean var_5;
          class ComboBox var_6;
          boolean var_7;

        }

        private void txtQty_TextChanged(object sender, class System.EventArgs e) {

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
          class GCUv2.cReceivedItemItem[] var_6;
          int32 num_5;
          class GCUv2.cReceivedItemItem var_7;
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

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          loc_4A2DE1: nop
          loc_4A2DE2: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A2DE7: callvirt instance class GCUv2.frmReceivedItem GCUv2.frmReceivedItemItem/MyForms::get_frmReceivedItem()
          loc_4A2DEC: callvirt instance class DataGridView GCUv2.frmReceivedItem::get_dgvItem()
          loc_4A2DF1: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_4A2DF6: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A2DFB: callvirt instance class GCUv2.frmReceivedItem GCUv2.frmReceivedItemItem/MyForms::get_frmReceivedItem()
          loc_4A2E00: callvirt instance class DataGridView GCUv2.frmReceivedItem::get_dgvItem()
          loc_4A2E05: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_4A2E0A: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_4A2E0F: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_4A2E14: nop
          loc_4A2E15: ldarg.0
          loc_4A2E16: call instance void System.Windows.Forms.Form::Close()
          loc_4A2E1B: nop
          loc_4A2E1C: ret
        }

    }
}
