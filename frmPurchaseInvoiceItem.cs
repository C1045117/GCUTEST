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
        private class GCUv2.FilteredTextBox _txtDeduction;
        private class Label _Label2;
        private class GCUv2.FilteredTextBox _txtParkedQty;
        private class Label _Label3;
        private class GCUv2.FilteredTextBox _txtExtraPrice;
        private class Label _Label7;
        private class GCUv2.FilteredTextBox _txtPrice;
        private class Label _Label8;
        private class Label _lblBaseUnit;
        private class ComboBox _cboUnit;
        private class RichTextBox _rtxDescription;
        private class Label _Label26;
        private boolean _currentData;
        private int32 _supplierId;
        private int32 _storageId;
        private valuetype System.DateTime _purchaseDate;
        private boolean _AllowEditStockQty;
        private double _unitId;
        private double _unitQty;
        private int32 _inventoryAccountId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_52D202: ldarg.0
          loc_52D203: ldfld GCUv2.frmPurchaseInvoiceItem::_btnDelete
          loc_52D208: br.s loc_52D20A
          loc_52D20A: // Referenced from: loc_52D208
          loc_52D20A: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_52D250: ldarg.0
          loc_52D251: ldfld GCUv2.frmPurchaseInvoiceItem::_btnSave
          loc_52D256: br.s loc_52D258
          loc_52D258: // Referenced from: loc_52D256
          loc_52D258: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_52D2A0: ldarg.0
          loc_52D2A1: ldfld GCUv2.frmPurchaseInvoiceItem::_txtQty
          loc_52D2A6: br.s loc_52D2A8
          loc_52D2A8: // Referenced from: loc_52D2A6
          loc_52D2A8: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class GCUv2.FilteredTextBox var_2;

        }

        assem override strict specialname class Label get_Label6() {

          loc_52D2F0: ldarg.0
          loc_52D2F1: ldfld GCUv2.frmPurchaseInvoiceItem::_Label6
          loc_52D2F6: br.s loc_52D2F8
          loc_52D2F8: // Referenced from: loc_52D2F6
          loc_52D2F8: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_52D2FA: ldarg.0
          loc_52D2FB: ldarg.1
          loc_52D2FC: stfld GCUv2.frmPurchaseInvoiceItem::_Label6
          loc_52D301: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_52D303: ldarg.0
          loc_52D304: ldfld GCUv2.frmPurchaseInvoiceItem::_cboItem
          loc_52D309: br.s loc_52D30B
          loc_52D30B: // Referenced from: loc_52D309
          loc_52D30B: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_52D350: ldarg.0
          loc_52D351: ldfld GCUv2.frmPurchaseInvoiceItem::_Label5
          loc_52D356: br.s loc_52D358
          loc_52D358: // Referenced from: loc_52D356
          loc_52D358: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_52D35A: ldarg.0
          loc_52D35B: ldarg.1
          loc_52D35C: stfld GCUv2.frmPurchaseInvoiceItem::_Label5
          loc_52D361: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtStockQty() {

          loc_52D363: ldarg.0
          loc_52D364: ldfld GCUv2.frmPurchaseInvoiceItem::_txtStockQty
          loc_52D369: br.s loc_52D36B
          loc_52D36B: // Referenced from: loc_52D369
          loc_52D36B: ret
        }

        assem override strict specialname void set_txtStockQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52D36D: ldarg.0
          loc_52D36E: ldarg.1
          loc_52D36F: stfld GCUv2.frmPurchaseInvoiceItem::_txtStockQty
          loc_52D374: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_52D376: ldarg.0
          loc_52D377: ldfld GCUv2.frmPurchaseInvoiceItem::_Label1
          loc_52D37C: br.s loc_52D37E
          loc_52D37E: // Referenced from: loc_52D37C
          loc_52D37E: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_52D380: ldarg.0
          loc_52D381: ldarg.1
          loc_52D382: stfld GCUv2.frmPurchaseInvoiceItem::_Label1
          loc_52D387: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDeduction() {

          loc_52D389: ldarg.0
          loc_52D38A: ldfld GCUv2.frmPurchaseInvoiceItem::_txtDeduction
          loc_52D38F: br.s loc_52D391
          loc_52D391: // Referenced from: loc_52D38F
          loc_52D391: ret
        }

        assem override strict specialname void set_txtDeduction(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52D393: ldarg.0
          loc_52D394: ldarg.1
          loc_52D395: stfld GCUv2.frmPurchaseInvoiceItem::_txtDeduction
          loc_52D39A: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_52D39C: ldarg.0
          loc_52D39D: ldfld GCUv2.frmPurchaseInvoiceItem::_Label2
          loc_52D3A2: br.s loc_52D3A4
          loc_52D3A4: // Referenced from: loc_52D3A2
          loc_52D3A4: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_52D3A6: ldarg.0
          loc_52D3A7: ldarg.1
          loc_52D3A8: stfld GCUv2.frmPurchaseInvoiceItem::_Label2
          loc_52D3AD: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtParkedQty() {

          loc_52D3AF: ldarg.0
          loc_52D3B0: ldfld GCUv2.frmPurchaseInvoiceItem::_txtParkedQty
          loc_52D3B5: br.s loc_52D3B7
          loc_52D3B7: // Referenced from: loc_52D3B5
          loc_52D3B7: ret
        }

        assem override strict specialname void set_txtParkedQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52D3B9: ldarg.0
          loc_52D3BA: ldarg.1
          loc_52D3BB: stfld GCUv2.frmPurchaseInvoiceItem::_txtParkedQty
          loc_52D3C0: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_52D3C2: ldarg.0
          loc_52D3C3: ldfld GCUv2.frmPurchaseInvoiceItem::_Label3
          loc_52D3C8: br.s loc_52D3CA
          loc_52D3CA: // Referenced from: loc_52D3C8
          loc_52D3CA: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_52D3CC: ldarg.0
          loc_52D3CD: ldarg.1
          loc_52D3CE: stfld GCUv2.frmPurchaseInvoiceItem::_Label3
          loc_52D3D3: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtExtraPrice() {

          loc_52D3D5: ldarg.0
          loc_52D3D6: ldfld GCUv2.frmPurchaseInvoiceItem::_txtExtraPrice
          loc_52D3DB: br.s loc_52D3DD
          loc_52D3DD: // Referenced from: loc_52D3DB
          loc_52D3DD: ret
        }

        assem override strict specialname void set_txtExtraPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52D3DF: ldarg.0
          loc_52D3E0: ldarg.1
          loc_52D3E1: stfld GCUv2.frmPurchaseInvoiceItem::_txtExtraPrice
          loc_52D3E6: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_52D3E8: ldarg.0
          loc_52D3E9: ldfld GCUv2.frmPurchaseInvoiceItem::_Label7
          loc_52D3EE: br.s loc_52D3F0
          loc_52D3F0: // Referenced from: loc_52D3EE
          loc_52D3F0: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_52D3F2: ldarg.0
          loc_52D3F3: ldarg.1
          loc_52D3F4: stfld GCUv2.frmPurchaseInvoiceItem::_Label7
          loc_52D3F9: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtPrice() {

          loc_52D3FB: ldarg.0
          loc_52D3FC: ldfld GCUv2.frmPurchaseInvoiceItem::_txtPrice
          loc_52D401: br.s loc_52D403
          loc_52D403: // Referenced from: loc_52D401
          loc_52D403: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52D405: ldarg.0
          loc_52D406: ldarg.1
          loc_52D407: stfld GCUv2.frmPurchaseInvoiceItem::_txtPrice
          loc_52D40C: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_52D40E: ldarg.0
          loc_52D40F: ldfld GCUv2.frmPurchaseInvoiceItem::_Label8
          loc_52D414: br.s loc_52D416
          loc_52D416: // Referenced from: loc_52D414
          loc_52D416: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_52D418: ldarg.0
          loc_52D419: ldarg.1
          loc_52D41A: stfld GCUv2.frmPurchaseInvoiceItem::_Label8
          loc_52D41F: ret
        }

        assem override strict specialname class Label get_lblBaseUnit() {

          loc_52D421: ldarg.0
          loc_52D422: ldfld GCUv2.frmPurchaseInvoiceItem::_lblBaseUnit
          loc_52D427: br.s loc_52D429
          loc_52D429: // Referenced from: loc_52D427
          loc_52D429: ret
        }

        assem override strict specialname void set_lblBaseUnit(class Label WithEventsValue) {

          loc_52D42B: ldarg.0
          loc_52D42C: ldarg.1
          loc_52D42D: stfld GCUv2.frmPurchaseInvoiceItem::_lblBaseUnit
          loc_52D432: ret
        }

        assem override strict specialname class ComboBox get_cboUnit() {

          loc_52D434: ldarg.0
          loc_52D435: ldfld GCUv2.frmPurchaseInvoiceItem::_cboUnit
          loc_52D43A: br.s loc_52D43C
          loc_52D43C: // Referenced from: loc_52D43A
          loc_52D43C: ret
        }

        assem override strict specialname void set_cboUnit(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class RichTextBox get_rtxDescription() {

          loc_52D484: ldarg.0
          loc_52D485: ldfld GCUv2.frmPurchaseInvoiceItem::_rtxDescription
          loc_52D48A: br.s loc_52D48C
          loc_52D48C: // Referenced from: loc_52D48A
          loc_52D48C: ret
        }

        assem override strict specialname void set_rtxDescription(class RichTextBox WithEventsValue) {

          loc_52D48E: ldarg.0
          loc_52D48F: ldarg.1
          loc_52D490: stfld GCUv2.frmPurchaseInvoiceItem::_rtxDescription
          loc_52D495: ret
        }

        assem override strict specialname class Label get_Label26() {

          loc_52D497: ldarg.0
          loc_52D498: ldfld GCUv2.frmPurchaseInvoiceItem::_Label26
          loc_52D49D: br.s loc_52D49F
          loc_52D49F: // Referenced from: loc_52D49D
          loc_52D49F: ret
        }

        assem override strict specialname void set_Label26(class Label WithEventsValue) {

          loc_52D4A1: ldarg.0
          loc_52D4A2: ldarg.1
          loc_52D4A3: stfld GCUv2.frmPurchaseInvoiceItem::_Label26
          loc_52D4A8: ret
        }

        public specialname int32 get_SupplierId() {

          int32 num_1;

        }

        public specialname void set_SupplierId(int32 value) {

          loc_52D4C5: nop
          loc_52D4C6: ldarg.0
          loc_52D4C7: ldarg.1
          loc_52D4C8: stfld 
          loc_52D4CD: ret
        }

        public specialname int32 get_StorageId() {

          int32 num_1;

        }

        public specialname void set_StorageId(int32 value) {

          loc_52D4E9: nop
          loc_52D4EA: ldarg.0
          loc_52D4EB: ldarg.1
          loc_52D4EC: stfld GCUv2.frmPurchaseInvoiceItem::_storageId
          loc_52D4F1: ret
        }

        public specialname valuetype System.DateTime get_PurchaseDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_PurchaseDate(valuetype System.DateTime value) {

          loc_52D50D: nop
          loc_52D50E: ldarg.0
          loc_52D50F: ldarg.1
          loc_52D510: stfld GCUv2.frmPurchaseInvoiceItem::_purchaseDate
          loc_52D515: ret
        }

        public void frmPurchaseInvoiceItem(boolean CurrentData, int32 SupplierId, valuetype System.DateTime PurchaseDate, int32 StorageId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmPurchaseInvoiceItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboItem_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class GCUv2.cItem var_3;
          class ComboBox var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

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
          double flt_3;
          class GCUv2.cItem var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

    }
}
