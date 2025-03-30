using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class TextBox _txtName;
        private class Label _Label1;
        private class Button _btnSave;
        public int32 intAdjtypeId;


        public void frmSettingAdjustmentTypeInput() {

          loc_53921B: ldarg.0
          loc_53921C: call instance void System.Windows.Forms.Form::.ctor()
          loc_539221: ldarg.0
          loc_539222: ldarg.0
          loc_539223: ldftn instance void GCUv2.frmSettingAdjustmentTypeInput::frmSettingAdjustmentTypeEdit_KeyDown(object, class KeyEventArgs)
          loc_539229: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_53922E: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_539233: ldarg.0
          loc_539234: ldarg.0
          loc_539235: ldftn instance void GCUv2.frmSettingAdjustmentTypeInput::frmSettingAdjustmentTypeEdit_Load(object, class System.EventArgs)
          loc_53923B: newobj instance void System.EventHandler::.ctor(object, System.IntPtr)
          loc_539240: call instance void System.Windows.Forms.Form::add_Load(class System.EventHandler)
          loc_539245: ldarg.0
          loc_539246: call instance void GCUv2.frmSettingAdjustmentTypeInput::InitializeComponent()
          loc_53924B: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class TextBox get_txtName() {

          loc_5394B5: ldarg.0
          loc_5394B6: ldfld GCUv2.frmSettingAdjustmentTypeInput::_txtName
          loc_5394BB: br.s loc_5394BD
          loc_5394BD: // Referenced from: loc_5394BB
          loc_5394BD: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_5394BF: ldarg.0
          loc_5394C0: ldarg.1
          loc_5394C1: stfld GCUv2.frmSettingAdjustmentTypeInput::_txtName
          loc_5394C6: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_5394C8: ldarg.0
          loc_5394C9: ldfld GCUv2.frmSettingAdjustmentTypeInput::_Label1
          loc_5394CE: br.s loc_5394D0
          loc_5394D0: // Referenced from: loc_5394CE
          loc_5394D0: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_5394D2: ldarg.0
          loc_5394D3: ldarg.1
          loc_5394D4: stfld GCUv2.frmSettingAdjustmentTypeInput::_Label1
          loc_5394D9: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_5394DB: ldarg.0
          loc_5394DC: ldfld GCUv2.frmSettingAdjustmentTypeInput::_btnSave
          loc_5394E1: br.s loc_5394E3
          loc_5394E3: // Referenced from: loc_5394E1
          loc_5394E3: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          string str_1;
          string str_2;
          boolean var_1;
          boolean var_2;

        }

        private void frmSettingAdjustmentTypeEdit_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void frmSettingAdjustmentTypeEdit_Load(object sender, class System.EventArgs e) {

          loc_539626: nop
          loc_539627: ldarg.0
          loc_539628: callvirt instance class TextBox GCUv2.frmSettingAdjustmentTypeInput::get_txtName()
          loc_53962D: ldc.i4.0
          loc_53962E: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_539633: nop
          loc_539634: ldarg.0
          loc_539635: callvirt instance class TextBox GCUv2.frmSettingAdjustmentTypeInput::get_txtName()
          loc_53963A: ldarg.0
          loc_53963B: callvirt instance class TextBox GCUv2.frmSettingAdjustmentTypeInput::get_txtName()
          loc_539640: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_539645: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_53964A: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_53964F: nop
          loc_539650: ret
        }

    }
}
