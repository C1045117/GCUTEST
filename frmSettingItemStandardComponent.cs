using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label4;
        private class ComboBox _cboStorage;
        private class Button _btnDelete;
        private class Button _btnSave;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private boolean _currentData;
        private int32 _productionStepId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label4() {

          loc_50819E: ldarg.0
          loc_50819F: ldfld GCUv2.frmSettingItemStandardComponent::_Label4
          loc_5081A4: br.s loc_5081A6
          loc_5081A6: // Referenced from: loc_5081A4
          loc_5081A6: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_5081A8: ldarg.0
          loc_5081A9: ldarg.1
          loc_5081AA: stfld GCUv2.frmSettingItemStandardComponent::_Label4
          loc_5081AF: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_5081B1: ldarg.0
          loc_5081B2: ldfld GCUv2.frmSettingItemStandardComponent::_cboStorage
          loc_5081B7: br.s loc_5081B9
          loc_5081B9: // Referenced from: loc_5081B7
          loc_5081B9: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_508200: ldarg.0
          loc_508201: ldfld GCUv2.frmSettingItemStandardComponent::_btnDelete
          loc_508206: br.s loc_508208
          loc_508208: // Referenced from: loc_508206
          loc_508208: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_508250: ldarg.0
          loc_508251: ldfld GCUv2.frmSettingItemStandardComponent::_btnSave
          loc_508256: br.s loc_508258
          loc_508258: // Referenced from: loc_508256
          loc_508258: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_5082A0: ldarg.0
          loc_5082A1: ldfld GCUv2.frmSettingItemStandardComponent::_txtQty
          loc_5082A6: br.s loc_5082A8
          loc_5082A8: // Referenced from: loc_5082A6
          loc_5082A8: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_5082AA: ldarg.0
          loc_5082AB: ldarg.1
          loc_5082AC: stfld GCUv2.frmSettingItemStandardComponent::_txtQty
          loc_5082B1: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_5082B3: ldarg.0
          loc_5082B4: ldfld GCUv2.frmSettingItemStandardComponent::_Label6
          loc_5082B9: br.s loc_5082BB
          loc_5082BB: // Referenced from: loc_5082B9
          loc_5082BB: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_5082BD: ldarg.0
          loc_5082BE: ldarg.1
          loc_5082BF: stfld GCUv2.frmSettingItemStandardComponent::_Label6
          loc_5082C4: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_5082C6: ldarg.0
          loc_5082C7: ldfld GCUv2.frmSettingItemStandardComponent::_cboItem
          loc_5082CC: br.s loc_5082CE
          loc_5082CE: // Referenced from: loc_5082CC
          loc_5082CE: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_5082D0: ldarg.0
          loc_5082D1: ldarg.1
          loc_5082D2: stfld GCUv2.frmSettingItemStandardComponent::_cboItem
          loc_5082D7: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_5082D9: ldarg.0
          loc_5082DA: ldfld GCUv2.frmSettingItemStandardComponent::_Label5
          loc_5082DF: br.s loc_5082E1
          loc_5082E1: // Referenced from: loc_5082DF
          loc_5082E1: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_5082E3: ldarg.0
          loc_5082E4: ldarg.1
          loc_5082E5: stfld GCUv2.frmSettingItemStandardComponent::_Label5
          loc_5082EA: ret
        }

        public void frmSettingItemStandardComponent(boolean CurrentData, int32 ProductionStepId) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSettingItemInputItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void cboStorage_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          boolean var_2;
          class ComboBox var_3;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          boolean var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;
          boolean var_7;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          loc_508767: nop
          loc_508768: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_50876D: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemStandardComponent/MyForms::get_frmSettingItemInput()
          loc_508772: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvStandardComponent()
          loc_508777: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_50877C: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_508781: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemStandardComponent/MyForms::get_frmSettingItemInput()
          loc_508786: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvStandardComponent()
          loc_50878B: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_508790: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_508795: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_50879A: nop
          loc_50879B: ldarg.0
          loc_50879C: call instance void System.Windows.Forms.Form::Close()
          loc_5087A1: nop
          loc_5087A2: ret
        }

    }
}
