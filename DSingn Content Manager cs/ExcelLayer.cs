using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Excel = Microsoft.Office.Interop.Excel;
using Sheet = Microsoft.Office.Interop.Excel.Worksheet;

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
            int rowShift = 3;
            int row, col;
            excelApp.SheetsInNewWorkbook = filenames.Length + 1;
            excelApp.Workbooks.Add(Type.Missing);
            int index = 0;
            foreach (Sheet sh in excelApp.ActiveWorkbook.Worksheets)
            {
                if (index > 0)
                {
                    sh.Name = filenames[index - 1];
                    sh.Cells[rowShift, collShift].Value = "test test";
                }
                else
                {
                    sh.Name = "Общая Сводка";
                    sh.Cells[rowShift, collShift].Value = "Имя файла";
                    rowShift++;
                    foreach (string str in filenames)
                    {
                        sh.Cells[rowShift, collShift].Value = str;
                        rowShift++;
                    }
                    rowShift = 3;
                    collShift = 2;
                }
                index++;
            }
            index = 0;
            excelApp.Visible = true;
        }
    }
}
