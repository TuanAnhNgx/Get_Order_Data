using System;
using System.Data;
using ClosedXML.Excel;

namespace Get_Orders_Data.BUS
{
    public class getExcelData
    {
        public getExcelData()
        {
        }
        public DataTable data(string excelFilePath)
        {
            DataTable table = new DataTable();

            using (var workbook = new XLWorkbook(excelFilePath))
            {
                var worksheet = workbook.Worksheet(1);

                var firstRow = worksheet.FirstRow();

                foreach (var cell in firstRow.Cells())
                {
                    table.Columns.Add(cell.Value.ToString());
                }

                var rows = worksheet.RowsUsed().Skip(1);

                foreach (var row in rows)
                {
                    var newRow = table.NewRow();
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        newRow[i] = row.Cell(i + 1).Value.ToString();
                    }
                    table.Rows.Add(newRow);
                }
            }

            return table;
        }
    }
}
