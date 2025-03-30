using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class DateTimePicker _dtpTransfer;
        private class ComboBox _cboStorageFrom;
        private class ComboBox _cboStorageTo;
        private class Label _Label1;
        private class Label _Label3;
        private class Label _Label4;
        private class Label _Label11;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _lblStorageTo;
        private class Label _lblStorageFrom;
        private class Label _lblNumber;
        private class Label _Label2;
        private class TabControl _TabControl1;
        private class TabPage _TabPage1;
        private class DataGridView _dgvItem;
        private class Button _btnItem;
        private class Button _btnPrint;
        private double _currentId;
        private boolean _edited;
        public int32 intOriginalItemId;
        public valuetype System.DateTime OriginalDate;
        public int32 OriginalStorageId;
        private class GCUv2.cTransferItem[] _TransferItem;
        private boolean _dateIsChanged;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class DateTimePicker get_dtpTransfer() {

          loc_5442D3: ldarg.0
          loc_5442D4: ldfld GCUv2.frmTransfer::_dtpTransfer
          loc_5442D9: br.s loc_5442DB
          loc_5442DB: // Referenced from: loc_5442D9
          loc_5442DB: ret
        }

        assem override strict specialname void set_dtpTransfer(class DateTimePicker WithEventsValue) {

          class System.EventHandler var_1;
          class DateTimePicker var_2;

        }

        assem override strict specialname class ComboBox get_cboStorageFrom() {

          loc_544320: ldarg.0
          loc_544321: ldfld GCUv2.frmTransfer::_cboStorageFrom
          loc_544326: br.s loc_544328
          loc_544328: // Referenced from: loc_544326
          loc_544328: ret
        }

        assem override strict specialname void set_cboStorageFrom(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class ComboBox get_cboStorageTo() {

          loc_544370: ldarg.0
          loc_544371: ldfld GCUv2.frmTransfer::_cboStorageTo
          loc_544376: br.s loc_544378
          loc_544378: // Referenced from: loc_544376
          loc_544378: ret
        }

        assem override strict specialname void set_cboStorageTo(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label1() {

          loc_5443C0: ldarg.0
          loc_5443C1: ldfld GCUv2.frmTransfer::_Label1
          loc_5443C6: br.s loc_5443C8
          loc_5443C8: // Referenced from: loc_5443C6
          loc_5443C8: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_5443CA: ldarg.0
          loc_5443CB: ldarg.1
          loc_5443CC: stfld GCUv2.frmTransfer::_Label1
          loc_5443D1: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_5443D3: ldarg.0
          loc_5443D4: ldfld GCUv2.frmTransfer::_Label3
          loc_5443D9: br.s loc_5443DB
          loc_5443DB: // Referenced from: loc_5443D9
          loc_5443DB: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_5443DD: ldarg.0
          loc_5443DE: ldarg.1
          loc_5443DF: stfld GCUv2.frmTransfer::_Label3
          loc_5443E4: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_5443E6: ldarg.0
          loc_5443E7: ldfld GCUv2.frmTransfer::_Label4
          loc_5443EC: br.s loc_5443EE
          loc_5443EE: // Referenced from: loc_5443EC
          loc_5443EE: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_5443F0: ldarg.0
          loc_5443F1: ldarg.1
          loc_5443F2: stfld GCUv2.frmTransfer::_Label4
          loc_5443F7: ret
        }

        assem override strict specialname class Label get_Label11() {

          loc_5443F9: ldarg.0
          loc_5443FA: ldfld GCUv2.frmTransfer::_Label11
          loc_5443FF: br.s loc_544401
          loc_544401: // Referenced from: loc_5443FF
          loc_544401: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_544403: ldarg.0
          loc_544404: ldarg.1
          loc_544405: stfld GCUv2.frmTransfer::_Label11
          loc_54440A: ret
        }

        assem override strict specialname class Button get_btnHistory() {

          loc_54440C: ldarg.0
          loc_54440D: ldfld GCUv2.frmTransfer::_btnHistory
          loc_544412: br.s loc_544414
          loc_544414: // Referenced from: loc_544412
          loc_544414: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_54445C: ldarg.0
          loc_54445D: ldfld GCUv2.frmTransfer::_btnSaveClose
          loc_544462: br.s loc_544464
          loc_544464: // Referenced from: loc_544462
          loc_544464: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_5444AC: ldarg.0
          loc_5444AD: ldfld GCUv2.frmTransfer::_btnDelete
          loc_5444B2: br.s loc_5444B4
          loc_5444B4: // Referenced from: loc_5444B2
          loc_5444B4: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_5444FC: ldarg.0
          loc_5444FD: ldfld GCUv2.frmTransfer::_btnSave
          loc_544502: br.s loc_544504
          loc_544504: // Referenced from: loc_544502
          loc_544504: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblStorageTo() {

          loc_54454C: ldarg.0
          loc_54454D: ldfld GCUv2.frmTransfer::_lblStorageTo
          loc_544552: br.s loc_544554
          loc_544554: // Referenced from: loc_544552
          loc_544554: ret
        }

        assem override strict specialname void set_lblStorageTo(class Label WithEventsValue) {

          loc_544556: ldarg.0
          loc_544557: ldarg.1
          loc_544558: stfld GCUv2.frmTransfer::_lblStorageTo
          loc_54455D: ret
        }

        assem override strict specialname class Label get_lblStorageFrom() {

          loc_54455F: ldarg.0
          loc_544560: ldfld GCUv2.frmTransfer::_lblStorageFrom
          loc_544565: br.s loc_544567
          loc_544567: // Referenced from: loc_544565
          loc_544567: ret
        }

        assem override strict specialname void set_lblStorageFrom(class Label WithEventsValue) {

          loc_544569: ldarg.0
          loc_54456A: ldarg.1
          loc_54456B: stfld GCUv2.frmTransfer::_lblStorageFrom
          loc_544570: ret
        }

        assem override strict specialname class Label get_lblNumber() {

          loc_544572: ldarg.0
          loc_544573: ldfld GCUv2.frmTransfer::_lblNumber
          loc_544578: br.s loc_54457A
          loc_54457A: // Referenced from: loc_544578
          loc_54457A: ret
        }

        assem override strict specialname void set_lblNumber(class Label WithEventsValue) {

          loc_54457C: ldarg.0
          loc_54457D: ldarg.1
          loc_54457E: stfld GCUv2.frmTransfer::_lblNumber
          loc_544583: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_544585: ldarg.0
          loc_544586: ldfld GCUv2.frmTransfer::_Label2
          loc_54458B: br.s loc_54458D
          loc_54458D: // Referenced from: loc_54458B
          loc_54458D: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_54458F: ldarg.0
          loc_544590: ldarg.1
          loc_544591: stfld GCUv2.frmTransfer::_Label2
          loc_544596: ret
        }

        assem override strict specialname class TabControl get_TabControl1() {

          loc_544598: ldarg.0
          loc_544599: ldfld GCUv2.frmTransfer::_TabControl1
          loc_54459E: br.s loc_5445A0
          loc_5445A0: // Referenced from: loc_54459E
          loc_5445A0: ret
        }

        assem override strict specialname void set_TabControl1(class TabControl WithEventsValue) {

          loc_5445A2: ldarg.0
          loc_5445A3: ldarg.1
          loc_5445A4: stfld GCUv2.frmTransfer::_TabControl1
          loc_5445A9: ret
        }

        assem override strict specialname class TabPage get_TabPage1() {

          loc_5445AB: ldarg.0
          loc_5445AC: ldfld GCUv2.frmTransfer::_TabPage1
          loc_5445B1: br.s loc_5445B3
          loc_5445B3: // Referenced from: loc_5445B1
          loc_5445B3: ret
        }

        assem override strict specialname void set_TabPage1(class TabPage WithEventsValue) {

          loc_5445B5: ldarg.0
          loc_5445B6: ldarg.1
          loc_5445B7: stfld GCUv2.frmTransfer::_TabPage1
          loc_5445BC: ret
        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_5445BE: ldarg.0
          loc_5445BF: ldfld GCUv2.frmTransfer::_dgvItem
          loc_5445C4: br.s loc_5445C6
          loc_5445C6: // Referenced from: loc_5445C4
          loc_5445C6: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class KeyEventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Button get_btnItem() {

          loc_544669: ldarg.0
          loc_54466A: ldfld GCUv2.frmTransfer::_btnItem
          loc_54466F: br.s loc_544671
          loc_544671: // Referenced from: loc_54466F
          loc_544671: ret
        }

        assem override strict specialname void set_btnItem(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnPrint() {

          loc_5446B8: ldarg.0
          loc_5446B9: ldfld GCUv2.frmTransfer::_btnPrint
          loc_5446BE: br.s loc_5446C0
          loc_5446C0: // Referenced from: loc_5446BE
          loc_5446C0: ret
        }

        assem override strict specialname void set_btnPrint(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_544721: nop
          loc_544722: ldarg.0
          loc_544723: ldarg.1
          loc_544724: stfld GCUv2.frmTransfer::_currentId
          loc_544729: ret
        }

        public specialname boolean get_Edited() {

          boolean var_1;

        }

        public specialname void set_Edited(boolean value) {

          loc_544745: nop
          loc_544746: ldarg.0
          loc_544747: ldarg.1
          loc_544748: stfld GCUv2.frmTransfer::_edited
          loc_54474D: ret
        }

        public void frmTransfer() {

          class ComboBox var_1;

        }

        private void frmTransfer_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void formatGrid() {


        }

        public void prepareForm(boolean SaveNew) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cTransfer var_1;
          valuetype System.DateTime var_2;
          class ComboBox var_3;
          class GCUv2.cTransferItem[] var_4;
          int32 num_3;
          class GCUv2.cTransferItem var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;

        }

        private void dtpTransfer_ValueChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void cboStorageFrom_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void cboStorageTo_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnItem_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.frmTransferItem var_3;
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

          loc_544EED: nop
          loc_544EEE: ldarg.0
          loc_544EEF: call instance void GCUv2.frmTransfer::OpenItem()
          loc_544EF4: nop
          loc_544EF5: ret
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
          class GCUv2.frmTransferItem var_6;
          class ComboBox var_7;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_545171: nop
          loc_545172: ldarg.0
          loc_545173: ldc.i4.0
          loc_545174: call instance void GCUv2.frmTransfer::saveData(boolean)
          loc_545179: nop
          loc_54517A: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_54517C: nop
          loc_54517D: ldarg.0
          loc_54517E: ldc.i4.1
          loc_54517F: call instance void GCUv2.frmTransfer::saveData(boolean)
          loc_545184: nop
          loc_545185: ret
        }

        private void saveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          double flt_1;
          int32 num_3;
          string str_1;
          int32 num_4;
          class GCUv2.cTransfer var_3;
          class GCUv2.cTransferItem[] var_4;
          string str_2;
          string str_3;
          class GCUv2.cHistory var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          int32 num_5;
          boolean var_12;
          class GCUv2.cTransferItem[] var_13;
          int32 num_6;
          class GCUv2.cTransferItem var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          int32 num_7;
          boolean var_18;
          int32 num_8;
          boolean var_19;
          boolean var_20;
          boolean var_21;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cTransfer var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

        private void btnPrint_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer var_1;
          int32 num_3;
          int32 num_4;
          int32 num_5;
          double flt_1;
          boolean var_2;
          boolean var_3;
          int32 num_6;
          int32 num_7;

        }

    }
}
