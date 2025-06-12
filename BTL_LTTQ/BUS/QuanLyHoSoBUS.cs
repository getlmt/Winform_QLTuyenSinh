using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
namespace BUS
{
    public class QuanLyHoSoBUS : HoSoBUS
    {

        private QuanLyHoSoDAL hoSoDAL;
        public QuanLyHoSoBUS()
        {
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
			hoSoDAL = new QuanLyHoSoDAL();
        }
		public DataTable TimKiemHoSo(string mahoso)
		{
			if (string.IsNullOrWhiteSpace(mahoso))
				throw new ArgumentException("Mã ngành không được để trống");

			return hoSoDAL.TimKiemHoSo(mahoso);
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
			cl2.Value2 = "Họ tên";
			cl2.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C1", "C1");
			cl3.Value2 = "Giới tính";
			cl3.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D1", "D1");
			cl4.Value2 = "Ngày sinh";
			cl4.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E1", "E1");
			cl5.Value2 = "Số điện thoại";
			cl5.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F1", "F1");
			cl6.Value2 = "Địa chỉ";
			cl6.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G1", "G1");
			cl7.Value2 = "Ảnh hồ sơ";
			cl7.ColumnWidth = 20;

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
			Microsoft.Office.Interop.Excel.Range dateColumn = oSheet.get_Range("D2", $"D{rowEnd}");
			dateColumn.NumberFormat = "dd/MM/yyyy";
		}
		public void SaveToDatabase(DataTable dataTable)
		{
			string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				foreach (DataRow row in dataTable.Rows)
				{
					string maHoSo = row["Mã hồ sơ"].ToString();
					// Kiểm tra xem mã hồ sơ đã tồn tại trong CSDL hay chưa
					string checkQuery = "SELECT COUNT(*) FROM HoSo WHERE MaHoSo = @MaHoSo";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
						int count = (int)checkCmd.ExecuteScalar();
						// Nếu mã hồ sơ chưa tồn tại thì tiến hành thêm mới
						if (count == 0)
						{
							string insertQuery = @"INSERT INTO HoSo 
                                           (MaHoSo, HoTen, GioiTinh, NgaySinh, SoDienThoai, DiaChi, AnhHoSo) 
                                           VALUES (@MaHoSo, @HoTen, @GioiTinh, @NgaySinh, @SoDienThoai, @DiaChi, @AnhHoSo)";

							using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
							{
								insertCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
								insertCmd.Parameters.AddWithValue("@HoTen", row["Họ tên"]);
								insertCmd.Parameters.AddWithValue("@GioiTinh", row["Giới tính"]);
								// Xử lý cột Ngày sinh
								if (DateTime.TryParse(row["Ngày sinh"].ToString(), out DateTime ngaySinh))
								{
									insertCmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
								}
								else
								{
									insertCmd.Parameters.AddWithValue("@NgaySinh", DBNull.Value);
								}
								insertCmd.Parameters.AddWithValue("@SoDienThoai", row["Số điện thoại"]);
								insertCmd.Parameters.AddWithValue("@DiaChi", row["Địa chỉ"]);
								insertCmd.Parameters.AddWithValue("@AnhHoSo", row["Ảnh hồ sơ"]);
								// Thực thi lệnh chèn dữ liệu
								insertCmd.ExecuteNonQuery();
							}
						}
					}
				}
			}
		}
		public void Account(DataTable dataTable)
		{
			string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				foreach (DataRow row in dataTable.Rows)
				{
					string maHoSo = row["Mã hồ sơ"].ToString();
					// Kiểm tra xem mã hồ sơ đã tồn tại trong CSDL hay chưa
					string checkQuery = "SELECT COUNT(HoSo.MaHoSo) FROM HoSo" +
										" JOIN XetTuyen ON HoSo.MaHoSo=XetTuyen.MaHoSo" +
										" WHERE HoSo.MaHoSo = @MaHoSo AND MaTruong=N'GTU'";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
						int count = (int)checkCmd.ExecuteScalar();

						// Nếu mã hồ sơ chưa tồn tại thì tiến hành thêm mới
						if (count > 0)
						{
							string query = @"INSERT INTO Users
                                           (MaHoSo, Account, Password) 
                                           VALUES (@MaHoSo, @Acc, @SoDienThoai)";
							using (SqlCommand insertCmd = new SqlCommand(query, conn))
							{
								insertCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
								insertCmd.Parameters.AddWithValue("@Acc", maHoSo);
								insertCmd.Parameters.AddWithValue("@SoDienThoai", row["Số điện thoại"]);
								// Thực thi lệnh chèn dữ liệu
								insertCmd.ExecuteNonQuery();
							}
						}
					}
				}
			}
		}
		public bool CheckTrungTuyen()
		{
			return hoSoDAL.CheckTrungTuyen();
		}
		public void ImportExcel(string path, DataGridView dt)
		{
			using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
			{
				ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
				DataTable dataTable = new DataTable();
				for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
				{
					dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
				}
				for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
				{
					List<object> listRows = new List<object>();

					for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
					{
						var cellValue = excelWorksheet.Cells[i, j].Value;
						if (j == 4)
						{							
							if (cellValue is double doubleValue)
							{
								listRows.Add(DateTime.FromOADate(doubleValue).ToString("MM/dd/yyyy"));
							}
							else if (cellValue is DateTime dateValue)
							{
								listRows.Add(dateValue.ToString("MM/dd/yyyy"));
							}
							else
							{
								listRows.Add(cellValue != null ? cellValue.ToString() : string.Empty);
							}
						}
						else
						{
							listRows.Add(cellValue != null ? cellValue.ToString() : string.Empty);
						}
					}
					dataTable.Rows.Add(listRows.ToArray());
				}
				dt.DataSource = dataTable;
				SaveToDatabase(dataTable);
				Account(dataTable);
			}
		}
		public DataTable GetAllHoSo()
        {
            return hoSoDAL.GetAllHoSo();
        }
        public bool DeleteHoSo(string maHoSo)
        {
            return hoSoDAL.DeleteHoSo(maHoSo);
        }
    }
}
