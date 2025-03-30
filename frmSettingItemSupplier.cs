using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label7;
        private class ComboBox _cboSupplier;
        private class Label _Label1;
        private class DateTimePicker _dtpValid;
        private class GCUv2.FilteredTextBox _txtPrice;
        private class Label _Label5;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class Label _Label2;
        private class ComboBox _cboUnit;
        private boolean _currentData;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label7() {

          loc_51192D: ldarg.0
          loc_51192E: ldfld GCUv2.frmSettingItemSupplier::_Label7
          loc_511933: br.s loc_511935
          loc_511935: // Referenced from: loc_511933
          loc_511935: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_511937: ldarg.0
          loc_511938: ldarg.1
          loc_511939: stfld GCUv2.frmSettingItemSupplier::_Label7
          loc_51193E: ret
        }

        assem override strict specialname class ComboBox get_cboSupplier() {

          loc_511940: ldarg.0
          loc_511941: ldfld GCUv2.frmSettingItemSupplier::_cboSupplier
          loc_511946: br.s loc_511948
          loc_511948: // Referenced from: loc_511946
          loc_511948: ret
        }

        assem override strict specialname void set_cboSupplier(class ComboBox WithEventsValue) {

          loc_51194A: ldarg.0
          loc_51194B: ldarg.1
          loc_51194C: stfld GCUv2.frmSettingItemSupplier::_cboSupplier
          loc_511951: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_511953: ldarg.0
          loc_511954: ldfld GCUv2.frmSettingItemSupplier::_Label1
          loc_511959: br.s loc_51195B
          loc_51195B: // Referenced from: loc_511959
          loc_51195B: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_51195D: ldarg.0
          loc_51195E: ldarg.1
          loc_51195F: stfld GCUv2.frmSettingItemSupplier::_Label1
          loc_511964: ret
        }

        assem override strict specialname class DateTimePicker get_dtpValid() {

          loc_511966: ldarg.0
          loc_511967: ldfld GCUv2.frmSettingItemSupplier::_dtpValid
          loc_51196C: br.s loc_51196E
          loc_51196E: // Referenced from: loc_51196C
          loc_51196E: ret
        }

        assem override strict specialname void set_dtpValid(class DateTimePicker WithEventsValue) {

          loc_511970: ldarg.0
          loc_511971: ldarg.1
          loc_511972: stfld GCUv2.frmSettingItemSupplier::_dtpValid
          loc_511977: ret
        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtPrice() {

          loc_511979: ldarg.0
          loc_51197A: ldfld GCUv2.frmSettingItemSupplier::_txtPrice
          loc_51197F: br.s loc_511981
          loc_511981: // Referenced from: loc_51197F
          loc_511981: ret
        }

        assem override strict specialname void set_txtPrice(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_511983: ldarg.0
          loc_511984: ldarg.1
          loc_511985: stfld GCUv2.frmSettingItemSupplier::_txtPrice
          loc_51198A: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_51198C: ldarg.0
          loc_51198D: ldfld GCUv2.frmSettingItemSupplier::_Label5
          loc_511992: br.s loc_511994
          loc_511994: // Referenced from: loc_511992
          loc_511994: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_511996: ldarg.0
          loc_511997: ldarg.1
          loc_511998: stfld GCUv2.frmSettingItemSupplier::_Label5
          loc_51199D: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_51199F: ldarg.0
          loc_5119A0: ldfld GCUv2.frmSettingItemSupplier::_btnDelete
          loc_5119A5: br.s loc_5119A7
          loc_5119A7: // Referenced from: loc_5119A5
          loc_5119A7: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_5119EC: ldarg.0
          loc_5119ED: ldfld GCUv2.frmSettingItemSupplier::_btnSave
          loc_5119F2: br.s loc_5119F4
          loc_5119F4: // Referenced from: loc_5119F2
          loc_5119F4: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label2() {

          loc_511A3C: ldarg.0
          loc_511A3D: ldfld GCUv2.frmSettingItemSupplier::_Label2
          loc_511A42: br.s loc_511A44
          loc_511A44: // Referenced from: loc_511A42
          loc_511A44: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_511A46: ldarg.0
          loc_511A47: ldarg.1
          loc_511A48: stfld GCUv2.frmSettingItemSupplier::_Label2
          loc_511A4D: ret
        }

        assem override strict specialname class ComboBox get_cboUnit() {

          loc_511A4F: ldarg.0
          loc_511A50: ldfld GCUv2.frmSettingItemSupplier::_cboUnit
          loc_511A55: br.s loc_511A57
          loc_511A57: // Referenced from: loc_511A55
          loc_511A57: ret
        }

        assem override strict specialname void set_cboUnit(class ComboBox WithEventsValue) {

          loc_511A59: ldarg.0
          loc_511A5A: ldarg.1
          loc_511A5B: stfld GCUv2.frmSettingItemSupplier::_cboUnit
          loc_511A60: ret
        }

        public void frmSettingItemSupplier(boolean CurrentData) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSettingItemSupplier_KeyDown(object sender, class KeyEventArgs e) {

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

          loc_511E71: nop
          loc_511E72: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_511E77: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemSupplier/MyForms::get_frmSettingItemInput()
          loc_511E7C: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvSupplier()
          loc_511E81: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_511E86: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_511E8B: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemSupplier/MyForms::get_frmSettingItemInput()
          loc_511E90: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvSupplier()
          loc_511E95: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_511E9A: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_511E9F: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_511EA4: nop
          loc_511EA5: ldarg.0
          loc_511EA6: call instance void System.Windows.Forms.Form::Close()
          loc_511EAB: nop
          loc_511EAC: ret
        }

    }
}
