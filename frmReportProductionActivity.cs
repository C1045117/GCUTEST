using System;
using System.Windows.Forms;

namespace GCUv2
{
    public class Form
    {

        private class ComponentModel.IContainer components;
        private class Button _btnSearch;
        private class Label _Label4;
        private class DateTimePicker _dtpBegin;
        private class ProgressBar _ProgressBar1;
        private class Excel.Application _xlApp;
        private class Excel.Workbook _xlWb;
        private string strReport;
        private int32 intTotalRows;


        protected override strict void Dispose(boolean disposing) {

          boolean var_1;

        }

        private void InitializeComponent() {


        }

        assem override strict specialname class Button get_btnSearch() {

          loc_46F386: ldarg.0
          loc_46F387: ldfld GCUv2.frmReportProductionActivity::_btnSearch
          loc_46F38C: br.s loc_46F38E
          loc_46F38E: // Referenced from: loc_46F38C
          loc_46F38E: ret
        }

        assem override strict specialname void set_btnSearch(class Button WithEventsValue) {

          class System.EventHandler var_1;
          class Button var_2;

        }

        assem override strict specialname class Label get_Label4() {

          loc_46F3D4: ldarg.0
          loc_46F3D5: ldfld GCUv2.frmReportProductionActivity::_Label4
          loc_46F3DA: br.s loc_46F3DC
          loc_46F3DC: // Referenced from: loc_46F3DA
          loc_46F3DC: ret
        }

        assem override strict specialname void set_Label4(class Label WithEventsValue) {

          loc_46F3DE: ldarg.0
          loc_46F3DF: ldarg.1
          loc_46F3E0: stfld GCUv2.frmReportProductionActivity::_Label4
          loc_46F3E5: ret
        }

        assem override strict specialname class DateTimePicker get_dtpBegin() {

          loc_46F3E7: ldarg.0
          loc_46F3E8: ldfld GCUv2.frmReportProductionActivity::_dtpBegin
          loc_46F3ED: br.s loc_46F3EF
          loc_46F3EF: // Referenced from: loc_46F3ED
          loc_46F3EF: ret
        }

        assem override strict specialname void set_dtpBegin(class DateTimePicker WithEventsValue) {

          loc_46F3F1: ldarg.0
          loc_46F3F2: ldarg.1
          loc_46F3F3: stfld GCUv2.frmReportProductionActivity::_dtpBegin
          loc_46F3F8: ret
        }

        assem override strict specialname class ProgressBar get_ProgressBar1() {

          loc_46F3FA: ldarg.0
          loc_46F3FB: ldfld GCUv2.frmReportProductionActivity::_ProgressBar1
          loc_46F400: br.s loc_46F402
          loc_46F402: // Referenced from: loc_46F400
          loc_46F402: ret
        }

        assem override strict specialname void set_ProgressBar1(class ProgressBar WithEventsValue) {

          loc_46F404: ldarg.0
          loc_46F405: ldarg.1
          loc_46F406: stfld GCUv2.frmReportProductionActivity::_ProgressBar1
          loc_46F40B: ret
        }

        public void frmReportProductionActivity() {


        }

        private void PrepareForm() {

          loc_46F45C: nop
          loc_46F45D: ldarg.0
          loc_46F45E: callvirt instance class DateTimePicker GCUv2.frmReportProductionActivity::get_dtpBegin()
          loc_46F463: call valuetype System.DateTime Microsoft.VisualBasic.DateAndTime::get_Now()
          loc_46F468: callvirt instance void System.Windows.Forms.DateTimePicker::set_Value(valuetype System.DateTime)
          loc_46F46D: nop
          loc_46F46E: ldarg.0
          loc_46F46F: callvirt instance class ProgressBar GCUv2.frmReportProductionActivity::get_ProgressBar1()
          loc_46F474: ldc.i4.0
          loc_46F475: callvirt instance void System.Windows.Forms.Control::set_Visible(boolean)
          loc_46F47A: nop
          loc_46F47B: ret
        }

        private void frmReportProductionActivity_KeyDown(object sender, class KeyEventArgs e) {

          boolean var_1;

        }

        private void btnSearch_Click(object sender, class System.EventArgs e) {

          int32 num_1;
          int32 num_2;
          int32 num_3;
          int32 num_4;
          int32 num_5;
          int32 num_6;
          object var_1;
          boolean var_2;
          object var_3;
          object var_4;
          object var_5;
          object var_6;
          object var_7;
          object var_8;
          object var_9;
          object var_10;
          object var_11;
          boolean var_12;
          int32 num_7;
          boolean var_13;
          object var_14;
          object var_15;
          object var_16;
          object var_17;
          object var_18;
          object var_19;
          object var_20;
          object var_21;
          object var_22;
          int32 num_8;
          int32 num_9;
          boolean var_23;
          object var_24;
          boolean var_25;
          boolean var_26;
          boolean var_27;
          object var_28;
          object var_29;
          object var_30;
          object var_31;
          object var_32;
          object var_33;
          object var_34;
          object var_35;
          object var_36;
          boolean var_37;
          object var_38;
          object var_39;
          object var_40;
          object var_41;
          object var_42;
          object var_43;
          object var_44;
          object var_45;
          object var_46;

        }

        private string getPurchase() {

          string str_1;
          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          string str_2;
          string str_3;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;
          boolean var_8;
          boolean var_9;

        }

        private string getProcess() {

          string str_1;
          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          class DataTable var_2;
          string str_2;
          string str_3;
          class System.Collections.IEnumerator var_3;
          class DataRow var_4;
          class System.Collections.IEnumerator var_5;
          class DataRow var_6;
          boolean var_7;
          boolean var_8;

        }

        private string getTransfer() {

          string str_1;
          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          string str_2;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

        private string getAdjustment() {

          string str_1;
          int32 num_1;
          int32 num_2;
          class DataTable var_1;
          string str_2;
          class System.Collections.IEnumerator var_2;
          class DataRow var_3;
          boolean var_4;

        }

    }
}
