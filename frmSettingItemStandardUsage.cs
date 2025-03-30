using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _Label4;
        private class ComboBox _cboBranch;
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

        assem override strict specialname class Label get_Label4() {

          loc_4F1429: ldarg.0
          loc_4F142A: ldfld GCUv2.frmSettingItemStandardUsage::_Label4
          loc_4F142F: br.s loc_4F1431
          loc_4F1431: // Referenced from: loc_4F142F
          loc_4F1431: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_4F1433: ldarg.0
          loc_4F1434: ldarg.1
          loc_4F1435: stfld GCUv2.frmSettingItemStandardUsage::_Label4
          loc_4F143A: ret
        }

        assem override strict specialname class ComboBox get_cboBranch() {

          loc_4F143C: ldarg.0
          loc_4F143D: ldfld GCUv2.frmSettingItemStandardUsage::_cboBranch
          loc_4F1442: br.s loc_4F1444
          loc_4F1444: // Referenced from: loc_4F1442
          loc_4F1444: ret
        }

        assem override strict specialname void set_cboBranch(class ComboBox WithEventsValue) {

          loc_4F1446: ldarg.0
          loc_4F1447: ldarg.1
          loc_4F1448: stfld GCUv2.frmSettingItemStandardUsage::_cboBranch
          loc_4F144D: ret
        }

        assem override strict specialname class Button get_btnDelete() {

          loc_4F144F: ldarg.0
          loc_4F1450: ldfld GCUv2.frmSettingItemStandardUsage::_btnDelete
          loc_4F1455: br.s loc_4F1457
          loc_4F1457: // Referenced from: loc_4F1455
          loc_4F1457: ret
        }

        assem override strict specialname void set_btnDelete(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSave() {

          loc_4F149C: ldarg.0
          loc_4F149D: ldfld GCUv2.frmSettingItemStandardUsage::_btnSave
          loc_4F14A2: br.s loc_4F14A4
          loc_4F14A4: // Referenced from: loc_4F14A2
          loc_4F14A4: ret
        }

        assem override strict specialname void set_btnSave(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class GCUv2.FilteredTextBox get_txtQty() {

          loc_4F14EC: ldarg.0
          loc_4F14ED: ldfld GCUv2.frmSettingItemStandardUsage::_txtQty
          loc_4F14F2: br.s loc_4F14F4
          loc_4F14F4: // Referenced from: loc_4F14F2
          loc_4F14F4: ret
        }

        assem override strict specialname void set_txtQty(class GCUv2.FilteredTextBox WithEventsValue) {

          loc_4F14F6: ldarg.0
          loc_4F14F7: ldarg.1
          loc_4F14F8: stfld GCUv2.frmSettingItemStandardUsage::_txtQty
          loc_4F14FD: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_4F14FF: ldarg.0
          loc_4F1500: ldfld GCUv2.frmSettingItemStandardUsage::_Label6
          loc_4F1505: br.s loc_4F1507
          loc_4F1507: // Referenced from: loc_4F1505
          loc_4F1507: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_4F1509: ldarg.0
          loc_4F150A: ldarg.1
          loc_4F150B: stfld GCUv2.frmSettingItemStandardUsage::_Label6
          loc_4F1510: ret
        }

        assem override strict specialname class ComboBox get_cboItem() {

          loc_4F1512: ldarg.0
          loc_4F1513: ldfld GCUv2.frmSettingItemStandardUsage::_cboItem
          loc_4F1518: br.s loc_4F151A
          loc_4F151A: // Referenced from: loc_4F1518
          loc_4F151A: ret
        }

        assem override strict specialname void set_cboItem(class ComboBox WithEventsValue) {

          loc_4F151C: ldarg.0
          loc_4F151D: ldarg.1
          loc_4F151E: stfld GCUv2.frmSettingItemStandardUsage::_cboItem
          loc_4F1523: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_4F1525: ldarg.0
          loc_4F1526: ldfld GCUv2.frmSettingItemStandardUsage::_Label5
          loc_4F152B: br.s loc_4F152D
          loc_4F152D: // Referenced from: loc_4F152B
          loc_4F152D: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_4F152F: ldarg.0
          loc_4F1530: ldarg.1
          loc_4F1531: stfld GCUv2.frmSettingItemStandardUsage::_Label5
          loc_4F1536: ret
        }

        public void frmSettingItemStandardUsage(boolean CurrentData) {

          class ComboBox var_1;
          boolean var_2;

        }

        private void frmSettingItemStandardUsage_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

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

          loc_4F1953: nop
          loc_4F1954: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4F1959: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemStandardUsage/MyForms::get_frmSettingItemInput()
          loc_4F195E: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvStandardUsage()
          loc_4F1963: callvirt instance class DataGridViewRowCollection System.Windows.Forms.DataGridView::get_Rows()
          loc_4F1968: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4F196D: callvirt instance class GCUv2.frmSettingItemInput GCUv2.frmSettingItemStandardUsage/MyForms::get_frmSettingItemInput()
          loc_4F1972: callvirt instance class DataGridView GCUv2.frmSettingItemInput::get_dgvStandardUsage()
          loc_4F1977: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_4F197C: callvirt instance int32 System.Windows.Forms.DataGridViewBand::get_Index()
          loc_4F1981: callvirt instance void System.Windows.Forms.DataGridViewRowCollection::RemoveAt(int32)
          loc_4F1986: nop
          loc_4F1987: ldarg.0
          loc_4F1988: call instance void System.Windows.Forms.Form::Close()
          loc_4F198D: nop
          loc_4F198E: ret
        }

    }
}
