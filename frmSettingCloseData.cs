using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Label _lblDate;
        private class Label _Label2;
        private class DateTimePicker _dtpCloseData;
        private class Button _btnCloseData;
        private class Label _Label5;
        private class Label _Label3;
        private class TextBox _txtConfirmation;
        private class Button _btnUpdate;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Label get_lblDate() {

          loc_505D49: ldarg.0
          loc_505D4A: ldfld GCUv2.frmSettingCloseData::_lblDate
          loc_505D4F: br.s loc_505D51
          loc_505D51: // Referenced from: loc_505D4F
          loc_505D51: ret
        }

        assem override strict specialname void set_lblDate(class Label WithEventsValue) {

          loc_505D53: ldarg.0
          loc_505D54: ldarg.1
          loc_505D55: stfld GCUv2.frmSettingCloseData::_lblDate
          loc_505D5A: ret
        }

        assem override strict specialname class Label get_Label2() {

          loc_505D5C: ldarg.0
          loc_505D5D: ldfld GCUv2.frmSettingCloseData::_Label2
          loc_505D62: br.s loc_505D64
          loc_505D64: // Referenced from: loc_505D62
          loc_505D64: ret
        }

        assem override strict specialname void set_Label2(class Label WithEventsValue) {

          loc_505D66: ldarg.0
          loc_505D67: ldarg.1
          loc_505D68: stfld GCUv2.frmSettingCloseData::_Label2
          loc_505D6D: ret
        }

        assem override strict specialname class DateTimePicker get_dtpCloseData() {

          loc_505D6F: ldarg.0
          loc_505D70: ldfld GCUv2.frmSettingCloseData::_dtpCloseData
          loc_505D75: br.s loc_505D77
          loc_505D77: // Referenced from: loc_505D75
          loc_505D77: ret
        }

        assem override strict specialname void set_dtpCloseData(class DateTimePicker WithEventsValue) {

          loc_505D79: ldarg.0
          loc_505D7A: ldarg.1
          loc_505D7B: stfld GCUv2.frmSettingCloseData::_dtpCloseData
          loc_505D80: ret
        }

        assem override strict specialname class Button get_btnCloseData() {

          loc_505D82: ldarg.0
          loc_505D83: ldfld GCUv2.frmSettingCloseData::_btnCloseData
          loc_505D88: br.s loc_505D8A
          loc_505D8A: // Referenced from: loc_505D88
          loc_505D8A: ret
        }

        assem override strict specialname void set_btnCloseData(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label5() {

          loc_505DD0: ldarg.0
          loc_505DD1: ldfld GCUv2.frmSettingCloseData::_Label5
          loc_505DD6: br.s loc_505DD8
          loc_505DD8: // Referenced from: loc_505DD6
          loc_505DD8: ret
        }

        assem override strict specialname void set_Label5(class Label WithEventsValue) {

          loc_505DDA: ldarg.0
          loc_505DDB: ldarg.1
          loc_505DDC: stfld GCUv2.frmSettingCloseData::_Label5
          loc_505DE1: ret
        }

        assem override strict specialname class Label get_Label3() {

          loc_505DE3: ldarg.0
          loc_505DE4: ldfld GCUv2.frmSettingCloseData::_Label3
          loc_505DE9: br.s loc_505DEB
          loc_505DEB: // Referenced from: loc_505DE9
          loc_505DEB: ret
        }

        assem override strict specialname void set_Label3(class Label WithEventsValue) {

          loc_505DED: ldarg.0
          loc_505DEE: ldarg.1
          loc_505DEF: stfld GCUv2.frmSettingCloseData::_Label3
          loc_505DF4: ret
        }

        assem override strict specialname class TextBox get_txtConfirmation() {

          loc_505DF6: ldarg.0
          loc_505DF7: ldfld GCUv2.frmSettingCloseData::_txtConfirmation
          loc_505DFC: br.s loc_505DFE
          loc_505DFE: // Referenced from: loc_505DFC
          loc_505DFE: ret
        }

        assem override strict specialname void set_txtConfirmation(class TextBox WithEventsValue) {

          loc_505E00: ldarg.0
          loc_505E01: ldarg.1
          loc_505E02: stfld GCUv2.frmSettingCloseData::_txtConfirmation
          loc_505E07: ret
        }

        assem override strict specialname class Button get_btnUpdate() {

          loc_505E09: ldarg.0
          loc_505E0A: ldfld GCUv2.frmSettingCloseData::_btnUpdate
          loc_505E0F: br.s loc_505E11
          loc_505E11: // Referenced from: loc_505E0F
          loc_505E11: ret
        }

        assem override strict specialname void set_btnUpdate(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        public void frmSettingCloseData() {

          boolean var_1;

        }

        private void frmSettingDatabase_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnCloseData_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          class DataTable var_2;
          class DataTable var_3;
          double flt_1;
          int32 num_3;
          int32 num_4;
          int32 num_5;
          int32 num_6;
          class MySqlClient.MySqlTransaction var_4;
          int32 num_7;
          double flt_2;
          valuetype System.DateTime var_5;
          double flt_3;
          double flt_4;
          valuetype System.DateTime var_6;
          double flt_5;
          double flt_6;
          boolean var_7;
          valuetype System.DateTime var_8;
          boolean var_9;
          boolean var_10;
          class System.Collections.IEnumerator var_11;
          class DataRow var_12;
          boolean var_13;
          class System.Collections.IEnumerator var_14;
          class DataRow var_15;
          boolean var_16;
          boolean var_17;
          class System.Collections.IEnumerator var_18;
          class DataRow var_19;
          boolean var_20;
          class System.Collections.IEnumerator var_21;
          class DataRow var_22;
          boolean var_23;
          class System.Collections.IEnumerator var_24;
          class DataRow var_25;
          boolean var_26;
          class System.Collections.IEnumerator var_27;
          class DataRow var_28;
          boolean var_29;
          boolean var_30;
          boolean var_31;
          boolean var_32;
          boolean var_33;
          class System.Collections.IEnumerator var_34;
          class DataRow var_35;
          boolean var_36;
          class System.Collections.IEnumerator var_37;
          class DataRow var_38;
          boolean var_39;
          boolean var_40;
          class System.Collections.IEnumerator var_41;
          class DataRow var_42;
          boolean var_43;
          class System.Collections.IEnumerator var_44;
          class DataRow var_45;
          boolean var_46;
          boolean var_47;
          boolean var_48;
          boolean var_49;
          boolean var_50;
          class System.Collections.IEnumerator var_51;
          class DataRow var_52;
          boolean var_53;
          boolean var_54;

        }

        private void frmSettingDatabase_Load(object sender, class System.EventArgs e) {

          loc_50793D: nop
          loc_50793E: ldarg.0
          loc_50793F: callvirt instance class Label GCUv2.frmSettingCloseData::get_lblDate()
          loc_507944: ldstr "Batas tanggal penghapusan data sebelumnya: "
          loc_507949: ldsfld GCUv2.Module1::pubBalanceDate
          loc_50794E: call string Microsoft.VisualBasic.CompilerServices.Conversions::ToString(valuetype System.DateTime)
          loc_507953: call string System.String::Concat(string, string)
          loc_507958: callvirt instance void System.Windows.Forms.Label::set_Text(string)
          loc_50795D: nop
          loc_50795E: ret
        }

        private void btnUpdate_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          string str_1;
          class DataTable var_1;
          double flt_1;
          double flt_2;
          boolean var_2;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          boolean var_5;
          boolean var_6;

        }

    }
}
