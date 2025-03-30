using System;
using System.Windows.Forms;
using mscorlib;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private class Label _Label4;
        private class Label _Label1;
        private class ComboBox _cboStorage;
        private class DateTimePicker _dtpProcess;
        private class DataGridView _dgvList;
        private class Label _Label3;
        private class Button _btnStandardComponent;
        private class Button _btnAddComponent;
        private class Label _Label11;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _lblItem;
        private double _currentId;
        private int32 _currentlySelectedComboIndex;
        private boolean _suppressComboChange;
        private class GCUv2.cComponent[] _component;
        public int32 intOriginalItemId;
        public int32 intOriginalStorageId;
        public valuetype System.DateTime dateOriginal;
        public double dblOriginalQty;
        private class GCUv2.cComponent[] _originalComponent;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_520A7D: ldarg.0
          loc_520A7E: ldfld GCUv2.frmProcess::_txtQty
          loc_520A83: br.s loc_520A85
          loc_520A85: // Referenced from: loc_520A83
          loc_520A85: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_520A87: ldarg.0
          loc_520A88: ldarg.1
          loc_520A89: stfld GCUv2.frmProcess::_txtQty
          loc_520A8E: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_520A90: ldarg.0
          loc_520A91: ldfld GCUv2.frmProcess::_Label6
          loc_520A96: br.s loc_520A98
          loc_520A98: // Referenced from: loc_520A96
          loc_520A98: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_520A9A: ldarg.0
          loc_520A9B: ldarg.1
          loc_520A9C: stfld GCUv2.frmProcess::_Label6
          loc_520AA1: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_520AA3: ldarg.0
          loc_520AA4: ldfld GCUv2.frmProcess::_cboItem
          loc_520AA9: br.s loc_520AAB
          loc_520AAB: // Referenced from: loc_520AA9
          loc_520AAB: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_520AF0: ldarg.0
          loc_520AF1: ldfld GCUv2.frmProcess::_Label5
          loc_520AF6: br.s loc_520AF8
          loc_520AF8: // Referenced from: loc_520AF6
          loc_520AF8: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_520AFA: ldarg.0
          loc_520AFB: ldarg.1
          loc_520AFC: stfld GCUv2.frmProcess::_Label5
          loc_520B01: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_520B03: ldarg.0
          loc_520B04: ldfld GCUv2.frmProcess::_Label4
          loc_520B09: br.s loc_520B0B
          loc_520B0B: // Referenced from: loc_520B09
          loc_520B0B: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_520B0D: ldarg.0
          loc_520B0E: ldarg.1
          loc_520B0F: stfld GCUv2.frmProcess::_Label4
          loc_520B14: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_520B16: ldarg.0
          loc_520B17: ldfld GCUv2.frmProcess::_Label1
          loc_520B1C: br.s loc_520B1E
          loc_520B1E: // Referenced from: loc_520B1C
          loc_520B1E: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_520B20: ldarg.0
          loc_520B21: ldarg.1
          loc_520B22: stfld GCUv2.frmProcess::_Label1
          loc_520B27: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_520B29: ldarg.0
          loc_520B2A: ldfld GCUv2.frmProcess::_cboStorage
          loc_520B2F: br.s loc_520B31
          loc_520B31: // Referenced from: loc_520B2F
          loc_520B31: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class DateTimePicker get_dtpProcess() {

          loc_520B78: ldarg.0
          loc_520B79: ldfld GCUv2.frmProcess::_dtpProcess
          loc_520B7E: br.s loc_520B80
          loc_520B80: // Referenced from: loc_520B7E
          loc_520B80: ret
        }

        assem override strict specialname void set_dtpProcess(class DateTimePicker WithEventsValue) {

          loc_520B82: ldarg.0
          loc_520B83: ldarg.1
          loc_520B84: stfld GCUv2.frmProcess::_dtpProcess
          loc_520B89: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_520B8B: ldarg.0
          loc_520B8C: ldfld GCUv2.frmProcess::_dgvList
          loc_520B91: br.s loc_520B93
          loc_520B93: // Referenced from: loc_520B91
          loc_520B93: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class System.EventHandler var_1;
          class KeyEventHandler var_2;
          class System.EventHandler var_3;
          class System.EventHandler var_4;
          class DataGridView var_5;

        }

        assem override strict specialname class Label get_Label3() {

          loc_520C35: ldarg.0
          loc_520C36: ldfld GCUv2.frmProcess::_Label3
          loc_520C3B: br.s loc_520C3D
          loc_520C3D: // Referenced from: loc_520C3B
          loc_520C3D: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_520C3F: ldarg.0
          loc_520C40: ldarg.1
          loc_520C41: stfld GCUv2.frmProcess::_Label3
          loc_520C46: ret
        }

        assem override strict specialname class Button get_btnStandardComponent() {

          loc_520C48: ldarg.0
          loc_520C49: ldfld GCUv2.frmProcess::_btnStandardComponent
          loc_520C4E: br.s loc_520C50
          loc_520C50: // Referenced from: loc_520C4E
          loc_520C50: ret
        }

        assem override strict specialname void set_btnStandardComponent(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnAddComponent() {

          loc_520C98: ldarg.0
          loc_520C99: ldfld GCUv2.frmProcess::_btnAddComponent
          loc_520C9E: br.s loc_520CA0
          loc_520CA0: // Referenced from: loc_520C9E
          loc_520CA0: ret
        }

        assem override strict specialname void set_btnAddComponent(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label11() {

          loc_520CE8: ldarg.0
          loc_520CE9: ldfld GCUv2.frmProcess::_Label11
          loc_520CEE: br.s loc_520CF0
          loc_520CF0: // Referenced from: loc_520CEE
          loc_520CF0: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_520CF2: ldarg.0
          loc_520CF3: ldarg.1
          loc_520CF4: stfld GCUv2.frmProcess::_Label11
          loc_520CF9: ret
        }

        assem override strict specialname class Button get_btnHistory() {

          loc_520CFB: ldarg.0
          loc_520CFC: ldfld GCUv2.frmProcess::_btnHistory
          loc_520D01: br.s loc_520D03
          loc_520D03: // Referenced from: loc_520D01
          loc_520D03: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_520D48: ldarg.0
          loc_520D49: ldfld GCUv2.frmProcess::_btnSaveClose
          loc_520D4E: br.s loc_520D50
          loc_520D50: // Referenced from: loc_520D4E
          loc_520D50: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_520D98: ldarg.0
          loc_520D99: ldfld GCUv2.frmProcess::_btnDelete
          loc_520D9E: br.s loc_520DA0
          loc_520DA0: // Referenced from: loc_520D9E
          loc_520DA0: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_520DE8: ldarg.0
          loc_520DE9: ldfld GCUv2.frmProcess::_btnSave
          loc_520DEE: br.s loc_520DF0
          loc_520DF0: // Referenced from: loc_520DEE
          loc_520DF0: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_lblItem() {

          loc_520E38: ldarg.0
          loc_520E39: ldfld GCUv2.frmProcess::_lblItem
          loc_520E3E: br.s loc_520E40
          loc_520E40: // Referenced from: loc_520E3E
          loc_520E40: ret
        }

        assem override strict specialname void set_lblItem(class Label WithEventsValue) {

          loc_520E42: ldarg.0
          loc_520E43: ldarg.1
          loc_520E44: stfld GCUv2.frmProcess::_lblItem
          loc_520E49: ret
        }

        public specialname class GCUv2.cComponent[] get_Component() {

          class GCUv2.cComponent[] var_1;

        }

        public specialname void set_Component(class GCUv2.cComponent[] value) {

          loc_520E65: nop
          loc_520E66: ldarg.0
          loc_520E67: ldarg.1
          loc_520E68: stfld GCUv2.frmProcess::_component
          loc_520E6D: ret
        }

        private void frmProcess_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void frmProcess() {


        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_520F0D: nop
          loc_520F0E: ldarg.0
          loc_520F0F: ldarg.1
          loc_520F10: stfld GCUv2.frmProcess::_currentId
          loc_520F15: ret
        }

        private void frmProcess_Load(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        public void prepareForm(boolean SaveNew, boolean KeepItem) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cProcess var_1;
          valuetype System.DateTime var_2;
          class ComboBox var_3;
          class GCUv2.cComponent[] var_4;
          int32 num_3;
          class GCUv2.cComponent var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void cboItem_SelectedIndexChanged(object sender, class System.EventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_5218A1: nop
          loc_5218A2: ldarg.0
          loc_5218A3: call instance void GCUv2.frmProcess::openComponent()
          loc_5218A8: nop
          loc_5218A9: ret
        }

        private void openComponent() {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class GCUv2.frmProcessComponent var_3;
          class ComboBox var_4;

        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void btnAddComponent_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.frmProcessComponent var_2;

        }

        private void btnStandardComponent_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class DataTable var_3;
          int32 num_3;
          int32 num_4;
          double flt_1;
          valuetype System.DateTime var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          class System.Collections.IEnumerator var_9;
          class DataRow var_10;
          boolean var_11;
          class GCUv2.cComponent[] var_12;
          int32 num_5;
          class GCUv2.cComponent var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          valuetype System.DateTime var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;

        }

        private void dgvList_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvList_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_521FE6: nop
          loc_521FE7: ldarg.0
          loc_521FE8: ldc.i4.0
          loc_521FE9: call instance void GCUv2.frmProcess::SaveData(boolean)
          loc_521FEE: nop
          loc_521FEF: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_521FF1: nop
          loc_521FF2: ldarg.0
          loc_521FF3: ldc.i4.1
          loc_521FF4: call instance void GCUv2.frmProcess::SaveData(boolean)
          loc_521FF9: nop
          loc_521FFA: ret
        }

        private void SaveData(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cProcess var_3;
          class GCUv2.cComponent[] var_4;
          int32 num_3;
          string str_1;
          string str_2;
          class GCUv2.cHistory var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          int32 num_4;
          int32 num_5;
          boolean var_14;
          boolean var_15;
          boolean var_16;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class GCUv2.cProcess var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

    }
}
