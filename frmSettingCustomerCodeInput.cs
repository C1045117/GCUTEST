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

          loc_4F2BF9: ldarg.0
          loc_4F2BFA: ldfld GCUv2.frmSettingCustomerCodeInput::_btnSaveClose
          loc_4F2BFF: br.s loc_4F2C01
          loc_4F2C01: // Referenced from: loc_4F2BFF
          loc_4F2C01: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_4F2C48: ldarg.0
          loc_4F2C49: ldfld GCUv2.frmSettingCustomerCodeInput::_Label9
          loc_4F2C4E: br.s loc_4F2C50
          loc_4F2C50: // Referenced from: loc_4F2C4E
          loc_4F2C50: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_4F2C52: ldarg.0
          loc_4F2C53: ldarg.1
          loc_4F2C54: stfld GCUv2.frmSettingCustomerCodeInput::_Label9
          loc_4F2C59: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_4F2C5B: ldarg.0
          loc_4F2C5C: ldfld GCUv2.frmSettingCustomerCodeInput::_cboActive
          loc_4F2C61: br.s loc_4F2C63
          loc_4F2C63: // Referenced from: loc_4F2C61
          loc_4F2C63: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_4F2C65: ldarg.0
          loc_4F2C66: ldarg.1
          loc_4F2C67: stfld GCUv2.frmSettingCustomerCodeInput::_cboActive
          loc_4F2C6C: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4F2C6E: ldarg.0
          loc_4F2C6F: ldfld GCUv2.frmSettingCustomerCodeInput::_txtName
          loc_4F2C74: br.s loc_4F2C76
          loc_4F2C76: // Referenced from: loc_4F2C74
          loc_4F2C76: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4F2C78: ldarg.0
          loc_4F2C79: ldarg.1
          loc_4F2C7A: stfld GCUv2.frmSettingCustomerCodeInput::_txtName
          loc_4F2C7F: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4F2C81: ldarg.0
          loc_4F2C82: ldfld GCUv2.frmSettingCustomerCodeInput::_Label1
          loc_4F2C87: br.s loc_4F2C89
          loc_4F2C89: // Referenced from: loc_4F2C87
          loc_4F2C89: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4F2C8B: ldarg.0
          loc_4F2C8C: ldarg.1
          loc_4F2C8D: stfld GCUv2.frmSettingCustomerCodeInput::_Label1
          loc_4F2C92: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_4F2CB2: nop
          loc_4F2CB3: ldarg.0
          loc_4F2CB4: ldarg.1
          loc_4F2CB5: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_4F2CBA: stfld GCUv2.frmSettingCustomerCodeInput::_currentId
          loc_4F2CBF: ret
        }

        public void frmSettingCustomerCodeInput() {

          class ComboBox var_1;

        }

        private void frmSettingCustomerCodeInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cCustomerCode var_1;
          class ComboBox var_2;

        }

        public void prepareForm() {

          loc_4F2E11: nop
          loc_4F2E12: ldarg.0
          loc_4F2E13: ldc.i4.0
          loc_4F2E14: stfld GCUv2.frmSettingCustomerCodeInput::_currentId
          loc_4F2E19: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cCustomerCode var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

    }
}
