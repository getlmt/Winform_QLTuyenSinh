using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoSoDAL
    {
        private string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public bool KiemTraMaHoSo(string maHoSo)
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
		public bool CheckMaHoSoExists(string maHoSO)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					// Kiểm tra xem mã ngành có tồn tại trong bảng Nganh
					SqlCommand checkNganhCommand = new SqlCommand("SELECT COUNT(*) FROM HoSo JOIN XetTuyen ON HoSo.MaHoSo=XetTuyen.MaHoSo WHERE HoSo.MaHoSo = @maHoSo AND MaTruong=N'GTU'", connection);
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
		public string GetMaxMaHoSo()
        {
            string maHoSoLonNhat = "HS000";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MAX(MaHoSo) AS MaHoSoLonNhat FROM HoSo";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            maHoSoLonNhat = result.ToString();
                        }
                    }
                }
                catch (Exception)
                {
                    // Return default value if there's an error
                    return maHoSoLonNhat;
                }
            }
            return maHoSoLonNhat;
        }
            public bool ThemHoSo(string maHoSo, string hoTen, string diaChi, string sdt, string gioiTinh, DateTime ngaySinh, string anhHoSo)
            {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = @"INSERT INTO HoSo (MaHoSo, HoTen, DiaChi, SoDienThoai, 
                                                   GioiTinh, NgaySinh, AnhHoSo) 
                                 VALUES (@MaHoSo, @HoTen, @DiaChi, @SoDienThoai, 
                                        @GioiTinh, @NgaySinh, @AnhHoSo)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@AnhHoSo", anhHoSo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
