namespace Word
{
    public interface 
    {

        class Word.Application get_Application();

        void _VtblGap1_2();

        string get_Name();

        class Word.Documents get_Documents();

        void _VtblGap2_1();

        class Word.Document get_ActiveDocument();

        class Word.Window get_ActiveWindow();

        class Word.Selection get_Selection();

        void _VtblGap3_17();

        boolean get_Visible();

        void set_Visible(boolean prop);

        void _VtblGap4_85();

        void Quit(object & SaveChanges, object & OriginalFormat, object & RouteDocument);

        void _VtblGap5_40();

        single InchesToPoints(single Inches);

        single CentimetersToPoints(single Centimeters);

        void _VtblGap6_30();

        void PrintOut(object & Background, object & Append, object & Range, object & OutputFileName, object & From, object & To, object & Item, object & Copies, object & Pages, object & PageType, object & PrintToFile, object & Collate, object & FileName, object & ActivePrinterMacGX, object & ManualDuplexPrint, object & PrintZoomColumn, object & PrintZoomRow, object & PrintZoomPaperWidth, object & PrintZoomPaperHeight);

    }
}
