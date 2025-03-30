using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label11;
        private class Label _Label8;
        private class TextBox _txtDescription;
        private class Label _Label1;
        private class DateTimePicker _dtpVoucher;
        private class Label _lblNumber;
        private class Label _Label3;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class Button _btnAccount;
        private class DataGridView _dgvAccount;
        private double _currentId;
        private double TotalDebit;
        private double TotalCredit;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnHistory() {

          loc_45159A: ldarg.0
          loc_45159B: ldfld GCUv2.frmJournalTransaction::_btnHistory
          loc_4515A0: br.s loc_4515A2
          loc_4515A2: // Referenced from: loc_4515A0
          loc_4515A2: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4515E8: ldarg.0
          loc_4515E9: ldfld GCUv2.frmJournalTransaction::_btnSaveClose
          loc_4515EE: br.s loc_4515F0
          loc_4515F0: // Referenced from: loc_4515EE
          loc_4515F0: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_451638: ldarg.0
          loc_451639: ldfld GCUv2.frmJournalTransaction::_btnDelete
          loc_45163E: br.s loc_451640
          loc_451640: // Referenced from: loc_45163E
          loc_451640: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_451688: ldarg.0
          loc_451689: ldfld GCUv2.frmJournalTransaction::_btnSave
          loc_45168E: br.s loc_451690
          loc_451690: // Referenced from: loc_45168E
          loc_451690: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label11() {

          loc_4516D8: ldarg.0
          loc_4516D9: ldfld GCUv2.frmJournalTransaction::_Label11
          loc_4516DE: br.s loc_4516E0
          loc_4516E0: // Referenced from: loc_4516DE
          loc_4516E0: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_4516E2: ldarg.0
          loc_4516E3: ldarg.1
          loc_4516E4: stfld GCUv2.frmJournalTransaction::_Label11
          loc_4516E9: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_4516EB: ldarg.0
          loc_4516EC: ldfld GCUv2.frmJournalTransaction::_Label8
          loc_4516F1: br.s loc_4516F3
          loc_4516F3: // Referenced from: loc_4516F1
          loc_4516F3: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_4516F5: ldarg.0
          loc_4516F6: ldarg.1
          loc_4516F7: stfld GCUv2.frmJournalTransaction::_Label8
          loc_4516FC: ret
        }

        assem override strict specialname class TextBox get_txtDescription() {

          loc_4516FE: ldarg.0
          loc_4516FF: ldfld GCUv2.frmJournalTransaction::_txtDescription
          loc_451704: br.s loc_451706
          loc_451706: // Referenced from: loc_451704
          loc_451706: ret
        }

        assem override strict specialname void set_txtDescription(class TextBox WithEventsValue) {

          loc_451708: ldarg.0
          loc_451709: ldarg.1
          loc_45170A: stfld GCUv2.frmJournalTransaction::_txtDescription
          loc_45170F: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_451711: ldarg.0
          loc_451712: ldfld GCUv2.frmJournalTransaction::_Label1
          loc_451717: br.s loc_451719
          loc_451719: // Referenced from: loc_451717
          loc_451719: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_45171B: ldarg.0
          loc_45171C: ldarg.1
          loc_45171D: stfld GCUv2.frmJournalTransaction::_Label1
          loc_451722: ret
        }

        assem override strict specialname class DateTimePicker get_dtpVoucher() {

          loc_451724: ldarg.0
          loc_451725: ldfld GCUv2.frmJournalTransaction::_dtpVoucher
          loc_45172A: br.s loc_45172C
          loc_45172C: // Referenced from: loc_45172A
          loc_45172C: ret
        }

        assem override strict specialname void set_dtpVoucher(class DateTimePicker WithEventsValue) {

          loc_45172E: ldarg.0
          loc_45172F: ldarg.1
          loc_451730: stfld GCUv2.frmJournalTransaction::_dtpVoucher
          loc_451735: ret
        }

        assem override strict specialname class Label get_lblNumber() {

          loc_451737: ldarg.0
          loc_451738: ldfld GCUv2.frmJournalTransaction::_lblNumber
          loc_45173D: br.s loc_45173F
          loc_45173F: // Referenced from: loc_45173D
          loc_45173F: ret
        }

        assem override strict specialname void set_lblNumber(class Label WithEventsValue) {

          loc_451741: ldarg.0
          loc_451742: ldarg.1
          loc_451743: stfld GCUv2.frmJournalTransaction::_lblNumber
          loc_451748: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_45174A: ldarg.0
          loc_45174B: ldfld GCUv2.frmJournalTransaction::_Label3
          loc_451750: br.s loc_451752
          loc_451752: // Referenced from: loc_451750
          loc_451752: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_451754: ldarg.0
          loc_451755: ldarg.1
          loc_451756: stfld GCUv2.frmJournalTransaction::_Label3
          loc_45175B: ret
        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_45175D: ldarg.0
          loc_45175E: ldfld GCUv2.frmJournalTransaction::_TabControl1
          loc_451763: br.s loc_451765
          loc_451765: // Referenced from: loc_451763
          loc_451765: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          loc_451767: ldarg.0
          loc_451768: ldarg.1
          loc_451769: stfld GCUv2.frmJournalTransaction::_TabControl1
          loc_45176E: ret
        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_451770: ldarg.0
          loc_451771: ldfld GCUv2.frmJournalTransaction::_TabPage1
          loc_451776: br.s loc_451778
          loc_451778: // Referenced from: loc_451776
          loc_451778: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_45177A: ldarg.0
          loc_45177B: ldarg.1
          loc_45177C: stfld GCUv2.frmJournalTransaction::_TabPage1
          loc_451781: ret
        }

        assem override strict specialname class Button get_btnAccount() {

          loc_451783: ldarg.0
          loc_451784: ldfld GCUv2.frmJournalTransaction::_btnAccount
          loc_451789: br.s loc_45178B
          loc_45178B: // Referenced from: loc_451789
          loc_45178B: ret
        }

        assem override strict specialname void set_btnAccount(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvAccount() {

          loc_4517D0: ldarg.0
          loc_4517D1: ldfld GCUv2.frmJournalTransaction::_dgvAccount
          loc_4517D6: br.s loc_4517D8
          loc_4517D8: // Referenced from: loc_4517D6
          loc_4517D8: ret
        }

        assem override strict specialname void set_dgvAccount(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_451895: nop
          loc_451896: ldarg.0
          loc_451897: ldarg.1
          loc_451898: stfld GCUv2.frmJournalTransaction::_currentId
          loc_45189D: ret
        }

        public void frmJournalTransaction() {


        }

        private void frmJournalTransaction_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void formatGrid() {


        }

        public void prepareForm(boolean SaveNew) {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cVoucher var_1;
          class GCUv2.cVoucherAccount[] var_2;
          int32 num_3;
          class GCUv2.cVoucherAccount var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

        public void calculateTotal() {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          double flt_1;
          int32 num_4;
          boolean var_1;
          double & var_2;

        }

        private void btnAccount_Click(object sender, class System.EventArgs e) {

          class GCUv2.frmJournalTransactionAccount var_1;

        }

        private void dgvAccount_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvAccount_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvAccount_DoubleClick(object sender, class System.EventArgs e) {

          loc_45212D: nop
          loc_45212E: ldarg.0
          loc_45212F: call instance void GCUv2.frmJournalTransaction::OpenAccount()
          loc_452134: nop
          loc_452135: ret
        }

        private void dgvAccount_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void OpenAccount() {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          class GCUv2.frmJournalTransactionAccount var_2;
          class ComboBox var_3;
          boolean var_4;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_4523A5: nop
          loc_4523A6: ldarg.0
          loc_4523A7: ldc.i4.0
          loc_4523A8: call instance void GCUv2.frmJournalTransaction::SaveData(boolean)
          loc_4523AD: nop
          loc_4523AE: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_4523B0: nop
          loc_4523B1: ldarg.0
          loc_4523B2: ldc.i4.1
          loc_4523B3: call instance void GCUv2.frmJournalTransaction::SaveData(boolean)
          loc_4523B8: nop
          loc_4523B9: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cVoucher var_1;
          class GCUv2.cVoucherAccount[] var_2;
          int32 num_3;
          double flt_1;
          string str_1;
          string str_2;
          class GCUv2.cHistory var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          int32 num_4;
          boolean var_8;
          boolean var_9;
          int32 num_5;
          boolean var_10;
          boolean var_11;
          boolean var_12;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cVoucher var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

    }
}
