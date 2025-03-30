using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSave;
        private class TextBox _txtName;
        private class Label _Label1;
        public int32 CurrentId;


        public void frmSettingGroupInput() {

          loc_4EEDE2: ldarg.0
          loc_4EEDE3: call instance void System.Windows.Forms.Form::.ctor()
          loc_4EEDE8: ldarg.0
          loc_4EEDE9: ldarg.0
          loc_4EEDEA: ldftn instance void GCUv2.frmSettingGroupInput::frmSettingGroupInput_KeyDown(object, class KeyEventArgs)
          loc_4EEDF0: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_4EEDF5: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_4EEDFA: ldarg.0
          loc_4EEDFB: ldarg.0
          loc_4EEDFC: ldftn instance void GCUv2.frmSettingGroupInput::frmSettingGroupInput_Load(object, class System.EventArgs)
          loc_4EEE02: newobj instance void System.EventHandler::.ctor(object, System.IntPtr)
          loc_4EEE07: call instance void System.Windows.Forms.Form::add_Load(class System.EventHandler)
          loc_4EEE0C: ldarg.0
          loc_4EEE0D: call instance void GCUv2.frmSettingGroupInput::InitializeComponent()
          loc_4EEE12: ret
        }

        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSave() {

          loc_4EF078: ldarg.0
          loc_4EF079: ldfld GCUv2.frmSettingGroupInput::_btnSave
          loc_4EF07E: br.s loc_4EF080
          loc_4EF080: // Referenced from: loc_4EF07E
          loc_4EF080: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TextBox get_txtName() {

          loc_4EF0C8: ldarg.0
          loc_4EF0C9: ldfld GCUv2.frmSettingGroupInput::_txtName
          loc_4EF0CE: br.s loc_4EF0D0
          loc_4EF0D0: // Referenced from: loc_4EF0CE
          loc_4EF0D0: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_4EF0D2: ldarg.0
          loc_4EF0D3: ldarg.1
          loc_4EF0D4: stfld GCUv2.frmSettingGroupInput::_txtName
          loc_4EF0D9: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_4EF0DB: ldarg.0
          loc_4EF0DC: ldfld GCUv2.frmSettingGroupInput::_Label1
          loc_4EF0E1: br.s loc_4EF0E3
          loc_4EF0E3: // Referenced from: loc_4EF0E1
          loc_4EF0E3: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_4EF0E5: ldarg.0
          loc_4EF0E6: ldarg.1
          loc_4EF0E7: stfld GCUv2.frmSettingGroupInput::_Label1
          loc_4EF0EC: ret
        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          string str_1;
          boolean var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void frmSettingGroupInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void frmSettingGroupInput_Load(object sender, class System.EventArgs e) {

          loc_4EF1FA: nop
          loc_4EF1FB: ldarg.0
          loc_4EF1FC: callvirt instance class TextBox GCUv2.frmSettingGroupInput::get_txtName()
          loc_4EF201: ldc.i4.0
          loc_4EF202: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionStart(int32)
          loc_4EF207: nop
          loc_4EF208: ldarg.0
          loc_4EF209: callvirt instance class TextBox GCUv2.frmSettingGroupInput::get_txtName()
          loc_4EF20E: ldarg.0
          loc_4EF20F: callvirt instance class TextBox GCUv2.frmSettingGroupInput::get_txtName()
          loc_4EF214: callvirt instance string System.Windows.Forms.TextBox::get_Text()
          loc_4EF219: call int32 Microsoft.VisualBasic.Strings::Len(string)
          loc_4EF21E: callvirt instance void System.Windows.Forms.TextBoxBase::set_SelectionLength(int32)
          loc_4EF223: nop
          loc_4EF224: ret
        }

    }
}
