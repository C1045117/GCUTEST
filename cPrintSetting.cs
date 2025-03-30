namespace GCUv2
{
    public class 
    {

        private string _companyName;
        private string _companyDetail1;
        private string _companyDetail2;
        private string _companyDetail3;
        private string _companyCity;
        private string _NPWP;
        private string _taxAddress;
        private string _taxNumber;
        private string _taxPersonName;
        private string _taxPersonPosition;
        private string _salesReceiptCode;
        private string _salesReceiptDescription;
        private string _salesReceiptPersonName;
        private string _salesReceiptCity;


        public specialname string get_CompanyName() {

          string str_1;

        }

        public specialname void set_CompanyName(string value) {

          loc_4115DD: nop
          loc_4115DE: ldarg.0
          loc_4115DF: ldarg.1
          loc_4115E0: call string GCUv2.Module1::cleanString(string)
          loc_4115E5: stfld GCUv2.cPage::_companyName
          loc_4115EA: ret
        }

        public specialname string get_CompanyDetail1() {

          string str_1;

        }

        public specialname void set_CompanyDetail1(string value) {

          loc_411605: nop
          loc_411606: ldarg.0
          loc_411607: ldarg.1
          loc_411608: call string GCUv2.Module1::cleanString(string)
          loc_41160D: stfld GCUv2.cPrintSetting::_companyDetail1
          loc_411612: ret
        }

        public specialname string get_CompanyDetail2() {

          string str_1;

        }

        public specialname void set_CompanyDetail2(string value) {

          loc_41162D: nop
          loc_41162E: ldarg.0
          loc_41162F: ldarg.1
          loc_411630: call string GCUv2.Module1::cleanString(string)
          loc_411635: stfld GCUv2.cPrintSetting::_companyDetail2
          loc_41163A: ret
        }

        public specialname string get_CompanyDetail3() {

          string str_1;

        }

        public specialname void set_CompanyDetail3(string value) {

          loc_411655: nop
          loc_411656: ldarg.0
          loc_411657: ldarg.1
          loc_411658: call string GCUv2.Module1::cleanString(string)
          loc_41165D: stfld GCUv2.cPrintSetting::_companyDetail3
          loc_411662: ret
        }

        public specialname string get_CompanyCity() {

          string str_1;

        }

        public specialname void set_CompanyCity(string value) {

          loc_41167D: nop
          loc_41167E: ldarg.0
          loc_41167F: ldarg.1
          loc_411680: call string GCUv2.Module1::cleanString(string)
          loc_411685: stfld GCUv2.cPrintSetting::_companyCity
          loc_41168A: ret
        }

        public specialname string get_NPWP() {

          string str_1;

        }

        public specialname void set_NPWP(string value) {

          loc_4116A5: nop
          loc_4116A6: ldarg.0
          loc_4116A7: ldarg.1
          loc_4116A8: stfld GCUv2.cPrintSetting::_NPWP
          loc_4116AD: ret
        }

        public specialname string get_TaxNumber() {

          string str_1;

        }

        public specialname void set_TaxNumber(string value) {

          loc_4116C9: nop
          loc_4116CA: ldarg.0
          loc_4116CB: ldarg.1
          loc_4116CC: stfld GCUv2.cPrintSetting::_taxNumber
          loc_4116D1: ret
        }

        public specialname string get_TaxAddress() {

          string str_1;

        }

        public specialname void set_TaxAddress(string value) {

          loc_4116ED: nop
          loc_4116EE: ldarg.0
          loc_4116EF: ldarg.1
          loc_4116F0: stfld GCUv2.cPrintSetting::_taxAddress
          loc_4116F5: ret
        }

        public specialname string get_TaxPersonName() {

          string str_1;

        }

        public specialname void set_TaxPersonName(string value) {

          loc_411711: nop
          loc_411712: ldarg.0
          loc_411713: ldarg.1
          loc_411714: call string GCUv2.Module1::cleanString(string)
          loc_411719: stfld GCUv2.cPrintSetting::_taxPersonName
          loc_41171E: ret
        }

        public specialname string get_TaxPersonPosition() {

          string str_1;

        }

        public specialname void set_TaxPersonPosition(string value) {

          loc_411739: nop
          loc_41173A: ldarg.0
          loc_41173B: ldarg.1
          loc_41173C: call string GCUv2.Module1::cleanString(string)
          loc_411741: stfld GCUv2.cPrintSetting::_taxPersonPosition
          loc_411746: ret
        }

        public specialname string get_SalesReceiptCode() {

          string str_1;

        }

        public specialname void set_SalesReceiptCode(string value) {

          loc_411761: nop
          loc_411762: ldarg.0
          loc_411763: ldarg.1
          loc_411764: call string GCUv2.Module1::cleanString(string)
          loc_411769: stfld GCUv2.cPrintSetting::_salesReceiptCode
          loc_41176E: ret
        }

        public specialname string get_SalesReceiptDescription() {

          string str_1;

        }

        public specialname void set_SalesReceiptDescription(string value) {

          loc_411789: nop
          loc_41178A: ldarg.0
          loc_41178B: ldarg.1
          loc_41178C: call string GCUv2.Module1::cleanString(string)
          loc_411791: stfld GCUv2.cPrintSetting::_salesReceiptDescription
          loc_411796: ret
        }

        public specialname string get_SalesReceiptPersonName() {

          string str_1;

        }

        public specialname void set_SalesReceiptPersonName(string value) {

          loc_4117B1: nop
          loc_4117B2: ldarg.0
          loc_4117B3: ldarg.1
          loc_4117B4: call string GCUv2.Module1::cleanString(string)
          loc_4117B9: stfld GCUv2.cPrintSetting::_salesReceiptPersonName
          loc_4117BE: ret
        }

        public specialname string get_SalesReceiptCity() {

          string str_1;

        }

        public specialname void set_SalesReceiptCity(string value) {

          loc_4117D9: nop
          loc_4117DA: ldarg.0
          loc_4117DB: ldarg.1
          loc_4117DC: call string GCUv2.Module1::cleanString(string)
          loc_4117E1: stfld GCUv2.cPrintSetting::_salesReceiptCity
          loc_4117E6: ret
        }

        public void cPrintSetting(int32 Id) {

          class DataTable var_1;
          string str_1;
          boolean var_2;
          boolean var_3;

        }

        public void Save() {

          string str_1;

        }

    }
}
