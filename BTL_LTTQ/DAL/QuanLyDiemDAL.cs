using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
	public class QuanLyDiemDAL
	{
		private string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
		public DataTable GetAllDiem()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = "SELECT DISTINCT Diem.MaHoSo, DiemHocBaTrungBinh, DiemToan, DiemVan, DiemAnh, DiemLy, DiemHoa, DiemSinh, DiemSu, DiemDia, DiemGDCD, HanhKiemCap3" +
							   " FROM Diem" +
							   " JOIN XetTuyen ON Diem.MaHoSo=XetTuyen.MaHoSo" +
							   " WHERE MaTruong = N'GTU'";
				SqlDataAdapter adapter = new SqlDataAdapter(query, con);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}
		public bool CheckMaHoSoExists(string maHoSo)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(*) FROM XetTuyen WHERE MaTruong = N'GTU' AND MaHoSo=@MaHoSo", connection);
					checkNganhCommand.Parameters.AddWithValue("@MaHoSo", maHoSo);
					int Exists = (int)checkNganhCommand.ExecuteScalar();
					return Exists > 0;
				}
				catch
				{
					return false;
				}
			}
		}
		public bool CheckMaHoSo(string maHoSo)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(*) FROM Diem JOIN XetTuyen ON Diem.MaHoSo=XetTuyen.MaHoSo WHERE MaTruong = N'GTU' AND Diem.MaHoSo=@MaHoSo", connection);
					checkNganhCommand.Parameters.AddWithValue("@MaHoSo", maHoSo);
					int Exists = (int)checkNganhCommand.ExecuteScalar();
					return Exists > 0;
				}
				catch
				{
					return false;
				}
			}
		}
		public bool Them(string maHoSo, float diemHocBaTrungBinh, float diemToan, float diemVan, float diemAnh, float diemLy, float diemHoa, float diemSinh, float diemSu, float diemDia, float diemGDCD, string hanhKiem)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string insertQuery = @"INSERT INTO Diem (MaHoSo, DiemHocBaTrungBinh, DiemToan, DiemVan, DiemAnh, DiemLy, DiemHoa, DiemSinh, DiemSu, DiemDia, DiemGDCD, HanhKiemCap3) 
										VALUES (@MaHoSo, @DiemHocBaTrungBinh, @DiemToan, @DiemVan, @DiemAnh, @DiemLy, @DiemHoa, @DiemSinh, @DiemSu, @DiemDia, @DiemGDCD, @HanhKiemCap3)";
				using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
				{
					cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
					cmd.Parameters.AddWithValue("@DiemHocBaTrungBinh", diemHocBaTrungBinh);
					cmd.Parameters.AddWithValue("@DiemToan", diemToan);
					cmd.Parameters.AddWithValue("@DiemVan", diemVan);
					cmd.Parameters.AddWithValue("@DiemAnh", diemAnh);
					cmd.Parameters.AddWithValue("@DiemLy", diemLy);
					cmd.Parameters.AddWithValue("@DiemHoa", diemHoa);
					cmd.Parameters.AddWithValue("@DiemSinh", diemSinh);
					cmd.Parameters.AddWithValue("@DiemSu", diemSu);
					cmd.Parameters.AddWithValue("@DiemDia", diemDia);
					cmd.Parameters.AddWithValue("@DiemGDCD", diemGDCD);
					cmd.Parameters.AddWithValue("@HanhKiemCap3", hanhKiem);
					return cmd.ExecuteNonQuery() > 0;
				}
			}
		}
		public bool CheckTrungTuyen()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					// Kiểm tra xem mã ngành có tồn tại trong bảng Nganh
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(TrungTuyen) FROM XetTuyen", connection);
					int nganhExists = (int)checkNganhCommand.ExecuteScalar();
					return nganhExists > 0;
				}
				catch
				{
					return false;
				}
			}
		}
		public DataTable TimKiem(string mahoso)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "SELECT DISTINCT XetTuyen.MaHoSo, DiemHocBaTrungBinh, DiemToan, DiemVan, DiemAnh, DiemLy, DiemHoa, DiemSinh, DiemSu, DiemDia, DiemGDCD" +
							   " FROM Diem" +
							   " JOIN XetTuyen ON Diem.MaHoSo=XetTuyen.MaHoSo" +
							   " WHERE XetTuyen.MaHoSo=@mahoso AND MaTruong=N'GTU'";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@MaHoSo", mahoso);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}
		public bool Delete(string maHoSo)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "DELETE FROM Diem WHERE MaHoSo = @MaHoSo";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
	}
}
