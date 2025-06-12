using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyThanhToanDAL
    {
        private string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        private SqlConnection connection;
        public QuanLyThanhToanDAL()
        {
            connection = new SqlConnection(connectionString);
        }
        public DataTable GetAllThanhToan()
        {
            DataTable table = new DataTable();
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
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return table;
        }
        public bool XoaThanhToan(string maHoSo)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM ThanhToan WHERE MaHoSo = @maHoSo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maHoSo", maHoSo);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
