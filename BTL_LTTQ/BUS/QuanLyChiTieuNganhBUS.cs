using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data.SqlClient;
using OfficeOpenXml;
using System.IO;
namespace BUS
{
    public class QuanLyChiTieuNganhBUS
    {
        private QuanLyChiTieuNganhDAL dal;
        public QuanLyChiTieuNganhBUS()
        {
            dal = new QuanLyChiTieuNganhDAL();
        }
        public DataTable GetAllXetTuyen()
        {
            return dal.GetAllXetTuyen();
        }
		public bool Check(string maNganh)
		{
		  return dal.CheckMaNganhExists(maNganh);
		}
		public void ToExcel(DataTable dataTable, string sheetName)
		{
			Microsoft.Office.Interop.Excel.Application oExcel= new Microsoft.Office.Interop.Excel.Application();
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

			Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A1","A1");
			//cl1.Value2 = "Mã hồ sơ";
			cl1.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B1", "B1");
			//cl2.Value2 = "Mã ngành";
			cl2.ColumnWidth = 20;
			Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C1", "C1");
			//cl3.Value2 = "Điểm xét tuyển";
			cl3.ColumnWidth = 20;

			object [,] arr = new object[dataTable.Rows.Count,  dataTable.Columns.Count];
			for (int row = 0; row<dataTable.Rows.Count;row++)
			{
				DataRow dataRow = dataTable.Rows[row];
				for(int col = 0; col < dataTable.Columns.Count; col++) 
				{
					arr[row, col] = dataRow[col];
				}		
			}

			int rowStart = 2;
			int columnStart = 1;
			int rowEnd = rowStart + dataTable.Rows.Count-1;
			int columnEnd = dataTable.Columns.Count;

			Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
			Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

			Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1,c2);

			range.Value2 = arr;
		}
		public DataTable GetAllNganh()
        {
            return dal.GetAllNganh();
        }
		public DataTable TimKiem(string mahoso)
		{
			if (string.IsNullOrWhiteSpace(mahoso))
				throw new ArgumentException("Mã hồ sơ được để trống");

			return dal.TimKiem(mahoso);
		}
		public void SaveToDatabase(DataTable dataTable)
		{
			string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				foreach (DataRow row in dataTable.Rows)
				{
					string maHoSo = row[0].ToString();
					string maNganh = row[1].ToString();
					// Kiểm tra xem mã hồ sơ đã tồn tại trong CSDL hay chưa
					string checkQuery = "SELECT COUNT(*) FROM XetTuyen WHERE MaHoSo = @MaHoSo AND MaNganh = @MaNganh";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
						checkCmd.Parameters.AddWithValue("@MaNganh", maNganh);
						int count = (int)checkCmd.ExecuteScalar();
						// Nếu mã hồ sơ chưa tồn tại thì tiến hành thêm mới
						if (count == 0)
						{
							string insertQuery = @"INSERT INTO XetTuyen
                                           (MaHoSo, MaNganh, DiemXetTuyen, MaTruong, TenTruong, ToHopXetTuyen, TTNV) 
                                           VALUES (@MaHoSo, @MaNganh, @DiemXetTuyen, @MaTruong, @TenTruong, @ToHopXetTuyen, @TTNV)";
							using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
							{
								insertCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
								insertCmd.Parameters.AddWithValue("@MaNganh", maNganh);
								insertCmd.Parameters.AddWithValue("@DiemXetTuyen", row[2]);
								insertCmd.Parameters.AddWithValue("@MaTruong", row[3]);
								insertCmd.Parameters.AddWithValue("@TenTruong", row[4]);
								insertCmd.Parameters.AddWithValue("@ToHopXetTuyen", row[5]);
								insertCmd.Parameters.AddWithValue("@TTNV", row[6]);
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
			return dal.CheckTrungTuyen();
		}
		public void DeleteAll()
		{
			dal.DeleteAll();
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
					List<string> listRows = new List<string>();
					for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
					{
						var cellValue = excelWorksheet.Cells[i, j].Value;
						listRows.Add(cellValue != null ? cellValue.ToString() : string.Empty);
					}
					dataTable.Rows.Add(listRows.ToArray());
				}
				dt.DataSource = dataTable;
				SaveToDatabase(dataTable);
			}
		}
		public void Update()
		{
			dal.Update();
		}
		public void Update2()
		{
			dal.Update2();
		}
		public void ThanhToan()
		{
			dal.ThanhToan();
		}
		public DataTable DSTT(string maNganh)
		{
			return dal.DSTT(maNganh);
		}
		public DataTable DanhSachTrungTuyen() 
        {
            return dal.DanhSachTrungTuyen();
        }
		public bool SuaXetTuyen(string maHoSo, string maNganh, string maNganhMoi, float diemXetTuyen, string toHopXetTuyen, int TTNV)
		{
			if (string.IsNullOrWhiteSpace(maNganh) || string.IsNullOrWhiteSpace(maHoSo) || dal.KiemTraNguyenVong(maNganhMoi, maHoSo) || !dal.CheckMaNganhExists(maNganhMoi))
				return false;
			return dal.SuaXetTuyen(maHoSo, maNganh, maNganhMoi, diemXetTuyen, toHopXetTuyen, TTNV);
		}
		public bool DeleteXetTuyen(string maHoSo)
        {
            return dal.DeleteXetTuyen(maHoSo);
        }
    }
}
