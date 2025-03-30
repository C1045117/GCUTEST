using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblTitle;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbNew;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_4A3206: ldarg.0
          loc_4A3207: ldfld GCUv2.frmReceivedItemList::_lblTitle
          loc_4A320C: br.s loc_4A320E
          loc_4A320E: // Referenced from: loc_4A320C
          loc_4A320E: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_4A3210: ldarg.0
          loc_4A3211: ldarg.1
          loc_4A3212: stfld GCUv2.frmReceivedItemList::_lblTitle
          loc_4A3217: ret
        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_4A3219: ldarg.0
          loc_4A321A: ldfld GCUv2.frmReceivedItemList::_dgvList
          loc_4A321F: br.s loc_4A3221
          loc_4A3221: // Referenced from: loc_4A321F
          loc_4A3221: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_4A3283: ldarg.0
          loc_4A3284: ldfld GCUv2.frmReceivedItemList::_ToolStrip1
          loc_4A3289: br.s loc_4A328B
          loc_4A328B: // Referenced from: loc_4A3289
          loc_4A328B: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_4A328D: ldarg.0
          loc_4A328E: ldarg.1
          loc_4A328F: stfld GCUv2.frmReceivedItemList::_ToolStrip1
          loc_4A3294: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_4A3296: ldarg.0
          loc_4A3297: ldfld GCUv2.frmReceivedItemList::_tsbNew
          loc_4A329C: br.s loc_4A329E
          loc_4A329E: // Referenced from: loc_4A329C
          loc_4A329E: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_4A32E4: ldarg.0
          loc_4A32E5: ldfld GCUv2.frmReceivedItemList::_tsbRefresh
          loc_4A32EA: br.s loc_4A32EC
          loc_4A32EC: // Referenced from: loc_4A32EA
          loc_4A32EC: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmReceivedItemList() {


        }

        private void frmReceivedItemList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;

        }

        public void GetRecent() {

          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;

        }

        private void FormatGrid() {


        }

        private void dgvList_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void dgvList_DoubleClick(object sender, class System.EventArgs e) {

          loc_4A3863: nop
          loc_4A3864: ldarg.0
          loc_4A3865: call instance void GCUv2.frmReceivedItemList::openSelection()
          loc_4A386A: nop
          loc_4A386B: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_4A394A: nop
          loc_4A394B: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A3950: callvirt instance class GCUv2.frmReceivedItem GCUv2.frmReceivedItemList/MyForms::get_frmReceivedItem()
          loc_4A3955: callvirt instance void System.Windows.Forms.Control::Show()
          loc_4A395A: nop
          loc_4A395B: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A3960: callvirt instance class GCUv2.frmReceivedItem GCUv2.frmReceivedItemList/MyForms::get_frmReceivedItem()
          loc_4A3965: ldc.i4.0
          loc_4A3966: callvirt instance void GCUv2.frmReceivedItem::prepareForm(boolean)
          loc_4A396B: nop
          loc_4A396C: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_4A3971: callvirt instance class GCUv2.frmReceivedItem GCUv2.frmReceivedItemList/MyForms::get_frmReceivedItem()
          loc_4A3976: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_4A397B: nop
          loc_4A397C: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_4A397E: nop
          loc_4A397F: ldarg.0
          loc_4A3980: call instance void GCUv2.frmReceivedItemList::GetRecent()
          loc_4A3985: nop
          loc_4A3986: ret
        }

    }
}
