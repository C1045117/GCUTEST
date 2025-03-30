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
        private class Label _Label2;
        private class ComboBox _cboActive;
        private int32 _currentId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSave() {

          loc_54170E: ldarg.0
          loc_54170F: ldfld GCUv2.frmSettingItemCategoryInput::_btnSave
          loc_541714: br.s loc_541716
          loc_541716: // Referenced from: loc_541714
          loc_541716: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class TextBox get_txtName() {

          loc_54175C: ldarg.0
          loc_54175D: ldfld GCUv2.frmSettingItemCategoryInput::_txtName
          loc_541762: br.s loc_541764
          loc_541764: // Referenced from: loc_541762
          loc_541764: ret
        }

        assem override strict specialname void set_txtName(class TextBox WithEventsValue) {

          loc_541766: ldarg.0
          loc_541767: ldarg.1
          loc_541768: stfld GCUv2.frmSettingItemCategoryInput::_txtName
          loc_54176D: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_54176F: ldarg.0
          loc_541770: ldfld GCUv2.frmSettingItemCategoryInput::_Label1
          loc_541775: br.s loc_541777
          loc_541777: // Referenced from: loc_541775
          loc_541777: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_541779: ldarg.0
          loc_54177A: ldarg.1
          loc_54177B: stfld GCUv2.frmSettingItemCategoryInput::_Label1
          loc_541780: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_541782: ldarg.0
          loc_541783: ldfld GCUv2.frmSettingItemCategoryInput::_Label2
          loc_541788: br.s loc_54178A
          loc_54178A: // Referenced from: loc_541788
          loc_54178A: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_54178C: ldarg.0
          loc_54178D: ldarg.1
          loc_54178E: stfld GCUv2.frmSettingItemCategoryInput::_Label2
          loc_541793: ret
        }

        assem override strict specialname class ComboBox get_cboActive() {

          loc_541795: ldarg.0
          loc_541796: ldfld GCUv2.frmSettingItemCategoryInput::_cboActive
          loc_54179B: br.s loc_54179D
          loc_54179D: // Referenced from: loc_54179B
          loc_54179D: ret
        }

        assem override strict specialname void set_cboActive(class ComboBox WithEventsValue) {

          loc_54179F: ldarg.0
          loc_5417A0: ldarg.1
          loc_5417A1: stfld GCUv2.frmSettingItemCategoryInput::_cboActive
          loc_5417A6: ret
        }

        public specialname string get_CurrentId() {

          string str_1;

        }

        public specialname void set_CurrentId(string value) {

          loc_5417C6: nop
          loc_5417C7: ldarg.0
          loc_5417C8: ldarg.1
          loc_5417C9: call int32 Microsoft.VisualBasic.CompilerServices.Conversions::ToInteger(string)
          loc_5417CE: stfld GCUv2.frmSettingItemCategoryInput::_currentId
          loc_5417D3: ret
        }

        public void frmSettingItemCategoryInput() {

          class ComboBox var_1;

        }

        private void frmSetItemCategoryInput_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void loadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cItemCategory var_1;
          class ComboBox var_2;

        }

        public void prepareForm() {

          loc_54191D: nop
          loc_54191E: ldarg.0
          loc_54191F: ldc.i4.0
          loc_541920: stfld GCUv2.frmSettingItemCategoryInput::_currentId
          loc_541925: ret
        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cItemCategory var_2;
          boolean var_3;
          boolean var_4;

        }

    }
}
