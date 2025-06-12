using System;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
	public class QuanLyHoSoDAL
	{
		string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
		public DataTable GetAllHoSo()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = connection.CreateCommand();
				command.CommandText = "SELECT DISTINCT HoSo.MaHoSo, HoTen, GioiTinh, NgaySinh, SoDienThoai, DiaChi, AnhHoSo FROM HoSo" +
									  " JOIN XetTuyen ON HoSo.MaHoSo=XetTuyen.MaHoSo" +
									  " JOIN Nganh ON XetTuyen.MaNganh=Nganh.MaNganh" +
									  " WHERE MaTruong=N'GTU'";
				DataTable table = new DataTable();
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(table);
				return table;
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
		public DataTable TimKiemHoSo(string mahoso)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM HoSo WHERE MaHoSo = @MaHoSo";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@MaHoSo", mahoso);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}
		public bool DeleteHoSo(string maHoSo)
		{
			if (string.IsNullOrEmpty(maHoSo)) // Check if maHoSo is null or empty
			{
				throw new ArgumentException("maHoSo cannot be null or empty.", nameof(maHoSo));
			}
			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					string deleteQuery = "DELETE FROM HoSo WHERE MaHoSo = @MaHoSo";
					using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
					{
						cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
						return cmd.ExecuteNonQuery() > 0;
					}
				}
			}
			catch (SqlException sqlEx)
			{
				// Log or handle SQL exceptions
				Console.WriteLine($"SQL Error: {sqlEx.Message}");
				return false;
			}
			catch (Exception ex)
			{
				// Log or handle other exceptions
				Console.WriteLine($"Error: {ex.Message}");
				return false;
			}
		}
	}
}
