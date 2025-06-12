using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocBaDAL
    {
        public DataTable GetHocBa(string maHoSo)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Diem WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public string GetHoTen(string maHoSo)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                string query = "SELECT HoTen FROM HoSo WHERE MaHoSo = @MaHoSo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : string.Empty;
            }
        }
        public string GetDiemHocBa(string maHoSo, string columnName)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    string query = $"SELECT {columnName} FROM Diem WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? Convert.ToString(result) : string.Empty;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lấy điểm: {ex.Message}");
                }
            }
        }
        private bool CheckHocBaExists(string maHoSo, SqlConnection connection)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM Diem WHERE MaHoSo = @mahoso";
            command.Parameters.AddWithValue("@mahoso", maHoSo);
            return (int)command.ExecuteScalar() > 0;
        }
        private void AddHocBaParameters(SqlCommand command, string maHoSo, HocBaModel hocBa)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@mahoso", maHoSo);
            command.Parameters.AddWithValue("@DiemToan", hocBa.DiemToan);
            command.Parameters.AddWithValue("@DiemVan", hocBa.DiemVan);
            command.Parameters.AddWithValue("@DiemAnh", hocBa.DiemAnh);
            command.Parameters.AddWithValue("@DiemLy", hocBa.DiemLy);
            command.Parameters.AddWithValue("@DiemHoa", hocBa.DiemHoa);
            command.Parameters.AddWithValue("@DiemSinh", hocBa.DiemSinh);
            command.Parameters.AddWithValue("@DiemSu", hocBa.DiemSu);
			command.Parameters.AddWithValue("@DiemDia", hocBa.DiemDia);
			command.Parameters.AddWithValue("@DiemGDCD", hocBa.DiemGDCD);
			command.Parameters.AddWithValue("@DiemHocBa", hocBa.DiemHocBaTrungBinh);
			command.Parameters.AddWithValue("@HanhKiem", hocBa.HanhKiem);
        }
        public HocBaModel GetHocBaModel(string maHoSo)
        {
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Diem WHERE MaHoSo = @MaHoSo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new HocBaModel
                        {
                            MaHoSo = maHoSo,
							DiemHocBaTrungBinh = reader["DiemHocBaTrungBinh"].ToString(),
							DiemToan = reader["DiemToan"].ToString(),
							DiemVan = reader["DiemVan"].ToString(),
							DiemAnh = reader["DiemAnh"].ToString(),
							DiemLy = reader["DiemLy"].ToString(),
							DiemHoa = reader["DiemHoa"].ToString(),
							DiemSinh = reader["DiemSinh"].ToString(),
							DiemSu = reader["DiemSu"].ToString(),
							DiemDia = reader["DiemDia"].ToString(),
							DiemGDCD = reader["DiemGDCD"].ToString(),
							HanhKiem = reader["HanhKiemCap3"].ToString()
                        };
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Lỗi khi lấy thông tin điểm: {ex.Message}");
                }
            }
        }
    }
}