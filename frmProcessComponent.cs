using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class GCUv2.FilteredTextBox _txtQty;
        private class Label _Label6;
        private class ComboBox _cboItem;
        private class Label _Label5;
        private class Label _Label4;
        private class Label _Label1;
        private class ComboBox _cboStorage;
        private class DateTimePicker _dtpComponent;
        private class Button _btnSave;
        private class Button _btnDelete;
        private boolean _currentData;
        private int32 _productionItemId;
        private class GCUv2.cComponent[] _component;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_523275: ldarg.0
          loc_523276: ldfld GCUv2.frmProcessComponent::_txtQty
          loc_52327B: br.s loc_52327D
          loc_52327D: // Referenced from: loc_52327B
          loc_52327D: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_52327F: ldarg.0
          loc_523280: ldarg.1
          loc_523281: stfld GCUv2.frmProcessComponent::_txtQty
          loc_523286: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_523288: ldarg.0
          loc_523289: ldfld GCUv2.frmProcessComponent::_Label6
          loc_52328E: br.s loc_523290
          loc_523290: // Referenced from: loc_52328E
          loc_523290: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_523292: ldarg.0
          loc_523293: ldarg.1
          loc_523294: stfld GCUv2.frmProcessComponent::_Label6
          loc_523299: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_52329B: ldarg.0
          loc_52329C: ldfld GCUv2.frmProcessComponent::_cboItem
          loc_5232A1: br.s loc_5232A3
          loc_5232A3: // Referenced from: loc_5232A1
          loc_5232A3: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_5232A5: ldarg.0
          loc_5232A6: ldarg.1
          loc_5232A7: stfld GCUv2.frmProcessComponent::_cboItem
          loc_5232AC: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_5232AE: ldarg.0
          loc_5232AF: ldfld GCUv2.frmProcessComponent::_Label5
          loc_5232B4: br.s loc_5232B6
          loc_5232B6: // Referenced from: loc_5232B4
          loc_5232B6: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_5232B8: ldarg.0
          loc_5232B9: ldarg.1
          loc_5232BA: stfld GCUv2.frmProcessComponent::_Label5
          loc_5232BF: ret
        }

        assem override strict specialname class Label get_Label4() {

          loc_5232C1: ldarg.0
          loc_5232C2: ldfld GCUv2.frmProcessComponent::_Label4
          loc_5232C7: br.s loc_5232C9
          loc_5232C9: // Referenced from: loc_5232C7
          loc_5232C9: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_5232CB: ldarg.0
          loc_5232CC: ldarg.1
          loc_5232CD: stfld GCUv2.frmProcessComponent::_Label4
          loc_5232D2: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_5232D4: ldarg.0
          loc_5232D5: ldfld GCUv2.frmProcessComponent::_Label1
          loc_5232DA: br.s loc_5232DC
          loc_5232DC: // Referenced from: loc_5232DA
          loc_5232DC: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_5232DE: ldarg.0
          loc_5232DF: ldarg.1
          loc_5232E0: stfld GCUv2.frmProcessComponent::_Label1
          loc_5232E5: ret
        }

        assem override strict specialname class ComboBox get_cboStorage() {

          loc_5232E7: ldarg.0
          loc_5232E8: ldfld GCUv2.frmProcessComponent::_cboStorage
          loc_5232ED: br.s loc_5232EF
          loc_5232EF: // Referenced from: loc_5232ED
          loc_5232EF: ret
        }

        assem override strict specialname void set_cboStorage(class ComboBox WithEventsValue) {

          loc_5232F1: ldarg.0
          loc_5232F2: ldarg.1
          loc_5232F3: stfld GCUv2.frmProcessComponent::_cboStorage
          loc_5232F8: ret
        }

        assem override strict specialname class DateTimePicker get_dtpComponent() {

          loc_5232FA: ldarg.0
          loc_5232FB: ldfld GCUv2.frmProcessComponent::_dtpComponent
          loc_523300: br.s loc_523302
          loc_523302: // Referenced from: loc_523300
          loc_523302: ret
        }

        assem override strict specialname void set_dtpComponent(class DateTimePicker WithEventsValue) {

          loc_523304: ldarg.0
          loc_523305: ldarg.1
          loc_523306: stfld GCUv2.frmProcessComponent::_dtpComponent
          loc_52330B: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_52330D: ldarg.0
          loc_52330E: ldfld GCUv2.frmProcessComponent::_btnSave
          loc_523313: br.s loc_523315
          loc_523315: // Referenced from: loc_523313
          loc_523315: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnDelete() {

          loc_52335C: ldarg.0
          loc_52335D: ldfld GCUv2.frmProcessComponent::_btnDelete
          loc_523362: br.s loc_523364
          loc_523364: // Referenced from: loc_523362
          loc_523364: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        public specialname class GCUv2.cComponent[] get_Component() {

          class GCUv2.cComponent[] var_1;

        }

        public specialname void set_Component(class GCUv2.cComponent[] value) {

          loc_5233C5: nop
          loc_5233C6: ldarg.0
          loc_5233C7: ldarg.1
          loc_5233C8: stfld GCUv2.frmProcessComponent::_component
          loc_5233CD: ret
        }

        public void frmProcessComponent(boolean CurrentData, int32 ProductionItemId) {

          int32 num_1;
          int32 num_2;
          class ComboBox var_1;
          boolean var_2;

        }

        private void frmProcessComponent_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cComboItem var_2;
          double flt_1;
          valuetype System.DateTime var_3;
          int32 num_1;
          int32 num_2;
          int32 num_3;
          boolean var_4;
          boolean var_5;
          class GCUv2.cComponent[] var_6;
          int32 num_4;
          class GCUv2.cComponent var_7;
          boolean var_8;
          boolean var_9;
          int32 num_5;
          boolean var_10;
          boolean var_11;
          boolean var_12;
          boolean var_13;
          boolean var_14;
          boolean var_15;
          boolean var_16;
          boolean var_17;
          boolean var_18;
          boolean var_19;
          boolean var_20;

        }

        private void btnDelete_Click(object sender, class System.EventArgs e) {

          loc_523AEF: nop
          loc_523AF0: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_523AF5: callvirt instance class GCUv2.frmProcess GCUv2.frmProcessComponent/MyForms::get_frmProcess()
          loc_523AFA: callvirt instance class DataGridView GCUv2.frmProcess::get_dgvList()
          loc_523AFF: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_523B04: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_523B09: callvirt instance class GCUv2.frmProcess GCUv2.frmProcessComponent/MyForms::get_frmProcess()
          loc_523B0E: callvirt instance class DataGridView GCUv2.frmProcess::get_dgvList()
          loc_523B13: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_523B18: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_523B1D: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_523B22: nop
          loc_523B23: ldarg.0
          loc_523B24: call instance void System.Windows.Forms.Form::Close()
          loc_523B29: nop
          loc_523B2A: ret
        }

    }
}
