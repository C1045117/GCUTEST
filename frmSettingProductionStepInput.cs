using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label1;
        private class ComboBox _cboStep;
        private class Label _Label2;
        private class Button _btnSave;
        private class Label _Label3;
        private class DataGridView _dgvItem;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_Label1() {

          loc_508BE2: ldarg.0
          loc_508BE3: ldfld GCUv2.frmSettingProductionStepInput::_Label1
          loc_508BE8: br.s loc_508BEA
          loc_508BEA: // Referenced from: loc_508BE8
          loc_508BEA: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_508BEC: ldarg.0
          loc_508BED: ldarg.1
          loc_508BEE: stfld GCUv2.frmSettingProductionStepInput::_Label1
          loc_508BF3: ret
        }

        assem override strict specialname class ComboBox get_cboStep() {

          loc_508BF5: ldarg.0
          loc_508BF6: ldfld GCUv2.frmSettingProductionStepInput::_cboStep
          loc_508BFB: br.s loc_508BFD
          loc_508BFD: // Referenced from: loc_508BFB
          loc_508BFD: ret
        }

        assem override strict specialname void set_cboStep(class ComboBox WithEventsValue) {

          class System.EventHandler var_1;
          class ComboBox var_2;

        }

        assem override strict specialname class Label get_Label2() {

          loc_508C44: ldarg.0
          loc_508C45: ldfld GCUv2.frmSettingProductionStepInput::_Label2
          loc_508C4A: br.s loc_508C4C
          loc_508C4C: // Referenced from: loc_508C4A
          loc_508C4C: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_508C4E: ldarg.0
          loc_508C4F: ldarg.1
          loc_508C50: stfld GCUv2.frmSettingProductionStepInput::_Label2
          loc_508C55: ret
        }

        assem override strict specialname class Button get_btnSave() {

          loc_508C57: ldarg.0
          loc_508C58: ldfld GCUv2.frmSettingProductionStepInput::_btnSave
          loc_508C5D: br.s loc_508C5F
          loc_508C5F: // Referenced from: loc_508C5D
          loc_508C5F: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label3() {

          loc_508CA4: ldarg.0
          loc_508CA5: ldfld GCUv2.frmSettingProductionStepInput::_Label3
          loc_508CAA: br.s loc_508CAC
          loc_508CAC: // Referenced from: loc_508CAA
          loc_508CAC: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_508CAE: ldarg.0
          loc_508CAF: ldarg.1
          loc_508CB0: stfld GCUv2.frmSettingProductionStepInput::_Label3
          loc_508CB5: ret
        }

        assem override strict specialname class DataGridView get_dgvItem() {

          loc_508CB7: ldarg.0
          loc_508CB8: ldfld GCUv2.frmSettingProductionStepInput::_dgvItem
          loc_508CBD: br.s loc_508CBF
          loc_508CBF: // Referenced from: loc_508CBD
          loc_508CBF: ret
        }

        assem override strict specialname void set_dgvItem(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class System.EventHandler var_3;
          class DataGridView var_4;

        }

        public void frmSettingProductionStepInput() {


        }

        private void frmSettingComponen_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void frmSettingComponen_Load(object sender, class System.EventArgs e) {

          class ComboBox var_1;

        }

        private void FormatGrid() {

          class DataGridViewCheckBoxColumn var_1;

        }

        private void dgvItem_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        private void dgvItem_GotFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void dgvItem_LostFocus(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSave_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class GCUv2.cComboItem var_1;
          class GCUv2.cStep var_2;
          int32 num_3;
          class GCUv2.cStepItem[] var_3;
          boolean var_4;
          int32 num_4;
          int32 num_5;
          boolean var_5;

        }

        private void cboStep_SelectedIndexChanged(object sender, class System.EventArgs e) {

          class GCUv2.cComboItem var_1;
          class GCUv2.cStep var_2;
          int32 num_1;
          class GCUv2.cStepItem[] var_3;
          int32 num_2;
          class GCUv2.cStepItem var_4;
          boolean var_5;
          boolean var_6;

        }

    }
}
