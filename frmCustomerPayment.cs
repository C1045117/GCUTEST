using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class ComboBox _cbo;
        private class Label _Label11;
        private class Button _btnSave;
        private class Button _btnDelete;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class DataGridView _dgvList;
        private class Label _lblTotalAllocation;
        private class Label _Label6;
        private class Label _lblRemain;
        private class Label _Label12;
        private class TextBox _txtDescription;
        private class Label _Label8;
        private class Button _btnSearch;
        private class Label _Label2;
        private class ComboBox _cboPaymentCode;
        private class Label _Label4;
        private class DateTimePicker _dtpPayment;
        private class Label _Label9;
        private class DateTimePicker _dtpCheque;
        private class Label _Label3;
        private class TextBox _txtChequeNo;
        private class Label _Label5;
        private class GCUv2.FilteredTextBox _txtAmount;
        private class ComboBox _cboAccount;
        private class Label _lblAccount;
        private class Label _Label7;
        private class Label _lblName;
        private class Label _lblAddress;
        private class ComboBox _cboBank;
        private class Label _Label1;
        private class Label _Label14;
        private class ComboBox _cboSalesPerson;
        private class Label _lblNote;
        private double _currentId;
        private double _customerId;
        private boolean _dontFocus;
        private boolean _formIsJustLoaded;
        private int32 _invoiceCurrencyId;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private valuetype System.DateTime _chequeDepositDate;
        private valuetype System.DateTime _chequeClearingDate;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class ComboBox get_cbo() {

          loc_442BC9: ldarg.0
          loc_442BCA: ldfld GCUv2.frmCustomerPayment::_cbo
          loc_442BCF: br.s loc_442BD1
          loc_442BD1: // Referenced from: loc_442BCF
          loc_442BD1: ret
        }

        assem override strict specialname void set_cbo(class ComboBox WithEventsValue) {

          loc_442BD3: ldarg.0
          loc_442BD4: ldarg.1
          loc_442BD5: stfld GCUv2.frmCustomerPayment::_cbo
          loc_442BDA: ret
        }

        assem override strict specialname class Label get_Label11() {

          loc_442BDC: ldarg.0
          loc_442BDD: ldfld GCUv2.frmCustomerPayment::_Label11
          loc_442BE2: br.s loc_442BE4
          loc_442BE4: // Referenced from: loc_442BE2
          loc_442BE4: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_442BE6: ldarg.0
          loc_442BE7: ldarg.1
          loc_442BE8: stfld GCUv2.frmCustomerPayment::_Label11
          loc_442BED: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_442BEF: ldarg.0
          loc_442BF0: ldfld GCUv2.frmCustomerPayment::_btnSave
          loc_442BF5: br.s loc_442BF7
          loc_442BF7: // Referenced from: loc_442BF5
          loc_442BF7: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_442C3C: ldarg.0
          loc_442C3D: ldfld GCUv2.frmCustomerPayment::_btnDelete
          loc_442C42: br.s loc_442C44
          loc_442C44: // Referenced from: loc_442C42
          loc_442C44: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_442C8C: ldarg.0
          loc_442C8D: ldfld GCUv2.frmCustomerPayment::_btnHistory
          loc_442C92: br.s loc_442C94
          loc_442C94: // Referenced from: loc_442C92
          loc_442C94: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_442CDC: ldarg.0
          loc_442CDD: ldfld GCUv2.frmCustomerPayment::_btnSaveClose
          loc_442CE2: br.s loc_442CE4
          loc_442CE4: // Referenced from: loc_442CE2
          loc_442CE4: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_442D2C: ldarg.0
          loc_442D2D: ldfld GCUv2.frmCustomerPayment::_dgvList
          loc_442D32: br.s loc_442D34
          loc_442D34: // Referenced from: loc_442D32
          loc_442D34: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class DataGridViewCellEventHandler var_1;
          class DataGridViewCellEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class KeyEventHandler var_5;
          class DataGridViewCellValidatingEventHandler var_6;
          class DataGridViewCellFormattingEventHandler var_7;
          class System.EventHandler var_8;
          class DataGridViewCellEventHandler var_9;
          class DataGridView var_10;

        }

        assem override strict specialname class Label get_lblTotalAllocation() {

          loc_442E79: ldarg.0
          loc_442E7A: ldfld GCUv2.frmCustomerPayment::_lblTotalAllocation
          loc_442E7F: br.s loc_442E81
          loc_442E81: // Referenced from: loc_442E7F
          loc_442E81: ret
        }

        assem override strict specialname void set_lblTotalAllocation(class Label WithEventsValue) {

          loc_442E83: ldarg.0
          loc_442E84: ldarg.1
          loc_442E85: stfld GCUv2.frmCustomerPayment::_lblTotalAllocation
          loc_442E8A: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_442E8C: ldarg.0
          loc_442E8D: ldfld GCUv2.frmCustomerPayment::_Label6
          loc_442E92: br.s loc_442E94
          loc_442E94: // Referenced from: loc_442E92
          loc_442E94: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_442E96: ldarg.0
          loc_442E97: ldarg.1
          loc_442E98: stfld GCUv2.frmCustomerPayment::_Label6
          loc_442E9D: ret
        }

        assem override strict specialname class Label get_lblRemain() {

          loc_442E9F: ldarg.0
          loc_442EA0: ldfld GCUv2.frmCustomerPayment::_lblRemain
          loc_442EA5: br.s loc_442EA7
          loc_442EA7: // Referenced from: loc_442EA5
          loc_442EA7: ret
        }

        assem override strict specialname void set_lblRemain(class Label WithEventsValue) {

          loc_442EA9: ldarg.0
          loc_442EAA: ldarg.1
          loc_442EAB: stfld GCUv2.frmCustomerPayment::_lblRemain
          loc_442EB0: ret
        }

        assem override strict specialname class Label get_Label12() {

          loc_442EB2: ldarg.0
          loc_442EB3: ldfld GCUv2.frmCustomerPayment::_Label12
          loc_442EB8: br.s loc_442EBA
          loc_442EBA: // Referenced from: loc_442EB8
          loc_442EBA: ret
        }

        assem override strict specialname void set_Label12(class Label WithEventsValue) {

          loc_442EBC: ldarg.0
          loc_442EBD: ldarg.1
          loc_442EBE: stfld GCUv2.frmCustomerPayment::_Label12
          loc_442EC3: ret
        }

        assem override strict specialname class TextBox get_txtDescription() {

          loc_442EC5: ldarg.0
          loc_442EC6: ldfld GCUv2.frmCustomerPayment::_txtDescription
          loc_442ECB: br.s loc_442ECD
          loc_442ECD: // Referenced from: loc_442ECB
          loc_442ECD: ret
        }

        assem override strict specialname void set_txtDescription(class TextBox WithEventsValue) {

          loc_442ECF: ldarg.0
          loc_442ED0: ldarg.1
          loc_442ED1: stfld GCUv2.frmCustomerPayment::_txtDescription
          loc_442ED6: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_442ED8: ldarg.0
          loc_442ED9: ldfld GCUv2.frmCustomerPayment::_Label8
          loc_442EDE: br.s loc_442EE0
          loc_442EE0: // Referenced from: loc_442EDE
          loc_442EE0: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_442EE2: ldarg.0
          loc_442EE3: ldarg.1
          loc_442EE4: stfld GCUv2.frmCustomerPayment::_Label8
          loc_442EE9: ret
        }

        assem override strict specialname class Button get_btnSearch() {

          loc_442EEB: ldarg.0
          loc_442EEC: ldfld GCUv2.frmCustomerPayment::_btnSearch
          loc_442EF1: br.s loc_442EF3
          loc_442EF3: // Referenced from: loc_442EF1
          loc_442EF3: ret
        }

        assem override strict specialname void set_btnSearch(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label2() {

          loc_442F38: ldarg.0
          loc_442F39: ldfld GCUv2.frmCustomerPayment::_Label2
          loc_442F3E: br.s loc_442F40
          loc_442F40: // Referenced from: loc_442F3E
          loc_442F40: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_442F42: ldarg.0
          loc_442F43: ldarg.1
          loc_442F44: stfld GCUv2.frmCustomerPayment::_Label2
          loc_442F49: ret
        }

        assem override strict specialname class ComboBox get_cboPaymentCode() {

          loc_442F4B: ldarg.0
          loc_442F4C: ldfld GCUv2.frmCustomerPayment::_cboPaymentCode
          loc_442F51: br.s loc_442F53
          loc_442F53: // Referenced from: loc_442F51
          loc_442F53: ret
        }

        assem override strict specialname void set_cboPaymentCode(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label4() {

          loc_442F98: ldarg.0
          loc_442F99: ldfld GCUv2.frmCustomerPayment::_Label4
          loc_442F9E: br.s loc_442FA0
          loc_442FA0: // Referenced from: loc_442F9E
          loc_442FA0: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_442FA2: ldarg.0
          loc_442FA3: ldarg.1
          loc_442FA4: stfld GCUv2.frmCustomerPayment::_Label4
          loc_442FA9: ret
        }

        assem override strict specialname class DateTimePicker get_dtpPayment() {

          loc_442FAB: ldarg.0
          loc_442FAC: ldfld GCUv2.frmCustomerPayment::_dtpPayment
          loc_442FB1: br.s loc_442FB3
          loc_442FB3: // Referenced from: loc_442FB1
          loc_442FB3: ret
        }

        assem override strict specialname void set_dtpPayment(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_442FF8: ldarg.0
          loc_442FF9: ldfld GCUv2.frmCustomerPayment::_Label9
          loc_442FFE: br.s loc_443000
          loc_443000: // Referenced from: loc_442FFE
          loc_443000: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_443002: ldarg.0
          loc_443003: ldarg.1
          loc_443004: stfld GCUv2.frmCustomerPayment::_Label9
          loc_443009: ret
        }

        assem override strict specialname class DateTimePicker get_dtpCheque() {

          loc_44300B: ldarg.0
          loc_44300C: ldfld GCUv2.frmCustomerPayment::_dtpCheque
          loc_443011: br.s loc_443013
          loc_443013: // Referenced from: loc_443011
          loc_443013: ret
        }

        assem override strict specialname void set_dtpCheque(class DateTimePicker WithEventsValue) {

          loc_443015: ldarg.0
          loc_443016: ldarg.1
          loc_443017: stfld GCUv2.frmCustomerPayment::_dtpCheque
          loc_44301C: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_44301E: ldarg.0
          loc_44301F: ldfld GCUv2.frmCustomerPayment::_Label3
          loc_443024: br.s loc_443026
          loc_443026: // Referenced from: loc_443024
          loc_443026: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_443028: ldarg.0
          loc_443029: ldarg.1
          loc_44302A: stfld GCUv2.frmCustomerPayment::_Label3
          loc_44302F: ret
        }

        assem override strict specialname class TextBox get_txtChequeNo() {

          loc_443031: ldarg.0
          loc_443032: ldfld GCUv2.frmCustomerPayment::_txtChequeNo
          loc_443037: br.s loc_443039
          loc_443039: // Referenced from: loc_443037
          loc_443039: ret
        }

        assem override strict specialname void set_txtChequeNo(class TextBox WithEventsValue) {

          loc_44303B: ldarg.0
          loc_44303C: ldarg.1
          loc_44303D: stfld GCUv2.frmCustomerPayment::_txtChequeNo
          loc_443042: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_443044: ldarg.0
          loc_443045: ldfld GCUv2.frmCustomerPayment::_Label5
          loc_44304A: br.s loc_44304C
          loc_44304C: // Referenced from: loc_44304A
          loc_44304C: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_44304E: ldarg.0
          loc_44304F: ldarg.1
          loc_443050: stfld GCUv2.frmCustomerPayment::_Label5
          loc_443055: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtAmount() {

          loc_443057: ldarg.0
          loc_443058: ldfld GCUv2.frmCustomerPayment::_txtAmount
          loc_44305D: br.s loc_44305F
          loc_44305F: // Referenced from: loc_44305D
          loc_44305F: ret
        }

        assem override strict specialname void set_txtAmount(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class GCUv2.FilteredTextBox var_2;

        }

        assem override strict specialname class ComboBox get_cboAccount() {

          loc_4430A4: ldarg.0
          loc_4430A5: ldfld GCUv2.frmCustomerPayment::_cboAccount
          loc_4430AA: br.s loc_4430AC
          loc_4430AC: // Referenced from: loc_4430AA
          loc_4430AC: ret
        }

        assem override strict specialname void set_cboAccount(class ComboBox WithEventsValue) {

          loc_4430AE: ldarg.0
          loc_4430AF: ldarg.1
          loc_4430B0: stfld GCUv2.frmCustomerPayment::_cboAccount
          loc_4430B5: ret
        }

        assem override strict specialname class Label get_lblAccount() {

          loc_4430B7: ldarg.0
          loc_4430B8: ldfld GCUv2.frmCustomerPayment::_lblAccount
          loc_4430BD: br.s loc_4430BF
          loc_4430BF: // Referenced from: loc_4430BD
          loc_4430BF: ret
        }

        assem override strict specialname void set_lblAccount(class Label WithEventsValue) {

          loc_4430C1: ldarg.0
          loc_4430C2: ldarg.1
          loc_4430C3: stfld GCUv2.frmCustomerPayment::_lblAccount
          loc_4430C8: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_4430CA: ldarg.0
          loc_4430CB: ldfld GCUv2.frmCustomerPayment::_Label7
          loc_4430D0: br.s loc_4430D2
          loc_4430D2: // Referenced from: loc_4430D0
          loc_4430D2: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_4430D4: ldarg.0
          loc_4430D5: ldarg.1
          loc_4430D6: stfld GCUv2.frmCustomerPayment::_Label7
          loc_4430DB: ret
        }

        assem override strict specialname class Label get_lblName() {

          loc_4430DD: ldarg.0
          loc_4430DE: ldfld GCUv2.frmCustomerPayment::_lblName
          loc_4430E3: br.s loc_4430E5
          loc_4430E5: // Referenced from: loc_4430E3
          loc_4430E5: ret
        }

        assem override strict specialname void set_lblName(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        assem override strict specialname class Label get_lblAddress() {

          loc_44312C: ldarg.0
          loc_44312D: ldfld GCUv2.frmCustomerPayment::_lblAddress
          loc_443132: br.s loc_443134
          loc_443134: // Referenced from: loc_443132
          loc_443134: ret
        }

        assem override strict specialname void set_lblAddress(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        assem override strict specialname class ComboBox get_cboBank() {

          loc_44317C: ldarg.0
          loc_44317D: ldfld GCUv2.frmCustomerPayment::_cboBank
          loc_443182: br.s loc_443184
          loc_443184: // Referenced from: loc_443182
          loc_443184: ret
        }

        assem override strict specialname void set_cboBank(class ComboBox WithEventsValue) {

          loc_443186: ldarg.0
          loc_443187: ldarg.1
          loc_443188: stfld GCUv2.frmCustomerPayment::_cboBank
          loc_44318D: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_44318F: ldarg.0
          loc_443190: ldfld GCUv2.frmCustomerPayment::_Label1
          loc_443195: br.s loc_443197
          loc_443197: // Referenced from: loc_443195
          loc_443197: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_443199: ldarg.0
          loc_44319A: ldarg.1
          loc_44319B: stfld GCUv2.frmCustomerPayment::_Label1
          loc_4431A0: ret
        }

        assem override strict specialname class Label get_Label14() {

          loc_4431A2: ldarg.0
          loc_4431A3: ldfld GCUv2.frmCustomerPayment::_Label14
          loc_4431A8: br.s loc_4431AA
          loc_4431AA: // Referenced from: loc_4431A8
          loc_4431AA: ret
        }

        assem override strict specialname void set_Label14(class Label WithEventsValue) {

          loc_4431AC: ldarg.0
          loc_4431AD: ldarg.1
          loc_4431AE: stfld GCUv2.frmCustomerPayment::_Label14
          loc_4431B3: ret
        }

        assem override strict specialname class ComboBox get_cboSalesPerson() {

          loc_4431B5: ldarg.0
          loc_4431B6: ldfld GCUv2.frmCustomerPayment::_cboSalesPerson
          loc_4431BB: br.s loc_4431BD
          loc_4431BD: // Referenced from: loc_4431BB
          loc_4431BD: ret
        }

        assem override strict specialname void set_cboSalesPerson(class ComboBox WithEventsValue) {

          loc_4431BF: ldarg.0
          loc_4431C0: ldarg.1
          loc_4431C1: stfld GCUv2.frmCustomerPayment::_cboSalesPerson
          loc_4431C6: ret
        }

        assem override strict specialname class Label get_lblNote() {

          loc_4431C8: ldarg.0
          loc_4431C9: ldfld GCUv2.frmCustomerPayment::_lblNote
          loc_4431CE: br.s loc_4431D0
          loc_4431D0: // Referenced from: loc_4431CE
          loc_4431D0: ret
        }

        assem override strict specialname void set_lblNote(class Label WithEventsValue) {

          loc_4431D2: ldarg.0
          loc_4431D3: ldarg.1
          loc_4431D4: stfld GCUv2.frmCustomerPayment::_lblNote
          loc_4431D9: ret
        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_4431F5: nop
          loc_4431F6: ldarg.0
          loc_4431F7: ldarg.1
          loc_4431F8: stfld GCUv2.frmCustomerPayment::_currentId
          loc_4431FD: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_443219: nop
          loc_44321A: ldarg.0
          loc_44321B: ldarg.1
          loc_44321C: stfld GCUv2.frmCustomerPayment::_customerId
          loc_443221: ret
        }

        public void frmCustomerPayment() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        public void PrepareForm(boolean SaveNew) {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cSalesInvoiceMultiPayment var_1;
          class ComboBox var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.cSalesInvoicePayment[] var_6;
          int32 num_3;
          class GCUv2.cSalesInvoicePayment var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          valuetype System.DateTime var_11;
          boolean var_12;

        }

        private void FormatGrid() {

          class DataGridViewCheckBoxColumn var_1;

        }

        private void frmPayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSearch_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmCustomerMiniSearch var_1;
          boolean var_2;

        }

        public void LoadCustomer() {

          class GCUv2.cCustomer var_1;
          class ComboBox var_2;

        }

        private void lblName_Click(object sender, class System.EventArgs e) {

          loc_443E99: nop
          loc_443E9A: ldarg.0
          loc_443E9B: call instance void GCUv2.frmCustomerPayment::OpenCustomer()
          loc_443EA0: nop
          loc_443EA1: ret
        }

        private void lblAddress_Click(object sender, class System.EventArgs e) {

          loc_443E99: nop
          loc_443E9A: ldarg.0
          loc_443E9B: call instance void GCUv2.frmCustomerPayment::OpenCustomer()
          loc_443EA0: nop
          loc_443EA1: ret
        }

        private void OpenCustomer() {

          boolean var_1;

        }

        private void dgvList_CellContentClick(object sender, class DataGridViewCellEventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          class GCUv2.cComboItem var_3;
          boolean var_4;

        }

        private void dgvList_CellContentDoubleClick(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          boolean var_2;
          class GCUv2.cComboItem var_3;
          boolean var_4;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void UntickAllocation() {


        }

        private void TickAllocation() {


        }

        private void dgvList_CellValidating(object sender, class DataGridViewCellValidatingEventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void dgvList_CellFormatting(object sender, class DataGridViewCellFormattingEventArgs e) {

          boolean var_1;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_4447C2: nop
          loc_4447C3: ldarg.0
          loc_4447C4: call instance void GCUv2.frmCustomerPayment::openSelection()
          loc_4447C9: nop
          loc_4447CA: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void CalculateAllocation() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          double flt_2;
          int32 num_4;
          boolean var_1;
          boolean var_2;

        }

        private void GetUnpaid() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          int32 num_3;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;
          class DataGridView var_5;
          boolean var_6;
          boolean var_7;

        }

        public boolean IsInDataGridView(class DataGridView& dgvList, string SearchValue, int32 Column, int32 MaxRow) {

          boolean var_1;
          int32 num_1;
          int32 num_2;
          boolean var_2;

        }

        private void cboPaymentCode_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_444E20: nop
          loc_444E21: ldarg.0
          loc_444E22: ldc.i4.0
          loc_444E23: call instance void GCUv2.frmCustomerPayment::SaveData(boolean)
          loc_444E28: nop
          loc_444E29: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_444E2B: nop
          loc_444E2C: ldarg.0
          loc_444E2D: ldc.i4.1
          loc_444E2E: call instance void GCUv2.frmCustomerPayment::SaveData(boolean)
          loc_444E33: nop
          loc_444E34: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          class GCUv2.cComboItem var_4;
          class GCUv2.cSalesInvoiceMultiPayment var_5;
          class GCUv2.cSalesInvoicePayment[] var_6;
          int32 num_3;
          string str_1;
          int32 num_4;
          string str_2;
          string str_3;
          class GCUv2.cHistory var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          int32 num_5;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cSalesInvoiceMultiPayment var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

        private void dgvList_CellValidated(object sender, class DataGridViewCellEventArgs e) {

          loc_44592A: nop
          loc_44592B: ldarg.0
          loc_44592C: call instance void GCUv2.frmCustomerPayment::CalculateAllocation()
          loc_445931: nop
          loc_445932: ret
        }

        private void txtAmount_TextChanged(object sender, class System.EventArgs e) {

          loc_44592A: nop
          loc_44592B: ldarg.0
          loc_44592C: call instance void GCUv2.frmCustomerPayment::CalculateAllocation()
          loc_445931: nop
          loc_445932: ret
        }

        private void dtpPayment_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          valuetype System.DateTime var_2;
          boolean var_3;

        }

    }
}
