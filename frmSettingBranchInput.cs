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
        private int32 _currentId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_504ACF: ldarg.0
          loc_504AD0: ldfld GCUv2.frmSettingBranchInput::_btnSaveClose
          loc_504AD5: br.s loc_504AD7
          loc_504AD7: // Referenced from: loc_504AD5
          loc_504AD7: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_504B1C: ldarg.0
          loc_504B1D: ldfld GCUv2.frmSettingBranchInput::_Label9
          loc_504B22: br.s loc_504B24
          loc_504B24: // Referenced from: loc_504B22
          loc_504B24: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_504B26: ldarg.0
          loc_504B27: ldarg.1
          loc_504B28: stfld GCUv2.frmSettingBranchInput::_Label9
          loc_504B2D: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_504B2F: ldarg.0
          loc_504B30: ldfld GCUv2.frmSettingBranchInput::_cboActive
          loc_504B35: br.s loc_504B37
          loc_504B37: // Referenced from: loc_504B35
          loc_504B37: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_504B39: ldarg.0
          loc_504B3A: ldarg.1
          loc_504B3B: stfld GCUv2.frmSettingBranchInput::_cboActive
          loc_504B40: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_504B42: ldarg.0
          loc_504B43: ldfld GCUv2.frmSettingBranchInput::_txtName
          loc_504B48: br.s loc_504B4A
          loc_504B4A: // Referenced from: loc_504B48
          loc_504B4A: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_504B4C: ldarg.0
          loc_504B4D: ldarg.1
          loc_504B4E: stfld GCUv2.frmSettingBranchInput::_txtName
          loc_504B53: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_504B55: ldarg.0
          loc_504B56: ldfld GCUv2.frmSettingBranchInput::_Label1
          loc_504B5B: br.s loc_504B5D
          loc_504B5D: // Referenced from: loc_504B5B
          loc_504B5D: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_504B5F: ldarg.0
          loc_504B60: ldarg.1
          loc_504B61: stfld GCUv2.frmSettingBranchInput::_Label1
          loc_504B66: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_504B86: nop
          loc_504B87: ldarg.0
          loc_504B88: ldarg.1
          loc_504B89: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_504B8E: stfld GCUv2.frmSettingBranchInput::_currentId
          loc_504B93: ret
        }

        public void frmSettingBranchInput() {

          class ComboBox var_1;

        }

        private void frmSettingBranchInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cBranch var_1;
          class ComboBox var_2;

        }

        public void prepareForm() {

          loc_504CE5: nop
          loc_504CE6: ldarg.0
          loc_504CE7: ldc.i4.0
          loc_504CE8: stfld GCUv2.frmSettingBranchInput::_currentId
          loc_504CED: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cBranch var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

    }
}
