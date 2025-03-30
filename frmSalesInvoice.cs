using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DataGridView _dgvItem;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label10;
        private class Label _Label13;
        private class Label _Label12;
        private class Label _Label11;
        private class Label _Label9;
        private class Label _lblTotalInvoice;
        private class Label _Label8;
        private class GCUv2.FilteredTextBox _txtDiscountValue;
        private class Label _Label3;
        private class TabPage _TabPage4;
        private class TabPage _TabPage1;
        private class Button _btnItem;
        private class DataGridView _dgvReturn;
        private class TabControl _TabControl1;
        private class TabPage _TabPage2;
        private class DataGridView _dgvPayment;
        private class Button _btnPayment;
        private class TabPage _TabPage3;
        private class Label _lblTotalReceivable;
        private class Label _lblTotalPayment;
        private class Label _lblTotalReturn;
        private class Label _lblTotalPrice;
        private class TextBox _txtInvoiceNumber;
        private class Label _Label6;
        private class Label _Label5;
        private class Label _Label1;
        private class DateTimePicker _dtpInvoice;
        private class TextBox _txtTaxInvoiceNumber;
        private class Label _lblTaxNumber;
        private class Label _lblTaxDate;
        private class DateTimePicker _dtpTaxInvoice;
        private class Label _Label16;
        private class ComboBox _cboInvoiceCode;
        private class Label _Label19;
        private class Label _lblCustomerAddress;
        private class Label _lblCustomerName;
        private class GCUv2.FilteredTextBox _txtDeduction;
        private class Label _Label20;
        private class Label _Label21;
        private class Label _lblTotalNetPayment;
        private class Label _Label22;
        private class Label _Label23;
        private class Label _Label26;
        private class Label _Label25;
        private class DateTimePicker _dtpTF;
        private class Label _Label24;
        private class ComboBox _cboTF;
        private class Label _Label27;
        private class ComboBox _cboStorage;
        private class CheckBox _chkUseOldPrice;
        private class Label _Label29;
        private class Label _Label17;
        private class ComboBox _cboSalesPerson;
        private class Button _btnPrint;
        private class Button _btnSearch;
        private class Button _btnCash;
        private class Button _btnDO;
        private class Button _btnSO;
        private class Label _lblPaidDate;
        private class Label _lblTaxNumberDash;
        private class Label _lblTaxDateDash;
        private class GCUv2.FilteredTextBox _txtDiscountDescription;
        private class TextBox _txtNote;
        private double _currentId;
        private int32 _currentlySelectedComboIndex;
        private boolean _suppressComboChange;
        private valuetype System.DateTime _paidDate;
        private class ComboBox _cachedComboBox;
        private string _customerNPWP;
        private string _customerPT;
        private string _customerTaxAddress;
        private double _DPP;
        private double _PPN;
        private double _customerId;
        private double _customerParentId;
        private int32 _branchId;
        private valuetype System.DateTime _originalDate;
        private int32 _originalStorageId;
        private boolean _edited;
        private string _currentInvoiceNumber;
        private double _currentTaxInvoiceNumber;
        private boolean _isDonation;
        private boolean _fullyPaidWhenLoaded;
        private boolean _disableDgvItem;
        private int32 _totalItem;
        private boolean _authorised;
        private boolean _wasCashInvoice;
        private int32 _totalUnpaid;
        private int32 _unpaidLimit;
        private class GCUv2.cSalesInvoiceItem[] _item;
        private double[] _SOId;
        private double[] _DOId;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private string _cashAccountName;
        private int32 _discountId;
        private boolean _justLoaded;
        private boolean _dateIsChanged;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_4D38A0: ldarg.0
          loc_4D38A1: ldfld GCUv2.frmSalesInvoice::_dgvItem
          loc_4D38A6: br.s loc_4D38A8
          loc_4D38A8: // Referenced from: loc_4D38A6
          loc_4D38A8: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_4D394D: ldarg.0
          loc_4D394E: ldfld GCUv2.frmSalesInvoice::_btnHistory
          loc_4D3953: br.s loc_4D3955
          loc_4D3955: // Referenced from: loc_4D3953
          loc_4D3955: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4D399C: ldarg.0
          loc_4D399D: ldfld GCUv2.frmSalesInvoice::_btnSaveClose
          loc_4D39A2: br.s loc_4D39A4
          loc_4D39A4: // Referenced from: loc_4D39A2
          loc_4D39A4: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4D39EC: ldarg.0
          loc_4D39ED: ldfld GCUv2.frmSalesInvoice::_btnDelete
          loc_4D39F2: br.s loc_4D39F4
          loc_4D39F4: // Referenced from: loc_4D39F2
          loc_4D39F4: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4D3A3C: ldarg.0
          loc_4D3A3D: ldfld GCUv2.frmSalesInvoice::_btnSave
          loc_4D3A42: br.s loc_4D3A44
          loc_4D3A44: // Referenced from: loc_4D3A42
          loc_4D3A44: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label10() {

          loc_4D3A8C: ldarg.0
          loc_4D3A8D: ldfld GCUv2.frmSalesInvoice::_Label10
          loc_4D3A92: br.s loc_4D3A94
          loc_4D3A94: // Referenced from: loc_4D3A92
          loc_4D3A94: ret
        }

        assem override strict specialname void set_Label10(class Label WithEventsValue) {

          loc_4D3A96: ldarg.0
          loc_4D3A97: ldarg.1
          loc_4D3A98: stfld GCUv2.frmSalesInvoice::_Label10
          loc_4D3A9D: ret
        }

        assem override strict specialname class Label get_Label13() {

          loc_4D3A9F: ldarg.0
          loc_4D3AA0: ldfld GCUv2.frmSalesInvoice::_Label13
          loc_4D3AA5: br.s loc_4D3AA7
          loc_4D3AA7: // Referenced from: loc_4D3AA5
          loc_4D3AA7: ret
        }

        assem override strict specialname void set_Label13(class Label WithEventsValue) {

          loc_4D3AA9: ldarg.0
          loc_4D3AAA: ldarg.1
          loc_4D3AAB: stfld GCUv2.frmSalesInvoice::_Label13
          loc_4D3AB0: ret
        }

        assem override strict specialname class Label get_Label12() {

          loc_4D3AB2: ldarg.0
          loc_4D3AB3: ldfld GCUv2.frmSalesInvoice::_Label12
          loc_4D3AB8: br.s loc_4D3ABA
          loc_4D3ABA: // Referenced from: loc_4D3AB8
          loc_4D3ABA: ret
        }

        assem override strict specialname void set_Label12(class Label WithEventsValue) {

          loc_4D3ABC: ldarg.0
          loc_4D3ABD: ldarg.1
          loc_4D3ABE: stfld GCUv2.frmSalesInvoice::_Label12
          loc_4D3AC3: ret
        }

        assem override strict specialname class Label get_Label11() {

          loc_4D3AC5: ldarg.0
          loc_4D3AC6: ldfld GCUv2.frmSalesInvoice::_Label11
          loc_4D3ACB: br.s loc_4D3ACD
          loc_4D3ACD: // Referenced from: loc_4D3ACB
          loc_4D3ACD: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_4D3ACF: ldarg.0
          loc_4D3AD0: ldarg.1
          loc_4D3AD1: stfld GCUv2.frmSalesInvoice::_Label11
          loc_4D3AD6: ret
        }

        assem override strict specialname class Label get_Label9() {

          loc_4D3AD8: ldarg.0
          loc_4D3AD9: ldfld GCUv2.frmSalesInvoice::_Label9
          loc_4D3ADE: br.s loc_4D3AE0
          loc_4D3AE0: // Referenced from: loc_4D3ADE
          loc_4D3AE0: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_4D3AE2: ldarg.0
          loc_4D3AE3: ldarg.1
          loc_4D3AE4: stfld GCUv2.frmSalesInvoice::_Label9
          loc_4D3AE9: ret
        }

        assem override strict specialname class Label get_lblTotalInvoice() {

          loc_4D3AEB: ldarg.0
          loc_4D3AEC: ldfld GCUv2.frmSalesInvoice::_lblTotalInvoice
          loc_4D3AF1: br.s loc_4D3AF3
          loc_4D3AF3: // Referenced from: loc_4D3AF1
          loc_4D3AF3: ret
        }

        assem override strict specialname void set_lblTotalInvoice(class Label WithEventsValue) {

          loc_4D3AF5: ldarg.0
          loc_4D3AF6: ldarg.1
          loc_4D3AF7: stfld GCUv2.frmSalesInvoice::_lblTotalInvoice
          loc_4D3AFC: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_4D3AFE: ldarg.0
          loc_4D3AFF: ldfld GCUv2.frmSalesInvoice::_Label8
          loc_4D3B04: br.s loc_4D3B06
          loc_4D3B06: // Referenced from: loc_4D3B04
          loc_4D3B06: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_4D3B08: ldarg.0
          loc_4D3B09: ldarg.1
          loc_4D3B0A: stfld GCUv2.frmSalesInvoice::_Label8
          loc_4D3B0F: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDiscountValue() {

          loc_4D3B11: ldarg.0
          loc_4D3B12: ldfld GCUv2.frmSalesInvoice::_txtDiscountValue
          loc_4D3B17: br.s loc_4D3B19
          loc_4D3B19: // Referenced from: loc_4D3B17
          loc_4D3B19: ret
        }

        assem override strict specialname void set_txtDiscountValue(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label3() {

          loc_4D3B96: ldarg.0
          loc_4D3B97: ldfld GCUv2.frmSalesInvoice::_Label3
          loc_4D3B9C: br.s loc_4D3B9E
          loc_4D3B9E: // Referenced from: loc_4D3B9C
          loc_4D3B9E: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_4D3BA0: ldarg.0
          loc_4D3BA1: ldarg.1
          loc_4D3BA2: stfld GCUv2.frmSalesInvoice::_Label3
          loc_4D3BA7: ret
        }

        assem override strict specialname class TabPage get_TabPage4() {

          loc_4D3BA9: ldarg.0
          loc_4D3BAA: ldfld GCUv2.frmSalesInvoice::_TabPage4
          loc_4D3BAF: br.s loc_4D3BB1
          loc_4D3BB1: // Referenced from: loc_4D3BAF
          loc_4D3BB1: ret
        }

        assem override strict specialname void set_TabPage4(class TabPage WithEventsValue) {

          loc_4D3BB3: ldarg.0
          loc_4D3BB4: ldarg.1
          loc_4D3BB5: stfld GCUv2.frmSalesInvoice::_TabPage4
          loc_4D3BBA: ret
        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_4D3BBC: ldarg.0
          loc_4D3BBD: ldfld GCUv2.frmSalesInvoice::_TabPage1
          loc_4D3BC2: br.s loc_4D3BC4
          loc_4D3BC4: // Referenced from: loc_4D3BC2
          loc_4D3BC4: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_4D3BC6: ldarg.0
          loc_4D3BC7: ldarg.1
          loc_4D3BC8: stfld GCUv2.frmSalesInvoice::_TabPage1
          loc_4D3BCD: ret
        }

        assem override strict specialname class Button get_btnItem() {

          loc_4D3BCF: ldarg.0
          loc_4D3BD0: ldfld GCUv2.frmSalesInvoice::_btnItem
          loc_4D3BD5: br.s loc_4D3BD7
          loc_4D3BD7: // Referenced from: loc_4D3BD5
          loc_4D3BD7: ret
        }

        assem override strict specialname void set_btnItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvReturn() {

          loc_4D3C1C: ldarg.0
          loc_4D3C1D: ldfld GCUv2.frmSalesInvoice::_dgvReturn
          loc_4D3C22: br.s loc_4D3C24
          loc_4D3C24: // Referenced from: loc_4D3C22
          loc_4D3C24: ret
        }

        assem override strict specialname void set_dgvReturn(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class DataGridViewCellEventHandler var_3;
          class DataGridViewCellEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_4D3CC9: ldarg.0
          loc_4D3CCA: ldfld GCUv2.frmSalesInvoice::_TabControl1
          loc_4D3CCF: br.s loc_4D3CD1
          loc_4D3CD1: // Referenced from: loc_4D3CCF
          loc_4D3CD1: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          class System.EventHandler var_1;
          class TabControl var_2;

        }

        assem override strict specialname class TabPage get_TabPage2() {

          loc_4D3D18: ldarg.0
          loc_4D3D19: ldfld GCUv2.frmSalesInvoice::_TabPage2
          loc_4D3D1E: br.s loc_4D3D20
          loc_4D3D20: // Referenced from: loc_4D3D1E
          loc_4D3D20: ret
        }

        assem override strict specialname void set_TabPage2(class TabPage WithEventsValue) {

          loc_4D3D22: ldarg.0
          loc_4D3D23: ldarg.1
          loc_4D3D24: stfld GCUv2.frmSalesInvoice::_TabPage2
          loc_4D3D29: ret
        }

        assem override strict specialname class DataGridView get_dgvPayment() {

          loc_4D3D2B: ldarg.0
          loc_4D3D2C: ldfld GCUv2.frmSalesInvoice::_dgvPayment
          loc_4D3D31: br.s loc_4D3D33
          loc_4D3D33: // Referenced from: loc_4D3D31
          loc_4D3D33: ret
        }

        assem override strict specialname void set_dgvPayment(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnPayment() {

          loc_4D3DD5: ldarg.0
          loc_4D3DD6: ldfld GCUv2.frmSalesInvoice::_btnPayment
          loc_4D3DDB: br.s loc_4D3DDD
          loc_4D3DDD: // Referenced from: loc_4D3DDB
          loc_4D3DDD: ret
        }

        assem override strict specialname void set_btnPayment(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TabPage get_TabPage3() {

          loc_4D3E24: ldarg.0
          loc_4D3E25: ldfld GCUv2.frmSalesInvoice::_TabPage3
          loc_4D3E2A: br.s loc_4D3E2C
          loc_4D3E2C: // Referenced from: loc_4D3E2A
          loc_4D3E2C: ret
        }

        assem override strict specialname void set_TabPage3(class TabPage WithEventsValue) {

          loc_4D3E2E: ldarg.0
          loc_4D3E2F: ldarg.1
          loc_4D3E30: stfld GCUv2.frmSalesInvoice::_TabPage3
          loc_4D3E35: ret
        }

        assem override strict specialname class Label get_lblTotalReceivable() {

          loc_4D3E37: ldarg.0
          loc_4D3E38: ldfld GCUv2.frmSalesInvoice::_lblTotalReceivable
          loc_4D3E3D: br.s loc_4D3E3F
          loc_4D3E3F: // Referenced from: loc_4D3E3D
          loc_4D3E3F: ret
        }

        assem override strict specialname void set_lblTotalReceivable(class Label WithEventsValue) {

          loc_4D3E41: ldarg.0
          loc_4D3E42: ldarg.1
          loc_4D3E43: stfld GCUv2.frmSalesInvoice::_lblTotalReceivable
          loc_4D3E48: ret
        }

        assem override strict specialname class Label get_lblTotalPayment() {

          loc_4D3E4A: ldarg.0
          loc_4D3E4B: ldfld GCUv2.frmSalesInvoice::_lblTotalPayment
          loc_4D3E50: br.s loc_4D3E52
          loc_4D3E52: // Referenced from: loc_4D3E50
          loc_4D3E52: ret
        }

        assem override strict specialname void set_lblTotalPayment(class Label WithEventsValue) {

          loc_4D3E54: ldarg.0
          loc_4D3E55: ldarg.1
          loc_4D3E56: stfld GCUv2.frmSalesInvoice::_lblTotalPayment
          loc_4D3E5B: ret
        }

        assem override strict specialname class Label get_lblTotalReturn() {

          loc_4D3E5D: ldarg.0
          loc_4D3E5E: ldfld GCUv2.frmSalesInvoice::_lblTotalReturn
          loc_4D3E63: br.s loc_4D3E65
          loc_4D3E65: // Referenced from: loc_4D3E63
          loc_4D3E65: ret
        }

        assem override strict specialname void set_lblTotalReturn(class Label WithEventsValue) {

          loc_4D3E67: ldarg.0
          loc_4D3E68: ldarg.1
          loc_4D3E69: stfld GCUv2.frmSalesInvoice::_lblTotalReturn
          loc_4D3E6E: ret
        }

        assem override strict specialname class Label get_lblTotalPrice() {

          loc_4D3E70: ldarg.0
          loc_4D3E71: ldfld GCUv2.frmSalesInvoice::_lblTotalPrice
          loc_4D3E76: br.s loc_4D3E78
          loc_4D3E78: // Referenced from: loc_4D3E76
          loc_4D3E78: ret
        }

        assem override strict specialname void set_lblTotalPrice(class Label WithEventsValue) {

          loc_4D3E7A: ldarg.0
          loc_4D3E7B: ldarg.1
          loc_4D3E7C: stfld GCUv2.frmSalesInvoice::_lblTotalPrice
          loc_4D3E81: ret
        }

        assem override strict specialname class TextBox get_txtInvoiceNumber() {

          loc_4D3E83: ldarg.0
          loc_4D3E84: ldfld GCUv2.frmSalesInvoice::_txtInvoiceNumber
          loc_4D3E89: br.s loc_4D3E8B
          loc_4D3E8B: // Referenced from: loc_4D3E89
          loc_4D3E8B: ret
        }

        assem override strict specialname void set_txtInvoiceNumber(class TextBox WithEventsValue) {

          class System.EventHandler var_1;
          class TextBox var_2;

        }

        assem override strict specialname class Label get_Label6() {

          loc_4D3ED0: ldarg.0
          loc_4D3ED1: ldfld GCUv2.frmSalesInvoice::_Label6
          loc_4D3ED6: br.s loc_4D3ED8
          loc_4D3ED8: // Referenced from: loc_4D3ED6
          loc_4D3ED8: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4D3EDA: ldarg.0
          loc_4D3EDB: ldarg.1
          loc_4D3EDC: stfld GCUv2.frmSalesInvoice::_Label6
          loc_4D3EE1: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_4D3EE3: ldarg.0
          loc_4D3EE4: ldfld GCUv2.frmSalesInvoice::_Label5
          loc_4D3EE9: br.s loc_4D3EEB
          loc_4D3EEB: // Referenced from: loc_4D3EE9
          loc_4D3EEB: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4D3EED: ldarg.0
          loc_4D3EEE: ldarg.1
          loc_4D3EEF: stfld GCUv2.frmSalesInvoice::_Label5
          loc_4D3EF4: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4D3EF6: ldarg.0
          loc_4D3EF7: ldfld GCUv2.frmSalesInvoice::_Label1
          loc_4D3EFC: br.s loc_4D3EFE
          loc_4D3EFE: // Referenced from: loc_4D3EFC
          loc_4D3EFE: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4D3F00: ldarg.0
          loc_4D3F01: ldarg.1
          loc_4D3F02: stfld GCUv2.frmSalesInvoice::_Label1
          loc_4D3F07: ret
        }

        assem override strict specialname class DateTimePicker get_dtpInvoice() {

          loc_4D3F09: ldarg.0
          loc_4D3F0A: ldfld GCUv2.frmSalesInvoice::_dtpInvoice
          loc_4D3F0F: br.s loc_4D3F11
          loc_4D3F11: // Referenced from: loc_4D3F0F
          loc_4D3F11: ret
        }

        assem override strict specialname void set_dtpInvoice(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class TextBox get_txtTaxInvoiceNumber() {

          loc_4D3F58: ldarg.0
          loc_4D3F59: ldfld GCUv2.frmSalesInvoice::_txtTaxInvoiceNumber
          loc_4D3F5E: br.s loc_4D3F60
          loc_4D3F60: // Referenced from: loc_4D3F5E
          loc_4D3F60: ret
        }

        assem override strict specialname void set_txtTaxInvoiceNumber(class TextBox WithEventsValue) {

          class System.EventHandler var_1;
          class TextBox var_2;

        }

        assem override strict specialname class Label get_lblTaxNumber() {

          loc_4D3FA8: ldarg.0
          loc_4D3FA9: ldfld GCUv2.frmSalesInvoice::_lblTaxNumber
          loc_4D3FAE: br.s loc_4D3FB0
          loc_4D3FB0: // Referenced from: loc_4D3FAE
          loc_4D3FB0: ret
        }

        assem override strict specialname void set_lblTaxNumber(class Label WithEventsValue) {

          loc_4D3FB2: ldarg.0
          loc_4D3FB3: ldarg.1
          loc_4D3FB4: stfld GCUv2.frmSalesInvoice::_lblTaxNumber
          loc_4D3FB9: ret
        }

        assem override strict specialname class Label get_lblTaxDate() {

          loc_4D3FBB: ldarg.0
          loc_4D3FBC: ldfld GCUv2.frmSalesInvoice::_lblTaxDate
          loc_4D3FC1: br.s loc_4D3FC3
          loc_4D3FC3: // Referenced from: loc_4D3FC1
          loc_4D3FC3: ret
        }

        assem override strict specialname void set_lblTaxDate(class Label WithEventsValue) {

          loc_4D3FC5: ldarg.0
          loc_4D3FC6: ldarg.1
          loc_4D3FC7: stfld GCUv2.frmSalesInvoice::_lblTaxDate
          loc_4D3FCC: ret
        }

        assem override strict specialname class DateTimePicker get_dtpTaxInvoice() {

          loc_4D3FCE: ldarg.0
          loc_4D3FCF: ldfld GCUv2.frmSalesInvoice::_dtpTaxInvoice
          loc_4D3FD4: br.s loc_4D3FD6
          loc_4D3FD6: // Referenced from: loc_4D3FD4
          loc_4D3FD6: ret
        }

        assem override strict specialname void set_dtpTaxInvoice(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class Label get_Label16() {

          loc_4D401C: ldarg.0
          loc_4D401D: ldfld GCUv2.frmSalesInvoice::_Label16
          loc_4D4022: br.s loc_4D4024
          loc_4D4024: // Referenced from: loc_4D4022
          loc_4D4024: ret
        }

        assem override strict specialname void set_Label16(class Label WithEventsValue) {

          loc_4D4026: ldarg.0
          loc_4D4027: ldarg.1
          loc_4D4028: stfld GCUv2.frmSalesInvoice::_Label16
          loc_4D402D: ret
        }

        assem override strict specialname class ComboBox get_cboInvoiceCode() {

          loc_4D402F: ldarg.0
          loc_4D4030: ldfld GCUv2.frmSalesInvoice::_cboInvoiceCode
          loc_4D4035: br.s loc_4D4037
          loc_4D4037: // Referenced from: loc_4D4035
          loc_4D4037: ret
        }

        assem override strict specialname void set_cboInvoiceCode(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label19() {

          loc_4D407C: ldarg.0
          loc_4D407D: ldfld GCUv2.frmSalesInvoice::_Label19
          loc_4D4082: br.s loc_4D4084
          loc_4D4084: // Referenced from: loc_4D4082
          loc_4D4084: ret
        }

        assem override strict specialname void set_Label19(class Label WithEventsValue) {

          loc_4D4086: ldarg.0
          loc_4D4087: ldarg.1
          loc_4D4088: stfld GCUv2.frmSalesInvoice::_Label19
          loc_4D408D: ret
        }

        assem override strict specialname class Label get_lblCustomerAddress() {

          loc_4D408F: ldarg.0
          loc_4D4090: ldfld GCUv2.frmSalesInvoice::_lblCustomerAddress
          loc_4D4095: br.s loc_4D4097
          loc_4D4097: // Referenced from: loc_4D4095
          loc_4D4097: ret
        }

        assem override strict specialname void set_lblCustomerAddress(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        assem override strict specialname class Label get_lblCustomerName() {

          loc_4D40DC: ldarg.0
          loc_4D40DD: ldfld GCUv2.frmSalesInvoice::_lblCustomerName
          loc_4D40E2: br.s loc_4D40E4
          loc_4D40E4: // Referenced from: loc_4D40E2
          loc_4D40E4: ret
        }

        assem override strict specialname void set_lblCustomerName(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDeduction() {

          loc_4D412C: ldarg.0
          loc_4D412D: ldfld GCUv2.frmSalesInvoice::_txtDeduction
          loc_4D4132: br.s loc_4D4134
          loc_4D4134: // Referenced from: loc_4D4132
          loc_4D4134: ret
        }

        assem override strict specialname void set_txtDeduction(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label20() {

          loc_4D41B2: ldarg.0
          loc_4D41B3: ldfld GCUv2.frmSalesInvoice::_Label20
          loc_4D41B8: br.s loc_4D41BA
          loc_4D41BA: // Referenced from: loc_4D41B8
          loc_4D41BA: ret
        }

        assem override strict specialname void set_Label20(class Label WithEventsValue) {

          loc_4D41BC: ldarg.0
          loc_4D41BD: ldarg.1
          loc_4D41BE: stfld GCUv2.frmSalesInvoice::_Label20
          loc_4D41C3: ret
        }

        assem override strict specialname class Label get_Label21() {

          loc_4D41C5: ldarg.0
          loc_4D41C6: ldfld GCUv2.frmSalesInvoice::_Label21
          loc_4D41CB: br.s loc_4D41CD
          loc_4D41CD: // Referenced from: loc_4D41CB
          loc_4D41CD: ret
        }

        assem override strict specialname void set_Label21(class Label WithEventsValue) {

          loc_4D41CF: ldarg.0
          loc_4D41D0: ldarg.1
          loc_4D41D1: stfld GCUv2.frmSalesInvoice::_Label21
          loc_4D41D6: ret
        }

        assem override strict specialname class Label get_lblTotalNetPayment() {

          loc_4D41D8: ldarg.0
          loc_4D41D9: ldfld GCUv2.frmSalesInvoice::_lblTotalNetPayment
          loc_4D41DE: br.s loc_4D41E0
          loc_4D41E0: // Referenced from: loc_4D41DE
          loc_4D41E0: ret
        }

        assem override strict specialname void set_lblTotalNetPayment(class Label WithEventsValue) {

          loc_4D41E2: ldarg.0
          loc_4D41E3: ldarg.1
          loc_4D41E4: stfld GCUv2.frmSalesInvoice::_lblTotalNetPayment
          loc_4D41E9: ret
        }

        assem override strict specialname class Label get_Label22() {

          loc_4D41EB: ldarg.0
          loc_4D41EC: ldfld GCUv2.frmSalesInvoice::_Label22
          loc_4D41F1: br.s loc_4D41F3
          loc_4D41F3: // Referenced from: loc_4D41F1
          loc_4D41F3: ret
        }

        assem override strict specialname void set_Label22(class Label WithEventsValue) {

          loc_4D41F5: ldarg.0
          loc_4D41F6: ldarg.1
          loc_4D41F7: stfld GCUv2.frmSalesInvoice::_Label22
          loc_4D41FC: ret
        }

        assem override strict specialname class Label get_Label23() {

          loc_4D41FE: ldarg.0
          loc_4D41FF: ldfld GCUv2.frmSalesInvoice::_Label23
          loc_4D4204: br.s loc_4D4206
          loc_4D4206: // Referenced from: loc_4D4204
          loc_4D4206: ret
        }

        assem override strict specialname void set_Label23(class Label WithEventsValue) {

          loc_4D4208: ldarg.0
          loc_4D4209: ldarg.1
          loc_4D420A: stfld GCUv2.frmSalesInvoice::_Label23
          loc_4D420F: ret
        }

        assem override strict specialname class Label get_Label26() {

          loc_4D4211: ldarg.0
          loc_4D4212: ldfld GCUv2.frmSalesInvoice::_Label26
          loc_4D4217: br.s loc_4D4219
          loc_4D4219: // Referenced from: loc_4D4217
          loc_4D4219: ret
        }

        assem override strict specialname void set_Label26(class Label WithEventsValue) {

          loc_4D421B: ldarg.0
          loc_4D421C: ldarg.1
          loc_4D421D: stfld GCUv2.frmSalesInvoice::_Label26
          loc_4D4222: ret
        }

        assem override strict specialname class Label get_Label25() {

          loc_4D4224: ldarg.0
          loc_4D4225: ldfld GCUv2.frmSalesInvoice::_Label25
          loc_4D422A: br.s loc_4D422C
          loc_4D422C: // Referenced from: loc_4D422A
          loc_4D422C: ret
        }

        assem override strict specialname void set_Label25(class Label WithEventsValue) {

          loc_4D422E: ldarg.0
          loc_4D422F: ldarg.1
          loc_4D4230: stfld GCUv2.frmSalesInvoice::_Label25
          loc_4D4235: ret
        }

        assem override strict specialname class DateTimePicker get_dtpTF() {

          loc_4D4237: ldarg.0
          loc_4D4238: ldfld GCUv2.frmSalesInvoice::_dtpTF
          loc_4D423D: br.s loc_4D423F
          loc_4D423F: // Referenced from: loc_4D423D
          loc_4D423F: ret
        }

        assem override strict specialname void set_dtpTF(class DateTimePicker WithEventsValue) {

          loc_4D4241: ldarg.0
          loc_4D4242: ldarg.1
          loc_4D4243: stfld GCUv2.frmSalesInvoice::_dtpTF
          loc_4D4248: ret
        }

        assem override strict specialname class Label get_Label24() {

          loc_4D424A: ldarg.0
          loc_4D424B: ldfld GCUv2.frmSalesInvoice::_Label24
          loc_4D4250: br.s loc_4D4252
          loc_4D4252: // Referenced from: loc_4D4250
          loc_4D4252: ret
        }

        assem override strict specialname void set_Label24(class Label WithEventsValue) {

          loc_4D4254: ldarg.0
          loc_4D4255: ldarg.1
          loc_4D4256: stfld GCUv2.frmSalesInvoice::_Label24
          loc_4D425B: ret
        }

        assem override strict specialname class ComboBox get_cboTF() {

          loc_4D425D: ldarg.0
          loc_4D425E: ldfld GCUv2.frmSalesInvoice::_cboTF
          loc_4D4263: br.s loc_4D4265
          loc_4D4265: // Referenced from: loc_4D4263
          loc_4D4265: ret
        }

        assem override strict specialname void set_cboTF(class ComboBox WithEventsValue) {

          loc_4D4267: ldarg.0
          loc_4D4268: ldarg.1
          loc_4D4269: stfld GCUv2.frmSalesInvoice::_cboTF
          loc_4D426E: ret
        }

        assem override strict specialname class Label get_Label27() {

          loc_4D4270: ldarg.0
          loc_4D4271: ldfld GCUv2.frmSalesInvoice::_Label27
          loc_4D4276: br.s loc_4D4278
          loc_4D4278: // Referenced from: loc_4D4276
          loc_4D4278: ret
        }

        assem override strict specialname void set_Label27(class Label WithEventsValue) {

          loc_4D427A: ldarg.0
          loc_4D427B: ldarg.1
          loc_4D427C: stfld GCUv2.frmSalesInvoice::_Label27
          loc_4D4281: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_4D4283: ldarg.0
          loc_4D4284: ldfld GCUv2.frmSalesInvoice::_cboStorage
          loc_4D4289: br.s loc_4D428B
          loc_4D428B: // Referenced from: loc_4D4289
          loc_4D428B: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class CheckBox get_chkUseOldPrice() {

          loc_4D42D0: ldarg.0
          loc_4D42D1: ldfld GCUv2.frmSalesInvoice::_chkUseOldPrice
          loc_4D42D6: br.s loc_4D42D8
          loc_4D42D8: // Referenced from: loc_4D42D6
          loc_4D42D8: ret
        }

        assem override strict specialname void set_chkUseOldPrice(class CheckBox WithEventsValue) {

          loc_4D42DA: ldarg.0
          loc_4D42DB: ldarg.1
          loc_4D42DC: stfld GCUv2.frmSalesInvoice::_chkUseOldPrice
          loc_4D42E1: ret
        }

        assem override strict specialname class Label get_Label29() {

          loc_4D42E3: ldarg.0
          loc_4D42E4: ldfld GCUv2.frmSalesInvoice::_Label29
          loc_4D42E9: br.s loc_4D42EB
          loc_4D42EB: // Referenced from: loc_4D42E9
          loc_4D42EB: ret
        }

        assem override strict specialname void set_Label29(class Label WithEventsValue) {

          loc_4D42ED: ldarg.0
          loc_4D42EE: ldarg.1
          loc_4D42EF: stfld GCUv2.frmSalesInvoice::_Label29
          loc_4D42F4: ret
        }

        assem override strict specialname class Label get_Label17() {

          loc_4D42F6: ldarg.0
          loc_4D42F7: ldfld GCUv2.frmSalesInvoice::_Label17
          loc_4D42FC: br.s loc_4D42FE
          loc_4D42FE: // Referenced from: loc_4D42FC
          loc_4D42FE: ret
        }

        assem override strict specialname void set_Label17(class Label WithEventsValue) {

          loc_4D4300: ldarg.0
          loc_4D4301: ldarg.1
          loc_4D4302: stfld GCUv2.frmSalesInvoice::_Label17
          loc_4D4307: ret
        }

        assem override strict specialname class ComboBox get_cboSalesPerson() {

          loc_4D4309: ldarg.0
          loc_4D430A: ldfld 
          loc_4D430F: br.s loc_4D4311
          loc_4D4311: // Referenced from: loc_4D430F
          loc_4D4311: ret
        }

        assem override strict specialname void set_cboSalesPerson(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Button get_btnPrint() {

          loc_4D4358: ldarg.0
          loc_4D4359: ldfld GCUv2.frmSalesInvoice::_btnPrint
          loc_4D435E: br.s loc_4D4360
          loc_4D4360: // Referenced from: loc_4D435E
          loc_4D4360: ret
        }

        assem override strict specialname void set_btnPrint(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSearch() {

          loc_4D43A8: ldarg.0
          loc_4D43A9: ldfld GCUv2.frmSalesInvoice::_btnSearch
          loc_4D43AE: br.s loc_4D43B0
          loc_4D43B0: // Referenced from: loc_4D43AE
          loc_4D43B0: ret
        }

        assem override strict specialname void set_btnSearch(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnCash() {

          loc_4D43F8: ldarg.0
          loc_4D43F9: ldfld GCUv2.frmSalesInvoice::_btnCash
          loc_4D43FE: br.s loc_4D4400
          loc_4D4400: // Referenced from: loc_4D43FE
          loc_4D4400: ret
        }

        assem override strict specialname void set_btnCash(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDO() {

          loc_4D4448: ldarg.0
          loc_4D4449: ldfld GCUv2.frmSalesInvoice::_btnDO
          loc_4D444E: br.s loc_4D4450
          loc_4D4450: // Referenced from: loc_4D444E
          loc_4D4450: ret
        }

        assem override strict specialname void set_btnDO(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSO() {

          loc_4D4498: ldarg.0
          loc_4D4499: ldfld GCUv2.frmSalesInvoice::_btnSO
          loc_4D449E: br.s loc_4D44A0
          loc_4D44A0: // Referenced from: loc_4D449E
          loc_4D44A0: ret
        }

        assem override strict specialname void set_btnSO(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblPaidDate() {

          loc_4D44E8: ldarg.0
          loc_4D44E9: ldfld GCUv2.frmSalesInvoice::_lblPaidDate
          loc_4D44EE: br.s loc_4D44F0
          loc_4D44F0: // Referenced from: loc_4D44EE
          loc_4D44F0: ret
        }

        assem override strict specialname void set_lblPaidDate(class Label WithEventsValue) {

          loc_4D44F2: ldarg.0
          loc_4D44F3: ldarg.1
          loc_4D44F4: stfld GCUv2.frmSalesInvoice::_lblPaidDate
          loc_4D44F9: ret
        }

        assem override strict specialname class Label get_lblTaxNumberDash() {

          loc_4D44FB: ldarg.0
          loc_4D44FC: ldfld GCUv2.frmSalesInvoice::_lblTaxNumberDash
          loc_4D4501: br.s loc_4D4503
          loc_4D4503: // Referenced from: loc_4D4501
          loc_4D4503: ret
        }

        assem override strict specialname void set_lblTaxNumberDash(class Label WithEventsValue) {

          loc_4D4505: ldarg.0
          loc_4D4506: ldarg.1
          loc_4D4507: stfld GCUv2.frmSalesInvoice::_lblTaxNumberDash
          loc_4D450C: ret
        }

        assem override strict specialname class Label get_lblTaxDateDash() {

          loc_4D450E: ldarg.0
          loc_4D450F: ldfld GCUv2.frmSalesInvoice::_lblTaxDateDash
          loc_4D4514: br.s loc_4D4516
          loc_4D4516: // Referenced from: loc_4D4514
          loc_4D4516: ret
        }

        assem override strict specialname void set_lblTaxDateDash(class Label WithEventsValue) {

          loc_4D4518: ldarg.0
          loc_4D4519: ldarg.1
          loc_4D451A: stfld GCUv2.frmSalesInvoice::_lblTaxDateDash
          loc_4D451F: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDiscountDescription() {

          loc_4D4521: ldarg.0
          loc_4D4522: ldfld GCUv2.frmSalesInvoice::_txtDiscountDescription
          loc_4D4527: br.s loc_4D4529
          loc_4D4529: // Referenced from: loc_4D4527
          loc_4D4529: ret
        }

        assem override strict specialname void set_txtDiscountDescription(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4D452B: ldarg.0
          loc_4D452C: ldarg.1
          loc_4D452D: stfld GCUv2.frmSalesInvoice::_txtDiscountDescription
          loc_4D4532: ret
        }

        assem override strict specialname class TextBox get_txtNote() {

          loc_4D4534: ldarg.0
          loc_4D4535: ldfld GCUv2.frmSalesInvoice::_txtNote
          loc_4D453A: br.s loc_4D453C
          loc_4D453C: // Referenced from: loc_4D453A
          loc_4D453C: ret
        }

        assem override strict specialname void set_txtNote(class TextBox WithEventsValue) {

          loc_4D453E: ldarg.0
          loc_4D453F: ldarg.1
          loc_4D4540: stfld GCUv2.frmSalesInvoice::_txtNote
          loc_4D4545: ret
        }

        public specialname double[] get_SOId() {

          double[] var_1;

        }

        public specialname void set_SOId(double[] value) {

          loc_4D4561: nop
          loc_4D4562: ldarg.0
          loc_4D4563: ldarg.1
          loc_4D4564: stfld GCUv2.frmSalesInvoice::_SOId
          loc_4D4569: ret
        }

        public specialname double[] get_DOId() {

          double[] var_1;

        }

        public specialname void set_DOId(double[] value) {

          loc_4D4585: nop
          loc_4D4586: ldarg.0
          loc_4D4587: ldarg.1
          loc_4D4588: stfld GCUv2.frmSalesInvoice::_DOId
          loc_4D458D: ret
        }

        public specialname double get_CustomerId() {

          double flt_1;

        }

        public specialname void set_CustomerId(double value) {

          loc_4D45A9: nop
          loc_4D45AA: ldarg.0
          loc_4D45AB: ldarg.1
          loc_4D45AC: stfld GCUv2.frmSalesInvoice::_customerId
          loc_4D45B1: ret
        }

        public specialname string get_CustomerNPWP() {

          string str_1;

        }

        public specialname void set_CustomerNPWP(string value) {

          loc_4D45CD: nop
          loc_4D45CE: ldarg.0
          loc_4D45CF: ldarg.1
          loc_4D45D0: stfld GCUv2.frmSalesInvoice::_customerNPWP
          loc_4D45D5: ret
        }

        public specialname int32 get_BranchId() {

          int32 num_1;

        }

        public specialname void set_BranchId(int32 value) {

          loc_4D45F1: nop
          loc_4D45F2: ldarg.0
          loc_4D45F3: ldarg.1
          loc_4D45F4: stfld GCUv2.frmSalesInvoice::_branchId
          loc_4D45F9: ret
        }

        public specialname boolean get_Edited() {

          boolean var_1;

        }

        public specialname void set_Edited(boolean value) {

          loc_4D4615: nop
          loc_4D4616: ldarg.0
          loc_4D4617: ldarg.1
          loc_4D4618: stfld GCUv2.frmSalesInvoice::_edited
          loc_4D461D: ret
        }

        public specialname valuetype System.DateTime get_OriginalDate() {

          valuetype System.DateTime var_1;

        }

        public specialname void set_OriginalDate(valuetype System.DateTime value) {

          loc_4D4639: nop
          loc_4D463A: ldarg.0
          loc_4D463B: ldarg.1
          loc_4D463C: stfld GCUv2.frmSalesInvoice::_originalDate
          loc_4D4641: ret
        }

        public specialname int32 get_OriginalStorageId() {

          int32 num_1;

        }

        public specialname void set_OriginalStorageId(int32 value) {

          loc_4D465D: nop
          loc_4D465E: ldarg.0
          loc_4D465F: ldarg.1
          loc_4D4660: stfld GCUv2.frmSalesInvoice::_originalStorageId
          loc_4D4665: ret
        }

        public specialname boolean get_Authorised() {

          boolean var_1;

        }

        public specialname void set_Authorised(boolean value) {

          loc_4D4681: nop
          loc_4D4682: ldarg.0
          loc_4D4683: ldarg.1
          loc_4D4684: stfld GCUv2.frmSalesInvoice::_authorised
          loc_4D4689: ret
        }

        public specialname int32 get_UnpaidLimit() {

          int32 num_1;

        }

        public specialname void set_UnpaidLimit(int32 value) {

          loc_4D46A5: nop
          loc_4D46A6: ldarg.0
          loc_4D46A7: ldarg.1
          loc_4D46A8: stfld GCUv2.frmSalesInvoice::_unpaidLimit
          loc_4D46AD: ret
        }

        public specialname boolean get_IsDonation() {

          boolean var_1;

        }

        public specialname void set_IsDonation(boolean value) {

          loc_4D46C9: nop
          loc_4D46CA: ldarg.0
          loc_4D46CB: ldarg.1
          loc_4D46CC: stfld GCUv2.frmSalesInvoice::_isDonation
          loc_4D46D1: ret
        }

        public void frmSalesInvoice() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        private void cboSalesPerson_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cSalesPerson var_2;
          class ComboBox var_3;

        }

        private void frmSalesInvoice_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_4D48C5: nop
          loc_4D48C6: ldarg.0
          loc_4D48C7: ldarg.1
          loc_4D48C8: stfld GCUv2.frmSalesInvoice::_currentId
          loc_4D48CD: ret
        }

        private void formatGrid() {

          class DataGridViewComboBoxColumn var_1;
          class DataGridViewCheckBoxColumn var_2;

        }

        public void prepareForm(boolean SaveNew) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cSalesInvoice var_1;
          valuetype System.DateTime var_2;
          class ComboBox var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          class GCUv2.cSalesInvoiceItem[] var_8;
          int32 num_3;
          class GCUv2.cSalesInvoiceItem var_9;
          boolean var_10;
          boolean var_11;
          class GCUv2.cSalesInvoicePayment[] var_12;
          int32 num_4;
          class GCUv2.cSalesInvoicePayment var_13;
          boolean var_14;
          class GCUv2.cSalesInvoiceReturn[] var_15;
          int32 num_5;
          class GCUv2.cSalesInvoiceReturn var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;

        }

        public void getTotalUnpaid() {

          loc_4D626D: nop
          loc_4D626E: ldarg.0
          loc_4D626F: ldarg.0
          loc_4D6270: ldfld GCUv2.frmSalesInvoice::_customerId
          loc_4D6275: call int32 GCUv2.cSalesInvoice::TotalUnpaidInvoice(double)
          loc_4D627A: stfld GCUv2.frmSalesInvoice::_totalUnpaid
          loc_4D627F: ret
        }

        private void btnSearch_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmCustomerMiniSearch var_1;
          boolean var_2;

        }

        public void LoadCustomer() {

          class GCUv2.cCustomer var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void lblCustomerName_Click(object sender, class System.EventArgs e) {

          loc_4D64EB: nop
          loc_4D64EC: ldarg.0
          loc_4D64ED: call instance void GCUv2.frmSalesInvoice::OpenCustomer()
          loc_4D64F2: nop
          loc_4D64F3: ret
        }

        private void lblCustomerAddress_Click(object sender, class System.EventArgs e) {

          loc_4D64EB: nop
          loc_4D64EC: ldarg.0
          loc_4D64ED: call instance void GCUv2.frmSalesInvoice::OpenCustomer()
          loc_4D64F2: nop
          loc_4D64F3: ret
        }

        private void OpenCustomer() {

          boolean var_1;

        }

        public void GetUnpaidReturn() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        public void calculateTotalPrice() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          double flt_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;
          int32 num_4;
          boolean var_4;
          int32 & var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        public void calculateDiscount() {


        }

        public void calculateTotalReturn() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          int32 num_4;
          boolean var_1;

        }

        public void calculateTotalPayment() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          int32 num_4;

        }

        public void calculateTotalInvoice() {

          int32 num_1;
          int32 num_2;
          double flt_1;
          double flt_2;
          double flt_3;
          valuetype System.DateTime var_1;
          double flt_4;
          int16 num_3;
          valuetype System.DateTime var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.frmSalesInvoiceItem var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnSO_Click(object sender, class System.EventArgs e) {

          boolean var_1;
          class GCUv2.frmSalesInvoiceSO var_2;

        }

        private void btnDO_Click(object sender, class System.EventArgs e) {

          boolean var_1;
          class GCUv2.frmSalesInvoiceDO var_2;

        }

        private void dgvItem_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_DoubleClick(object sender, class System.EventArgs e) {

          loc_4D7049: nop
          loc_4D704A: ldarg.0
          loc_4D704B: call instance void GCUv2.frmSalesInvoice::OpenItem()
          loc_4D7050: nop
          loc_4D7051: ret
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
          boolean var_3;
          class GCUv2.cComboItem var_4;
          class GCUv2.frmSalesInvoiceItem var_5;
          boolean var_6;
          class ComboBox var_7;
          boolean var_8;
          boolean var_9;

        }

        private void btnPayment_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.frmSalesInvoicePayment var_2;

        }

        private void btnCash_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvPayment_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_DoubleClick(object sender, class System.EventArgs e) {

          loc_4D7639: nop
          loc_4D763A: ldarg.0
          loc_4D763B: call instance void GCUv2.frmSalesInvoice::openPayment()
          loc_4D7640: nop
          loc_4D7641: ret
        }

        private void dgvPayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void openPayment() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          class GCUv2.frmSalesInvoicePayment var_5;
          class ComboBox var_6;
          boolean var_7;
          boolean var_8;

        }

        private void dgvReturn_DoubleClick(object sender, class System.EventArgs e) {

          loc_4D7AAD: nop
          loc_4D7AAE: ldarg.0
          loc_4D7AAF: call instance void GCUv2.frmSalesInvoice::OpenSalesReturn()
          loc_4D7AB4: nop
          loc_4D7AB5: ret
        }

        private void OpenSalesReturn() {

          boolean var_1;

        }

        private void dgvReturn_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvReturn_CellContentClick(object sender, class DataGridViewCellEventArgs e) {

          loc_4D7BE6: nop
          loc_4D7BE7: ldarg.0
          loc_4D7BE8: call instance void GCUv2.frmSalesInvoice::calculateTotalReturn()
          loc_4D7BED: nop
          loc_4D7BEE: ret
        }

        private void dgvReturn_CellContentDoubleClick(object sender, class DataGridViewCellEventArgs e) {

          loc_4D7BE6: nop
          loc_4D7BE7: ldarg.0
          loc_4D7BE8: call instance void GCUv2.frmSalesInvoice::calculateTotalReturn()
          loc_4D7BED: nop
          loc_4D7BEE: ret
        }

        private void txtDiscount_Click(object sender, class System.EventArgs e) {

          loc_4D7BF0: nop
          loc_4D7BF1: ldarg.0
          loc_4D7BF2: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7BF7: ldc.i4.0
          loc_4D7BF8: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_4D7BFD: nop
          loc_4D7BFE: ldarg.0
          loc_4D7BFF: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7C04: ldarg.0
          loc_4D7C05: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7C0A: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_4D7C0F: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_4D7C14: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_4D7C19: nop
          loc_4D7C1A: ret
        }

        private void txtDiscount_GotFocus(object sender, class System.EventArgs e) {

          loc_4D7BF0: nop
          loc_4D7BF1: ldarg.0
          loc_4D7BF2: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7BF7: ldc.i4.0
          loc_4D7BF8: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_4D7BFD: nop
          loc_4D7BFE: ldarg.0
          loc_4D7BFF: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7C04: ldarg.0
          loc_4D7C05: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDiscountValue()
          loc_4D7C0A: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_4D7C0F: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_4D7C14: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_4D7C19: nop
          loc_4D7C1A: ret
        }

        private void txtDiscount_TextChanged(object sender, class System.EventArgs e) {

          loc_4D7C1C: nop
          loc_4D7C1D: ldarg.0
          loc_4D7C1E: call instance void GCUv2.frmSalesInvoice::calculateTotalInvoice()
          loc_4D7C23: nop
          loc_4D7C24: ldarg.0
          loc_4D7C25: ldc.i4.1
          loc_4D7C26: stfld GCUv2.frmSalesInvoice::_edited
          loc_4D7C2B: ret
        }

        private void txtDeduction_Click(object sender, class System.EventArgs e) {

          loc_4D7C2D: nop
          loc_4D7C2E: ldarg.0
          loc_4D7C2F: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C34: ldc.i4.0
          loc_4D7C35: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_4D7C3A: nop
          loc_4D7C3B: ldarg.0
          loc_4D7C3C: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C41: ldarg.0
          loc_4D7C42: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C47: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_4D7C4C: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_4D7C51: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_4D7C56: nop
          loc_4D7C57: ret
        }

        private void txtDeduction_GotFocus(object sender, class System.EventArgs e) {

          loc_4D7C2D: nop
          loc_4D7C2E: ldarg.0
          loc_4D7C2F: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C34: ldc.i4.0
          loc_4D7C35: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_4D7C3A: nop
          loc_4D7C3B: ldarg.0
          loc_4D7C3C: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C41: ldarg.0
          loc_4D7C42: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmSalesInvoice::get_txtDeduction()
          loc_4D7C47: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_4D7C4C: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_4D7C51: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_4D7C56: nop
          loc_4D7C57: ret
        }

        private void txtDeduction_TextChanged(object sender, class System.EventArgs e) {

          loc_4D7C59: nop
          loc_4D7C5A: ldarg.0
          loc_4D7C5B: call instance void GCUv2.frmSalesInvoice::calculateTotalInvoice()
          loc_4D7C60: nop
          loc_4D7C61: ret
        }

        private void TabControl1_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_4D7CF6: nop
          loc_4D7CF7: ldarg.0
          loc_4D7CF8: ldc.i4.0
          loc_4D7CF9: call instance void GCUv2.frmSalesInvoice::SaveData(boolean)
          loc_4D7CFE: nop
          loc_4D7CFF: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_4D7D01: nop
          loc_4D7D02: ldarg.0
          loc_4D7D03: ldc.i4.1
          loc_4D7D04: call instance void GCUv2.frmSalesInvoice::SaveData(boolean)
          loc_4D7D09: nop
          loc_4D7D0A: ret
        }

        private boolean isCash() {

          boolean var_1;
          int32 num_1;
          int32 num_2;
          boolean var_2;

        }

        private boolean checkInput() {

          boolean var_1;
          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          string str_1;
          double flt_1;
          double flt_2;
          int32 num_3;
          int32 num_4;
          double flt_3;
          class GCUv2.cComboItem var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;
          boolean var_21;
          boolean var_22;
          boolean var_23;
          boolean var_24;
          boolean var_25;
          boolean var_26;
          boolean var_27;
          boolean var_28;
          boolean var_29;
          boolean var_30;
          boolean var_31;
          boolean var_32;
          boolean var_33;
          boolean var_34;
          boolean var_35;
          boolean var_36;
          boolean var_37;
          boolean var_38;
          boolean var_39;
          boolean var_40;
          boolean var_41;
          boolean var_42;
          boolean var_43;
          boolean var_44;
          boolean var_45;
          boolean var_46;
          boolean var_47;
          boolean var_48;
          boolean var_49;
          boolean var_50;
          boolean var_51;
          boolean var_52;
          boolean var_53;
          boolean var_54;
          int32 num_5;
          int32 num_6;
          boolean var_55;
          class GCUv2.cSalesInvoiceItem[] var_56;
          int32 num_7;
          class GCUv2.cSalesInvoiceItem var_57;
          boolean var_58;
          boolean var_59;
          boolean var_60;

        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          class MySqlClient.MySqlTransaction var_4;
          int32 num_3;
          class GCUv2.cSalesInvoice var_5;
          class GCUv2.cSalesInvoiceItem[] var_6;
          class GCUv2.cSalesInvoicePayment[] var_7;
          string str_1;
          string str_2;
          string str_3;
          class GCUv2.cSalesInvoiceReturn[] var_8;
          int32 num_4;
          string str_4;
          string str_5;
          class GCUv2.cHistory var_9;
          boolean var_10;
          boolean var_11;
          int32 num_5;
          boolean var_12;
          int32 num_6;
          boolean var_13;
          boolean var_14;
          int32 num_7;
          int32 num_8;
          boolean var_15;
          int32 num_9;
          boolean var_16;
          boolean var_17;
          boolean var_18;
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
          class GCUv2.cSalesInvoice var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

        private void btnPrint_Click(object sender, class System.EventArgs e) {

          string str_1;
          class GCUv2.frmSalesInvoicePrint var_1;
          class GCUv2.cPrintSetting var_2;
          int32 num_1;
          string[] var_3;
          int32 num_2;
          string str_2;
          string str_3;
          string str_4;
          string str_5;
          boolean var_4;
          boolean var_5;
          int32 num_3;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          int32 num_4;
          int32 num_5;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          int32 num_6;
          int32 num_7;
          boolean var_12;
          boolean var_13;
          int32 num_8;
          boolean var_14;

        }

        private void cboInvoiceCode_SelectedIndexChanged(object sender, class System.EventArgs e) {

          object var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.frmAuthorisation var_6;
          boolean var_7;

        }

        private void dtpInvoice_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          valuetype System.DateTime var_2;
          boolean var_3;

        }

        private void dtpTaxInvoice_ValueChanged(object sender, class System.EventArgs e) {

          loc_4DAA67: nop
          loc_4DAA68: ldarg.0
          loc_4DAA69: ldc.i4.1
          loc_4DAA6A: stfld GCUv2.frmSalesInvoice::_edited
          loc_4DAA6F: ret
        }

        private void txtInvoiceNumber_TextChanged(object sender, class System.EventArgs e) {

          loc_4DAA67: nop
          loc_4DAA68: ldarg.0
          loc_4DAA69: ldc.i4.1
          loc_4DAA6A: stfld GCUv2.frmSalesInvoice::_edited
          loc_4DAA6F: ret
        }

        private void txtTaxInvoiceNumber_TextChanged(object sender, class System.EventArgs e) {

          loc_4DAA67: nop
          loc_4DAA68: ldarg.0
          loc_4DAA69: ldc.i4.1
          loc_4DAA6A: stfld GCUv2.frmSalesInvoice::_edited
          loc_4DAA6F: ret
        }

    }
}
