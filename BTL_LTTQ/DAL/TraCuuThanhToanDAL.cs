using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TraCuuThanhToanDAL
    {
        private string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public DataTable GetThanhToanByMaHoSo(string maHoSo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaHoSo, HinhThucThanhToan, SoTienThanhToan, BienLai FROM ThanhToan WHERE MaHoSo = @maHoSo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maHoSo", maHoSo);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
