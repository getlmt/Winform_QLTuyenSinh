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
	public class QuanLyDiemBUS
	{
		private QuanLyDiemDAL quanLyDiemDAL;
		public QuanLyDiemBUS()
		{
			quanLyDiemDAL = new QuanLyDiemDAL();
		}
		public bool Them(string maHoSo, float diemHocBaTrungBinh, float diemToan, float diemVan, float diemAnh, float diemLy, float diemHoa, float diemSinh, float diemSu, float diemDia, float diemGDCD, string hanhKiem)
		{
			return quanLyDiemDAL.Them(maHoSo, diemHocBaTrungBinh, diemToan, diemVan, diemAnh, diemLy, diemHoa, diemSinh, diemSu, diemDia, diemGDCD, hanhKiem);
		}
		public bool CheckTrungTuyen()
		{
			return quanLyDiemDAL.CheckTrungTuyen();
		}
		public bool MaHoSo(string maHoSo)
		{
			return quanLyDiemDAL.CheckMaHoSoExists(maHoSo);
		}
		public bool CheckMaHoSo(string maHoSo)
		{
			return quanLyDiemDAL.CheckMaHoSo(maHoSo);
		}
		public DataTable TimKiem(string mahoso)
		{
			if (string.IsNullOrWhiteSpace(mahoso))
				throw new ArgumentException("Mã hồ sơ không được để trống");
			return quanLyDiemDAL.TimKiem(mahoso);
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
					// Kiểm tra xem mã hồ sơ đã tồn tại trong CSDL hay chưa
					string checkQuery = "SELECT COUNT(*) FROM Diem WHERE MaHoSo = @MaHoSo";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
					{
						checkCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
						int count = (int)checkCmd.ExecuteScalar();
						// Nếu mã hồ sơ chưa tồn tại thì tiến hành thêm mới
						if (count == 0)
						{
							string insertQuery = @"INSERT INTO Diem
                                           (MaHoSo ,DiemHocBaTrungBinh, DiemToan, DiemVan, DiemAnh, DiemLy, DiemHoa, DiemSinh, DiemSu, DiemDia, DiemGDCD, HanhKiemCap3) 
                                           VALUES (@MaHoSo, @DiemHocBaTrungBinh, @DiemToan, @DiemVan, @DiemAnh, @DiemLy, @DiemHoa, @DiemSinh, @DiemSu, @DiemDia, @DiemGDCD, @HanhKiemCap3)";
							using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
							{
								insertCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
								insertCmd.Parameters.AddWithValue("@DiemHocBaTrungBinh", row[1]);
								insertCmd.Parameters.AddWithValue("@DiemToan", row[2]);
								insertCmd.Parameters.AddWithValue("@DiemVan", row[3]);
								insertCmd.Parameters.AddWithValue("@DiemAnh", row[4]);
								insertCmd.Parameters.AddWithValue("@DiemLy", row[5]);
								insertCmd.Parameters.AddWithValue("@DiemHoa", row[6]);
								insertCmd.Parameters.AddWithValue("@DiemSinh", row[7]);
								insertCmd.Parameters.AddWithValue("@DiemSu", row[8]);
								insertCmd.Parameters.AddWithValue("@DiemDia", row[9]);
								insertCmd.Parameters.AddWithValue("@DiemGDCD", row[10]);
								insertCmd.Parameters.AddWithValue("@HanhKiemCap3", row[11]);
								// Thực thi lệnh chèn dữ liệu
								insertCmd.ExecuteNonQuery();
							}
						}
					}
				}
			}
		}
		public bool Delete(string maHoSo)
		{
			return quanLyDiemDAL.Delete(maHoSo);
		}
		public DataTable GetAllDiem()
		{
			return quanLyDiemDAL.GetAllDiem();
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
	}
}
