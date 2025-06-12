using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class PaymentDAL
    {
        private string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public bool CheckPaymentExists(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM ThanhToan WHERE MaHoSo = @MaHoSo", connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                return (int)command.ExecuteScalar() > 0;
            }
        }
		public bool CheckMaHoSoExists(string maHoSO)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Kiểm tra xem mã ngành có tồn tại trong bảng Nganh
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(*) FROM ThanhToan WHERE HoSo.MaHoSo = @maHoSo", connection);
					checkNganhCommand.Parameters.AddWithValue("@maHoSo", maHoSO);
					int nganhExists = (int)checkNganhCommand.ExecuteScalar();
					return nganhExists > 0; // Trả về true nếu mã ngành tồn tại, false nếu không
				}
				catch
				{
					return false;
				}
			}
		}
		public bool KiemTraMaHoSo2(string maHoSo)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string query = "SELECT COUNT(*) FROM XetTuyen WHERE MaHoSo = @MaHoSo AND MaTruong=N'GTU'";
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
			}
		}
		public bool ThemThanhToan(string maHoSo, string hinhThuc, decimal soTien, string bienLai)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO ThanhToan (MaHoSo, HinhThucThanhToan, SoTienThanhToan, BienLai) 
                               VALUES (@maHoSo, @hinhThuc, @soTien, @bienLai)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maHoSo", maHoSo);
                        command.Parameters.AddWithValue("@hinhThuc", hinhThuc);
                        command.Parameters.AddWithValue("@soTien", soTien);
                        command.Parameters.AddWithValue("@bienLai", bienLai);
                        return command.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
		public bool SuaThanhToan(string maHoSo, string hinhThuc, decimal soTien, string bienLai)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();
                    string query = @"UPDATE ThanhToan SET HinhThucThanhToan=@hinhthuc, SoTienThanhToan=@soTien, BienLai=@bienLai WHERE MaHoSo=@maHoSo";
					using (SqlCommand command = new SqlCommand(query, connection))
					{
						command.Parameters.AddWithValue("@maHoSo", maHoSo);
						command.Parameters.AddWithValue("@hinhThuc", hinhThuc);
						command.Parameters.AddWithValue("@soTien", soTien);
						command.Parameters.AddWithValue("@bienLai", bienLai);
						return command.ExecuteNonQuery() > 0;
					}
				}
				catch (Exception)
				{
					throw;
				}
			}
		}
		public DataTable GetAllThanhToan()
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM ThanhToan";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return table;
        }
        public bool KiemTraMaHoSo(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ThanhToan WHERE MaHoSo = @maHoSo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maHoSo", maHoSo);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public string GetHoTen(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT HoTen FROM HoSo WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    object result = command.ExecuteScalar();
                    return result != null ? (string)result : "";
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }
    }
}
