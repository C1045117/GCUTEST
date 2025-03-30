using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblTitle;
        private class ToolStripButton _tsbNew;
        private class DataGridView _dgvList;
        private class ToolStrip _ToolStrip1;
        private class ToolStripButton _tsbRefresh;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {

          class ComponentModel.ComponentResourceManager var_1;

        }

        assem override strict specialname class Label get_lblTitle() {

          loc_44D1B6: ldarg.0
          loc_44D1B7: ldfld GCUv2.frmDeliveryOrderList::_lblTitle
          loc_44D1BC: br.s loc_44D1BE
          loc_44D1BE: // Referenced from: loc_44D1BC
          loc_44D1BE: ret
        }

        assem override strict specialname void set_lblTitle(class Label WithEventsValue) {

          loc_44D1C0: ldarg.0
          loc_44D1C1: ldarg.1
          loc_44D1C2: stfld GCUv2.frmDeliveryOrderList::_lblTitle
          loc_44D1C7: ret
        }

        assem override strict specialname class ToolStripButton get_tsbNew() {

          loc_44D1C9: ldarg.0
          loc_44D1CA: ldfld GCUv2.frmDeliveryOrderList::_tsbNew
          loc_44D1CF: br.s loc_44D1D1
          loc_44D1D1: // Referenced from: loc_44D1CF
          loc_44D1D1: ret
        }

        assem override strict specialname void set_tsbNew(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        assem override strict specialname class DataGridView get_dgvList() {

          loc_44D218: ldarg.0
          loc_44D219: ldfld GCUv2.frmDeliveryOrderList::_dgvList
          loc_44D21E: br.s loc_44D220
          loc_44D220: // Referenced from: loc_44D21E
          loc_44D220: ret
        }

        assem override strict specialname void set_dgvList(class DataGridView WithEventsValue) {

          class KeyEventHandler var_1;
          class System.EventHandler var_2;
          class DataGridView var_3;

        }

        assem override strict specialname class ToolStrip get_ToolStrip1() {

          loc_44D283: ldarg.0
          loc_44D284: ldfld GCUv2.frmDeliveryOrderList::_ToolStrip1
          loc_44D289: br.s loc_44D28B
          loc_44D28B: // Referenced from: loc_44D289
          loc_44D28B: ret
        }

        assem override strict specialname void set_ToolStrip1(class ToolStrip WithEventsValue) {

          loc_44D28D: ldarg.0
          loc_44D28E: ldarg.1
          loc_44D28F: stfld GCUv2.frmDeliveryOrderList::_ToolStrip1
          loc_44D294: ret
        }

        assem override strict specialname class ToolStripButton get_tsbRefresh() {

          loc_44D296: ldarg.0
          loc_44D297: ldfld GCUv2.frmDeliveryOrderList::_tsbRefresh
          loc_44D29C: br.s loc_44D29E
          loc_44D29E: // Referenced from: loc_44D29C
          loc_44D29E: ret
        }

        assem override strict specialname void set_tsbRefresh(class ToolStripButton WithEventsValue) {

          class System.EventHandler var_1;
          class ToolStripButton var_2;

        }

        public void frmDeliveryOrderList() {


        }

        private void frmDeliveryOrderList_KeyDown(object sender, class KeyEventArgs e) {

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

          loc_44D83F: nop
          loc_44D840: ldarg.0
          loc_44D841: call instance void GCUv2.frmDeliveryOrderList::openSelection()
          loc_44D846: nop
          loc_44D847: ret
        }

        private void openSelection() {

          boolean var_1;

        }

        private void tsbNew_Click(object sender, class System.EventArgs e) {

          loc_44D926: nop
          loc_44D927: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_44D92C: callvirt instance class GCUv2.frmDeliveryOrder GCUv2.frmDeliveryOrderList/MyForms::get_frmDeliveryOrder()
          loc_44D931: callvirt instance void System.Windows.Forms.Control::Show()
          loc_44D936: nop
          loc_44D937: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_44D93C: callvirt instance class GCUv2.frmDeliveryOrder GCUv2.frmDeliveryOrderList/MyForms::get_frmDeliveryOrder()
          loc_44D941: ldc.i4.0
          loc_44D942: callvirt instance void GCUv2.frmDeliveryOrder::prepareForm(boolean)
          loc_44D947: nop
          loc_44D948: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_44D94D: callvirt instance class GCUv2.frmDeliveryOrder GCUv2.frmDeliveryOrderList/MyForms::get_frmDeliveryOrder()
          loc_44D952: callvirt instance void System.Windows.Forms.Form::Activate()
          loc_44D957: nop
          loc_44D958: ret
        }

        private void tsbRefresh_Click(object sender, class System.EventArgs e) {

          loc_44D95A: nop
          loc_44D95B: ldarg.0
          loc_44D95C: call instance void GCUv2.frmDeliveryOrderList::GetRecent()
          loc_44D961: nop
          loc_44D962: ret
        }

    }
}
