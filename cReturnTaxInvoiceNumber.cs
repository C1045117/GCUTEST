namespace GCUv2
{
    public class 
    {

        private int32 _year;
        private double _latestNumber;


        public specialname int32 get_Year() {

          int32 num_1;

        }

        public specialname void set_Year(int32 value) {

          loc_41B075: nop
          loc_41B076: ldarg.0
          loc_41B077: ldarg.1
          loc_41B078: stfld GCUv2.cReceivedItemItem::_year
          loc_41B07D: ret
        }

        public specialname double get_LatestNumber() {

          double flt_1;

        }

        public specialname void set_LatestNumber(double value) {

          loc_41B099: nop
          loc_41B09A: ldarg.0
          loc_41B09B: ldarg.1
          loc_41B09C: stfld GCUv2.cReturnTaxInvoiceNumber::_latestNumber
          loc_41B0A1: ret
        }

        public void cReturnTaxInvoiceNumber(int32 Year) {

          boolean var_1;
          string str_1;
          class DataTable var_2;
          boolean var_3;

        }

        public void Save() {

          string str_1;
          class MySqlClient.MySqlTransaction var_1;

        }

    }
}
