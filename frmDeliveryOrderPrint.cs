using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnPrintLetter;
        private class DataGridView _dgvItemLetter;
        private class Label _lblInvoiceNoLetter;
        private class Label _lblAddressLetter;
        private class Label _lblNameLetter;
        private class Label _lblYthLetter;
        private class Label _lblDateLetter;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnPrintLetter() {

          loc_44DE36: ldarg.0
          loc_44DE37: ldfld GCUv2.frmDeliveryOrderPrint::_btnPrintLetter
          loc_44DE3C: br.s loc_44DE3E
          loc_44DE3E: // Referenced from: loc_44DE3C
          loc_44DE3E: ret
        }

        assem override strict specialname void set_btnPrintLetter(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class DataGridView get_dgvItemLetter() {

          loc_44DE84: ldarg.0
          loc_44DE85: ldfld GCUv2.frmDeliveryOrderPrint::_dgvItemLetter
          loc_44DE8A: br.s loc_44DE8C
          loc_44DE8C: // Referenced from: loc_44DE8A
          loc_44DE8C: ret
        }

        assem override strict specialname void set_dgvItemLetter(class DataGridView WithEventsValue) {

          loc_44DE8E: ldarg.0
          loc_44DE8F: ldarg.1
          loc_44DE90: stfld GCUv2.frmDeliveryOrderPrint::_dgvItemLetter
          loc_44DE95: ret
        }

        assem override strict specialname class Label get_lblInvoiceNoLetter() {

          loc_44DE97: ldarg.0
          loc_44DE98: ldfld GCUv2.frmDeliveryOrderPrint::_lblInvoiceNoLetter
          loc_44DE9D: br.s loc_44DE9F
          loc_44DE9F: // Referenced from: loc_44DE9D
          loc_44DE9F: ret
        }

        assem override strict specialname void set_lblInvoiceNoLetter(class Label WithEventsValue) {

          loc_44DEA1: ldarg.0
          loc_44DEA2: ldarg.1
          loc_44DEA3: stfld GCUv2.frmDeliveryOrderPrint::_lblInvoiceNoLetter
          loc_44DEA8: ret
        }

        assem override strict specialname class Label get_lblAddressLetter() {

          loc_44DEAA: ldarg.0
          loc_44DEAB: ldfld GCUv2.frmDeliveryOrderPrint::_lblAddressLetter
          loc_44DEB0: br.s loc_44DEB2
          loc_44DEB2: // Referenced from: loc_44DEB0
          loc_44DEB2: ret
        }

        assem override strict specialname void set_lblAddressLetter(class Label WithEventsValue) {

          loc_44DEB4: ldarg.0
          loc_44DEB5: ldarg.1
          loc_44DEB6: stfld GCUv2.frmDeliveryOrderPrint::_lblAddressLetter
          loc_44DEBB: ret
        }

        assem override strict specialname class Label get_lblNameLetter() {

          loc_44DEBD: ldarg.0
          loc_44DEBE: ldfld GCUv2.frmDeliveryOrderPrint::_lblNameLetter
          loc_44DEC3: br.s loc_44DEC5
          loc_44DEC5: // Referenced from: loc_44DEC3
          loc_44DEC5: ret
        }

        assem override strict specialname void set_lblNameLetter(class Label WithEventsValue) {

          loc_44DEC7: ldarg.0
          loc_44DEC8: ldarg.1
          loc_44DEC9: stfld GCUv2.frmDeliveryOrderPrint::_lblNameLetter
          loc_44DECE: ret
        }

        assem override strict specialname class Label get_lblYthLetter() {

          loc_44DED0: ldarg.0
          loc_44DED1: ldfld GCUv2.frmDeliveryOrderPrint::_lblYthLetter
          loc_44DED6: br.s loc_44DED8
          loc_44DED8: // Referenced from: loc_44DED6
          loc_44DED8: ret
        }

        assem override strict specialname void set_lblYthLetter(class Label WithEventsValue) {

          loc_44DEDA: ldarg.0
          loc_44DEDB: ldarg.1
          loc_44DEDC: stfld GCUv2.frmDeliveryOrderPrint::_lblYthLetter
          loc_44DEE1: ret
        }

        assem override strict specialname class Label get_lblDateLetter() {

          loc_44DEE3: ldarg.0
          loc_44DEE4: ldfld GCUv2.frmDeliveryOrderPrint::_lblDateLetter
          loc_44DEE9: br.s loc_44DEEB
          loc_44DEEB: // Referenced from: loc_44DEE9
          loc_44DEEB: ret
        }

        assem override strict specialname void set_lblDateLetter(class Label WithEventsValue) {

          loc_44DEED: ldarg.0
          loc_44DEEE: ldarg.1
          loc_44DEEF: stfld GCUv2.frmDeliveryOrderPrint::_lblDateLetter
          loc_44DEF4: ret
        }

        public void frmDeliveryOrderPrint() {


        }

        private void formatGrid() {


        }

        private void frmDeliveryOrderPrint_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void frmDeliveryOrderPrint_Load(object sender, class System.EventArgs e) {

          loc_44E106: nop
          loc_44E107: ldarg.0
          loc_44E108: callvirt instance class DataGridView GCUv2.frmDeliveryOrderPrint::get_dgvItemLetter()
          loc_44E10D: callvirt instance class DataGridViewRow System.Windows.Forms.DataGridView::get_CurrentRow()
          loc_44E112: ldc.i4.0
          loc_44E113: callvirt instance void System.Windows.Forms.DataGridViewRow::set_Selected(boolean)
          loc_44E118: nop
          loc_44E119: ret
        }

        private void btnPrintLetter_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          class Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6.Printer var_1;
          int32 num_3;
          int32 num_4;
          int32 num_5;
          double flt_1;
          string[] var_2;
          int32 num_6;
          int32 num_7;
          int32 num_8;

        }

    }
}
