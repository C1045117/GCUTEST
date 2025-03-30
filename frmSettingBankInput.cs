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

          loc_4E8B19: ldarg.0
          loc_4E8B1A: ldfld GCUv2.frmSettingBankInput::_btnSaveClose
          loc_4E8B1F: br.s loc_4E8B21
          loc_4E8B21: // Referenced from: loc_4E8B1F
          loc_4E8B21: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label9() {

          loc_4E8B68: ldarg.0
          loc_4E8B69: ldfld GCUv2.frmSettingBankInput::_Label9
          loc_4E8B6E: br.s loc_4E8B70
          loc_4E8B70: // Referenced from: loc_4E8B6E
          loc_4E8B70: ret
        }

        assem override strict specialname void set_Label9(class Label WithEventsValue) {

          loc_4E8B72: ldarg.0
          loc_4E8B73: ldarg.1
          loc_4E8B74: stfld GCUv2.frmSettingBankInput::_Label9
          loc_4E8B79: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_4E8B7B: ldarg.0
          loc_4E8B7C: ldfld GCUv2.frmSettingBankInput::_cboActive
          loc_4E8B81: br.s loc_4E8B83
          loc_4E8B83: // Referenced from: loc_4E8B81
          loc_4E8B83: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_4E8B85: ldarg.0
          loc_4E8B86: ldarg.1
          loc_4E8B87: stfld GCUv2.frmSettingBankInput::_cboActive
          loc_4E8B8C: ret
        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4E8B8E: ldarg.0
          loc_4E8B8F: ldfld GCUv2.frmSettingBankInput::_txtName
          loc_4E8B94: br.s loc_4E8B96
          loc_4E8B96: // Referenced from: loc_4E8B94
          loc_4E8B96: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4E8B98: ldarg.0
          loc_4E8B99: ldarg.1
          loc_4E8B9A: stfld GCUv2.frmSettingBankInput::_txtName
          loc_4E8B9F: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4E8BA1: ldarg.0
          loc_4E8BA2: ldfld GCUv2.frmSettingBankInput::_Label1
          loc_4E8BA7: br.s loc_4E8BA9
          loc_4E8BA9: // Referenced from: loc_4E8BA7
          loc_4E8BA9: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4E8BAB: ldarg.0
          loc_4E8BAC: ldarg.1
          loc_4E8BAD: stfld GCUv2.frmSettingBankInput::_Label1
          loc_4E8BB2: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_4E8BD2: nop
          loc_4E8BD3: ldarg.0
          loc_4E8BD4: ldarg.1
          loc_4E8BD5: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_4E8BDA: stfld GCUv2.frmSettingBankInput::_currentId
          loc_4E8BDF: ret
        }

        public void frmSettingBankInput() {

          class ComboBox var_1;

        }

        private void frmSettingBankInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cBank var_1;
          class ComboBox var_2;

        }

        public void prepareForm() {

          loc_4E8D31: nop
          loc_4E8D32: ldarg.0
          loc_4E8D33: ldc.i4.0
          loc_4E8D34: stfld GCUv2.frmSettingBankInput::_currentId
          loc_4E8D39: ret
        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cBank var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

    }
}
