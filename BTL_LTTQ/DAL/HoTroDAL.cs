using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoTroDAL
    {
        private string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        private SqlConnection connection;
        public HoTroDAL()
        {
            connection = new SqlConnection(connectionString);
        }
        public bool ThemHoTro(string maHoSo, string thongTinYeuCau, string thongTinHoTro, string hinhThucHoTro)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"INSERT INTO HoTro (MaHoSo, ThongTinYeuCau, ThongTinHoTro, HinhThucHoTro) 
                               VALUES (@MaHoSo, @ThongTinYeuCau, @ThongTinHoTro, @HinhThucHoTro)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
                        cmd.Parameters.AddWithValue("@ThongTinYeuCau", thongTinYeuCau);
                        cmd.Parameters.AddWithValue("@ThongTinHoTro", thongTinHoTro);
                        cmd.Parameters.AddWithValue("@HinhThucHoTro", hinhThucHoTro);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
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
		public bool UpdateHoTro(string maHoSo, string thongTinYeuCau, string thongTinHoTro, string hinhThuc)
        {
            string query = @"UPDATE HoTro 
                        SET ThongTinYeuCau = @ThongTinYeuCau, 
                            ThongTinHoTro = @ThongTinHoTro, 
                            HinhThucHoTro = @HinhThucHoTro 
                        WHERE MaHoSo = @MaHoSo";
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
                    cmd.Parameters.AddWithValue("@ThongTinYeuCau", thongTinYeuCau);
                    cmd.Parameters.AddWithValue("@ThongTinHoTro", thongTinHoTro);
                    cmd.Parameters.AddWithValue("@HinhThucHoTro", hinhThuc);

                    int rowsAffected = cmd.ExecuteNonQuery();
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
