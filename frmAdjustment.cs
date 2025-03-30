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
        private class Label _Label3;
        private class Label _Label2;
        private class Label _Label1;
        private class ComboBox _cboStorage;
        private class DateTimePicker _dtpAdjustment;
        private class ComboBox _cboCategory;
        private class Label _Label7;
        private class ComboBox _cboType;
        private class TextBox _txtDescription;
        private class Label _Label8;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label11;
        private class Label _lblItem;
        private class Label _lblType;
        private double _currentId;
        public int32 intOriginalItemId;
        public int32 intOriginalStorageId;
        public valuetype System.DateTime dateOriginal;
        public double dblOriginalQty;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_42C43B: ldarg.0
          loc_42C43C: ldfld GCUv2.frmAdjustment::_txtQty
          loc_42C441: br.s loc_42C443
          loc_42C443: // Referenced from: loc_42C441
          loc_42C443: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_42C445: ldarg.0
          loc_42C446: ldarg.1
          loc_42C447: stfld GCUv2.frmAdjustment::_txtQty
          loc_42C44C: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_42C44E: ldarg.0
          loc_42C44F: ldfld GCUv2.frmAdjustment::_Label6
          loc_42C454: br.s loc_42C456
          loc_42C456: // Referenced from: loc_42C454
          loc_42C456: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_42C458: ldarg.0
          loc_42C459: ldarg.1
          loc_42C45A: stfld GCUv2.frmAdjustment::_Label6
          loc_42C45F: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_42C461: ldarg.0
          loc_42C462: ldfld GCUv2.frmAdjustment::_cboItem
          loc_42C467: br.s loc_42C469
          loc_42C469: // Referenced from: loc_42C467
          loc_42C469: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_42C46B: ldarg.0
          loc_42C46C: ldarg.1
          loc_42C46D: stfld GCUv2.frmAdjustment::_cboItem
          loc_42C472: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_42C474: ldarg.0
          loc_42C475: ldfld GCUv2.frmAdjustment::_Label5
          loc_42C47A: br.s loc_42C47C
          loc_42C47C: // Referenced from: loc_42C47A
          loc_42C47C: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_42C47E: ldarg.0
          loc_42C47F: ldarg.1
          loc_42C480: stfld GCUv2.frmAdjustment::_Label5
          loc_42C485: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_42C487: ldarg.0
          loc_42C488: ldfld GCUv2.frmAdjustment::_Label3
          loc_42C48D: br.s loc_42C48F
          loc_42C48F: // Referenced from: loc_42C48D
          loc_42C48F: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_42C491: ldarg.0
          loc_42C492: ldarg.1
          loc_42C493: stfld GCUv2.frmAdjustment::_Label3
          loc_42C498: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_42C49A: ldarg.0
          loc_42C49B: ldfld GCUv2.frmAdjustment::_Label2
          loc_42C4A0: br.s loc_42C4A2
          loc_42C4A2: // Referenced from: loc_42C4A0
          loc_42C4A2: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_42C4A4: ldarg.0
          loc_42C4A5: ldarg.1
          loc_42C4A6: stfld GCUv2.frmAdjustment::_Label2
          loc_42C4AB: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_42C4AD: ldarg.0
          loc_42C4AE: ldfld GCUv2.frmAdjustment::_Label1
          loc_42C4B3: br.s loc_42C4B5
          loc_42C4B5: // Referenced from: loc_42C4B3
          loc_42C4B5: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_42C4B7: ldarg.0
          loc_42C4B8: ldarg.1
          loc_42C4B9: stfld GCUv2.frmAdjustment::_Label1
          loc_42C4BE: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_42C4C0: ldarg.0
          loc_42C4C1: ldfld GCUv2.frmAdjustment::_cboStorage
          loc_42C4C6: br.s loc_42C4C8
          loc_42C4C8: // Referenced from: loc_42C4C6
          loc_42C4C8: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class DateTimePicker get_dtpAdjustment() {

          loc_42C510: ldarg.0
          loc_42C511: ldfld GCUv2.frmAdjustment::_dtpAdjustment
          loc_42C516: br.s loc_42C518
          loc_42C518: // Referenced from: loc_42C516
          loc_42C518: ret
        }

        assem override strict specialname void set_dtpAdjustment(class DateTimePicker WithEventsValue) {

          loc_42C51A: ldarg.0
          loc_42C51B: ldarg.1
          loc_42C51C: stfld GCUv2.frmAdjustment::_dtpAdjustment
          loc_42C521: ret
        }

        assem override strict specialname class ComboBox get_cboCategory() {

          loc_42C523: ldarg.0
          loc_42C524: ldfld GCUv2.frmAdjustment::_cboCategory
          loc_42C529: br.s loc_42C52B
          loc_42C52B: // Referenced from: loc_42C529
          loc_42C52B: ret
        }

        assem override strict specialname void set_cboCategory(class ComboBox WithEventsValue) {

          loc_42C52D: ldarg.0
          loc_42C52E: ldarg.1
          loc_42C52F: stfld GCUv2.frmAdjustment::_cboCategory
          loc_42C534: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_42C536: ldarg.0
          loc_42C537: ldfld GCUv2.frmAdjustment::_Label7
          loc_42C53C: br.s loc_42C53E
          loc_42C53E: // Referenced from: loc_42C53C
          loc_42C53E: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_42C540: ldarg.0
          loc_42C541: ldarg.1
          loc_42C542: stfld GCUv2.frmAdjustment::_Label7
          loc_42C547: ret
        }

        assem override strict specialname class ComboBox get_cboType() {

          loc_42C549: ldarg.0
          loc_42C54A: ldfld GCUv2.frmAdjustment::_cboType
          loc_42C54F: br.s loc_42C551
          loc_42C551: // Referenced from: loc_42C54F
          loc_42C551: ret
        }

        assem override strict specialname void set_cboType(class ComboBox WithEventsValue) {

          loc_42C553: ldarg.0
          loc_42C554: ldarg.1
          loc_42C555: stfld GCUv2.frmAdjustment::_cboType
          loc_42C55A: ret
        }

        assem override strict specialname class TextBox get_txtDescription() {

          loc_42C55C: ldarg.0
          loc_42C55D: ldfld GCUv2.frmAdjustment::_txtDescription
          loc_42C562: br.s loc_42C564
          loc_42C564: // Referenced from: loc_42C562
          loc_42C564: ret
        }

        assem override strict specialname void set_txtDescription(class TextBox WithEventsValue) {

          loc_42C566: ldarg.0
          loc_42C567: ldarg.1
          loc_42C568: stfld GCUv2.frmAdjustment::_txtDescription
          loc_42C56D: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_42C56F: ldarg.0
          loc_42C570: ldfld GCUv2.frmAdjustment::_Label8
          loc_42C575: br.s loc_42C577
          loc_42C577: // Referenced from: loc_42C575
          loc_42C577: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_42C579: ldarg.0
          loc_42C57A: ldarg.1
          loc_42C57B: stfld GCUv2.frmAdjustment::_Label8
          loc_42C580: ret
        }

        assem override strict specialname class Button get_btnHistory() {

          loc_42C582: ldarg.0
          loc_42C583: ldfld GCUv2.frmAdjustment::_btnHistory
          loc_42C588: br.s loc_42C58A
          loc_42C58A: // Referenced from: loc_42C588
          loc_42C58A: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_42C5D0: ldarg.0
          loc_42C5D1: ldfld GCUv2.frmAdjustment::_btnSaveClose
          loc_42C5D6: br.s loc_42C5D8
          loc_42C5D8: // Referenced from: loc_42C5D6
          loc_42C5D8: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_42C620: ldarg.0
          loc_42C621: ldfld GCUv2.frmAdjustment::_btnDelete
          loc_42C626: br.s loc_42C628
          loc_42C628: // Referenced from: loc_42C626
          loc_42C628: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_42C670: ldarg.0
          loc_42C671: ldfld GCUv2.frmAdjustment::_btnSave
          loc_42C676: br.s loc_42C678
          loc_42C678: // Referenced from: loc_42C676
          loc_42C678: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label11() {

          loc_42C6C0: ldarg.0
          loc_42C6C1: ldfld GCUv2.frmAdjustment::_Label11
          loc_42C6C6: br.s loc_42C6C8
          loc_42C6C8: // Referenced from: loc_42C6C6
          loc_42C6C8: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_42C6CA: ldarg.0
          loc_42C6CB: ldarg.1
          loc_42C6CC: stfld GCUv2.frmAdjustment::_Label11
          loc_42C6D1: ret
        }

        assem override strict specialname class Label get_lblItem() {

          loc_42C6D3: ldarg.0
          loc_42C6D4: ldfld GCUv2.frmAdjustment::_lblItem
          loc_42C6D9: br.s loc_42C6DB
          loc_42C6DB: // Referenced from: loc_42C6D9
          loc_42C6DB: ret
        }

        assem override strict specialname void set_lblItem(class Label WithEventsValue) {

          loc_42C6DD: ldarg.0
          loc_42C6DE: ldarg.1
          loc_42C6DF: stfld GCUv2.frmAdjustment::_lblItem
          loc_42C6E4: ret
        }

        assem override strict specialname class Label get_lblType() {

          loc_42C6E6: ldarg.0
          loc_42C6E7: ldfld GCUv2.frmAdjustment::_lblType
          loc_42C6EC: br.s loc_42C6EE
          loc_42C6EE: // Referenced from: loc_42C6EC
          loc_42C6EE: ret
        }

        assem override strict specialname void set_lblType(class Label WithEventsValue) {

          loc_42C6F0: ldarg.0
          loc_42C6F1: ldarg.1
          loc_42C6F2: stfld GCUv2.frmAdjustment::_lblType
          loc_42C6F7: ret
        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_42C711: nop
          loc_42C712: ldarg.0
          loc_42C713: ldarg.1
          loc_42C714: stfld GCUv2.frmAdjustment::_currentId
          loc_42C719: ret
        }

        public void frmAdjustment() {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;

        }

        public void prepareForm(boolean SaveNew) {

          int32 num_1;
          int32 num_2;
          boolean var_1;

        }

        private void frmAdjustment_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cAdjustment var_1;
          class ComboBox var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          loc_42CD4D: nop
          loc_42CD4E: ldarg.0
          loc_42CD4F: ldc.i4.0
          loc_42CD50: call instance void GCUv2.frmAdjustment::Save(boolean)
          loc_42CD55: nop
          loc_42CD56: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          loc_42CD58: nop
          loc_42CD59: ldarg.0
          loc_42CD5A: ldc.i4.1
          loc_42CD5B: call instance void GCUv2.frmAdjustment::Save(boolean)
          loc_42CD60: nop
          loc_42CD61: ret
        }

        private void Save(boolean CloseForm) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          class GCUv2.cComboItem var_4;
          class GCUv2.cAdjustment var_5;
          string str_1;
          string str_2;
          class GCUv2.cHistory var_6;
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

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          string str_1;
          class GCUv2.cAdjustment var_2;
          class GCUv2.cHistory var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;

        }

    }
}
