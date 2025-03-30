using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label1;
        private class DateTimePicker _dtpInvoice;
        private class GCUv2.FilteredTextBox _txtDiscount;
        private class Label _Label5;
        private class Label _Label6;
        private class TextBox _txtInvoiceNo;
        private class Label _lblTotalPrice;
        private class Label _lblTotalReturn;
        private class Label _lblTotalPayment;
        private class Label _lblTotalPayable;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class Button _btnItem;
        private class DataGridView _dgvItem;
        private class TabPage _TabPage2;
        private class Button _btnPayment;
        private class TabPage _TabPage3;
        private class DataGridView _dgvReturn;
        private class TabPage _TabPage4;
        private class Label _Label3;
        private class Label _Label8;
        private class Label _Label9;
        private class Label _lblTotalInvoice;
        private class Label _Label11;
        private class Label _Label12;
        private class Label _Label13;
        private class DataGridView _dgvPayment;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label10;
        private class ComboBox _cboSupplier;
        private class Label _Label7;
        private class Label _lblSupplier;
        private class Label _Label16;
        private class ComboBox _cboInvoiceCode;
        private class TextBox _txtTaxInvoiceNo;
        private class Label _lblTaxNumber;
        private class Label _lblTaxDate;
        private class DateTimePicker _dtpTaxInvoice;
        private class GCUv2.FilteredTextBox _txtDeduction;
        private class Label _Label14;
        private class Label _Label15;
        private class Label _lblTotalPaymentPlusDeduction;
        private class Label _Label18;
        private class Button _btnReceivedItem;
        private class GCUv2.FilteredTextBox _txtCurrencyRate;
        private class Label _Label17;
        private class Label _lblCurrencyName;
        private class Label _Label4;
        private class ComboBox _cboStorage;
        private class Label _lblPaidDate;
        private class Label _lblTaxDateDash;
        private class Label _lblTaxNumberDash;
        private class Label _lblPPN2;
        private class Label _lblSubTotalPrice2;
        private class Label _lblPPN;
        private class Label _lblSubTotalPrice;
        private class Label _Label20;
        private class CheckBox _chkPPN;
        private double _currentId;
        private int32 _currentlySelectedComboIndex;
        private boolean _suppressComboChange;
        private valuetype System.DateTime _paidDate;
        private boolean _hasNPWP;
        private double[] _riId;
        private int32 _currencyId;
        private boolean _disableDgvItem;
        private int32 _cashAccountId;
        private int32 _bankAccountId;
        private boolean _justLoaded;
        private string _addDailyTotalSql;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class DataGridViewCellStyle var_1;
          class DataGridViewCellStyle var_2;

        }

        assem override strict specialname class Label get_Label1() {

          loc_526B5F: ldarg.0
          loc_526B60: ldfld GCUv2.frmPurchaseInvoice::_Label1
          loc_526B65: br.s loc_526B67
          loc_526B67: // Referenced from: loc_526B65
          loc_526B67: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_526B69: ldarg.0
          loc_526B6A: ldarg.1
          loc_526B6B: stfld GCUv2.frmPurchaseInvoice::_Label1
          loc_526B70: ret
        }

        assem override strict specialname class DateTimePicker get_dtpInvoice() {

          loc_526B72: ldarg.0
          loc_526B73: ldfld GCUv2.frmPurchaseInvoice::_dtpInvoice
          loc_526B78: br.s loc_526B7A
          loc_526B7A: // Referenced from: loc_526B78
          loc_526B7A: ret
        }

        assem override strict specialname void set_dtpInvoice(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDiscount() {

          loc_526BC0: ldarg.0
          loc_526BC1: ldfld GCUv2.frmPurchaseInvoice::_txtDiscount
          loc_526BC6: br.s loc_526BC8
          loc_526BC8: // Referenced from: loc_526BC6
          loc_526BC8: ret
        }

        assem override strict specialname void set_txtDiscount(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label5() {

          loc_526C46: ldarg.0
          loc_526C47: ldfld GCUv2.frmPurchaseInvoice::_Label5
          loc_526C4C: br.s loc_526C4E
          loc_526C4E: // Referenced from: loc_526C4C
          loc_526C4E: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_526C50: ldarg.0
          loc_526C51: ldarg.1
          loc_526C52: stfld GCUv2.frmPurchaseInvoice::_Label5
          loc_526C57: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_526C59: ldarg.0
          loc_526C5A: ldfld GCUv2.frmPurchaseInvoice::_Label6
          loc_526C5F: br.s loc_526C61
          loc_526C61: // Referenced from: loc_526C5F
          loc_526C61: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_526C63: ldarg.0
          loc_526C64: ldarg.1
          loc_526C65: stfld GCUv2.frmPurchaseInvoice::_Label6
          loc_526C6A: ret
        }

        assem override strict specialname class TextBox get_txtInvoiceNo() {

          loc_526C6C: ldarg.0
          loc_526C6D: ldfld GCUv2.frmPurchaseInvoice::_txtInvoiceNo
          loc_526C72: br.s loc_526C74
          loc_526C74: // Referenced from: loc_526C72
          loc_526C74: ret
        }

        assem override strict specialname void set_txtInvoiceNo(class TextBox WithEventsValue) {

          loc_526C76: ldarg.0
          loc_526C77: ldarg.1
          loc_526C78: stfld GCUv2.frmPurchaseInvoice::_txtInvoiceNo
          loc_526C7D: ret
        }

        assem override strict specialname class Label get_lblTotalPrice() {

          loc_526C7F: ldarg.0
          loc_526C80: ldfld GCUv2.frmPurchaseInvoice::_lblTotalPrice
          loc_526C85: br.s loc_526C87
          loc_526C87: // Referenced from: loc_526C85
          loc_526C87: ret
        }

        assem override strict specialname void set_lblTotalPrice(class Label WithEventsValue) {

          loc_526C89: ldarg.0
          loc_526C8A: ldarg.1
          loc_526C8B: stfld GCUv2.frmPurchaseInvoice::_lblTotalPrice
          loc_526C90: ret
        }

        assem override strict specialname class Label get_lblTotalReturn() {

          loc_526C92: ldarg.0
          loc_526C93: ldfld GCUv2.frmPurchaseInvoice::_lblTotalReturn
          loc_526C98: br.s loc_526C9A
          loc_526C9A: // Referenced from: loc_526C98
          loc_526C9A: ret
        }

        assem override strict specialname void set_lblTotalReturn(class Label WithEventsValue) {

          loc_526C9C: ldarg.0
          loc_526C9D: ldarg.1
          loc_526C9E: stfld GCUv2.frmPurchaseInvoice::_lblTotalReturn
          loc_526CA3: ret
        }

        assem override strict specialname class Label get_lblTotalPayment() {

          loc_526CA5: ldarg.0
          loc_526CA6: ldfld GCUv2.frmPurchaseInvoice::_lblTotalPayment
          loc_526CAB: br.s loc_526CAD
          loc_526CAD: // Referenced from: loc_526CAB
          loc_526CAD: ret
        }

        assem override strict specialname void set_lblTotalPayment(class Label WithEventsValue) {

          loc_526CAF: ldarg.0
          loc_526CB0: ldarg.1
          loc_526CB1: stfld GCUv2.frmPurchaseInvoice::_lblTotalPayment
          loc_526CB6: ret
        }

        assem override strict specialname class Label get_lblTotalPayable() {

          loc_526CB8: ldarg.0
          loc_526CB9: ldfld GCUv2.frmPurchaseInvoice::_lblTotalPayable
          loc_526CBE: br.s loc_526CC0
          loc_526CC0: // Referenced from: loc_526CBE
          loc_526CC0: ret
        }

        assem override strict specialname void set_lblTotalPayable(class Label WithEventsValue) {

          loc_526CC2: ldarg.0
          loc_526CC3: ldarg.1
          loc_526CC4: stfld GCUv2.frmPurchaseInvoice::_lblTotalPayable
          loc_526CC9: ret
        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_526CCB: ldarg.0
          loc_526CCC: ldfld GCUv2.frmPurchaseInvoice::_TabControl1
          loc_526CD1: br.s loc_526CD3
          loc_526CD3: // Referenced from: loc_526CD1
          loc_526CD3: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          class System.EventHandler var_1;
          class TabControl var_2;

        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_526D18: ldarg.0
          loc_526D19: ldfld GCUv2.frmPurchaseInvoice::_TabPage1
          loc_526D1E: br.s loc_526D20
          loc_526D20: // Referenced from: loc_526D1E
          loc_526D20: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_526D22: ldarg.0
          loc_526D23: ldarg.1
          loc_526D24: stfld GCUv2.frmPurchaseInvoice::_TabPage1
          loc_526D29: ret
        }

        assem override strict specialname class Button get_btnItem() {

          loc_526D2B: ldarg.0
          loc_526D2C: ldfld GCUv2.frmPurchaseInvoice::_btnItem
          loc_526D31: br.s loc_526D33
          loc_526D33: // Referenced from: loc_526D31
          loc_526D33: ret
        }

        assem override strict specialname void set_btnItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_526D78: ldarg.0
          loc_526D79: ldfld GCUv2.frmPurchaseInvoice::_dgvItem
          loc_526D7E: br.s loc_526D80
          loc_526D80: // Referenced from: loc_526D7E
          loc_526D80: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class TabPage get_TabPage2() {

          loc_526E25: ldarg.0
          loc_526E26: ldfld GCUv2.frmPurchaseInvoice::_TabPage2
          loc_526E2B: br.s loc_526E2D
          loc_526E2D: // Referenced from: loc_526E2B
          loc_526E2D: ret
        }

        assem override strict specialname void set_TabPage2(class TabPage WithEventsValue) {

          loc_526E2F: ldarg.0
          loc_526E30: ldarg.1
          loc_526E31: stfld GCUv2.frmPurchaseInvoice::_TabPage2
          loc_526E36: ret
        }

        assem override strict specialname class Button get_btnPayment() {

          loc_526E38: ldarg.0
          loc_526E39: ldfld GCUv2.frmPurchaseInvoice::_btnPayment
          loc_526E3E: br.s loc_526E40
          loc_526E40: // Referenced from: loc_526E3E
          loc_526E40: ret
        }

        assem override strict specialname void set_btnPayment(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TabPage get_TabPage3() {

          loc_526E88: ldarg.0
          loc_526E89: ldfld GCUv2.frmPurchaseInvoice::_TabPage3
          loc_526E8E: br.s loc_526E90
          loc_526E90: // Referenced from: loc_526E8E
          loc_526E90: ret
        }

        assem override strict specialname void set_TabPage3(class TabPage WithEventsValue) {

          loc_526E92: ldarg.0
          loc_526E93: ldarg.1
          loc_526E94: stfld GCUv2.frmPurchaseInvoice::_TabPage3
          loc_526E99: ret
        }

        assem override strict specialname class DataGridView get_dgvReturn() {

          loc_526E9B: ldarg.0
          loc_526E9C: ldfld GCUv2.frmPurchaseInvoice::_dgvReturn
          loc_526EA1: br.s loc_526EA3
          loc_526EA3: // Referenced from: loc_526EA1
          loc_526EA3: ret
        }

        assem override strict specialname void set_dgvReturn(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridViewCellEventHandler var_5;
          class DataGridViewCellEventHandler var_6;
          class DataGridView var_7;

        }

        assem override strict specialname class TabPage get_TabPage4() {

          loc_526F85: ldarg.0
          loc_526F86: ldfld GCUv2.frmPurchaseInvoice::_TabPage4
          loc_526F8B: br.s loc_526F8D
          loc_526F8D: // Referenced from: loc_526F8B
          loc_526F8D: ret
        }

        assem override strict specialname void set_TabPage4(class TabPage WithEventsValue) {

          loc_526F8F: ldarg.0
          loc_526F90: ldarg.1
          loc_526F91: stfld GCUv2.frmPurchaseInvoice::_TabPage4
          loc_526F96: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_526F98: ldarg.0
          loc_526F99: ldfld GCUv2.frmPurchaseInvoice::_Label3
          loc_526F9E: br.s loc_526FA0
          loc_526FA0: // Referenced from: loc_526F9E
          loc_526FA0: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_526FA2: ldarg.0
          loc_526FA3: ldarg.1
          loc_526FA4: stfld GCUv2.frmPurchaseInvoice::_Label3
          loc_526FA9: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_526FAB: ldarg.0
          loc_526FAC: ldfld GCUv2.frmPurchaseInvoice::_Label8
          loc_526FB1: br.s loc_526FB3
          loc_526FB3: // Referenced from: loc_526FB1
          loc_526FB3: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_526FB5: ldarg.0
          loc_526FB6: ldarg.1
          loc_526FB7: stfld GCUv2.frmPurchaseInvoice::_Label8
          loc_526FBC: ret
        }

        assem override strict specialname class Label get_Label9() {

          loc_526FBE: ldarg.0
          loc_526FBF: ldfld GCUv2.frmPurchaseInvoice::_Label9
          loc_526FC4: br.s loc_526FC6
          loc_526FC6: // Referenced from: loc_526FC4
          loc_526FC6: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_526FC8: ldarg.0
          loc_526FC9: ldarg.1
          loc_526FCA: stfld GCUv2.frmPurchaseInvoice::_Label9
          loc_526FCF: ret
        }

        assem override strict specialname class Label get_lblTotalInvoice() {

          loc_526FD1: ldarg.0
          loc_526FD2: ldfld GCUv2.frmPurchaseInvoice::_lblTotalInvoice
          loc_526FD7: br.s loc_526FD9
          loc_526FD9: // Referenced from: loc_526FD7
          loc_526FD9: ret
        }

        assem override strict specialname void set_lblTotalInvoice(class Label WithEventsValue) {

          loc_526FDB: ldarg.0
          loc_526FDC: ldarg.1
          loc_526FDD: stfld GCUv2.frmPurchaseInvoice::_lblTotalInvoice
          loc_526FE2: ret
        }

        assem override strict specialname class Label get_Label11() {

          loc_526FE4: ldarg.0
          loc_526FE5: ldfld GCUv2.frmPurchaseInvoice::_Label11
          loc_526FEA: br.s loc_526FEC
          loc_526FEC: // Referenced from: loc_526FEA
          loc_526FEC: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_526FEE: ldarg.0
          loc_526FEF: ldarg.1
          loc_526FF0: stfld GCUv2.frmPurchaseInvoice::_Label11
          loc_526FF5: ret
        }

        assem override strict specialname class Label get_Label12() {

          loc_526FF7: ldarg.0
          loc_526FF8: ldfld GCUv2.frmPurchaseInvoice::_Label12
          loc_526FFD: br.s loc_526FFF
          loc_526FFF: // Referenced from: loc_526FFD
          loc_526FFF: ret
        }

        assem override strict specialname void set_Label12(class Label WithEventsValue) {

          loc_527001: ldarg.0
          loc_527002: ldarg.1
          loc_527003: stfld GCUv2.frmPurchaseInvoice::_Label12
          loc_527008: ret
        }

        assem override strict specialname class Label get_Label13() {

          loc_52700A: ldarg.0
          loc_52700B: ldfld GCUv2.frmPurchaseInvoice::_Label13
          loc_527010: br.s loc_527012
          loc_527012: // Referenced from: loc_527010
          loc_527012: ret
        }

        assem override strict specialname void set_Label13(class Label WithEventsValue) {

          loc_527014: ldarg.0
          loc_527015: ldarg.1
          loc_527016: stfld GCUv2.frmPurchaseInvoice::_Label13
          loc_52701B: ret
        }

        assem override strict specialname class DataGridView get_dgvPayment() {

          loc_52701D: ldarg.0
          loc_52701E: ldfld GCUv2.frmPurchaseInvoice::_dgvPayment
          loc_527023: br.s loc_527025
          loc_527025: // Referenced from: loc_527023
          loc_527025: ret
        }

        assem override strict specialname void set_dgvPayment(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_5270C9: ldarg.0
          loc_5270CA: ldfld GCUv2.frmPurchaseInvoice::_btnHistory
          loc_5270CF: br.s loc_5270D1
          loc_5270D1: // Referenced from: loc_5270CF
          loc_5270D1: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_527118: ldarg.0
          loc_527119: ldfld GCUv2.frmPurchaseInvoice::_btnSaveClose
          loc_52711E: br.s loc_527120
          loc_527120: // Referenced from: loc_52711E
          loc_527120: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_527168: ldarg.0
          loc_527169: ldfld GCUv2.frmPurchaseInvoice::_btnDelete
          loc_52716E: br.s loc_527170
          loc_527170: // Referenced from: loc_52716E
          loc_527170: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_5271B8: ldarg.0
          loc_5271B9: ldfld GCUv2.frmPurchaseInvoice::_btnSave
          loc_5271BE: br.s loc_5271C0
          loc_5271C0: // Referenced from: loc_5271BE
          loc_5271C0: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label10() {

          loc_527208: ldarg.0
          loc_527209: ldfld GCUv2.frmPurchaseInvoice::_Label10
          loc_52720E: br.s loc_527210
          loc_527210: // Referenced from: loc_52720E
          loc_527210: ret
        }

        assem override strict specialname void set_Label10(class Label WithEventsValue) {

          loc_527212: ldarg.0
          loc_527213: ldarg.1
          loc_527214: stfld GCUv2.frmPurchaseInvoice::_Label10
          loc_527219: ret
        }

        assem override strict specialname class ComboBox get_cboSupplier() {

          loc_52721B: ldarg.0
          loc_52721C: ldfld GCUv2.frmPurchaseInvoice::_cboSupplier
          loc_527221: br.s loc_527223
          loc_527223: // Referenced from: loc_527221
          loc_527223: ret
        }

        assem override strict specialname void set_cboSupplier(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label7() {

          loc_527268: ldarg.0
          loc_527269: ldfld GCUv2.frmPurchaseInvoice::_Label7
          loc_52726E: br.s loc_527270
          loc_527270: // Referenced from: loc_52726E
          loc_527270: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_527272: ldarg.0
          loc_527273: ldarg.1
          loc_527274: stfld GCUv2.frmPurchaseInvoice::_Label7
          loc_527279: ret
        }

        assem override strict specialname class Label get_lblSupplier() {

          loc_52727B: ldarg.0
          loc_52727C: ldfld GCUv2.frmPurchaseInvoice::_lblSupplier
          loc_527281: br.s loc_527283
          loc_527283: // Referenced from: loc_527281
          loc_527283: ret
        }

        assem override strict specialname void set_lblSupplier(class Label WithEventsValue) {

          loc_527285: ldarg.0
          loc_527286: ldarg.1
          loc_527287: stfld GCUv2.frmPurchaseInvoice::_lblSupplier
          loc_52728C: ret
        }

        assem override strict specialname class Label get_Label16() {

          loc_52728E: ldarg.0
          loc_52728F: ldfld GCUv2.frmPurchaseInvoice::_Label16
          loc_527294: br.s loc_527296
          loc_527296: // Referenced from: loc_527294
          loc_527296: ret
        }

        assem override strict specialname void set_Label16(class Label WithEventsValue) {

          loc_527298: ldarg.0
          loc_527299: ldarg.1
          loc_52729A: stfld GCUv2.frmPurchaseInvoice::_Label16
          loc_52729F: ret
        }

        assem override strict specialname class ComboBox get_cboInvoiceCode() {

          loc_5272A1: ldarg.0
          loc_5272A2: ldfld GCUv2.frmPurchaseInvoice::_cboInvoiceCode
          loc_5272A7: br.s loc_5272A9
          loc_5272A9: // Referenced from: loc_5272A7
          loc_5272A9: ret
        }

        assem override strict specialname void set_cboInvoiceCode(class ComboBox WithEventsValue) {

          loc_5272AB: ldarg.0
          loc_5272AC: ldarg.1
          loc_5272AD: stfld GCUv2.frmPurchaseInvoice::_cboInvoiceCode
          loc_5272B2: ret
        }

        assem override strict specialname class TextBox get_txtTaxInvoiceNo() {

          loc_5272B4: ldarg.0
          loc_5272B5: ldfld GCUv2.frmPurchaseInvoice::_txtTaxInvoiceNo
          loc_5272BA: br.s loc_5272BC
          loc_5272BC: // Referenced from: loc_5272BA
          loc_5272BC: ret
        }

        assem override strict specialname void set_txtTaxInvoiceNo(class TextBox WithEventsValue) {

          loc_5272BE: ldarg.0
          loc_5272BF: ldarg.1
          loc_5272C0: stfld GCUv2.frmPurchaseInvoice::_txtTaxInvoiceNo
          loc_5272C5: ret
        }

        assem override strict specialname class Label get_lblTaxNumber() {

          loc_5272C7: ldarg.0
          loc_5272C8: ldfld GCUv2.frmPurchaseInvoice::_lblTaxNumber
          loc_5272CD: br.s loc_5272CF
          loc_5272CF: // Referenced from: loc_5272CD
          loc_5272CF: ret
        }

        assem override strict specialname void set_lblTaxNumber(class Label WithEventsValue) {

          loc_5272D1: ldarg.0
          loc_5272D2: ldarg.1
          loc_5272D3: stfld GCUv2.frmPurchaseInvoice::_lblTaxNumber
          loc_5272D8: ret
        }

        assem override strict specialname class Label get_lblTaxDate() {

          loc_5272DA: ldarg.0
          loc_5272DB: ldfld GCUv2.frmPurchaseInvoice::_lblTaxDate
          loc_5272E0: br.s loc_5272E2
          loc_5272E2: // Referenced from: loc_5272E0
          loc_5272E2: ret
        }

        assem override strict specialname void set_lblTaxDate(class Label WithEventsValue) {

          loc_5272E4: ldarg.0
          loc_5272E5: ldarg.1
          loc_5272E6: stfld GCUv2.frmPurchaseInvoice::_lblTaxDate
          loc_5272EB: ret
        }

        assem override strict specialname class DateTimePicker get_dtpTaxInvoice() {

          loc_5272ED: ldarg.0
          loc_5272EE: ldfld GCUv2.frmPurchaseInvoice::_dtpTaxInvoice
          loc_5272F3: br.s loc_5272F5
          loc_5272F5: // Referenced from: loc_5272F3
          loc_5272F5: ret
        }

        assem override strict specialname void set_dtpTaxInvoice(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtDeduction() {

          loc_52733C: ldarg.0
          loc_52733D: ldfld GCUv2.frmPurchaseInvoice::_txtDeduction
          loc_527342: br.s loc_527344
          loc_527344: // Referenced from: loc_527342
          loc_527344: ret
        }

        assem override strict specialname void set_txtDeduction(class GCUv2.FilteredTextBox WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class GCUv2.FilteredTextBox var_4;

        }

        assem override strict specialname class Label get_Label14() {

          loc_5273C2: ldarg.0
          loc_5273C3: ldfld GCUv2.frmPurchaseInvoice::_Label14
          loc_5273C8: br.s loc_5273CA
          loc_5273CA: // Referenced from: loc_5273C8
          loc_5273CA: ret
        }

        assem override strict specialname void set_Label14(class Label WithEventsValue) {

          loc_5273CC: ldarg.0
          loc_5273CD: ldarg.1
          loc_5273CE: stfld GCUv2.frmPurchaseInvoice::_Label14
          loc_5273D3: ret
        }

        assem override strict specialname class Label get_Label15() {

          loc_5273D5: ldarg.0
          loc_5273D6: ldfld GCUv2.frmPurchaseInvoice::_Label15
          loc_5273DB: br.s loc_5273DD
          loc_5273DD: // Referenced from: loc_5273DB
          loc_5273DD: ret
        }

        assem override strict specialname void set_Label15(class Label WithEventsValue) {

          loc_5273DF: ldarg.0
          loc_5273E0: ldarg.1
          loc_5273E1: stfld GCUv2.frmPurchaseInvoice::_Label15
          loc_5273E6: ret
        }

        assem override strict specialname class Label get_lblTotalPaymentPlusDeduction() {

          loc_5273E8: ldarg.0
          loc_5273E9: ldfld GCUv2.frmPurchaseInvoice::_lblTotalPaymentPlusDeduction
          loc_5273EE: br.s loc_5273F0
          loc_5273F0: // Referenced from: loc_5273EE
          loc_5273F0: ret
        }

        assem override strict specialname void set_lblTotalPaymentPlusDeduction(class Label WithEventsValue) {

          loc_5273F2: ldarg.0
          loc_5273F3: ldarg.1
          loc_5273F4: stfld GCUv2.frmPurchaseInvoice::_lblTotalPaymentPlusDeduction
          loc_5273F9: ret
        }

        assem override strict specialname class Label get_Label18() {

          loc_5273FB: ldarg.0
          loc_5273FC: ldfld GCUv2.frmPurchaseInvoice::_Label18
          loc_527401: br.s loc_527403
          loc_527403: // Referenced from: loc_527401
          loc_527403: ret
        }

        assem override strict specialname void set_Label18(class Label WithEventsValue) {

          loc_527405: ldarg.0
          loc_527406: ldarg.1
          loc_527407: stfld GCUv2.frmPurchaseInvoice::_Label18
          loc_52740C: ret
        }

        assem override strict specialname class Button get_btnReceivedItem() {

          loc_52740E: ldarg.0
          loc_52740F: ldfld GCUv2.frmPurchaseInvoice::_btnReceivedItem
          loc_527414: br.s loc_527416
          loc_527416: // Referenced from: loc_527414
          loc_527416: ret
        }

        assem override strict specialname void set_btnReceivedItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtCurrencyRate() {

          loc_52745C: ldarg.0
          loc_52745D: ldfld GCUv2.frmPurchaseInvoice::_txtCurrencyRate
          loc_527462: br.s loc_527464
          loc_527464: // Referenced from: loc_527462
          loc_527464: ret
        }

        assem override strict specialname void set_txtCurrencyRate(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_527466: ldarg.0
          loc_527467: ldarg.1
          loc_527468: stfld GCUv2.frmPurchaseInvoice::_txtCurrencyRate
          loc_52746D: ret
        }

        assem override strict specialname class Label get_Label17() {

          loc_52746F: ldarg.0
          loc_527470: ldfld GCUv2.frmPurchaseInvoice::_Label17
          loc_527475: br.s loc_527477
          loc_527477: // Referenced from: loc_527475
          loc_527477: ret
        }

        assem override strict specialname void set_Label17(class Label WithEventsValue) {

          loc_527479: ldarg.0
          loc_52747A: ldarg.1
          loc_52747B: stfld GCUv2.frmPurchaseInvoice::_Label17
          loc_527480: ret
        }

        assem override strict specialname class Label get_lblCurrencyName() {

          loc_527482: ldarg.0
          loc_527483: ldfld GCUv2.frmPurchaseInvoice::_lblCurrencyName
          loc_527488: br.s loc_52748A
          loc_52748A: // Referenced from: loc_527488
          loc_52748A: ret
        }

        assem override strict specialname void set_lblCurrencyName(class Label WithEventsValue) {

          loc_52748C: ldarg.0
          loc_52748D: ldarg.1
          loc_52748E: stfld GCUv2.frmPurchaseInvoice::_lblCurrencyName
          loc_527493: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_527495: ldarg.0
          loc_527496: ldfld GCUv2.frmPurchaseInvoice::_Label4
          loc_52749B: br.s loc_52749D
          loc_52749D: // Referenced from: loc_52749B
          loc_52749D: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_52749F: ldarg.0
          loc_5274A0: ldarg.1
          loc_5274A1: stfld GCUv2.frmPurchaseInvoice::_Label4
          loc_5274A6: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_5274A8: ldarg.0
          loc_5274A9: ldfld GCUv2.frmPurchaseInvoice::_cboStorage
          loc_5274AE: br.s loc_5274B0
          loc_5274B0: // Referenced from: loc_5274AE
          loc_5274B0: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_lblPaidDate() {

          loc_5274F8: ldarg.0
          loc_5274F9: ldfld GCUv2.frmPurchaseInvoice::_lblPaidDate
          loc_5274FE: br.s loc_527500
          loc_527500: // Referenced from: loc_5274FE
          loc_527500: ret
        }

        assem override strict specialname void set_lblPaidDate(class Label WithEventsValue) {

          loc_527502: ldarg.0
          loc_527503: ldarg.1
          loc_527504: stfld GCUv2.frmPurchaseInvoice::_lblPaidDate
          loc_527509: ret
        }

        assem override strict specialname class Label get_lblTaxDateDash() {

          loc_52750B: ldarg.0
          loc_52750C: ldfld GCUv2.frmPurchaseInvoice::_lblTaxDateDash
          loc_527511: br.s loc_527513
          loc_527513: // Referenced from: loc_527511
          loc_527513: ret
        }

        assem override strict specialname void set_lblTaxDateDash(class Label WithEventsValue) {

          loc_527515: ldarg.0
          loc_527516: ldarg.1
          loc_527517: stfld GCUv2.frmPurchaseInvoice::_lblTaxDateDash
          loc_52751C: ret
        }

        assem override strict specialname class Label get_lblTaxNumberDash() {

          loc_52751E: ldarg.0
          loc_52751F: ldfld GCUv2.frmPurchaseInvoice::_lblTaxNumberDash
          loc_527524: br.s loc_527526
          loc_527526: // Referenced from: loc_527524
          loc_527526: ret
        }

        assem override strict specialname void set_lblTaxNumberDash(class Label WithEventsValue) {

          loc_527528: ldarg.0
          loc_527529: ldarg.1
          loc_52752A: stfld GCUv2.frmPurchaseInvoice::_lblTaxNumberDash
          loc_52752F: ret
        }

        assem override strict specialname class Label get_lblPPN2() {

          loc_527531: ldarg.0
          loc_527532: ldfld GCUv2.frmPurchaseInvoice::_lblPPN2
          loc_527537: br.s loc_527539
          loc_527539: // Referenced from: loc_527537
          loc_527539: ret
        }

        assem override strict specialname void set_lblPPN2(class Label WithEventsValue) {

          loc_52753B: ldarg.0
          loc_52753C: ldarg.1
          loc_52753D: stfld GCUv2.frmPurchaseInvoice::_lblPPN2
          loc_527542: ret
        }

        assem override strict specialname class Label get_lblSubTotalPrice2() {

          loc_527544: ldarg.0
          loc_527545: ldfld GCUv2.frmPurchaseInvoice::_lblSubTotalPrice2
          loc_52754A: br.s loc_52754C
          loc_52754C: // Referenced from: loc_52754A
          loc_52754C: ret
        }

        assem override strict specialname void set_lblSubTotalPrice2(class Label WithEventsValue) {

          loc_52754E: ldarg.0
          loc_52754F: ldarg.1
          loc_527550: stfld GCUv2.frmPurchaseInvoice::_lblSubTotalPrice2
          loc_527555: ret
        }

        assem override strict specialname class Label get_lblPPN() {

          loc_527557: ldarg.0
          loc_527558: ldfld GCUv2.frmPurchaseInvoice::_lblPPN
          loc_52755D: br.s loc_52755F
          loc_52755F: // Referenced from: loc_52755D
          loc_52755F: ret
        }

        assem override strict specialname void set_lblPPN(class Label WithEventsValue) {

          loc_527561: ldarg.0
          loc_527562: ldarg.1
          loc_527563: stfld GCUv2.frmPurchaseInvoice::_lblPPN
          loc_527568: ret
        }

        assem override strict specialname class Label get_lblSubTotalPrice() {

          loc_52756A: ldarg.0
          loc_52756B: ldfld GCUv2.frmPurchaseInvoice::_lblSubTotalPrice
          loc_527570: br.s loc_527572
          loc_527572: // Referenced from: loc_527570
          loc_527572: ret
        }

        assem override strict specialname void set_lblSubTotalPrice(class Label WithEventsValue) {

          loc_527574: ldarg.0
          loc_527575: ldarg.1
          loc_527576: stfld GCUv2.frmPurchaseInvoice::_lblSubTotalPrice
          loc_52757B: ret
        }

        assem override strict specialname class Label get_Label20() {

          loc_52757D: ldarg.0
          loc_52757E: ldfld GCUv2.frmPurchaseInvoice::_Label20
          loc_527583: br.s loc_527585
          loc_527585: // Referenced from: loc_527583
          loc_527585: ret
        }

        assem override strict specialname void set_Label20(class Label WithEventsValue) {

          loc_527587: ldarg.0
          loc_527588: ldarg.1
          loc_527589: stfld GCUv2.frmPurchaseInvoice::_Label20
          loc_52758E: ret
        }

        assem override strict specialname class CheckBox get_chkPPN() {

          loc_527590: ldarg.0
          loc_527591: ldfld GCUv2.frmPurchaseInvoice::_chkPPN
          loc_527596: br.s loc_527598
          loc_527598: // Referenced from: loc_527596
          loc_527598: ret
        }

        assem override strict specialname void set_chkPPN(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        public specialname double[] get_RIId() {

          double[] var_1;

        }

        public specialname void set_RIId(double[] value) {

          loc_5275F9: nop
          loc_5275FA: ldarg.0
          loc_5275FB: ldarg.1
          loc_5275FC: stfld GCUv2.frmPurchaseInvoice::_riId
          loc_527601: ret
        }

        public void frmPurchaseInvoice() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        private void frmPurchaseInvoice_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_527809: nop
          loc_52780A: ldarg.0
          loc_52780B: ldarg.1
          loc_52780C: stfld GCUv2.frmPurchaseInvoice::_currentId
          loc_527811: ret
        }

        private void formatGrid() {

          class DataGridViewCheckBoxColumn var_1;

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
          boolean var_5;
          class ComboBox var_6;
          boolean var_7;
          class GCUv2.cPurchaseInvoiceItem[] var_8;
          int32 num_3;
          class GCUv2.cPurchaseInvoiceItem var_9;
          boolean var_10;
          boolean var_11;
          class GCUv2.cPurchaseInvoicePayment[] var_12;
          int32 num_4;
          class GCUv2.cPurchaseInvoicePayment var_13;
          boolean var_14;
          class GCUv2.cPurchaseInvoiceReturn[] var_15;
          int32 num_5;
          class GCUv2.cPurchaseInvoiceReturn var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;

        }

        private void GetUnpaidReturn() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class DataTable var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        private void dtpInvoice_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          valuetype System.DateTime var_2;

        }

        public void calculateTotalPrice() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          int32 num_4;
          boolean var_7;
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
          boolean var_19;

        }

        public void CalculateTotalReturn() {

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
          double flt_4;
          double flt_5;
          double flt_6;
          valuetype System.DateTime var_1;
          double flt_7;
          double flt_8;
          int16 num_3;
          valuetype System.DateTime var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.frmPurchaseInvoiceItem var_6;

        }

        private void btnReceivedItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class GCUv2.frmPurchaseInvoiceRI var_3;

        }

        private void dgvItem_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_DoubleClick(object sender, class System.EventArgs e) {

          loc_529CF1: nop
          loc_529CF2: ldarg.0
          loc_529CF3: call instance void GCUv2.frmPurchaseInvoice::OpenItem()
          loc_529CF8: nop
          loc_529CF9: ret
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
          class GCUv2.frmPurchaseInvoiceItem var_5;
          class ComboBox var_6;
          boolean var_7;

        }

        private void btnPayment_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmPurchaseInvoicePayment var_1;

        }

        private void dgvPayment_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvPayment_DoubleClick(object sender, class System.EventArgs e) {

          loc_52A23D: nop
          loc_52A23E: ldarg.0
          loc_52A23F: call instance void GCUv2.frmPurchaseInvoice::openPayment()
          loc_52A244: nop
          loc_52A245: ret
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
          class GCUv2.frmPurchaseInvoicePayment var_2;
          class ComboBox var_3;
          boolean var_4;
          boolean var_5;

        }

        private void dgvReturn_DoubleClick(object sender, class System.EventArgs e) {

          loc_52A659: nop
          loc_52A65A: ldarg.0
          loc_52A65B: call instance void GCUv2.frmPurchaseInvoice::OpenPurchaseReturn()
          loc_52A660: nop
          loc_52A661: ret
        }

        private void OpenPurchaseReturn() {

          boolean var_1;

        }

        private void dgvReturn_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvReturn_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvReturn_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvReturn_CellContentClick(object sender, class DataGridViewCellEventArgs e) {

          loc_52A7FA: nop
          loc_52A7FB: ldarg.0
          loc_52A7FC: call instance void GCUv2.frmPurchaseInvoice::CalculateTotalReturn()
          loc_52A801: nop
          loc_52A802: ret
        }

        private void dgvReturn_CellContentDoubleClick(object sender, class DataGridViewCellEventArgs e) {

          loc_52A7FA: nop
          loc_52A7FB: ldarg.0
          loc_52A7FC: call instance void GCUv2.frmPurchaseInvoice::CalculateTotalReturn()
          loc_52A801: nop
          loc_52A802: ret
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
          boolean var_9;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void txtDiscount_Click(object sender, class System.EventArgs e) {

          loc_52AC12: nop
          loc_52AC13: ldarg.0
          loc_52AC14: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC19: ldc.i4.0
          loc_52AC1A: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_52AC1F: nop
          loc_52AC20: ldarg.0
          loc_52AC21: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC26: ldarg.0
          loc_52AC27: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC2C: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_52AC31: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_52AC36: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_52AC3B: nop
          loc_52AC3C: ret
        }

        private void txtDiscount_GotFocus(object sender, class System.EventArgs e) {

          loc_52AC12: nop
          loc_52AC13: ldarg.0
          loc_52AC14: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC19: ldc.i4.0
          loc_52AC1A: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_52AC1F: nop
          loc_52AC20: ldarg.0
          loc_52AC21: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC26: ldarg.0
          loc_52AC27: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDiscount()
          loc_52AC2C: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_52AC31: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_52AC36: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_52AC3B: nop
          loc_52AC3C: ret
        }

        private void txtDiscount_TextChanged(object sender, class System.EventArgs e) {

          loc_52AC3E: nop
          loc_52AC3F: ldarg.0
          loc_52AC40: call instance void GCUv2.frmPurchaseInvoice::calculateTotalInvoice()
          loc_52AC45: nop
          loc_52AC46: ret
        }

        private void txtDeduction_Click(object sender, class System.EventArgs e) {

          loc_52AC48: nop
          loc_52AC49: ldarg.0
          loc_52AC4A: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC4F: ldc.i4.0
          loc_52AC50: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_52AC55: nop
          loc_52AC56: ldarg.0
          loc_52AC57: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC5C: ldarg.0
          loc_52AC5D: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC62: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_52AC67: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_52AC6C: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_52AC71: nop
          loc_52AC72: ret
        }

        private void txtDeduction_GotFocus(object sender, class System.EventArgs e) {

          loc_52AC48: nop
          loc_52AC49: ldarg.0
          loc_52AC4A: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC4F: ldc.i4.0
          loc_52AC50: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_52AC55: nop
          loc_52AC56: ldarg.0
          loc_52AC57: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC5C: ldarg.0
          loc_52AC5D: callvirt instance class GCUv2.FilteredTextBox GCUv2.frmPurchaseInvoice::get_txtDeduction()
          loc_52AC62: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_52AC67: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_52AC6C: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_52AC71: nop
          loc_52AC72: ret
        }

        private void txtDeduction_TextChanged(object sender, class System.EventArgs e) {

          loc_52AC3E: nop
          loc_52AC3F: ldarg.0
          loc_52AC40: call instance void GCUv2.frmPurchaseInvoice::calculateTotalInvoice()
          loc_52AC45: nop
          loc_52AC46: ret
        }

        private void TabControl1_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_52AD01: nop
          loc_52AD02: ldarg.0
          loc_52AD03: ldc.i4.0
          loc_52AD04: call instance void GCUv2.frmPurchaseInvoice::SaveData(boolean)
          loc_52AD09: nop
          loc_52AD0A: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_52AD0C: nop
          loc_52AD0D: ldarg.0
          loc_52AD0E: ldc.i4.1
          loc_52AD0F: call instance void GCUv2.frmPurchaseInvoice::SaveData(boolean)
          loc_52AD14: nop
          loc_52AD15: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          int32 num_3;
          class GCUv2.cPurchaseInvoice var_4;
          class GCUv2.cPurchaseInvoiceItem[] var_5;
          class GCUv2.cPurchaseInvoicePayment[] var_6;
          string str_1;
          string str_2;
          string str_3;
          class GCUv2.cPurchaseInvoiceReturn[] var_7;
          int32 num_4;
          string str_4;
          string str_5;
          class GCUv2.cHistory var_8;
          boolean var_9;
          boolean var_10;
          int32 num_5;
          boolean var_11;
          int32 num_6;
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
          int32 num_7;
          int32 num_8;
          boolean var_25;
          int32 num_9;
          boolean var_26;
          boolean var_27;
          boolean var_28;
          boolean var_29;
          boolean var_30;

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

        private void chkPPN_CheckedChanged(object sender, class System.EventArgs e) {

          loc_52AC3E: nop
          loc_52AC3F: ldarg.0
          loc_52AC40: call instance void GCUv2.frmPurchaseInvoice::calculateTotalInvoice()
          loc_52AC45: nop
          loc_52AC46: ret
        }

        private void dtpTaxInvoice_ValueChanged(object sender, class System.EventArgs e) {

          loc_52AC3E: nop
          loc_52AC3F: ldarg.0
          loc_52AC40: call instance void GCUv2.frmPurchaseInvoice::calculateTotalInvoice()
          loc_52AC45: nop
          loc_52AC46: ret
        }

    }
}
