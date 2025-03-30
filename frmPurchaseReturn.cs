using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSaveClose;
        private class Button _btnHistory;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label10;
        private class Label _lblRetur;
        private class Label _Label13;
        private class Label _Label12;
        private class Label _Label11;
        private class Label _Label9;
        private class Label _lblTotalInvoice;
        private class Label _Label8;
        private class TabPage _TabPage4;
        private class GCUv2.FilteredTextBox _txtDiscount;
        private class Label _Label7;
        private class ComboBox _cboSupplier;
        private class Label _Label1;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class Button _btnItem;
        private class DataGridView _dgvItem;
        private class TabPage _TabPage2;
        private class DataGridView _dgvPayment;
        private class Button _btnPayment;
        private class Label _lblTotalReceivable;
        private class Label _lblTotalPayment;
        private class Label _lblTotalPrice;
        private class Label _Label6;
        private class DateTimePicker _dtpInvoice;
        private class Label _Label5;
        private class Label _lblSupplier;
        private class Label _Label16;
        private class ComboBox _cboInvoiceCode;
        private class Label _Label15;
        private class Label _lblTotalPaymentPlusDeduction;
        private class GCUv2.FilteredTextBox _txtDeduction;
        private class Label _Label14;
        private class Label _lblNumber;
        private class Label _lblInformation;
        private class Button _btnPrint;
        private class Label _lblCurrencyName;
        private class GCUv2.FilteredTextBox _txtCurrencyRate;
        private class Label _Label17;
        private class Label _Label4;
        private class ComboBox _cboStorage;
        private double _currentId;
        private int32 _currentlySelectedComboIndex;
        private boolean _suppressComboChange;
        private valuetype System.DateTime _paidDate;
        private double _parentInvoiceId;
        private valuetype System.DateTime _originalDate;
        private int32 _originalStorageId;
        private int32 _currencyId;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private boolean _edited;
        private class GCUv2.cPurchaseInvoiceItem[] _item;
        private boolean _disableDgvItem;
        private boolean _justLoaded;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_458BDF: ldarg.0
          loc_458BE0: ldfld GCUv2.frmPurchaseReturn::_btnSaveClose
          loc_458BE5: br.s loc_458BE7
          loc_458BE7: // Referenced from: loc_458BE5
          loc_458BE7: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_458C2C: ldarg.0
          loc_458C2D: ldfld GCUv2.frmPurchaseReturn::_btnHistory
          loc_458C32: br.s loc_458C34
          loc_458C34: // Referenced from: loc_458C32
          loc_458C34: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_458C7C: ldarg.0
          loc_458C7D: ldfld GCUv2.frmPurchaseReturn::_btnDelete
          loc_458C82: br.s loc_458C84
          loc_458C84: // Referenced from: loc_458C82
          loc_458C84: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_458CCC: ldarg.0
          loc_458CCD: ldfld GCUv2.frmPurchaseReturn::_btnSave
          loc_458CD2: br.s loc_458CD4
          loc_458CD4: // Referenced from: loc_458CD2
          loc_458CD4: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label10() {

          loc_458D1C: ldarg.0
          loc_458D1D: ldfld GCUv2.frmPurchaseReturn::_Label10
          loc_458D22: br.s loc_458D24
          loc_458D24: // Referenced from: loc_458D22
          loc_458D24: ret
        }

        assem override strict specialname void set_Label10(class Label WithEventsValue) {

          loc_458D26: ldarg.0
          loc_458D27: ldarg.1
          loc_458D28: stfld GCUv2.frmPurchaseReturn::_Label10
          loc_458D2D: ret
        }

        assem override strict specialname class Label get_lblRetur() {

          loc_458D2F: ldarg.0
          loc_458D30: ldfld GCUv2.frmPurchaseReturn::_lblRetur
          loc_458D35: br.s loc_458D37
          loc_458D37: // Referenced from: loc_458D35
          loc_458D37: ret
        }

        assem override strict specialname void set_lblRetur(class Label WithEventsValue) {

          loc_458D39: ldarg.0
          loc_458D3A: ldarg.1
          loc_458D3B: stfld GCUv2.frmPurchaseReturn::_lblRetur
          loc_458D40: ret
        }

        assem override strict specialname class Label get_Label13() {

          loc_458D42: ldarg.0
          loc_458D43: ldfld GCUv2.frmPurchaseReturn::_Label13
          loc_458D48: br.s loc_458D4A
          loc_458D4A: // Referenced from: loc_458D48
          loc_458D4A: ret
        }

        assem override strict specialname void set_Label13(class Label WithEventsValue) {

          loc_458D4C: ldarg.0
          loc_458D4D: ldarg.1
          loc_458D4E: stfld GCUv2.frmPurchaseReturn::_Label13
          loc_458D53: ret
        }

        assem override strict specialname class Label get_Label12() {

          loc_458D55: ldarg.0
          loc_458D56: ldfld GCUv2.frmPurchaseReturn::_Label12
          loc_458D5B: br.s loc_458D5D
          loc_458D5D: // Referenced from: loc_458D5B
          loc_458D5D: ret
        }

        assem override strict specialname void set_Label12(class Label WithEventsValue) {

          loc_458D5F: ldarg.0
          loc_458D60: ldarg.1
          loc_458D61: stfld GCUv2.frmPurchaseReturn::_Label12
          loc_458D66: ret
        }

        assem override strict specialname class Label get_Label11() {

          loc_458D68: ldarg.0
          loc_458D69: ldfld GCUv2.frmPurchaseReturn::_Label11
          loc_458D6E: br.s loc_458D70
          loc_458D70: // Referenced from: loc_458D6E
          loc_458D70: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_458D72: ldarg.0
          loc_458D73: ldarg.1
          loc_458D74: stfld GCUv2.frmPurchaseReturn::_Label11
          loc_458D79: ret
        }

        assem override strict specialname class Label get_Label9() {

          loc_458D7B: ldarg.0
          loc_458D7C: ldfld GCUv2.frmPurchaseReturn::_Label9
          loc_458D81: br.s loc_458D83
          loc_458D83: // Referenced from: loc_458D81
          loc_458D83: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_458D85: ldarg.0
          loc_458D86: ldarg.1
          loc_458D87: stfld GCUv2.frmPurchaseReturn::_Label9
          loc_458D8C: ret
        }

        assem override strict specialname class Label get_lblTotalInvoice() {

          loc_458D8E: ldarg.0
          loc_458D8F: ldfld GCUv2.frmPurchaseReturn::_lblTotalInvoice
          loc_458D94: br.s loc_458D96
          loc_458D96: // Referenced from: loc_458D94
          loc_458D96: ret
        }

        assem override strict specialname void set_lblTotalInvoice(class Label WithEventsValue) {

          loc_458D98: ldarg.0
          loc_458D99: ldarg.1
          loc_458D9A: stfld GCUv2.frmPurchaseReturn::_lblTotalInvoice
          loc_458D9F: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_458DA1: ldarg.0
          loc_458DA2: ldfld GCUv2.frmPurchaseReturn::_Label8
          loc_458DA7: br.s loc_458DA9
          loc_458DA9: // Referenced from: loc_458DA7
          loc_458DA9: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_458DAB: ldarg.0
          loc_458DAC: ldarg.1
          loc_458DAD: stfld GCUv2.frmPurchaseReturn::_Label8
          loc_458DB2: ret
        }

        assem override strict specialname class TabPage get_TabPage4() {

          loc_458DB4: ldarg.0
          loc_458DB5: ldfld GCUv2.frmPurchaseReturn::_TabPage4
          loc_458DBA: br.s loc_458DBC
          loc_458DBC: // Referenced from: loc_458DBA
          loc_458DBC: ret
        }

        assem override strict specialname void set_TabPage4(class TabPage WithEventsValue) {

          loc_458DBE: ldarg.0
          loc_458DBF: ldarg.1
          loc_458DC0: stfld GCUv2.frmPurchaseReturn::_TabPage4
          loc_458DC5: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDiscount() {

          loc_458DC7: ldarg.0
          loc_458DC8: ldfld GCUv2.frmPurchaseReturn::_txtDiscount
          loc_458DCD: br.s loc_458DCF
          loc_458DCF: // Referenced from: loc_458DCD
          loc_458DCF: ret
        }

        assem override strict specialname void set_txtDiscount(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label7() {

          loc_458E4A: ldarg.0
          loc_458E4B: ldfld GCUv2.frmPurchaseReturn::_Label7
          loc_458E50: br.s loc_458E52
          loc_458E52: // Referenced from: loc_458E50
          loc_458E52: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_458E54: ldarg.0
          loc_458E55: ldarg.1
          loc_458E56: stfld GCUv2.frmPurchaseReturn::_Label7
          loc_458E5B: ret
        }

        assem override strict specialname class ComboBox get_cboSupplier() {

          loc_458E5D: ldarg.0
          loc_458E5E: ldfld GCUv2.frmPurchaseReturn::_cboSupplier
          loc_458E63: br.s loc_458E65
          loc_458E65: // Referenced from: loc_458E63
          loc_458E65: ret
        }

        assem override strict specialname void set_cboSupplier(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label1() {

          loc_458EAC: ldarg.0
          loc_458EAD: ldfld GCUv2.frmPurchaseReturn::_Label1
          loc_458EB2: br.s loc_458EB4
          loc_458EB4: // Referenced from: loc_458EB2
          loc_458EB4: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_458EB6: ldarg.0
          loc_458EB7: ldarg.1
          loc_458EB8: stfld GCUv2.frmPurchaseReturn::_Label1
          loc_458EBD: ret
        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_458EBF: ldarg.0
          loc_458EC0: ldfld GCUv2.frmPurchaseReturn::_TabControl1
          loc_458EC5: br.s loc_458EC7
          loc_458EC7: // Referenced from: loc_458EC5
          loc_458EC7: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          class System.EventHandler var_1;
          class TabControl var_2;

        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_458F0C: ldarg.0
          loc_458F0D: ldfld GCUv2.frmPurchaseReturn::_TabPage1
          loc_458F12: br.s loc_458F14
          loc_458F14: // Referenced from: loc_458F12
          loc_458F14: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_458F16: ldarg.0
          loc_458F17: ldarg.1
          loc_458F18: stfld GCUv2.frmPurchaseReturn::_TabPage1
          loc_458F1D: ret
        }

        assem override strict specialname class Button get_btnItem() {

          loc_458F1F: ldarg.0
          loc_458F20: ldfld GCUv2.frmPurchaseReturn::_btnItem
          loc_458F25: br.s loc_458F27
          loc_458F27: // Referenced from: loc_458F25
          loc_458F27: ret
        }

        assem override strict specialname void set_btnItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_458F6C: ldarg.0
          loc_458F6D: ldfld GCUv2.frmPurchaseReturn::_dgvItem
          loc_458F72: br.s loc_458F74
          loc_458F74: // Referenced from: loc_458F72
          loc_458F74: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class TabPage get_TabPage2() {

          loc_459019: ldarg.0
          loc_45901A: ldfld GCUv2.frmPurchaseReturn::_TabPage2
          loc_45901F: br.s loc_459021
          loc_459021: // Referenced from: loc_45901F
          loc_459021: ret
        }

        assem override strict specialname void set_TabPage2(class TabPage WithEventsValue) {

          loc_459023: ldarg.0
          loc_459024: ldarg.1
          loc_459025: stfld GCUv2.frmPurchaseReturn::_TabPage2
          loc_45902A: ret
        }

        assem override strict specialname class DataGridView get_dgvPayment() {

          loc_45902C: ldarg.0
          loc_45902D: ldfld GCUv2.frmPurchaseReturn::_dgvPayment
          loc_459032: br.s loc_459034
          loc_459034: // Referenced from: loc_459032
          loc_459034: ret
        }

        assem override strict specialname void set_dgvPayment(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnPayment() {

          loc_4590D9: ldarg.0
          loc_4590DA: ldfld GCUv2.frmPurchaseReturn::_btnPayment
          loc_4590DF: br.s loc_4590E1
          loc_4590E1: // Referenced from: loc_4590DF
          loc_4590E1: ret
        }

        assem override strict specialname void set_btnPayment(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblTotalReceivable() {

          loc_459128: ldarg.0
          loc_459129: ldfld GCUv2.frmPurchaseReturn::_lblTotalReceivable
          loc_45912E: br.s loc_459130
          loc_459130: // Referenced from: loc_45912E
          loc_459130: ret
        }

        assem override strict specialname void set_lblTotalReceivable(class Label WithEventsValue) {

          loc_459132: ldarg.0
          loc_459133: ldarg.1
          loc_459134: stfld GCUv2.frmPurchaseReturn::_lblTotalReceivable
          loc_459139: ret
        }

        assem override strict specialname class Label get_lblTotalPayment() {

          loc_45913B: ldarg.0
          loc_45913C: ldfld GCUv2.frmPurchaseReturn::_lblTotalPayment
          loc_459141: br.s loc_459143
          loc_459143: // Referenced from: loc_459141
          loc_459143: ret
        }

        assem override strict specialname void set_lblTotalPayment(class Label WithEventsValue) {

          loc_459145: ldarg.0
          loc_459146: ldarg.1
          loc_459147: stfld GCUv2.frmPurchaseReturn::_lblTotalPayment
          loc_45914C: ret
        }

        assem override strict specialname class Label get_lblTotalPrice() {

          loc_45914E: ldarg.0
          loc_45914F: ldfld GCUv2.frmPurchaseReturn::_lblTotalPrice
          loc_459154: br.s loc_459156
          loc_459156: // Referenced from: loc_459154
          loc_459156: ret
        }

        assem override strict specialname void set_lblTotalPrice(class Label WithEventsValue) {

          loc_459158: ldarg.0
          loc_459159: ldarg.1
          loc_45915A: stfld GCUv2.frmPurchaseReturn::_lblTotalPrice
          loc_45915F: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_459161: ldarg.0
          loc_459162: ldfld GCUv2.frmPurchaseReturn::_Label6
          loc_459167: br.s loc_459169
          loc_459169: // Referenced from: loc_459167
          loc_459169: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_45916B: ldarg.0
          loc_45916C: ldarg.1
          loc_45916D: stfld GCUv2.frmPurchaseReturn::_Label6
          loc_459172: ret
        }

        assem override strict specialname class DateTimePicker get_dtpInvoice() {

          loc_459174: ldarg.0
          loc_459175: ldfld GCUv2.frmPurchaseReturn::_dtpInvoice
          loc_45917A: br.s loc_45917C
          loc_45917C: // Referenced from: loc_45917A
          loc_45917C: ret
        }

        assem override strict specialname void set_dtpInvoice(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_4591C4: ldarg.0
          loc_4591C5: ldfld GCUv2.frmPurchaseReturn::_Label5
          loc_4591CA: br.s loc_4591CC
          loc_4591CC: // Referenced from: loc_4591CA
          loc_4591CC: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4591CE: ldarg.0
          loc_4591CF: ldarg.1
          loc_4591D0: stfld GCUv2.frmPurchaseReturn::_Label5
          loc_4591D5: ret
        }

        assem override strict specialname class Label get_lblSupplier() {

          loc_4591D7: ldarg.0
          loc_4591D8: ldfld GCUv2.frmPurchaseReturn::_lblSupplier
          loc_4591DD: br.s loc_4591DF
          loc_4591DF: // Referenced from: loc_4591DD
          loc_4591DF: ret
        }

        assem override strict specialname void set_lblSupplier(class Label WithEventsValue) {

          loc_4591E1: ldarg.0
          loc_4591E2: ldarg.1
          loc_4591E3: stfld GCUv2.frmPurchaseReturn::_lblSupplier
          loc_4591E8: ret
        }

        assem override strict specialname class Label get_Label16() {

          loc_4591EA: ldarg.0
          loc_4591EB: ldfld GCUv2.frmPurchaseReturn::_Label16
          loc_4591F0: br.s loc_4591F2
          loc_4591F2: // Referenced from: loc_4591F0
          loc_4591F2: ret
        }

        assem override strict specialname void set_Label16(class Label WithEventsValue) {

          loc_4591F4: ldarg.0
          loc_4591F5: ldarg.1
          loc_4591F6: stfld GCUv2.frmPurchaseReturn::_Label16
          loc_4591FB: ret
        }

        assem override strict specialname class ComboBox get_cboInvoiceCode() {

          loc_4591FD: ldarg.0
          loc_4591FE: ldfld GCUv2.frmPurchaseReturn::_cboInvoiceCode
          loc_459203: br.s loc_459205
          loc_459205: // Referenced from: loc_459203
          loc_459205: ret
        }

        assem override strict specialname void set_cboInvoiceCode(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label15() {

          loc_45924C: ldarg.0
          loc_45924D: ldfld GCUv2.frmPurchaseReturn::_Label15
          loc_459252: br.s loc_459254
          loc_459254: // Referenced from: loc_459252
          loc_459254: ret
        }

        assem override strict specialname void set_Label15(class Label WithEventsValue) {

          loc_459256: ldarg.0
          loc_459257: ldarg.1
          loc_459258: stfld GCUv2.frmPurchaseReturn::_Label15
          loc_45925D: ret
        }

        assem override strict specialname class Label get_lblTotalPaymentPlusDeduction() {

          loc_45925F: ldarg.0
          loc_459260: ldfld GCUv2.frmPurchaseReturn::_lblTotalPaymentPlusDeduction
          loc_459265: br.s loc_459267
          loc_459267: // Referenced from: loc_459265
          loc_459267: ret
        }

        assem override strict specialname void set_lblTotalPaymentPlusDeduction(class Label WithEventsValue) {

          loc_459269: ldarg.0
          loc_45926A: ldarg.1
          loc_45926B: stfld GCUv2.frmPurchaseReturn::_lblTotalPaymentPlusDeduction
          loc_459270: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDeduction() {

          loc_459272: ldarg.0
          loc_459273: ldfld GCUv2.frmPurchaseReturn::_txtDeduction
          loc_459278: br.s loc_45927A
          loc_45927A: // Referenced from: loc_459278
          loc_45927A: ret
        }

        assem override strict specialname void set_txtDeduction(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label14() {

          loc_4592F6: ldarg.0
          loc_4592F7: ldfld GCUv2.frmPurchaseReturn::_Label14
          loc_4592FC: br.s loc_4592FE
          loc_4592FE: // Referenced from: loc_4592FC
          loc_4592FE: ret
        }

        assem override strict specialname void set_Label14(class Label WithEventsValue) {

          loc_459300: ldarg.0
          loc_459301: ldarg.1
          loc_459302: stfld GCUv2.frmPurchaseReturn::_Label14
          loc_459307: ret
        }

        assem override strict specialname class Label get_lblNumber() {

          loc_459309: ldarg.0
          loc_45930A: ldfld GCUv2.frmPurchaseReturn::_lblNumber
          loc_45930F: br.s loc_459311
          loc_459311: // Referenced from: loc_45930F
          loc_459311: ret
        }

        assem override strict specialname void set_lblNumber(class Label WithEventsValue) {

          loc_459313: ldarg.0
          loc_459314: ldarg.1
          loc_459315: stfld GCUv2.frmPurchaseReturn::_lblNumber
          loc_45931A: ret
        }

        assem override strict specialname class Label get_lblInformation() {

          loc_45931C: ldarg.0
          loc_45931D: ldfld GCUv2.frmPurchaseReturn::_lblInformation
          loc_459322: br.s loc_459324
          loc_459324: // Referenced from: loc_459322
          loc_459324: ret
        }

        assem override strict specialname void set_lblInformation(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        assem override strict specialname class Button get_btnPrint() {

          loc_45936C: ldarg.0
          loc_45936D: ldfld GCUv2.frmPurchaseReturn::_btnPrint
          loc_459372: br.s loc_459374
          loc_459374: // Referenced from: loc_459372
          loc_459374: ret
        }

        assem override strict specialname void set_btnPrint(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblCurrencyName() {

          loc_4593BC: ldarg.0
          loc_4593BD: ldfld GCUv2.frmPurchaseReturn::_lblCurrencyName
          loc_4593C2: br.s loc_4593C4
          loc_4593C4: // Referenced from: loc_4593C2
          loc_4593C4: ret
        }

        assem override strict specialname void set_lblCurrencyName(class Label WithEventsValue) {

          loc_4593C6: ldarg.0
          loc_4593C7: ldarg.1
          loc_4593C8: stfld GCUv2.frmPurchaseReturn::_lblCurrencyName
          loc_4593CD: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtCurrencyRate() {

          loc_4593CF: ldarg.0
          loc_4593D0: ldfld GCUv2.frmPurchaseReturn::_txtCurrencyRate
          loc_4593D5: br.s loc_4593D7
          loc_4593D7: // Referenced from: loc_4593D5
          loc_4593D7: ret
        }

        assem override strict specialname void set_txtCurrencyRate(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class GCUv2.FilteredTextBox var_2;

        }

        assem override strict specialname class Label get_Label17() {

          loc_45941C: ldarg.0
          loc_45941D: ldfld GCUv2.frmPurchaseReturn::_Label17
          loc_459422: br.s loc_459424
          loc_459424: // Referenced from: loc_459422
          loc_459424: ret
        }

        assem override strict specialname void set_Label17(class Label WithEventsValue) {

          loc_459426: ldarg.0
          loc_459427: ldarg.1
          loc_459428: stfld GCUv2.frmPurchaseReturn::_Label17
          loc_45942D: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_45942F: ldarg.0
          loc_459430: ldfld GCUv2.frmPurchaseReturn::_Label4
          loc_459435: br.s loc_459437
          loc_459437: // Referenced from: loc_459435
          loc_459437: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_459439: ldarg.0
          loc_45943A: ldarg.1
          loc_45943B: stfld GCUv2.frmPurchaseReturn::_Label4
          loc_459440: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_459442: ldarg.0
          loc_459443: ldfld GCUv2.frmPurchaseReturn::_cboStorage
          loc_459448: br.s loc_45944A
          loc_45944A: // Referenced from: loc_459448
          loc_45944A: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        public specialname valuetype System.DateTime get_OriginalDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_OriginalDate(valuetype System.DateTime value) {

          loc_4594A9: nop
          loc_4594AA: ldarg.0
          loc_4594AB: ldarg.1
          loc_4594AC: stfld GCUv2.frmPurchaseReturn::_originalDate
          loc_4594B1: ret
        }

        public specialname int32 get_OriginalStorageId() {

          int32 num_1;

        }

        public specialname void set_OriginalStorageId(int32 value) {

          loc_4594CD: nop
          loc_4594CE: ldarg.0
          loc_4594CF: ldarg.1
          loc_4594D0: stfld GCUv2.frmPurchaseReturn::_originalStorageId
          loc_4594D5: ret
        }

        public specialname boolean get_Edited() {

          boolean var_1;

        }

        public specialname void set_Edited(boolean value) {

          loc_4594F1: nop
          loc_4594F2: ldarg.0
          loc_4594F3: ldarg.1
          loc_4594F4: stfld GCUv2.frmPurchaseReturn::_edited
          loc_4594F9: ret
        }

        public void frmPurchaseReturn() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        private void frmPurchaseReturn_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_4596B9: nop
          loc_4596BA: ldarg.0
          loc_4596BB: ldarg.1
          loc_4596BC: stfld GCUv2.frmPurchaseReturn::_currentId
          loc_4596C1: ret
        }

        private void formatGrid() {


        }

        public void prepareForm(boolean SaveNew, boolean KeepSupplier) {

          boolean var_1;
          boolean var_2;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cPurchaseInvoice var_1;
          valuetype System.DateTime var_2;
          boolean var_3;
          boolean var_4;
          class ComboBox var_5;
          class GCUv2.cPurchaseInvoiceItem[] var_6;
          int32 num_3;
          class GCUv2.cPurchaseInvoiceItem var_7;
          boolean var_8;
          boolean var_9;
          class GCUv2.cPurchaseInvoicePayment[] var_10;
          int32 num_4;
          class GCUv2.cPurchaseInvoicePayment var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;

        }

        public void calculateTotalPrice() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          boolean var_1;
          int32 num_4;
          boolean var_2;
          boolean var_3;

        }

        public void calculateTotalPayment() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          int32 num_4;
          boolean var_1;

        }

        public void calculateTotalInvoice() {

          int32 num_1;
          int32 num_2;
          double flt_1;
          double flt_2;
          double flt_3;

        }

        private void btnItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          class GCUv2.frmPurchaseReturnItem var_4;

        }

        private void dgvItem_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        private void dgvItem_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_DoubleClick(object sender, class System.EventArgs e) {

          loc_45AE6E: nop
          loc_45AE6F: ldarg.0
          loc_45AE70: call instance void GCUv2.frmPurchaseReturn::OpenItem()
          loc_45AE75: nop
          loc_45AE76: ret
        }

        private void dgvItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void OpenItem() {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          class GCUv2.cComboItem var_3;
          class GCUv2.cComboItem var_4;
          class GCUv2.frmPurchaseReturnItem var_5;
          class ComboBox var_6;

        }

        private void btnPayment_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmPurchaseReturnPayment var_1;

        }

        private void dgvPayment_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_DoubleClick(object sender, class System.EventArgs e) {

          loc_45B251: nop
          loc_45B252: ldarg.0
          loc_45B253: call instance void GCUv2.frmPurchaseReturn::openPayment()
          loc_45B258: nop
          loc_45B259: ret
        }

        private void dgvPayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void openPayment() {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          class GCUv2.frmPurchaseReturnPayment var_2;
          class ComboBox var_3;
          boolean var_4;
          boolean var_5;

        }

        private void dgvReturn_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void cboSupplier_SelectedIndexChanged(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.cComboItem var_6;
          class GCUv2.cSupplier var_7;
          boolean var_8;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void txtDiscount_Click(object sender, class System.EventArgs e) {

          loc_45B942: nop
          loc_45B943: ldarg.0
          loc_45B944: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B949: ldc.i4.0
          loc_45B94A: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_45B94F: nop
          loc_45B950: ldarg.0
          loc_45B951: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B956: ldarg.0
          loc_45B957: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B95C: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_45B961: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_45B966: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_45B96B: nop
          loc_45B96C: ret
        }

        private void txtDiscount_GotFocus(object sender, class System.EventArgs e) {

          loc_45B942: nop
          loc_45B943: ldarg.0
          loc_45B944: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B949: ldc.i4.0
          loc_45B94A: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_45B94F: nop
          loc_45B950: ldarg.0
          loc_45B951: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B956: ldarg.0
          loc_45B957: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDiscount()
          loc_45B95C: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_45B961: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_45B966: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_45B96B: nop
          loc_45B96C: ret
        }

        private void txtDiscount_TextChanged(object sender, class System.EventArgs e) {

          loc_45B96E: nop
          loc_45B96F: ldarg.0
          loc_45B970: call instance void GCUv2.frmPurchaseReturn::calculateTotalInvoice()
          loc_45B975: nop
          loc_45B976: ldarg.0
          loc_45B977: ldc.i4.1
          loc_45B978: stfld GCUv2.frmPurchaseReturn::_edited
          loc_45B97D: ret
        }

        private void txtDeduction_Click(object sender, class System.EventArgs e) {

          loc_45B97F: nop
          loc_45B980: ldarg.0
          loc_45B981: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B986: ldc.i4.0
          loc_45B987: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_45B98C: nop
          loc_45B98D: ldarg.0
          loc_45B98E: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B993: ldarg.0
          loc_45B994: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B999: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_45B99E: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_45B9A3: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_45B9A8: nop
          loc_45B9A9: ret
        }

        private void txtDeduction_GotFocus(object sender, class System.EventArgs e) {

          loc_45B97F: nop
          loc_45B980: ldarg.0
          loc_45B981: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B986: ldc.i4.0
          loc_45B987: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_45B98C: nop
          loc_45B98D: ldarg.0
          loc_45B98E: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B993: ldarg.0
          loc_45B994: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseReturn::get_txtDeduction()
          loc_45B999: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_45B99E: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_45B9A3: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_45B9A8: nop
          loc_45B9A9: ret
        }

        private void txtDeduction_TextChanged(object sender, class System.EventArgs e) {

          loc_45B96E: nop
          loc_45B96F: ldarg.0
          loc_45B970: call instance void GCUv2.frmPurchaseReturn::calculateTotalInvoice()
          loc_45B975: nop
          loc_45B976: ldarg.0
          loc_45B977: ldc.i4.1
          loc_45B978: stfld GCUv2.frmPurchaseReturn::_edited
          loc_45B97D: ret
        }

        private void TabControl1_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_45B9FA: nop
          loc_45B9FB: ldarg.0
          loc_45B9FC: ldc.i4.0
          loc_45B9FD: ldc.i4.0
          loc_45B9FE: call instance void GCUv2.frmPurchaseReturn::SaveData(boolean, boolean)
          loc_45BA03: nop
          loc_45BA04: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_45BA06: nop
          loc_45BA07: ldarg.0
          loc_45BA08: ldc.i4.1
          loc_45BA09: ldc.i4.0
          loc_45BA0A: call instance void GCUv2.frmPurchaseReturn::SaveData(boolean, boolean)
          loc_45BA0F: nop
          loc_45BA10: ret
        }

        private void SaveData(boolean CloseForm, boolean OpenPrintPreview) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          class GCUv2.cPurchaseInvoice var_4;
          class GCUv2.cPurchaseInvoiceItem[] var_5;
          class GCUv2.cPurchaseInvoicePayment[] var_6;
          int32 num_3;
          string str_1;
          string str_2;
          string str_3;
          string str_4;
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
          int32 num_4;
          int32 num_5;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cPurchaseInvoice var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

        private void lblInformation_Click(object sender, class System.EventArgs e) {


        }

        private void btnPrint_Click(object sender, class System.EventArgs e) {

          string str_1;
          class GCUv2.frmPurchaseReturnPrint var_1;
          class GCUv2.cPrintSetting var_2;
          int32 num_1;
          class GCUv2.cPurchaseInvoice var_3;
          double flt_1;
          double flt_2;
          double flt_3;
          double flt_4;
          double flt_5;
          double flt_6;
          valuetype System.DateTime var_4;
          double flt_7;
          int16 num_2;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          int32 num_3;
          boolean var_8;
          boolean var_9;
          int32 num_4;
          boolean var_10;
          boolean var_11;
          valuetype System.DateTime var_12;
          boolean var_13;
          boolean var_14;

        }

        private void dtpInvoice_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          valuetype System.DateTime var_2;

        }

        private void cboInvoiceCode_SelectedIndexChanged(object sender, class System.EventArgs e) {

          loc_45D291: nop
          loc_45D292: ldarg.0
          loc_45D293: ldc.i4.1
          loc_45D294: stfld GCUv2.frmPurchaseReturn::_edited
          loc_45D299: ret
        }

        private void txtCurrencyRate_TextChanged(object sender, class System.EventArgs e) {

          loc_45D291: nop
          loc_45D292: ldarg.0
          loc_45D293: ldc.i4.1
          loc_45D294: stfld GCUv2.frmPurchaseReturn::_edited
          loc_45D299: ret
        }

    }
}
