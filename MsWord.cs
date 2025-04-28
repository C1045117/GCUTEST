using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Word;

namespace GCUv2;

public class MsWord
{
	private Application wordApp;

	public void initWord(bool blnPortrait)
	{
		Documents documents = wordApp.Documents;
		object Template = RuntimeHelpers.GetObjectValue(Missing.Value);
		object NewTemplate = RuntimeHelpers.GetObjectValue(Missing.Value);
		object DocumentType = RuntimeHelpers.GetObjectValue(Missing.Value);
		object Visible = RuntimeHelpers.GetObjectValue(Missing.Value);
		documents.Add(ref Template, ref NewTemplate, ref DocumentType, ref Visible);
		wordApp.ActiveWindow.ActivePane.View.Zoom.Percentage = 90;
		PageSetup pageSetup = wordApp.ActiveDocument.PageSetup;
		pageSetup.LineNumbering.Active = 0;
		if (!blnPortrait)
		{
			pageSetup.Orientation = WdOrientation.wdOrientLandscape;
			pageSetup.LeftMargin = wordApp.InchesToPoints(0.5f);
			pageSetup.PageWidth = wordApp.InchesToPoints(11f);
			pageSetup.PageHeight = wordApp.InchesToPoints(8.5f);
		}
		else
		{
			pageSetup.Orientation = WdOrientation.wdOrientPortrait;
			pageSetup.LeftMargin = wordApp.InchesToPoints(0.5f);
			pageSetup.PageWidth = wordApp.InchesToPoints(8.5f);
			pageSetup.PageHeight = wordApp.InchesToPoints(11f);
		}
		pageSetup.TopMargin = wordApp.InchesToPoints(0.5f);
		pageSetup.BottomMargin = wordApp.InchesToPoints(0.5f);
		pageSetup.RightMargin = wordApp.InchesToPoints(0.5f);
		pageSetup.Gutter = wordApp.InchesToPoints(0f);
		pageSetup.HeaderDistance = wordApp.InchesToPoints(0.5f);
		pageSetup.FooterDistance = wordApp.InchesToPoints(0.5f);
		pageSetup.FirstPageTray = WdPaperTray.wdPrinterDefaultBin;
		pageSetup.OtherPagesTray = WdPaperTray.wdPrinterDefaultBin;
		pageSetup.SectionStart = WdSectionStart.wdSectionNewPage;
		pageSetup.OddAndEvenPagesHeaderFooter = 0;
		pageSetup.DifferentFirstPageHeaderFooter = 0;
		pageSetup.VerticalAlignment = WdVerticalAlignment.wdAlignVerticalTop;
		pageSetup.SuppressEndnotes = 0;
		pageSetup.MirrorMargins = 0;
		pageSetup.TwoPagesOnOne = false;
		pageSetup.GutterPos = WdGutterStyle.wdGutterPosLeft;
		pageSetup = null;
	}

	public void rptWordNew(int intRows, int intCols, string strAlign, bool blnPortrait, string strTitle, bool Print)
	{
		wordApp = (Application)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
		if (!Print)
		{
			wordApp.Visible = true;
		}
		initWord(blnPortrait);
		putTitle(strTitle);
		PageNumbers pageNumbers = wordApp.Selection.Sections.First.Footers.Item(WdHeaderFooterIndex.wdHeaderFooterPrimary).PageNumbers;
		object PageNumberAlignment = WdPageNumberAlignment.wdAlignPageNumberCenter;
		object FirstPage = RuntimeHelpers.GetObjectValue(Missing.Value);
		pageNumbers.Add(ref PageNumberAlignment, ref FirstPage);
		wordApp.Selection.Paste();
		wordApp.Selection.Tables.Item(1).Select();
		wordApp.Selection.Font.Size = 10f;
		wordApp.ActiveDocument.Tables.Item(1).TopPadding = wordApp.CentimetersToPoints(0.03f);
		wordApp.ActiveDocument.Tables.Item(1).BottomPadding = wordApp.CentimetersToPoints(0.03f);
		wordApp.ActiveDocument.Tables.Item(1).LeftPadding = wordApp.CentimetersToPoints(0.1f);
		wordApp.ActiveDocument.Tables.Item(1).RightPadding = wordApp.CentimetersToPoints(0.1f);
		wordApp.ActiveDocument.Tables.Item(1).Spacing = 0f;
		wordApp.ActiveDocument.Tables.Item(1).Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
		wordApp.ActiveDocument.Tables.Item(1).Borders.OutsideLineStyle = WdLineStyle.wdLineStyleNone;
		wordApp.ActiveDocument.Tables.Item(1).Borders.Enable = -1;
		int num = Strings.Len(strAlign);
		for (int i = 1; i <= num; i = checked(i + 1))
		{
			if (Operators.CompareString(Strings.Mid(strAlign, i, 1), "R", TextCompare: false) == 0)
			{
				wordApp.ActiveDocument.Tables.Item(1).Columns.Item(i).Select();
				wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
			}
		}
		wordApp.ActiveDocument.Tables.Item(1).Rows.Item(1).Select();
		wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
		Selection selection = wordApp.Selection;
		FirstPage = WdUnits.wdLine;
		PageNumberAlignment = 1;
		object Extend = RuntimeHelpers.GetObjectValue(Missing.Value);
		selection.MoveUp(ref FirstPage, ref PageNumberAlignment, ref Extend);
		if (Print)
		{
			Application application = wordApp.Application;
			Extend = false;
			PageNumberAlignment = RuntimeHelpers.GetObjectValue(Missing.Value);
			FirstPage = WdPrintOutRange.wdPrintAllDocument;
			object OutputFileName = RuntimeHelpers.GetObjectValue(Missing.Value);
			object From = RuntimeHelpers.GetObjectValue(Missing.Value);
			object To = RuntimeHelpers.GetObjectValue(Missing.Value);
			object Item = WdPrintOutItem.wdPrintDocumentContent;
			object Copies = 1;
			object Pages = "";
			object PageType = WdPrintOutPages.wdPrintAllPages;
			object PrintToFile = false;
			object Collate = true;
			object FileName = "";
			object ActivePrinterMacGX = RuntimeHelpers.GetObjectValue(Missing.Value);
			object ManualDuplexPrint = false;
			object PrintZoomColumn = 0;
			object PrintZoomRow = 0;
			object PrintZoomPaperWidth = 0;
			object PrintZoomPaperHeight = 0;
			application.PrintOut(ref Extend, ref PageNumberAlignment, ref FirstPage, ref OutputFileName, ref From, ref To, ref Item, ref Copies, ref Pages, ref PageType, ref PrintToFile, ref Collate, ref FileName, ref ActivePrinterMacGX, ref ManualDuplexPrint, ref PrintZoomColumn, ref PrintZoomRow, ref PrintZoomPaperWidth, ref PrintZoomPaperHeight);
			Document activeDocument = wordApp.ActiveDocument;
			PrintZoomPaperHeight = false;
			PrintZoomPaperWidth = RuntimeHelpers.GetObjectValue(Missing.Value);
			PrintZoomRow = RuntimeHelpers.GetObjectValue(Missing.Value);
			activeDocument.Close(ref PrintZoomPaperHeight, ref PrintZoomPaperWidth, ref PrintZoomRow);
			Application application2 = wordApp;
			PrintZoomRow = RuntimeHelpers.GetObjectValue(Missing.Value);
			PrintZoomPaperWidth = RuntimeHelpers.GetObjectValue(Missing.Value);
			PrintZoomPaperHeight = RuntimeHelpers.GetObjectValue(Missing.Value);
			application2.Quit(ref PrintZoomRow, ref PrintZoomPaperWidth, ref PrintZoomPaperHeight);
		}
		wordApp = null;
	}

	private void putTitle(string strTitle)
	{
		wordApp.Selection.TypeText(strTitle);
		wordApp.Selection.TypeParagraph();
		wordApp.Selection.TypeParagraph();
	}

	private void setTableNew(int intRows, int intCols)
	{
		Tables tables = wordApp.ActiveDocument.Tables;
		Range range = wordApp.Selection.Range;
		int numRows = checked(intRows + 1);
		int numColumns = intCols;
		object DefaultTableBehavior = WdDefaultTableBehavior.wdWord9TableBehavior;
		object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;
		tables.Add(range, numRows, numColumns, ref DefaultTableBehavior, ref AutoFitBehavior);
		Selection selection = wordApp.Selection;
		AutoFitBehavior = WdUnits.wdCharacter;
		DefaultTableBehavior = intCols;
		object Extend = WdMovementType.wdExtend;
		selection.MoveRight(ref AutoFitBehavior, ref DefaultTableBehavior, ref Extend);
		intCols = Conversions.ToInteger(DefaultTableBehavior);
		Cells cells = wordApp.Selection.Cells;
		Shading shading = cells.Shading;
		shading.Texture = WdTextureIndex.wdTextureNone;
		shading.ForegroundPatternColor = WdColor.wdColorAutomatic;
		shading = null;
		cells = null;
	}
}
