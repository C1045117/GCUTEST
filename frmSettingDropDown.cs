using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSaveClose;
        private class TextBox _txtTOP;
        private class Label _Label1;
        private class TextBox _txtCredit;
        private class Label _Label2;
        private class Label _Label3;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_4F3D6C: ldarg.0
          loc_4F3D6D: ldfld GCUv2.frmSettingDropDown::_btnSaveClose
          loc_4F3D72: br.s loc_4F3D74
          loc_4F3D74: // Referenced from: loc_4F3D72
          loc_4F3D74: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TextBox get_txtTOP() {

          loc_4F3DBC: ldarg.0
          loc_4F3DBD: ldfld GCUv2.frmSettingDropDown::_txtTOP
          loc_4F3DC2: br.s loc_4F3DC4
          loc_4F3DC4: // Referenced from: loc_4F3DC2
          loc_4F3DC4: ret
        }

        assem override strict specialname void set_txtTOP(class TextBox WithEventsValue) {

          loc_4F3DC6: ldarg.0
          loc_4F3DC7: ldarg.1
          loc_4F3DC8: stfld GCUv2.frmSettingDropDown::_txtTOP
          loc_4F3DCD: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4F3DCF: ldarg.0
          loc_4F3DD0: ldfld GCUv2.frmSettingDropDown::_Label1
          loc_4F3DD5: br.s loc_4F3DD7
          loc_4F3DD7: // Referenced from: loc_4F3DD5
          loc_4F3DD7: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4F3DD9: ldarg.0
          loc_4F3DDA: ldarg.1
          loc_4F3DDB: stfld GCUv2.frmSettingDropDown::_Label1
          loc_4F3DE0: ret
        }

        assem override strict specialname class TextBox get_txtCredit() {

          loc_4F3DE2: ldarg.0
          loc_4F3DE3: ldfld GCUv2.frmSettingDropDown::_txtCredit
          loc_4F3DE8: br.s loc_4F3DEA
          loc_4F3DEA: // Referenced from: loc_4F3DE8
          loc_4F3DEA: ret
        }

        assem override strict specialname void set_txtCredit(class TextBox WithEventsValue) {

          loc_4F3DEC: ldarg.0
          loc_4F3DED: ldarg.1
          loc_4F3DEE: stfld GCUv2.frmSettingDropDown::_txtCredit
          loc_4F3DF3: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_4F3DF5: ldarg.0
          loc_4F3DF6: ldfld GCUv2.frmSettingDropDown::_Label2
          loc_4F3DFB: br.s loc_4F3DFD
          loc_4F3DFD: // Referenced from: loc_4F3DFB
          loc_4F3DFD: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_4F3DFF: ldarg.0
          loc_4F3E00: ldarg.1
          loc_4F3E01: stfld GCUv2.frmSettingDropDown::_Label2
          loc_4F3E06: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_4F3E08: ldarg.0
          loc_4F3E09: ldfld GCUv2.frmSettingDropDown::_Label3
          loc_4F3E0E: br.s loc_4F3E10
          loc_4F3E10: // Referenced from: loc_4F3E0E
          loc_4F3E10: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_4F3E12: ldarg.0
          loc_4F3E13: ldarg.1
          loc_4F3E14: stfld GCUv2.frmSettingDropDown::_Label3
          loc_4F3E19: ret
        }

        public void frmSettingDropDown() {

          loc_4F3E1B: nop
          loc_4F3E1C: ldarg.0
          loc_4F3E1D: call instance void System.Windows.Forms.Form::.ctor()
          loc_4F3E22: nop
          loc_4F3E23: ldarg.0
          loc_4F3E24: ldarg.0
          loc_4F3E25: ldftn instance void GCUv2.frmSettingDropDown::frmSettingDropDown_KeyDown(object, class KeyEventArgs)
          loc_4F3E2B: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_4F3E30: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4F3E35: nop
          loc_4F3E36: ldarg.0
          loc_4F3E37: call instance void GCUv2.frmSettingDropDown::InitializeComponent()
          loc_4F3E3C: nop
          loc_4F3E3D: ldarg.0
          loc_4F3E3E: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4F3E43: callvirt instance class GCUv2.frmMenu GCUv2.frmSettingDropDown/MyForms::get_frmMenu()
          loc_4F3E48: call 
          loc_4F3E4D: nop
          loc_4F3E4E: ldarg.0
          loc_4F3E4F: call instance void GCUv2.frmSettingDropDown::loadData()
          loc_4F3E54: nop
          loc_4F3E55: ret
        }

        private void frmSettingDropDown_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cSetting var_1;

        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cSetting var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

    }
}
