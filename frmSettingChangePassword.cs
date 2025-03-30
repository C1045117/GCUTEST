using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class TextBox _txtPassword2;
        private class Label _Label3;
        private class Button _btnSaveClose;
        private class TextBox _txtPassword;
        private class Label _Label2;
        private class TextBox _txtOldPassword;
        private class Label _Label1;


        public void frmSettingChangePassword() {

          loc_4E99C1: ldarg.0
          loc_4E99C2: call instance void System.Windows.Forms.Form::.ctor()
          loc_4E99C7: ldarg.0
          loc_4E99C8: ldarg.0
          loc_4E99C9: ldftn instance void GCUv2.frmSettingChangePassword::frmSettingChangePassword_KeyDown(object, class KeyEventArgs)
          loc_4E99CF: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_4E99D4: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4E99D9: ldarg.0
          loc_4E99DA: call instance void GCUv2.frmSettingChangePassword::InitializeComponent()
          loc_4E99DF: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class TextBox get_txtPassword2() {

          loc_4E9E8A: ldarg.0
          loc_4E9E8B: ldfld GCUv2.frmSettingChangePassword::_txtPassword2
          loc_4E9E90: br.s loc_4E9E92
          loc_4E9E92: // Referenced from: loc_4E9E90
          loc_4E9E92: ret
        }

        assem override strict specialname void set_txtPassword2(class TextBox WithEventsValue) {

          loc_4E9E94: ldarg.0
          loc_4E9E95: ldarg.1
          loc_4E9E96: stfld GCUv2.frmSettingChangePassword::_txtPassword2
          loc_4E9E9B: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_4E9E9D: ldarg.0
          loc_4E9E9E: ldfld GCUv2.frmSettingChangePassword::_Label3
          loc_4E9EA3: br.s loc_4E9EA5
          loc_4E9EA5: // Referenced from: loc_4E9EA3
          loc_4E9EA5: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_4E9EA7: ldarg.0
          loc_4E9EA8: ldarg.1
          loc_4E9EA9: stfld GCUv2.frmSettingChangePassword::_Label3
          loc_4E9EAE: ret
        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4E9EB0: ldarg.0
          loc_4E9EB1: ldfld GCUv2.frmSettingChangePassword::_btnSaveClose
          loc_4E9EB6: br.s loc_4E9EB8
          loc_4E9EB8: // Referenced from: loc_4E9EB6
          loc_4E9EB8: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TextBox get_txtPassword() {

          loc_4E9F00: ldarg.0
          loc_4E9F01: ldfld GCUv2.frmSettingChangePassword::_txtPassword
          loc_4E9F06: br.s loc_4E9F08
          loc_4E9F08: // Referenced from: loc_4E9F06
          loc_4E9F08: ret
        }

        assem override strict specialname void set_txtPassword(class TextBox WithEventsValue) {

          loc_4E9F0A: ldarg.0
          loc_4E9F0B: ldarg.1
          loc_4E9F0C: stfld GCUv2.frmSettingChangePassword::_txtPassword
          loc_4E9F11: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_4E9F13: ldarg.0
          loc_4E9F14: ldfld GCUv2.frmSettingChangePassword::_Label2
          loc_4E9F19: br.s loc_4E9F1B
          loc_4E9F1B: // Referenced from: loc_4E9F19
          loc_4E9F1B: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4E9F1D: ldarg.0
          loc_4E9F1E: ldarg.1
          loc_4E9F1F: stfld GCUv2.frmSettingChangePassword::_Label2
          loc_4E9F24: ret
        }

        assem override strict specialname class TextBox get_txtOldPassword() {

          loc_4E9F26: ldarg.0
          loc_4E9F27: ldfld GCUv2.frmSettingChangePassword::_txtOldPassword
          loc_4E9F2C: br.s loc_4E9F2E
          loc_4E9F2E: // Referenced from: loc_4E9F2C
          loc_4E9F2E: ret
        }

        assem override strict specialname void set_txtOldPassword(class TextBox WithEventsValue) {

          loc_4E9F30: ldarg.0
          loc_4E9F31: ldarg.1
          loc_4E9F32: stfld GCUv2.frmSettingChangePassword::_txtOldPassword
          loc_4E9F37: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4E9F39: ldarg.0
          loc_4E9F3A: ldfld GCUv2.frmSettingChangePassword::_Label1
          loc_4E9F3F: br.s loc_4E9F41
          loc_4E9F41: // Referenced from: loc_4E9F3F
          loc_4E9F41: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4E9F43: ldarg.0
          loc_4E9F44: ldarg.1
          loc_4E9F45: stfld GCUv2.frmSettingChangePassword::_Label1
          loc_4E9F4A: ret
        }

        private void frmSettingChangePassword_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          class GCUv2.cUser var_1;
          class GCUv2.cHistory var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

    }
}
