using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnHistory;
        private class Button _btnSaveClose;
        private class Label _Label11;
        private class Label _Label1;
        private class DateTimePicker _dtpDeposit;
        private class CheckBox _chkNoDeposit;
        private class CheckBox _chkDeposit;
        private class CheckBox _chkClearing;
        private class CheckBox _chkNoClearing;
        private class Label _Label2;
        private class DateTimePicker _dtpClearing;
        private class Label _Label5;
        private class Label _Label6;
        private class Label _Label7;
        private class Label _Label8;
        private class Label _lblChequeDate;
        private class Label _lblChequeNo;
        private class Label _lblAmount;
        private class Label _lblAccountName;
        private double _currentId;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnHistory() {

          loc_4359C9: ldarg.0
          loc_4359CA: ldfld GCUv2.frmChequeIn::_btnHistory
          loc_4359CF: br.s loc_4359D1
          loc_4359D1: // Referenced from: loc_4359CF
          loc_4359D1: ret
        }

        assem override strict specialname void set_btnHistory(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Button get_btnSaveClose() {

          loc_435A18: ldarg.0
          loc_435A19: ldfld GCUv2.frmChequeIn::_btnSaveClose
          loc_435A1E: br.s loc_435A20
          loc_435A20: // Referenced from: loc_435A1E
          loc_435A20: ret
        }

        assem override strict specialname void set_btnSaveClose(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label11() {

          loc_435A68: ldarg.0
          loc_435A69: ldfld GCUv2.frmChequeIn::_Label11
          loc_435A6E: br.s loc_435A70
          loc_435A70: // Referenced from: loc_435A6E
          loc_435A70: ret
        }

        assem override strict specialname void set_Label11(class Label WithEventsValue) {

          loc_435A72: ldarg.0
          loc_435A73: ldarg.1
          loc_435A74: stfld GCUv2.frmChequeIn::_Label11
          loc_435A79: ret
        }

        assem override strict specialname class Label get_Label1() {

          loc_435A7B: ldarg.0
          loc_435A7C: ldfld GCUv2.frmChequeIn::_Label1
          loc_435A81: br.s loc_435A83
          loc_435A83: // Referenced from: loc_435A81
          loc_435A83: ret
        }

        assem override strict specialname void set_Label1(class Label WithEventsValue) {

          loc_435A85: ldarg.0
          loc_435A86: ldarg.1
          loc_435A87: stfld GCUv2.frmChequeIn::_Label1
          loc_435A8C: ret
        }

        assem override strict specialname class DateTimePicker get_dtpDeposit() {

          loc_435A8E: ldarg.0
          loc_435A8F: ldfld GCUv2.frmChequeIn::_dtpDeposit
          loc_435A94: br.s loc_435A96
          loc_435A96: // Referenced from: loc_435A94
          loc_435A96: ret
        }

        assem override strict specialname void set_dtpDeposit(class DateTimePicker WithEventsValue) {

          loc_435A98: ldarg.0
          loc_435A99: ldarg.1
          loc_435A9A: stfld GCUv2.frmChequeIn::_dtpDeposit
          loc_435A9F: ret
        }

        assem override strict specialname class CheckBox get_chkNoDeposit() {

          loc_435AA1: ldarg.0
          loc_435AA2: ldfld GCUv2.frmChequeIn::_chkNoDeposit
          loc_435AA7: br.s loc_435AA9
          loc_435AA9: // Referenced from: loc_435AA7
          loc_435AA9: ret
        }

        assem override strict specialname void set_chkNoDeposit(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class CheckBox get_chkDeposit() {

          loc_435AF0: ldarg.0
          loc_435AF1: ldfld GCUv2.frmChequeIn::_chkDeposit
          loc_435AF6: br.s loc_435AF8
          loc_435AF8: // Referenced from: loc_435AF6
          loc_435AF8: ret
        }

        assem override strict specialname void set_chkDeposit(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class CheckBox get_chkClearing() {

          loc_435B40: ldarg.0
          loc_435B41: ldfld GCUv2.frmChequeIn::_chkClearing
          loc_435B46: br.s loc_435B48
          loc_435B48: // Referenced from: loc_435B46
          loc_435B48: ret
        }

        assem override strict specialname void set_chkClearing(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class CheckBox get_chkNoClearing() {

          loc_435B90: ldarg.0
          loc_435B91: ldfld GCUv2.frmChequeIn::_chkNoClearing
          loc_435B96: br.s loc_435B98
          loc_435B98: // Referenced from: loc_435B96
          loc_435B98: ret
        }

        assem override strict specialname void set_chkNoClearing(class CheckBox WithEventsValue) {

          class System.EventHandler var_1;
          class CheckBox var_2;

        }

        assem override strict specialname class Label get_Label2() {

          loc_435BE0: ldarg.0
          loc_435BE1: ldfld GCUv2.frmChequeIn::_Label2
          loc_435BE6: br.s loc_435BE8
          loc_435BE8: // Referenced from: loc_435BE6
          loc_435BE8: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_435BEA: ldarg.0
          loc_435BEB: ldarg.1
          loc_435BEC: stfld GCUv2.frmChequeIn::_Label2
          loc_435BF1: ret
        }

        assem override strict specialname class DateTimePicker get_dtpClearing() {

          loc_435BF3: ldarg.0
          loc_435BF4: ldfld GCUv2.frmChequeIn::_dtpClearing
          loc_435BF9: br.s loc_435BFB
          loc_435BFB: // Referenced from: loc_435BF9
          loc_435BFB: ret
        }

        assem override strict specialname void set_dtpClearing(class DateTimePicker WithEventsValue) {

          loc_435BFD: ldarg.0
          loc_435BFE: ldarg.1
          loc_435BFF: stfld GCUv2.frmChequeIn::_dtpClearing
          loc_435C04: ret
        }

        assem override strict specialname class Label get_Label5() {

          loc_435C06: ldarg.0
          loc_435C07: ldfld GCUv2.frmChequeIn::_Label5
          loc_435C0C: br.s loc_435C0E
          loc_435C0E: // Referenced from: loc_435C0C
          loc_435C0E: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_435C10: ldarg.0
          loc_435C11: ldarg.1
          loc_435C12: stfld GCUv2.frmChequeIn::_Label5
          loc_435C17: ret
        }

        assem override strict specialname class Label get_Label6() {

          loc_435C19: ldarg.0
          loc_435C1A: ldfld GCUv2.frmChequeIn::_Label6
          loc_435C1F: br.s loc_435C21
          loc_435C21: // Referenced from: loc_435C1F
          loc_435C21: ret
        }

        assem override strict specialname void set_Label6(class Label WithEventsValue) {

          loc_435C23: ldarg.0
          loc_435C24: ldarg.1
          loc_435C25: stfld GCUv2.frmChequeIn::_Label6
          loc_435C2A: ret
        }

        assem override strict specialname class Label get_Label7() {

          loc_435C2C: ldarg.0
          loc_435C2D: ldfld GCUv2.frmChequeIn::_Label7
          loc_435C32: br.s loc_435C34
          loc_435C34: // Referenced from: loc_435C32
          loc_435C34: ret
        }

        assem override strict specialname void set_Label7(class Label WithEventsValue) {

          loc_435C36: ldarg.0
          loc_435C37: ldarg.1
          loc_435C38: stfld GCUv2.frmChequeIn::_Label7
          loc_435C3D: ret
        }

        assem override strict specialname class Label get_Label8() {

          loc_435C3F: ldarg.0
          loc_435C40: ldfld GCUv2.frmChequeIn::_Label8
          loc_435C45: br.s loc_435C47
          loc_435C47: // Referenced from: loc_435C45
          loc_435C47: ret
        }

        assem override strict specialname void set_Label8(class Label WithEventsValue) {

          loc_435C49: ldarg.0
          loc_435C4A: ldarg.1
          loc_435C4B: stfld GCUv2.frmChequeIn::_Label8
          loc_435C50: ret
        }

        assem override strict specialname class Label get_lblChequeDate() {

          loc_435C52: ldarg.0
          loc_435C53: ldfld GCUv2.frmChequeIn::_lblChequeDate
          loc_435C58: br.s loc_435C5A
          loc_435C5A: // Referenced from: loc_435C58
          loc_435C5A: ret
        }

        assem override strict specialname void set_lblChequeDate(class Label WithEventsValue) {

          loc_435C5C: ldarg.0
          loc_435C5D: ldarg.1
          loc_435C5E: stfld GCUv2.frmChequeIn::_lblChequeDate
          loc_435C63: ret
        }

        assem override strict specialname class Label get_lblChequeNo() {

          loc_435C65: ldarg.0
          loc_435C66: ldfld GCUv2.frmChequeIn::_lblChequeNo
          loc_435C6B: br.s loc_435C6D
          loc_435C6D: // Referenced from: loc_435C6B
          loc_435C6D: ret
        }

        assem override strict specialname void set_lblChequeNo(class Label WithEventsValue) {

          loc_435C6F: ldarg.0
          loc_435C70: ldarg.1
          loc_435C71: stfld GCUv2.frmChequeIn::_lblChequeNo
          loc_435C76: ret
        }

        assem override strict specialname class Label get_lblAmount() {

          loc_435C78: ldarg.0
          loc_435C79: ldfld GCUv2.frmChequeIn::_lblAmount
          loc_435C7E: br.s loc_435C80
          loc_435C80: // Referenced from: loc_435C7E
          loc_435C80: ret
        }

        assem override strict specialname void set_lblAmount(class Label WithEventsValue) {

          loc_435C82: ldarg.0
          loc_435C83: ldarg.1
          loc_435C84: stfld GCUv2.frmChequeIn::_lblAmount
          loc_435C89: ret
        }

        assem override strict specialname class Label get_lblAccountName() {

          loc_435C8B: ldarg.0
          loc_435C8C: ldfld GCUv2.frmChequeIn::_lblAccountName
          loc_435C91: br.s loc_435C93
          loc_435C93: // Referenced from: loc_435C91
          loc_435C93: ret
        }

        assem override strict specialname void set_lblAccountName(class Label WithEventsValue) {

          loc_435C95: ldarg.0
          loc_435C96: ldarg.1
          loc_435C97: stfld GCUv2.frmChequeIn::_lblAccountName
          loc_435C9C: ret
        }

        public specialname double get_CurrentId() {

          double flt_1;

        }

        public specialname void set_CurrentId(double value) {

          loc_435CB9: nop
          loc_435CBA: ldarg.0
          loc_435CBB: ldarg.1
          loc_435CBC: stfld GCUv2.frmChequeIn::_currentId
          loc_435CC1: ret
        }

        public void frmChequeIn() {

          loc_435CC3: nop
          loc_435CC4: ldarg.0
          loc_435CC5: call instance void System.Windows.Forms.Form::.ctor()
          loc_435CCA: nop
          loc_435CCB: ldarg.0
          loc_435CCC: ldarg.0
          loc_435CCD: ldftn instance void GCUv2.frmChequeIn::frmChequeIn_KeyDown(object, class KeyEventArgs)
          loc_435CD3: newobj instance void System.Windows.Forms.KeyEventHandler::.ctor(object, System.IntPtr)
          loc_435CD8: call instance void System.Windows.Forms.Control::add_KeyDown(class KeyEventHandler)
          loc_435CDD: nop
          loc_435CDE: ldarg.0
          loc_435CDF: call instance void GCUv2.frmChequeIn::InitializeComponent()
          loc_435CE4: nop
          loc_435CE5: ldarg.0
          loc_435CE6: ldc.i4.1
          loc_435CE7: callvirt instance void System.Windows.Forms.Control::set_DoubleBuffered(boolean)
          loc_435CEC: nop
          loc_435CED: ldarg.0
          loc_435CEE: call class MyForms GCUv2.My.MyProject::get_Forms()
          loc_435CF3: callvirt instance class GCUv2.frmMenu GCUv2.frmChequeIn/MyForms::get_frmMenu()
          loc_435CF8: call 
          loc_435CFD: nop
          loc_435CFE: ret
        }

        private void frmChequeIn_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        public void prepareForm() {

          int32 num_1;
          int32 num_2;

        }

        public void LoadData() {

          int32 num_1;
          int32 num_2;
          class GCUv2.cChequeIn var_1;
          boolean var_2;
          boolean var_3;
          boolean var_4;

        }

        private void chkNoDeposit_CheckedChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void chkDeposit_CheckedChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void chkNoClearing_CheckedChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void chkClearing_CheckedChanged(object sender, class System.EventArgs e) {

          boolean var_1;

        }

        private void btnSaveClose_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          boolean var_1;
          boolean var_2;
          string str_1;
          string str_2;
          class GCUv2.cHistory var_3;
          boolean var_4;
          boolean var_5;
          boolean var_6;

        }

        private void btnHistory_Click(object sender, class System.EventArgs e) {


        }

    }
}
