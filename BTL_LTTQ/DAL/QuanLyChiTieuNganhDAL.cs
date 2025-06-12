using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class QuanLyChiTieuNganhDAL
    {
        private string connectionString = @"Data Source=KHABANH\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
        public DataTable GetAllXetTuyen()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT *" +
                               " FROM XetTuyen" +
							   " WHERE MaTruong = N'GTU'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
		public DataTable TimKiem(string mahoso)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "SELECT *" +
							   " FROM XetTuyen" +
							   " WHERE MaHoSo=@mahoso AND MaTruong=N'GTU'";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@MaHoSo", mahoso);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
			}
		}
		public DataTable GetAllNganh()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Nganh";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable DanhSachTrungTuyen()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
				string query = "DELETE DanhSachTrungTuyen\r\nDELETE ChiTieuConLai\r\nINSERT INTO ChiTieuConLai (MaNganh, ChiTieuCon)\r\nSELECT MaNganh, ChiTieu\r\nFROM Nganh;\r\nDECLARE @DanhSachTiepTuc TABLE (\r\n    MaHoSo VARCHAR(10),\r\n    MaNganh VARCHAR(10),\r\n    DiemXetTuyen FLOAT,\r\n    TTNV INT,\r\n    DaTrungTuyen BIT DEFAULT 0\r\n);\r\nINSERT INTO @DanhSachTiepTuc (MaHoSo, MaNganh, DiemXetTuyen, TTNV)\r\nSELECT MaHoSo, MaNganh, DiemXetTuyen, TTNV\r\nFROM XetTuyen\r\nWHERE MaTruong ='GTU'\r\nDECLARE @MaHoSo VARCHAR(10), @MaNganh VARCHAR(10), @DiemXetTuyen FLOAT, @TTNV INT;\r\nDECLARE @ChiTieuCon INT;\r\nWHILE EXISTS (\r\n    SELECT 1 \r\n    FROM @DanhSachTiepTuc \r\n    WHERE DaTrungTuyen = 0\r\n)\r\nBEGIN\r\n    SELECT TOP 1 \r\n        @MaHoSo = MaHoSo,\r\n        @MaNganh = MaNganh,\r\n        @DiemXetTuyen = DiemXetTuyen,\r\n        @TTNV = TTNV\r\n    FROM @DanhSachTiepTuc\r\n    WHERE DaTrungTuyen = 0\r\n    ORDER BY DiemXetTuyen DESC, TTNV ASC;\r\n\r\n    -- Kiểm tra chỉ tiêu của ngành\r\n    SELECT @ChiTieuCon = ChiTieuCon\r\n    FROM ChiTieuConLai\r\n    WHERE MaNganh = @MaNganh;\r\n\r\n    IF @ChiTieuCon > 0\r\n    BEGIN\r\n        INSERT INTO DanhSachTrungTuyen (MaHoSo, MaNganh, DiemXetTuyen, TTNV)\r\n        VALUES (@MaHoSo, @MaNganh, @DiemXetTuyen, @TTNV);\r\n        UPDATE ChiTieuConLai\r\n        SET ChiTieuCon = ChiTieuCon - 1\r\n        WHERE MaNganh = @MaNganh;\r\n        UPDATE @DanhSachTiepTuc\r\n        SET DaTrungTuyen = 1\r\n        WHERE MaHoSo = @MaHoSo;\r\n    END\r\n    ELSE\r\n    BEGIN\r\n        UPDATE @DanhSachTiepTuc\r\n        SET DaTrungTuyen = 1\r\n        WHERE MaHoSo = @MaHoSo AND MaNganh = @MaNganh;\r\n    END\r\nEND\r\nSELECT *\r\nFROM DanhSachTrungTuyen\r\nORDER BY MaNganh, DiemXetTuyen DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
		public DataTable DSTT(string maNganh)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = "SELECT * FROM DanhSachTrungTuyen " +
							   "Where MaNganh=@manganh " +
							   "ORDER BY MaNganh, DiemXetTuyen DESC";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@manganh", maNganh);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				return dt;
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
		public void DeleteAll()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "DELETE XetTuyen";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();

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
		public void Update()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "UPDATE xt\r\nSET TrungTuyen=N'Đỗ'\r\nFROM XetTuyen xt\r\nJOIN DanhSachTrungTuyen dstt ON xt.MaHoSo= dstt.MaHoSo\r\nWHERE xt.MaHoSo = dstt.MaHoSo AND xt.MaNganh=dstt.MaNganh";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();

			}
		}
		public void Update2()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "UPDATE XetTuyen\r\nSET TrungTuyen = N'Trượt'\r\nWHERE MaTruong='GTU' AND TrungTuyen IS NULL";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
			}
		}
		public void ThanhToan()
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "UPDATE ds\r\nSET ThanhToan=N'Đã thanh toán'\r\nFROM DanhSachTrungTuyen ds\r\nJOIN ThanhToan tt ON ds.MaHoSo=tt.MaHoSo\r\nWHERE ds.MaHoSo = tt.MaHoSo AND SoTienThanhToan IS NOT NULL\r\nUPDATE DanhSachTrungTuyen\r\nSET ThanhToan=N'Chưa thanh toán'\r\nWHERE ThanhToan IS NULL";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.ExecuteNonQuery();
			}
		}
		public bool SuaXetTuyen(string maHoSo, string maNganh, string maNganhMoi, float diemXetTuyen, string toHopXetTuyen, int TTNV)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string query = "UPDATE XetTuyen SET MaNganh=@maNganhMoi, DiemXetTuyen=@DiemXetTuyen, ToHopXetTuyen=@ToHopXetTuyen, TTNV=@TTNV WHERE MaHoSo = @MaHoSo AND MaNganh = @maNganh";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
				cmd.Parameters.AddWithValue("@maNganh", maNganh);
				cmd.Parameters.AddWithValue("@maNganhMoi", maNganhMoi);
				cmd.Parameters.AddWithValue("@DiemXetTuyen", diemXetTuyen);
				cmd.Parameters.AddWithValue("@ToHopXetTuyen", toHopXetTuyen);
				cmd.Parameters.AddWithValue("@TTNV", TTNV);
				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
		public bool DeleteXetTuyen(string maHoSo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "DELETE FROM XetTuyen WHERE MaHoSo = @MaHoSo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
