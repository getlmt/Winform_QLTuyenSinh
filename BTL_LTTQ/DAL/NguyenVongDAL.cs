using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class NguyenVongDAL
    {
        private string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public DataTable GetNguyenVongByMaHoSo(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM XetTuyen WHERE MaHoSo = @MaHoSo";
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
        }
        public bool DeleteNguyenVong(string maNganh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM XetTuyen WHERE MaNganh = @MaNganh";
                    command.Parameters.AddWithValue("@MaNganh", maNganh);
                    return command.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public float GetDiemXetTuyen(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT DiemXetTuyen FROM HocBa WHERE MaHoSo = @MaHoSo", connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToSingle(result) : 0;
                }
                catch
                {
                    return 0;
                }
            }
        }
		public bool KiemTraNguyenVong(string maNganh, string mahoso)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
					// Check if a record with the specified maHoSo and maNganh already exists
					SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM XetTuyen WHERE MaNganh = @manganh AND MaHoSo = @mahoso", connection);
					checkCommand.Parameters.AddWithValue("@manganh", maNganh);
					checkCommand.Parameters.AddWithValue("@mahoso", mahoso);
					int count = (int)checkCommand.ExecuteScalar();
					return count > 0; // Return true if record exists, false otherwise
				}
				catch
				{
					return false;
				}
			}
		}
		public bool CheckMaNganhExists(string maNganh)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Kiểm tra xem mã ngành có tồn tại trong bảng Nganh
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(*) FROM Nganh WHERE MaNganh = @manganh", connection);
					checkNganhCommand.Parameters.AddWithValue("@manganh", maNganh);
					int nganhExists = (int)checkNganhCommand.ExecuteScalar();
					return nganhExists > 0; // Trả về true nếu mã ngành tồn tại, false nếu không
				}
				catch
				{
					return false;
				}
			}
		}

		public bool InsertNguyenVong(string maHoSo, string maNganh, float diemXetTuyen)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO XetTuyen (MaHoSo, MaNganh, DiemXetTuyen) VALUES (@mahoso, @manganh, @dxt)";
                    command.Parameters.AddWithValue("@mahoso", maHoSo);
                    command.Parameters.AddWithValue("@manganh", maNganh);
                    command.Parameters.AddWithValue("@dxt", diemXetTuyen);
                    return command.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }
            }
        }
        public DataTable GetAllNganh()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Nganh";
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                return table;
            }
        }
        public string GetHoTen(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT HoTen FROM HoSo WHERE MaHoSo = @MaHoSo", connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}
