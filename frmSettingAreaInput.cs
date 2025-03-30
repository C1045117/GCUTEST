using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSaveClose;
        private class Label _Label9;
        private class ComboBox _cboActive;
        private class TextBox _txtName;
        private class Label _Label1;
        private class Label _Label2;
        private class ComboBox _cboBranch;
        private int32 _currentId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4E7817: ldarg.0
          loc_4E7818: ldfld GCUv2.frmSettingAreaInput::_btnSaveClose
          loc_4E781D: br.s loc_4E781F
          loc_4E781F: // Referenced from: loc_4E781D
          loc_4E781F: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_4E7864: ldarg.0
          loc_4E7865: ldfld GCUv2.frmSettingAreaInput::_Label9
          loc_4E786A: br.s loc_4E786C
          loc_4E786C: // Referenced from: loc_4E786A
          loc_4E786C: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_4E786E: ldarg.0
          loc_4E786F: ldarg.1
          loc_4E7870: stfld GCUv2.frmSettingAreaInput::_Label9
          loc_4E7875: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_4E7877: ldarg.0
          loc_4E7878: ldfld GCUv2.frmSettingAreaInput::_cboActive
          loc_4E787D: br.s loc_4E787F
          loc_4E787F: // Referenced from: loc_4E787D
          loc_4E787F: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_4E7881: ldarg.0
          loc_4E7882: ldarg.1
          loc_4E7883: stfld GCUv2.frmSettingAreaInput::_cboActive
          loc_4E7888: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4E788A: ldarg.0
          loc_4E788B: ldfld GCUv2.frmSettingAreaInput::_txtName
          loc_4E7890: br.s loc_4E7892
          loc_4E7892: // Referenced from: loc_4E7890
          loc_4E7892: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4E7894: ldarg.0
          loc_4E7895: ldarg.1
          loc_4E7896: stfld GCUv2.frmSettingAreaInput::_txtName
          loc_4E789B: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4E789D: ldarg.0
          loc_4E789E: ldfld GCUv2.frmSettingAreaInput::_Label1
          loc_4E78A3: br.s loc_4E78A5
          loc_4E78A5: // Referenced from: loc_4E78A3
          loc_4E78A5: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4E78A7: ldarg.0
          loc_4E78A8: ldarg.1
          loc_4E78A9: stfld GCUv2.frmSettingAreaInput::_Label1
          loc_4E78AE: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_4E78B0: ldarg.0
          loc_4E78B1: ldfld GCUv2.frmSettingAreaInput::_Label2
          loc_4E78B6: br.s loc_4E78B8
          loc_4E78B8: // Referenced from: loc_4E78B6
          loc_4E78B8: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4E78BA: ldarg.0
          loc_4E78BB: ldarg.1
          loc_4E78BC: stfld GCUv2.frmSettingAreaInput::_Label2
          loc_4E78C1: ret
        }

        assem override strict specialname class ComboBox get_cboBranch() {

          loc_4E78C3: ldarg.0
          loc_4E78C4: ldfld GCUv2.frmSettingAreaInput::_cboBranch
          loc_4E78C9: br.s loc_4E78CB
          loc_4E78CB: // Referenced from: loc_4E78C9
          loc_4E78CB: ret
        }

        assem override strict specialname void set_cboBranch(class ComboBox WithEventsValue) {

          loc_4E78CD: ldarg.0
          loc_4E78CE: ldarg.1
          loc_4E78CF: stfld GCUv2.frmSettingAreaInput::_cboBranch
          loc_4E78D4: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_4E78F6: nop
          loc_4E78F7: ldarg.0
          loc_4E78F8: ldarg.1
          loc_4E78F9: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_4E78FE: stfld GCUv2.frmSettingAreaInput::_currentId
          loc_4E7903: ret
        }

        public void frmSettingAreaInput() {

          class ComboBox var_1;

        }

        private void frmSettingAreaInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cArea var_1;
          class ComboBox var_2;

        }

        public void prepareForm() {

          loc_4E7A95: nop
          loc_4E7A96: ldarg.0
          loc_4E7A97: ldc.i4.0
          loc_4E7A98: stfld GCUv2.frmSettingAreaInput::_currentId
          loc_4E7A9D: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          class GCUv2.cArea var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;
          boolean var_8;

        }

    }
}
