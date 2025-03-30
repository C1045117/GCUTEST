using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label1;
        private class ComboBox _cboPaymentCode;
        private class Label _lblAccount;
        private class ComboBox _cboAccount;
        private class GCUv2.FilteredTextBox _txtAmount;
        private class Label _Label5;
        private class Label _Label9;
        private class DateTimePicker _dtpPayment;
        private class Label _Label4;
        private class ComboBox _cboSalesPerson;
        private class Button _btnDelete;
        private class Button _btnSave;
        private boolean _currentData;
        private string _currencyName;
        private int32 _cashAccountId;
        private int32 _bankAccountId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label1() {

          loc_5012F0: ldarg.0
          loc_5012F1: ldfld GCUv2.frmSalesReturnPayment::_Label1
          loc_5012F6: br.s loc_5012F8
          loc_5012F8: // Referenced from: loc_5012F6
          loc_5012F8: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_5012FA: ldarg.0
          loc_5012FB: ldarg.1
          loc_5012FC: stfld GCUv2.frmSalesReturnPayment::_Label1
          loc_501301: ret
        }

        assem override strict specialname class ComboBox get_cboPaymentCode() {

          loc_501303: ldarg.0
          loc_501304: ldfld GCUv2.frmSalesReturnPayment::_cboPaymentCode
          loc_501309: br.s loc_50130B
          loc_50130B: // Referenced from: loc_501309
          loc_50130B: ret
        }

        assem override strict specialname void set_cboPaymentCode(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_lblAccount() {

          loc_501350: ldarg.0
          loc_501351: ldfld GCUv2.frmSalesReturnPayment::_lblAccount
          loc_501356: br.s loc_501358
          loc_501358: // Referenced from: loc_501356
          loc_501358: ret
        }

        assem override strict specialname void set_lblAccount(class Label WithEventsValue) {

          loc_50135A: ldarg.0
          loc_50135B: ldarg.1
          loc_50135C: stfld GCUv2.frmSalesReturnPayment::_lblAccount
          loc_501361: ret
        }

        assem override strict specialname class ComboBox get_cboAccount() {

          loc_501363: ldarg.0
          loc_501364: ldfld GCUv2.frmSalesReturnPayment::_cboAccount
          loc_501369: br.s loc_50136B
          loc_50136B: // Referenced from: loc_501369
          loc_50136B: ret
        }

        assem override strict specialname void set_cboAccount(class ComboBox WithEventsValue) {

          loc_50136D: ldarg.0
          loc_50136E: ldarg.1
          loc_50136F: stfld GCUv2.frmSalesReturnPayment::_cboAccount
          loc_501374: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtAmount() {

          loc_501376: ldarg.0
          loc_501377: ldfld GCUv2.frmSalesReturnPayment::_txtAmount
          loc_50137C: br.s loc_50137E
          loc_50137E: // Referenced from: loc_50137C
          loc_50137E: ret
        }

        assem override strict specialname void set_txtAmount(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_501380: ldarg.0
          loc_501381: ldarg.1
          loc_501382: stfld GCUv2.frmSalesReturnPayment::_txtAmount
          loc_501387: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_501389: ldarg.0
          loc_50138A: ldfld GCUv2.frmSalesReturnPayment::_Label5
          loc_50138F: br.s loc_501391
          loc_501391: // Referenced from: loc_50138F
          loc_501391: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_501393: ldarg.0
          loc_501394: ldarg.1
          loc_501395: stfld GCUv2.frmSalesReturnPayment::_Label5
          loc_50139A: ret
        }

        assem override strict specialname class Label get_Label9() {

          loc_50139C: ldarg.0
          loc_50139D: ldfld GCUv2.frmSalesReturnPayment::_Label9
          loc_5013A2: br.s loc_5013A4
          loc_5013A4: // Referenced from: loc_5013A2
          loc_5013A4: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_5013A6: ldarg.0
          loc_5013A7: ldarg.1
          loc_5013A8: stfld GCUv2.frmSalesReturnPayment::_Label9
          loc_5013AD: ret
        }

        assem override strict specialname class DateTimePicker get_dtpPayment() {

          loc_5013AF: ldarg.0
          loc_5013B0: ldfld GCUv2.frmSalesReturnPayment::_dtpPayment
          loc_5013B5: br.s loc_5013B7
          loc_5013B7: // Referenced from: loc_5013B5
          loc_5013B7: ret
        }

        assem override strict specialname void set_dtpPayment(class DateTimePicker WithEventsValue) {

          loc_5013B9: ldarg.0
          loc_5013BA: ldarg.1
          loc_5013BB: stfld GCUv2.frmSalesReturnPayment::_dtpPayment
          loc_5013C0: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_5013C2: ldarg.0
          loc_5013C3: ldfld GCUv2.frmSalesReturnPayment::_Label4
          loc_5013C8: br.s loc_5013CA
          loc_5013CA: // Referenced from: loc_5013C8
          loc_5013CA: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_5013CC: ldarg.0
          loc_5013CD: ldarg.1
          loc_5013CE: stfld GCUv2.frmSalesReturnPayment::_Label4
          loc_5013D3: ret
        }

        assem override strict specialname class ComboBox get_cboSalesPerson() {

          loc_5013D5: ldarg.0
          loc_5013D6: ldfld GCUv2.frmSalesReturnPayment::_cboSalesPerson
          loc_5013DB: br.s loc_5013DD
          loc_5013DD: // Referenced from: loc_5013DB
          loc_5013DD: ret
        }

        assem override strict specialname void set_cboSalesPerson(class ComboBox WithEventsValue) {

          loc_5013DF: ldarg.0
          loc_5013E0: ldarg.1
          loc_5013E1: stfld GCUv2.frmSalesReturnPayment::_cboSalesPerson
          loc_5013E6: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_5013E8: ldarg.0
          loc_5013E9: ldfld GCUv2.frmSalesReturnPayment::_btnDelete
          loc_5013EE: br.s loc_5013F0
          loc_5013F0: // Referenced from: loc_5013EE
          loc_5013F0: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_501438: ldarg.0
          loc_501439: ldfld GCUv2.frmSalesReturnPayment::_btnSave
          loc_50143E: br.s loc_501440
          loc_501440: // Referenced from: loc_50143E
          loc_501440: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_5014A1: nop
          loc_5014A2: ldarg.0
          loc_5014A3: ldarg.1
          loc_5014A4: stfld GCUv2.frmSalesReturnPayment::_cashAccountId
          loc_5014A9: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_5014C5: nop
          loc_5014C6: ldarg.0
          loc_5014C7: ldarg.1
          loc_5014C8: stfld GCUv2.frmSalesReturnPayment::_bankAccountId
          loc_5014CD: ret
        }

        public void frmSalesReturnPayment(boolean CurrentData, int32 SalesPersonId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSalesReturnPayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          valuetype System.DateTime var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

        private void cboPaymentCode_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          class ComboBox var_2;

        }

    }
}
