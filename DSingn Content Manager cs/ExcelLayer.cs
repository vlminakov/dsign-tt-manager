using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;

namespace DSingn_Content_Manager_cs
{
    public partial class ExcelLayer
    {
        private Excel.Application excelApp;

        public ExcelLayer()
        {
            excelApp = new Excel.Application();
        }

        public void createReport(List<List<FileReportObject>> report, string[] filenames)
        {
            int collShift = 2;
            int rowShift = 5;
            int row = 0, col = 0;
            excelApp.Workbooks.Add("ds_report1.xlsx");
            //
            Excel.Worksheet sh = excelApp.ActiveWorkbook.Worksheets[1];
            sh.Name = "Сводная информация";
            Excel.Sheets sheets = excelApp.ActiveWorkbook.Worksheets;
            for (int i = 1; i <= filenames.Length; i++)
            {
                sh.Cells[rowShift, collShift].Value = i;
                collShift++;
                string fn = filenames[i-1].Substring(0, filenames[i-1].IndexOf('.'));
                string ext = filenames[i - 1].Substring(filenames[i - 1].IndexOf('.') + 1);
                sh.Cells[rowShift, collShift].Value = fn; collShift++;
                sh.Cells[rowShift, collShift].Value = ext; collShift++;
                int showTime = report[i-1].Count;
                sh.Cells[rowShift, collShift].Value = showTime; collShift++;
                collShift = 2;
                rowShift++;
                Excel.Range range = sh.get_Range("A" + rowShift.ToString(), "A" + rowShift.ToString()).EntireRow;
                range.Insert(Excel.XlInsertShiftDirection.xlShiftDown);
            }
            rowShift = 4;
            collShift = 2;
            foreach (List<FileReportObject> fileReport in report)
            {
                Excel.Worksheet newSheet = (Excel.Worksheet)sheets.Add(Type.Missing, sheets[sheets.Count], Type.Missing, Type.Missing);
                newSheet.Name = fileReport.ElementAt(0).filename;
                // header
                newSheet.Cells[rowShift + row, collShift + col].Value = "№"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Имя файла"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Тип"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Дата показа"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Время показа"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Имя плеера"; col++;
                newSheet.Cells[rowShift + row, collShift + col].Value = "Описание плеера"; col = 0; row++;
                //end of header
                //body
                int num = 1;
                foreach (FileReportObject file in fileReport)
                {
                    newSheet.Cells[rowShift + row, collShift + col].Value = num.ToString(); col++;
                    string fn = file.filename.Substring(0, file.filename.IndexOf('.'));
                    string ext = file.filename.Substring(file.filename.IndexOf('.') + 1);
                    newSheet.Cells[rowShift + row, collShift + col].Value = fn; col++;
                    newSheet.Cells[rowShift + row, collShift + col].Value = ext; col++;
                    newSheet.Cells[rowShift + row, collShift + col].Value = file.date; col++;
                    newSheet.Cells[rowShift + row, collShift + col].Value = file.time; col++;
                    newSheet.Cells[rowShift + row, collShift + col].Value = file.pname; col++;
                    newSheet.Cells[rowShift + row, collShift + col].Value = file.pdescription; col = 0; row++;
                    num++;
                }
                col = 0;
                row = 0;
            }
            excelApp.Visible = true;
        }
    }
}
