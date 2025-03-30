using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GCUv2.FilteredTextBox _txtAmount;
        private class Label _Label7;
        private class ComboBox _cboAccount;
        private class Label _Label5;
        private class Label _Label2;
        private class ComboBox _cboDebitCredit;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class GCUv2.FilteredTextBox _txtCurrencyRate;
        private class Label _lblCurrencyRate;
        private boolean _currentData;
        private string _currencyName;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtAmount() {

          loc_4533AA: ldarg.0
          loc_4533AB: ldfld GCUv2.frmJournalTransactionAccount::_txtAmount
          loc_4533B0: br.s loc_4533B2
          loc_4533B2: // Referenced from: loc_4533B0
          loc_4533B2: ret
        }

        assem override strict specialname void set_txtAmount(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4533B4: ldarg.0
          loc_4533B5: ldarg.1
          loc_4533B6: stfld GCUv2.frmJournalTransactionAccount::_txtAmount
          loc_4533BB: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_4533BD: ldarg.0
          loc_4533BE: ldfld GCUv2.frmJournalTransactionAccount::_Label7
          loc_4533C3: br.s loc_4533C5
          loc_4533C5: // Referenced from: loc_4533C3
          loc_4533C5: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_4533C7: ldarg.0
          loc_4533C8: ldarg.1
          loc_4533C9: stfld GCUv2.frmJournalTransactionAccount::_Label7
          loc_4533CE: ret
        }

        assem override strict specialname class ComboBox get_cboAccount() {

          loc_4533D0: ldarg.0
          loc_4533D1: ldfld GCUv2.frmJournalTransactionAccount::_cboAccount
          loc_4533D6: br.s loc_4533D8
          loc_4533D8: // Referenced from: loc_4533D6
          loc_4533D8: ret
        }

        assem override strict specialname void set_cboAccount(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_453420: ldarg.0
          loc_453421: ldfld GCUv2.frmJournalTransactionAccount::_Label5
          loc_453426: br.s loc_453428
          loc_453428: // Referenced from: loc_453426
          loc_453428: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_45342A: ldarg.0
          loc_45342B: ldarg.1
          loc_45342C: stfld GCUv2.frmJournalTransactionAccount::_Label5
          loc_453431: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_453433: ldarg.0
          loc_453434: ldfld GCUv2.frmJournalTransactionAccount::_Label2
          loc_453439: br.s loc_45343B
          loc_45343B: // Referenced from: loc_453439
          loc_45343B: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_45343D: ldarg.0
          loc_45343E: ldarg.1
          loc_45343F: stfld GCUv2.frmJournalTransactionAccount::_Label2
          loc_453444: ret
        }

        assem override strict specialname class ComboBox get_cboDebitCredit() {

          loc_453446: ldarg.0
          loc_453447: ldfld GCUv2.frmJournalTransactionAccount::_cboDebitCredit
          loc_45344C: br.s loc_45344E
          loc_45344E: // Referenced from: loc_45344C
          loc_45344E: ret
        }

        assem override strict specialname void set_cboDebitCredit(class ComboBox WithEventsValue) {

          loc_453450: ldarg.0
          loc_453451: ldarg.1
          loc_453452: stfld GCUv2.frmJournalTransactionAccount::_cboDebitCredit
          loc_453457: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_453459: ldarg.0
          loc_45345A: ldfld GCUv2.frmJournalTransactionAccount::_btnDelete
          loc_45345F: br.s loc_453461
          loc_453461: // Referenced from: loc_45345F
          loc_453461: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4534A8: ldarg.0
          loc_4534A9: ldfld GCUv2.frmJournalTransactionAccount::_btnSave
          loc_4534AE: br.s loc_4534B0
          loc_4534B0: // Referenced from: loc_4534AE
          loc_4534B0: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtCurrencyRate() {

          loc_4534F8: ldarg.0
          loc_4534F9: ldfld GCUv2.frmJournalTransactionAccount::_txtCurrencyRate
          loc_4534FE: br.s loc_453500
          loc_453500: // Referenced from: loc_4534FE
          loc_453500: ret
        }

        assem override strict specialname void set_txtCurrencyRate(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_453502: ldarg.0
          loc_453503: ldarg.1
          loc_453504: stfld GCUv2.frmJournalTransactionAccount::_txtCurrencyRate
          loc_453509: ret
        }

        assem override strict specialname class Label get_lblCurrencyRate() {

          loc_45350B: ldarg.0
          loc_45350C: ldfld GCUv2.frmJournalTransactionAccount::_lblCurrencyRate
          loc_453511: br.s loc_453513
          loc_453513: // Referenced from: loc_453511
          loc_453513: ret
        }

        assem override strict specialname void set_lblCurrencyRate(class Label WithEventsValue) {

          loc_453515: ldarg.0
          loc_453516: ldarg.1
          loc_453517: stfld GCUv2.frmJournalTransactionAccount::_lblCurrencyRate
          loc_45351C: ret
        }

        public void frmJournalTransactionAccount(boolean CurrentData) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmJournalTransactionAccount_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {


        }

        private void cboAccount_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class DataTable var_3;
          boolean var_4;

        }

    }
}
