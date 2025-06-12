using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyNganhDAL
    {
        private string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public QuanLyNganhDAL()
        {
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
        }
        public DataTable GetAllNganh()
        {
            DataTable table = new DataTable();
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT MaNganh, MoTa, TenNganh, ChiTieu FROM Nganh";
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            finally
            {
                connection.Close();
            }
            return table;
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
		public bool ThemNganh(string maNganh, string moTa, string tenNganh, int chiTieu)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Nganh (MaNganh, MoTa, TenNganh, ChiTieu) VALUES (@manganh, @mota, @ten, @chitieu)";
                command.Parameters.AddWithValue("@manganh", maNganh);
                command.Parameters.AddWithValue("@mota", moTa);
				command.Parameters.AddWithValue("@ten", tenNganh);
				command.Parameters.AddWithValue("@chitieu", chiTieu);
				return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }
		public DataTable TimKiemNganh(string maNganh)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM Nganh WHERE MaNganh = @MaNganh";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@MaNganh", maNganh);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}
		public bool XoaNganh(string maNganh)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Nganh WHERE MaNganh = @MaNganh";
                command.Parameters.AddWithValue("@MaNganh", maNganh);
                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool SuaNganh(string maNganh, string moTa, string tenNganh, int chiTieu)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "UPDATE Nganh SET MoTa=@mota, TenNganh=@ten, ChiTieu=@chitieu WHERE MaNganh=@manganh";
                command.Parameters.AddWithValue("@manganh", maNganh);
                command.Parameters.AddWithValue("@mota", moTa);
                command.Parameters.AddWithValue("@ten", tenNganh);
				command.Parameters.AddWithValue("@chitieu", chiTieu);
				return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool KiemTraMaNganhTonTai(string maNganh)
        {
            try
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "SELECT COUNT(*) FROM Nganh WHERE MaNganh = @manganh";
                command.Parameters.AddWithValue("@manganh", maNganh);
                return (int)command.ExecuteScalar() > 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
