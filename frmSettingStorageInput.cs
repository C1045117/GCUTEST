using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label2;
        private class ComboBox _cboBranch;
        private class Button _btnSaveClose;
        private class Label _Label9;
        private class ComboBox _cboActive;
        private class TextBox _txtName;
        private class Label _Label1;
        private class Label _Label3;
        private class ComboBox _cboMarketingStorageType;
        private int32 _currentId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label2() {

          loc_5124C7: ldarg.0
          loc_5124C8: ldfld GCUv2.frmSettingStorageInput::_Label2
          loc_5124CD: br.s loc_5124CF
          loc_5124CF: // Referenced from: loc_5124CD
          loc_5124CF: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_5124D1: ldarg.0
          loc_5124D2: ldarg.1
          loc_5124D3: stfld GCUv2.frmSettingStorageInput::_Label2
          loc_5124D8: ret
        }

        assem override strict specialname class ComboBox get_cboBranch() {

          loc_5124DA: ldarg.0
          loc_5124DB: ldfld GCUv2.frmSettingStorageInput::_cboBranch
          loc_5124E0: br.s loc_5124E2
          loc_5124E2: // Referenced from: loc_5124E0
          loc_5124E2: ret
        }

        assem override strict specialname void set_cboBranch(class ComboBox WithEventsValue) {

          loc_5124E4: ldarg.0
          loc_5124E5: ldarg.1
          loc_5124E6: stfld GCUv2.frmSettingStorageInput::_cboBranch
          loc_5124EB: ret
        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_5124ED: ldarg.0
          loc_5124EE: ldfld GCUv2.frmSettingStorageInput::_btnSaveClose
          loc_5124F3: br.s loc_5124F5
          loc_5124F5: // Referenced from: loc_5124F3
          loc_5124F5: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_51253C: ldarg.0
          loc_51253D: ldfld GCUv2.frmSettingStorageInput::_Label9
          loc_512542: br.s loc_512544
          loc_512544: // Referenced from: loc_512542
          loc_512544: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_512546: ldarg.0
          loc_512547: ldarg.1
          loc_512548: stfld GCUv2.frmSettingStorageInput::_Label9
          loc_51254D: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_51254F: ldarg.0
          loc_512550: ldfld GCUv2.frmSettingStorageInput::_cboActive
          loc_512555: br.s loc_512557
          loc_512557: // Referenced from: loc_512555
          loc_512557: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_512559: ldarg.0
          loc_51255A: ldarg.1
          loc_51255B: stfld GCUv2.frmSettingStorageInput::_cboActive
          loc_512560: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_512562: ldarg.0
          loc_512563: ldfld GCUv2.frmSettingStorageInput::_txtName
          loc_512568: br.s loc_51256A
          loc_51256A: // Referenced from: loc_512568
          loc_51256A: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_51256C: ldarg.0
          loc_51256D: ldarg.1
          loc_51256E: stfld GCUv2.frmSettingStorageInput::_txtName
          loc_512573: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_512575: ldarg.0
          loc_512576: ldfld GCUv2.frmSettingStorageInput::_Label1
          loc_51257B: br.s loc_51257D
          loc_51257D: // Referenced from: loc_51257B
          loc_51257D: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_51257F: ldarg.0
          loc_512580: ldarg.1
          loc_512581: stfld GCUv2.frmSettingStorageInput::_Label1
          loc_512586: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_512588: ldarg.0
          loc_512589: ldfld GCUv2.frmSettingStorageInput::_Label3
          loc_51258E: br.s loc_512590
          loc_512590: // Referenced from: loc_51258E
          loc_512590: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_512592: ldarg.0
          loc_512593: ldarg.1
          loc_512594: stfld GCUv2.frmSettingStorageInput::_Label3
          loc_512599: ret
        }

        assem override strict specialname class ComboBox get_cboMarketingStorageType() {

          loc_51259B: ldarg.0
          loc_51259C: ldfld GCUv2.frmSettingStorageInput::_cboMarketingStorageType
          loc_5125A1: br.s loc_5125A3
          loc_5125A3: // Referenced from: loc_5125A1
          loc_5125A3: ret
        }

        assem override strict specialname void set_cboMarketingStorageType(class ComboBox WithEventsValue) {

          loc_5125A5: ldarg.0
          loc_5125A6: ldarg.1
          loc_5125A7: stfld GCUv2.frmSettingStorageInput::_cboMarketingStorageType
          loc_5125AC: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_5125CE: nop
          loc_5125CF: ldarg.0
          loc_5125D0: ldarg.1
          loc_5125D1: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_5125D6: stfld GCUv2.frmSettingStorageInput::_currentId
          loc_5125DB: ret
        }

        public void frmSettingStorageInput() {

          class ComboBox var_1;

        }

        private void frmSettingAreaInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cStorage var_1;
          boolean var_2;
          class ComboBox var_3;
          boolean var_4;

        }

        public void prepareForm() {

          loc_512819: nop
          loc_51281A: ldarg.0
          loc_51281B: ldc.i4.0
          loc_51281C: stfld GCUv2.frmSettingStorageInput::_currentId
          loc_512821: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cComboItem var_3;
          class GCUv2.cStorage var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;

        }

    }
}
