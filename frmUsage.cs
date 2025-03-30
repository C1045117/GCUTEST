using System;
using System.Windows.Forms;
using mscorlib;

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
        private class TextBox _txtNote;
        private class Label _Label3;
        private class Label _Label1;
        private class ComboBox _cboStorage;
        private class DateTimePicker _dtpUsage;
        private class DataGridView _dgvList;
        private class Label _Label2;
        private class Label _lblUsageNumber;
        private class Label _lblStorage;
        private boolean _dontFocus;
        private double _currentId;
        private valuetype System.DateTime _originalDate;
        private int32 _originalStorageId;
        private boolean _dateIsChanged;
        private boolean _dataIsInGrid;
        private boolean blnDecimal;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class DataGridViewCellStyle var_1;
          class DataGridViewCellStyle var_2;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_54838A: ldarg.0
          loc_54838B: ldfld GCUv2.frmUsage::_btnHistory
          loc_548390: br.s loc_548392
          loc_548392: // Referenced from: loc_548390
          loc_548392: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_5483D8: ldarg.0
          loc_5483D9: ldfld 
          loc_5483DE: br.s loc_5483E0
          loc_5483E0: // Referenced from: loc_5483DE
          loc_5483E0: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_548428: ldarg.0
          loc_548429: ldfld GCUv2.frmUsage::_btnDelete
          loc_54842E: br.s loc_548430
          loc_548430: // Referenced from: loc_54842E
          loc_548430: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_548478: ldarg.0
          loc_548479: ldfld GCUv2.frmUsage::_btnSave
          loc_54847E: br.s loc_548480
          loc_548480: // Referenced from: loc_54847E
          loc_548480: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label11() {

          loc_5484C8: ldarg.0
          loc_5484C9: ldfld GCUv2.frmUsage::_Label11
          loc_5484CE: br.s loc_5484D0
          loc_5484D0: // Referenced from: loc_5484CE
          loc_5484D0: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_5484D2: ldarg.0
          loc_5484D3: ldarg.1
          loc_5484D4: stfld GCUv2.frmUsage::_Label11
          loc_5484D9: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_5484DB: ldarg.0
          loc_5484DC: ldfld GCUv2.frmUsage::_Label8
          loc_5484E1: br.s loc_5484E3
          loc_5484E3: // Referenced from: loc_5484E1
          loc_5484E3: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_5484E5: ldarg.0
          loc_5484E6: ldarg.1
          loc_5484E7: stfld GCUv2.frmUsage::_Label8
          loc_5484EC: ret
        }

        assem override strict specialname class TextBox get_txtNote() {

          loc_5484EE: ldarg.0
          loc_5484EF: ldfld GCUv2.frmUsage::_txtNote
          loc_5484F4: br.s loc_5484F6
          loc_5484F6: // Referenced from: loc_5484F4
          loc_5484F6: ret
        }

        assem override strict specialname void set_txtNote(class TextBox WithEventsValue) {

          loc_5484F8: ldarg.0
          loc_5484F9: ldarg.1
          loc_5484FA: stfld GCUv2.frmUsage::_txtNote
          loc_5484FF: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_548501: ldarg.0
          loc_548502: ldfld GCUv2.frmUsage::_Label3
          loc_548507: br.s loc_548509
          loc_548509: // Referenced from: loc_548507
          loc_548509: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_54850B: ldarg.0
          loc_54850C: ldarg.1
          loc_54850D: stfld GCUv2.frmUsage::_Label3
          loc_548512: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_548514: ldarg.0
          loc_548515: ldfld GCUv2.frmUsage::_Label1
          loc_54851A: br.s loc_54851C
          loc_54851C: // Referenced from: loc_54851A
          loc_54851C: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_54851E: ldarg.0
          loc_54851F: ldarg.1
          loc_548520: stfld GCUv2.frmUsage::_Label1
          loc_548525: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_548527: ldarg.0
          loc_548528: ldfld GCUv2.frmUsage::_cboStorage
          loc_54852D: br.s loc_54852F
          loc_54852F: // Referenced from: loc_54852D
          loc_54852F: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class DateTimePicker get_dtpUsage() {

          loc_548574: ldarg.0
          loc_548575: ldfld GCUv2.frmUsage::_dtpUsage
          loc_54857A: br.s loc_54857C
          loc_54857C: // Referenced from: loc_54857A
          loc_54857C: ret
        }

        assem override strict specialname void set_dtpUsage(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_5485C4: ldarg.0
          loc_5485C5: ldfld GCUv2.frmUsage::_dgvList
          loc_5485CA: br.s loc_5485CC
          loc_5485CC: // Referenced from: loc_5485CA
          loc_5485CC: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class DataGridViewCellEventHandler var_1;
          class DataGridViewCellEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class KeyEventHandler var_5;
          class DataGridViewCellValidatingEventHandler var_6;
          class DataGridViewCellEventHandler var_7;
          class DataGridViewEditingControlShowingEventHandler var_8;
          class DataGridView var_9;

        }

        assem override strict specialname class Label get_Label2() {

          loc_5486F1: ldarg.0
          loc_5486F2: ldfld GCUv2.frmUsage::_Label2
          loc_5486F7: br.s loc_5486F9
          loc_5486F9: // Referenced from: loc_5486F7
          loc_5486F9: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_5486FB: ldarg.0
          loc_5486FC: ldarg.1
          loc_5486FD: stfld GCUv2.frmUsage::_Label2
          loc_548702: ret
        }

        assem override strict specialname class Label get_lblUsageNumber() {

          loc_548704: ldarg.0
          loc_548705: ldfld GCUv2.frmUsage::_lblUsageNumber
          loc_54870A: br.s loc_54870C
          loc_54870C: // Referenced from: loc_54870A
          loc_54870C: ret
        }

        assem override strict specialname void set_lblUsageNumber(class Label WithEventsValue) {

          loc_54870E: ldarg.0
          loc_54870F: ldarg.1
          loc_548710: stfld GCUv2.frmUsage::_lblUsageNumber
          loc_548715: ret
        }

        assem override strict specialname class Label get_lblStorage() {

          loc_548717: ldarg.0
          loc_548718: ldfld GCUv2.frmUsage::_lblStorage
          loc_54871D: br.s loc_54871F
          loc_54871F: // Referenced from: loc_54871D
          loc_54871F: ret
        }

        assem override strict specialname void set_lblStorage(class Label WithEventsValue) {

          loc_548721: ldarg.0
          loc_548722: ldarg.1
          loc_548723: stfld GCUv2.frmUsage::_lblStorage
          loc_548728: ret
        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_548745: nop
          loc_548746: ldarg.0
          loc_548747: ldarg.1
          loc_548748: stfld GCUv2.frmUsage::_currentId
          loc_54874D: ret
        }

        public void frmUsage() {

          class ComboBox var_1;

        }

        private void frmPayment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void PrepareForm(boolean SaveNew) {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cUsage var_1;
          class ComboBox var_2;
          class GCUv2.cUsageItem[] var_3;
          int32 num_3;
          class GCUv2.cUsageItem var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;

        }

        private void dgvList_CellEnter(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;

        }

        private void dgvList_CellEndEdit(object sender, class DataGridViewCellEventArgs e) {

          boolean var_1;
          string str_1;
          boolean var_2;

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

        }

        private void dgvList_CellValidating(object sender, class DataGridViewCellValidatingEventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvList_CellValidated(object sender, class DataGridViewCellEventArgs e) {

          int32 num_1;
          int32 num_2;
          double flt_1;
          double flt_2;
          class GCUv2.cComboItem var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

        private void dgvList_EditingControlShowing(object sender, class DataGridViewEditingControlShowingEventArgs e) {

          class Control var_1;

        }

        protected void Handle_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        protected void Handle_KeyPress(object sender, class KeyPressEventArgs e) {

          int16 num_1;
          boolean var_1;
          boolean var_2;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          boolean var_2;

        }

        private void GetItemByStorage() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class DataTable var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

        private void dtpUsage_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_549BEE: nop
          loc_549BEF: ldarg.0
          loc_549BF0: ldc.i4.0
          loc_549BF1: call instance void GCUv2.frmUsage::SaveData(boolean)
          loc_549BF6: nop
          loc_549BF7: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_549BF9: nop
          loc_549BFA: ldarg.0
          loc_549BFB: ldc.i4.1
          loc_549BFC: call instance void GCUv2.frmUsage::SaveData(boolean)
          loc_549C01: nop
          loc_549C02: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          string str_1;
          int32 num_3;
          boolean var_2;
          class GCUv2.cUsage var_3;
          class GCUv2.cUsageItem[] var_4;
          int32 num_4;
          string str_2;
          string str_3;
          string str_4;
          class GCUv2.cHistory var_5;
          int32 num_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          int32 num_6;
          boolean var_11;
          int32 num_7;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cUsage var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;

        }

    }
}
