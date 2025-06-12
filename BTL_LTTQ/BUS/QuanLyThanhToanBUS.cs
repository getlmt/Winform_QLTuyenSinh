using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyThanhToanBUS : PaymentBUS
    {
        private QuanLyThanhToanDAL thanhToanDAL;
        public QuanLyThanhToanBUS()
        {
            thanhToanDAL = new QuanLyThanhToanDAL();
        }
        public DataTable GetAllThanhToan()
        {
            return thanhToanDAL.GetAllThanhToan();
        }
		public void ToExcel(DataTable dataTable, string sheetName)
		{
			Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel.Workbooks oBooks;
			Microsoft.Office.Interop.Excel.Sheets oSheets;
			Microsoft.Office.Interop.Excel.Workbook oBook;
			Microsoft.Office.Interop.Excel.Worksheet oSheet;

			oExcel.Visible = true;
			oExcel.DisplayAlerts = false;
			oExcel.Application.SheetsInNewWorkbook = 1;
			oBooks = oExcel.Workbooks;
			oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
			oSheets = oBook.Worksheets;
			oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
			oSheet.Name = sheetName;

			Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A1", "A1");
			cl1.Value2 = "Mã hồ sơ";
			cl1.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B1", "B1");
			cl2.Value2 = "Số tiền thanh toán";
			cl2.ColumnWidth = 25;
			Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C1", "C1");
			cl3.Value2 = "Hình thức thanh toán";
			cl3.ColumnWidth = 25;
			Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D1", "D1");
			cl4.Value2 = "Biên lai thanh toán";
			cl4.ColumnWidth = 25;

			object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
			for (int row = 0; row < dataTable.Rows.Count; row++)
			{
				DataRow dataRow = dataTable.Rows[row];
				for (int col = 0; col < dataTable.Columns.Count; col++)
				{
					arr[row, col] = dataRow[col];
				}
			}

			int rowStart = 2;
			int columnStart = 1;
			int rowEnd = rowStart + dataTable.Rows.Count - 1;
			int columnEnd = dataTable.Columns.Count;

			Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
			Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

			Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

			range.Value2 = arr;
		}
		public bool XoaThanhToan(string maHoSo)
        {
            return thanhToanDAL.XoaThanhToan(maHoSo);
        }
    }
}
