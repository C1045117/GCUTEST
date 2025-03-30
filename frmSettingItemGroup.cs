using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private boolean _currentData;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4F0A03: ldarg.0
          loc_4F0A04: ldfld GCUv2.frmSettingItemGroup::_btnDelete
          loc_4F0A09: br.s loc_4F0A0B
          loc_4F0A0B: // Referenced from: loc_4F0A09
          loc_4F0A0B: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4F0A50: ldarg.0
          loc_4F0A51: ldfld GCUv2.frmSettingItemGroup::_btnSave
          loc_4F0A56: br.s loc_4F0A58
          loc_4F0A58: // Referenced from: loc_4F0A56
          loc_4F0A58: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_4F0AA0: ldarg.0
          loc_4F0AA1: ldfld GCUv2.frmSettingItemGroup::_txtQty
          loc_4F0AA6: br.s loc_4F0AA8
          loc_4F0AA8: // Referenced from: loc_4F0AA6
          loc_4F0AA8: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4F0AAA: ldarg.0
          loc_4F0AAB: ldarg.1
          loc_4F0AAC: stfld GCUv2.frmSettingItemGroup::_txtQty
          loc_4F0AB1: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_4F0AB3: ldarg.0
          loc_4F0AB4: ldfld GCUv2.frmSettingItemGroup::_Label6
          loc_4F0AB9: br.s loc_4F0ABB
          loc_4F0ABB: // Referenced from: loc_4F0AB9
          loc_4F0ABB: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4F0ABD: ldarg.0
          loc_4F0ABE: ldarg.1
          loc_4F0ABF: stfld GCUv2.frmSettingItemGroup::_Label6
          loc_4F0AC4: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_4F0AC6: ldarg.0
          loc_4F0AC7: ldfld GCUv2.frmSettingItemGroup::_cboItem
          loc_4F0ACC: br.s loc_4F0ACE
          loc_4F0ACE: // Referenced from: loc_4F0ACC
          loc_4F0ACE: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_4F0AD0: ldarg.0
          loc_4F0AD1: ldarg.1
          loc_4F0AD2: stfld GCUv2.frmSettingItemGroup::_cboItem
          loc_4F0AD7: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_4F0AD9: ldarg.0
          loc_4F0ADA: ldfld GCUv2.frmSettingItemGroup::_Label5
          loc_4F0ADF: br.s loc_4F0AE1
          loc_4F0AE1: // Referenced from: loc_4F0ADF
          loc_4F0AE1: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4F0AE3: ldarg.0
          loc_4F0AE4: ldarg.1
          loc_4F0AE5: stfld GCUv2.frmSettingItemGroup::_Label5
          loc_4F0AEA: ret
        }

        public void frmSettingItemGroup(boolean CurrentData) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSettingItemGroup_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          loc_4F0E12: nop
          loc_4F0E13: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4F0E18: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemGroup/MyForms::get_frmSettingItemInput()
          loc_4F0E1D: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvItemGroup()
          loc_4F0E22: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_4F0E27: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4F0E2C: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemGroup/MyForms::get_frmSettingItemInput()
          loc_4F0E31: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvItemGroup()
          loc_4F0E36: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_4F0E3B: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_4F0E40: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_4F0E45: nop
          loc_4F0E46: ldarg.0
          loc_4F0E47: call instance void System.Windows.Forms.Form::Close()
          loc_4F0E4C: nop
          loc_4F0E4D: ret
        }

    }
}
