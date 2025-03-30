using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label4;
        private class ComboBox _cboPaymentCode;
        private class Label _Label1;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label9;
        private class DateTimePicker _dtpPayment;
        private class CheckBox _chkPayInFront;
        private class Label _Label2;
        private class DateTimePicker _dtpCheque;
        private class Label _Label3;
        private class TextBox _txtChequeNo;
        private class GCUv2.FilteredTextBox _txtAmount;
        private class Label _lblAmount;
        private class Label _lblAccount;
        private class ComboBox _cboAccount;
        private class Label _lblCurrencyRate;
        private class GCUv2.FilteredTextBox _txtCurrencyRate;
        private boolean _currentData;
        private int32 _invoiceCurrencyId;
        private string _currencyName;
        private int32 _cashAccountId;
        private int32 _bankAccountId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label4() {

          loc_52FAB4: ldarg.0
          loc_52FAB5: ldfld GCUv2.frmPurchaseInvoicePayment::_Label4
          loc_52FABA: br.s loc_52FABC
          loc_52FABC: // Referenced from: loc_52FABA
          loc_52FABC: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_52FABE: ldarg.0
          loc_52FABF: ldarg.1
          loc_52FAC0: stfld GCUv2.frmPurchaseInvoicePayment::_Label4
          loc_52FAC5: ret
        }

        assem override strict specialname class ComboBox get_cboPaymentCode() {

          loc_52FAC7: ldarg.0
          loc_52FAC8: ldfld GCUv2.frmPurchaseInvoicePayment::_cboPaymentCode
          loc_52FACD: br.s loc_52FACF
          loc_52FACF: // Referenced from: loc_52FACD
          loc_52FACF: ret
        }

        assem override strict specialname void set_cboPaymentCode(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label1() {

          loc_52FB14: ldarg.0
          loc_52FB15: ldfld GCUv2.frmPurchaseInvoicePayment::_Label1
          loc_52FB1A: br.s loc_52FB1C
          loc_52FB1C: // Referenced from: loc_52FB1A
          loc_52FB1C: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_52FB1E: ldarg.0
          loc_52FB1F: ldarg.1
          loc_52FB20: stfld GCUv2.frmPurchaseInvoicePayment::_Label1
          loc_52FB25: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_52FB27: ldarg.0
          loc_52FB28: ldfld GCUv2.frmPurchaseInvoicePayment::_btnDelete
          loc_52FB2D: br.s loc_52FB2F
          loc_52FB2F: // Referenced from: loc_52FB2D
          loc_52FB2F: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_52FB74: ldarg.0
          loc_52FB75: ldfld GCUv2.frmPurchaseInvoicePayment::_btnSave
          loc_52FB7A: br.s loc_52FB7C
          loc_52FB7C: // Referenced from: loc_52FB7A
          loc_52FB7C: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_52FBC4: ldarg.0
          loc_52FBC5: ldfld GCUv2.frmPurchaseInvoicePayment::_Label9
          loc_52FBCA: br.s loc_52FBCC
          loc_52FBCC: // Referenced from: loc_52FBCA
          loc_52FBCC: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_52FBCE: ldarg.0
          loc_52FBCF: ldarg.1
          loc_52FBD0: stfld GCUv2.frmPurchaseInvoicePayment::_Label9
          loc_52FBD5: ret
        }

        assem override strict specialname class DateTimePicker get_dtpPayment() {

          loc_52FBD7: ldarg.0
          loc_52FBD8: ldfld GCUv2.frmPurchaseInvoicePayment::_dtpPayment
          loc_52FBDD: br.s loc_52FBDF
          loc_52FBDF: // Referenced from: loc_52FBDD
          loc_52FBDF: ret
        }

        assem override strict specialname void set_dtpPayment(class DateTimePicker WithEventsValue) {

          loc_52FBE1: ldarg.0
          loc_52FBE2: ldarg.1
          loc_52FBE3: stfld GCUv2.frmPurchaseInvoicePayment::_dtpPayment
          loc_52FBE8: ret
        }

        assem override strict specialname class CheckBox get_chkPayInFront() {

          loc_52FBEA: ldarg.0
          loc_52FBEB: ldfld GCUv2.frmPurchaseInvoicePayment::_chkPayInFront
          loc_52FBF0: br.s loc_52FBF2
          loc_52FBF2: // Referenced from: loc_52FBF0
          loc_52FBF2: ret
        }

        assem override strict specialname void set_chkPayInFront(class CheckBox WithEventsValue) {

          loc_52FBF4: ldarg.0
          loc_52FBF5: ldarg.1
          loc_52FBF6: stfld GCUv2.frmPurchaseInvoicePayment::_chkPayInFront
          loc_52FBFB: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_52FBFD: ldarg.0
          loc_52FBFE: ldfld GCUv2.frmPurchaseInvoicePayment::_Label2
          loc_52FC03: br.s loc_52FC05
          loc_52FC05: // Referenced from: loc_52FC03
          loc_52FC05: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_52FC07: ldarg.0
          loc_52FC08: ldarg.1
          loc_52FC09: stfld GCUv2.frmPurchaseInvoicePayment::_Label2
          loc_52FC0E: ret
        }

        assem override strict specialname class DateTimePicker get_dtpCheque() {

          loc_52FC10: ldarg.0
          loc_52FC11: ldfld GCUv2.frmPurchaseInvoicePayment::_dtpCheque
          loc_52FC16: br.s loc_52FC18
          loc_52FC18: // Referenced from: loc_52FC16
          loc_52FC18: ret
        }

        assem override strict specialname void set_dtpCheque(class DateTimePicker WithEventsValue) {

          loc_52FC1A: ldarg.0
          loc_52FC1B: ldarg.1
          loc_52FC1C: stfld GCUv2.frmPurchaseInvoicePayment::_dtpCheque
          loc_52FC21: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_52FC23: ldarg.0
          loc_52FC24: ldfld GCUv2.frmPurchaseInvoicePayment::_Label3
          loc_52FC29: br.s loc_52FC2B
          loc_52FC2B: // Referenced from: loc_52FC29
          loc_52FC2B: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_52FC2D: ldarg.0
          loc_52FC2E: ldarg.1
          loc_52FC2F: stfld GCUv2.frmPurchaseInvoicePayment::_Label3
          loc_52FC34: ret
        }

        assem override strict specialname class TextBox get_txtChequeNo() {

          loc_52FC36: ldarg.0
          loc_52FC37: ldfld GCUv2.frmPurchaseInvoicePayment::_txtChequeNo
          loc_52FC3C: br.s loc_52FC3E
          loc_52FC3E: // Referenced from: loc_52FC3C
          loc_52FC3E: ret
        }

        assem override strict specialname void set_txtChequeNo(class TextBox WithEventsValue) {

          loc_52FC40: ldarg.0
          loc_52FC41: ldarg.1
          loc_52FC42: stfld GCUv2.frmPurchaseInvoicePayment::_txtChequeNo
          loc_52FC47: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtAmount() {

          loc_52FC49: ldarg.0
          loc_52FC4A: ldfld GCUv2.frmPurchaseInvoicePayment::_txtAmount
          loc_52FC4F: br.s loc_52FC51
          loc_52FC51: // Referenced from: loc_52FC4F
          loc_52FC51: ret
        }

        assem override strict specialname void set_txtAmount(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52FC53: ldarg.0
          loc_52FC54: ldarg.1
          loc_52FC55: stfld GCUv2.frmPurchaseInvoicePayment::_txtAmount
          loc_52FC5A: ret
        }

        assem override strict specialname class Label get_lblAmount() {

          loc_52FC5C: ldarg.0
          loc_52FC5D: ldfld GCUv2.frmPurchaseInvoicePayment::_lblAmount
          loc_52FC62: br.s loc_52FC64
          loc_52FC64: // Referenced from: loc_52FC62
          loc_52FC64: ret
        }

        assem override strict specialname void set_lblAmount(class Label WithEventsValue) {

          loc_52FC66: ldarg.0
          loc_52FC67: ldarg.1
          loc_52FC68: stfld GCUv2.frmPurchaseInvoicePayment::_lblAmount
          loc_52FC6D: ret
        }

        assem override strict specialname class Label get_lblAccount() {

          loc_52FC6F: ldarg.0
          loc_52FC70: ldfld GCUv2.frmPurchaseInvoicePayment::_lblAccount
          loc_52FC75: br.s loc_52FC77
          loc_52FC77: // Referenced from: loc_52FC75
          loc_52FC77: ret
        }

        assem override strict specialname void set_lblAccount(class Label WithEventsValue) {

          loc_52FC79: ldarg.0
          loc_52FC7A: ldarg.1
          loc_52FC7B: stfld GCUv2.frmPurchaseInvoicePayment::_lblAccount
          loc_52FC80: ret
        }

        assem override strict specialname class ComboBox get_cboAccount() {

          loc_52FC82: ldarg.0
          loc_52FC83: ldfld GCUv2.frmPurchaseInvoicePayment::_cboAccount
          loc_52FC88: br.s loc_52FC8A
          loc_52FC8A: // Referenced from: loc_52FC88
          loc_52FC8A: ret
        }

        assem override strict specialname void set_cboAccount(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_lblCurrencyRate() {

          loc_52FCD0: ldarg.0
          loc_52FCD1: ldfld GCUv2.frmPurchaseInvoicePayment::_lblCurrencyRate
          loc_52FCD6: br.s loc_52FCD8
          loc_52FCD8: // Referenced from: loc_52FCD6
          loc_52FCD8: ret
        }

        assem override strict specialname void set_lblCurrencyRate(class Label WithEventsValue) {

          loc_52FCDA: ldarg.0
          loc_52FCDB: ldarg.1
          loc_52FCDC: stfld GCUv2.frmPurchaseInvoicePayment::_lblCurrencyRate
          loc_52FCE1: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtCurrencyRate() {

          loc_52FCE3: ldarg.0
          loc_52FCE4: ldfld GCUv2.frmPurchaseInvoicePayment::_txtCurrencyRate
          loc_52FCE9: br.s loc_52FCEB
          loc_52FCEB: // Referenced from: loc_52FCE9
          loc_52FCEB: ret
        }

        assem override strict specialname void set_txtCurrencyRate(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52FCED: ldarg.0
          loc_52FCEE: ldarg.1
          loc_52FCEF: stfld GCUv2.frmPurchaseInvoicePayment::_txtCurrencyRate
          loc_52FCF4: ret
        }

        public specialname int32 get_CashAccountId() {

          int32 num_1;

        }

        public specialname void set_CashAccountId(int32 value) {

          loc_52FD11: nop
          loc_52FD12: ldarg.0
          loc_52FD13: ldarg.1
          loc_52FD14: stfld GCUv2.frmPurchaseInvoicePayment::_cashAccountId
          loc_52FD19: ret
        }

        public specialname int32 get_BankAccountId() {

          int32 num_1;

        }

        public specialname void set_BankAccountId(int32 value) {

          loc_52FD35: nop
          loc_52FD36: ldarg.0
          loc_52FD37: ldarg.1
          loc_52FD38: stfld GCUv2.frmPurchaseInvoicePayment::_bankAccountId
          loc_52FD3D: ret
        }

        public void frmPurchaseInvoicePayment(boolean CurrentData, int32 CurrencyId) {

          boolean var_1;
          boolean var_2;
          class GCUv2.cCurrency var_3;
          class ComboBox var_4;
          boolean var_5;

        }

        private void frmPurchaseInvoicePayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          valuetype System.DateTime var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

        private void cboPaymentType_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void cboAccount_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class DataTable var_3;
          boolean var_4;

        }

    }
}
