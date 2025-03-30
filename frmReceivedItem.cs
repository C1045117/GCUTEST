using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblNumber;
        private class Label _Label3;
        private class ComboBox _cboStorage;
        private class Label _Label4;
        private class Label _lblStorage;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class Label _Label1;
        private class DateTimePicker _dtpRI;
        private class DataGridView _dgvItem;
        private class Button _btnItem;
        private class Label _Label10;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Button _btnHistory;
        private class Label _lblSupplier;
        private class Label _Label7;
        private class ComboBox _cboSupplier;
        private class Label _lblInformation;
        private double _currentId;
        public valuetype System.DateTime OriginalDate;
        public int32 OriginalStorageId;
        private class GCUv2.cReceivedItemItem[] _RIItem;
        private double _invoiceId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_lblNumber() {

          loc_4A0079: ldarg.0
          loc_4A007A: ldfld GCUv2.frmReceivedItem::_lblNumber
          loc_4A007F: br.s loc_4A0081
          loc_4A0081: // Referenced from: loc_4A007F
          loc_4A0081: ret
        }

        assem override strict specialname void set_lblNumber(class Label WithEventsValue) {

          loc_4A0083: ldarg.0
          loc_4A0084: ldarg.1
          loc_4A0085: stfld GCUv2.frmReceivedItem::_lblNumber
          loc_4A008A: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_4A008C: ldarg.0
          loc_4A008D: ldfld GCUv2.frmReceivedItem::_Label3
          loc_4A0092: br.s loc_4A0094
          loc_4A0094: // Referenced from: loc_4A0092
          loc_4A0094: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_4A0096: ldarg.0
          loc_4A0097: ldarg.1
          loc_4A0098: stfld GCUv2.frmReceivedItem::_Label3
          loc_4A009D: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_4A009F: ldarg.0
          loc_4A00A0: ldfld GCUv2.frmReceivedItem::_cboStorage
          loc_4A00A5: br.s loc_4A00A7
          loc_4A00A7: // Referenced from: loc_4A00A5
          loc_4A00A7: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label4() {

          loc_4A00EC: ldarg.0
          loc_4A00ED: ldfld GCUv2.frmReceivedItem::_Label4
          loc_4A00F2: br.s loc_4A00F4
          loc_4A00F4: // Referenced from: loc_4A00F2
          loc_4A00F4: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_4A00F6: ldarg.0
          loc_4A00F7: ldarg.1
          loc_4A00F8: stfld GCUv2.frmReceivedItem::_Label4
          loc_4A00FD: ret
        }

        assem override strict specialname class Label get_lblStorage() {

          loc_4A00FF: ldarg.0
          loc_4A0100: ldfld GCUv2.frmReceivedItem::_lblStorage
          loc_4A0105: br.s loc_4A0107
          loc_4A0107: // Referenced from: loc_4A0105
          loc_4A0107: ret
        }

        assem override strict specialname void set_lblStorage(class Label WithEventsValue) {

          loc_4A0109: ldarg.0
          loc_4A010A: ldarg.1
          loc_4A010B: stfld GCUv2.frmReceivedItem::_lblStorage
          loc_4A0110: ret
        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_4A0112: ldarg.0
          loc_4A0113: ldfld GCUv2.frmReceivedItem::_TabControl1
          loc_4A0118: br.s loc_4A011A
          loc_4A011A: // Referenced from: loc_4A0118
          loc_4A011A: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          loc_4A011C: ldarg.0
          loc_4A011D: ldarg.1
          loc_4A011E: stfld GCUv2.frmReceivedItem::_TabControl1
          loc_4A0123: ret
        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_4A0125: ldarg.0
          loc_4A0126: ldfld GCUv2.frmReceivedItem::_TabPage1
          loc_4A012B: br.s loc_4A012D
          loc_4A012D: // Referenced from: loc_4A012B
          loc_4A012D: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_4A012F: ldarg.0
          loc_4A0130: ldarg.1
          loc_4A0131: stfld GCUv2.frmReceivedItem::_TabPage1
          loc_4A0136: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4A0138: ldarg.0
          loc_4A0139: ldfld GCUv2.frmReceivedItem::_Label1
          loc_4A013E: br.s loc_4A0140
          loc_4A0140: // Referenced from: loc_4A013E
          loc_4A0140: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4A0142: ldarg.0
          loc_4A0143: ldarg.1
          loc_4A0144: stfld GCUv2.frmReceivedItem::_Label1
          loc_4A0149: ret
        }

        assem override strict specialname class DateTimePicker get_dtpRI() {

          loc_4A014B: ldarg.0
          loc_4A014C: ldfld GCUv2.frmReceivedItem::_dtpRI
          loc_4A0151: br.s loc_4A0153
          loc_4A0153: // Referenced from: loc_4A0151
          loc_4A0153: ret
        }

        assem override strict specialname void set_dtpRI(class DateTimePicker WithEventsValue) {

          loc_4A0155: ldarg.0
          loc_4A0156: ldarg.1
          loc_4A0157: stfld GCUv2.frmReceivedItem::_dtpRI
          loc_4A015C: ret
        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_4A015E: ldarg.0
          loc_4A015F: ldfld GCUv2.frmReceivedItem::_dgvItem
          loc_4A0164: br.s loc_4A0166
          loc_4A0166: // Referenced from: loc_4A0164
          loc_4A0166: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnItem() {

          loc_4A0209: ldarg.0
          loc_4A020A: ldfld GCUv2.frmReceivedItem::_btnItem
          loc_4A020F: br.s loc_4A0211
          loc_4A0211: // Referenced from: loc_4A020F
          loc_4A0211: ret
        }

        assem override strict specialname void set_btnItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label10() {

          loc_4A0258: ldarg.0
          loc_4A0259: ldfld GCUv2.frmReceivedItem::_Label10
          loc_4A025E: br.s loc_4A0260
          loc_4A0260: // Referenced from: loc_4A025E
          loc_4A0260: ret
        }

        assem override strict specialname void set_Label10(class Label WithEventsValue) {

          loc_4A0262: ldarg.0
          loc_4A0263: ldarg.1
          loc_4A0264: stfld GCUv2.frmReceivedItem::_Label10
          loc_4A0269: ret
        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4A026B: ldarg.0
          loc_4A026C: ldfld GCUv2.frmReceivedItem::_btnSaveClose
          loc_4A0271: br.s loc_4A0273
          loc_4A0273: // Referenced from: loc_4A0271
          loc_4A0273: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4A02B8: ldarg.0
          loc_4A02B9: ldfld GCUv2.frmReceivedItem::_btnDelete
          loc_4A02BE: br.s loc_4A02C0
          loc_4A02C0: // Referenced from: loc_4A02BE
          loc_4A02C0: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4A0308: ldarg.0
          loc_4A0309: ldfld GCUv2.frmReceivedItem::_btnSave
          loc_4A030E: br.s loc_4A0310
          loc_4A0310: // Referenced from: loc_4A030E
          loc_4A0310: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnHistory() {

          loc_4A0358: ldarg.0
          loc_4A0359: ldfld GCUv2.frmReceivedItem::_btnHistory
          loc_4A035E: br.s loc_4A0360
          loc_4A0360: // Referenced from: loc_4A035E
          loc_4A0360: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblSupplier() {

          loc_4A03A8: ldarg.0
          loc_4A03A9: ldfld GCUv2.frmReceivedItem::_lblSupplier
          loc_4A03AE: br.s loc_4A03B0
          loc_4A03B0: // Referenced from: loc_4A03AE
          loc_4A03B0: ret
        }

        assem override strict specialname void set_lblSupplier(class Label WithEventsValue) {

          loc_4A03B2: ldarg.0
          loc_4A03B3: ldarg.1
          loc_4A03B4: stfld GCUv2.frmReceivedItem::_lblSupplier
          loc_4A03B9: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_4A03BB: ldarg.0
          loc_4A03BC: ldfld GCUv2.frmReceivedItem::_Label7
          loc_4A03C1: br.s loc_4A03C3
          loc_4A03C3: // Referenced from: loc_4A03C1
          loc_4A03C3: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_4A03C5: ldarg.0
          loc_4A03C6: ldarg.1
          loc_4A03C7: stfld GCUv2.frmReceivedItem::_Label7
          loc_4A03CC: ret
        }

        assem override strict specialname class ComboBox get_cboSupplier() {

          loc_4A03CE: ldarg.0
          loc_4A03CF: ldfld GCUv2.frmReceivedItem::_cboSupplier
          loc_4A03D4: br.s loc_4A03D6
          loc_4A03D6: // Referenced from: loc_4A03D4
          loc_4A03D6: ret
        }

        assem override strict specialname void set_cboSupplier(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_lblInformation() {

          loc_4A041C: ldarg.0
          loc_4A041D: ldfld GCUv2.frmReceivedItem::_lblInformation
          loc_4A0422: br.s loc_4A0424
          loc_4A0424: // Referenced from: loc_4A0422
          loc_4A0424: ret
        }

        assem override strict specialname void set_lblInformation(class Label WithEventsValue) {

          class System.EventHandler var_1;
          class Label var_2;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_4A0485: nop
          loc_4A0486: ldarg.0
          loc_4A0487: ldarg.1
          loc_4A0488: stfld GCUv2.frmReceivedItem::_currentId
          loc_4A048D: ret
        }

        public void frmReceivedItem() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        private void formatGrid() {


        }

        public void prepareForm(boolean SaveNew) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cReceivedItem var_1;
          class ComboBox var_2;
          class GCUv2.cReceivedItemItem[] var_3;
          int32 num_3;
          class GCUv2.cReceivedItemItem var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        private void frmReceivedItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboSupplier_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.frmReceivedItemItem var_3;
          boolean var_4;
          boolean var_5;

        }

        private void dgvItem_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_DoubleClick(object sender, class System.EventArgs e) {

          loc_4A0E9D: nop
          loc_4A0E9E: ldarg.0
          loc_4A0E9F: call instance void GCUv2.frmReceivedItem::OpenItem()
          loc_4A0EA4: nop
          loc_4A0EA5: ret
        }

        private void dgvItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void OpenItem() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.frmReceivedItemItem var_6;
          class ComboBox var_7;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_4A1171: nop
          loc_4A1172: ldarg.0
          loc_4A1173: ldc.i4.0
          loc_4A1174: call instance void GCUv2.frmReceivedItem::SaveData(boolean)
          loc_4A1179: nop
          loc_4A117A: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_4A117C: nop
          loc_4A117D: ldarg.0
          loc_4A117E: ldc.i4.1
          loc_4A117F: call instance void GCUv2.frmReceivedItem::SaveData(boolean)
          loc_4A1184: nop
          loc_4A1185: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cReceivedItem var_3;
          class GCUv2.cReceivedItemItem[] var_4;
          int32 num_3;
          string str_1;
          string str_2;
          class GCUv2.cHistory var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          int32 num_4;
          boolean var_10;
          int32 num_5;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cReceivedItem var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

        private void lblInformation_Click(object sender, class System.EventArgs e) {


        }

    }
}
