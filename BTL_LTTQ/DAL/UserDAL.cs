using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
	public class UserDAL
	{
		SqlConnection connection = DBConnection.GetConnection();
		public string GetMaHoSo(string username, string password)
		{
			string maHoSo = string.Empty;
			string query = "SELECT MaHoSo FROM Users WHERE Account = @Account AND Password = @Password";
			try
			{
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@Account", username);
					cmd.Parameters.AddWithValue("@Password", password);
					connection.Open();
					object result = cmd.ExecuteScalar();
					if (result != null)
					{
						maHoSo = result.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception($"Lỗi truy cập dữ liệu: {ex.Message}");
			}
			finally
			{
				connection.Close();
			}
			return maHoSo;
		}
		public bool VerifyOldPassword(string maHoSo, string oldPassword)
		{
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				string query = "SELECT COUNT(*) FROM Users WHERE MaHoSo = @MaHoSo AND Password = @OldPassword";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@MaHoSo", maHoSo);
				command.Parameters.AddWithValue("@OldPassword", oldPassword);

				connection.Open();
				int count = (int)command.ExecuteScalar();
				return count > 0;
			}
		}
		public bool CheckAccountExists(string account)
		{
			string query = "SELECT COUNT(*) FROM Users WHERE Account = @Account";
			using (SqlCommand cmd = new SqlCommand(query, connection))
			{
				cmd.Parameters.AddWithValue("@Account", account);
				try
				{
					connection.Open();
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
				finally
				{
					connection.Close();
				}
			}
		}
		public string GetMaxMaHoSo()
		{
			string maHoSoLonNhat = "HS000";
			string query = "SELECT MAX(MaHoSo) AS MaHoSoLonNhat FROM Users";
			try
			{
				connection.Open();
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					object result = cmd.ExecuteScalar();
					if (result != DBNull.Value && result != null)
					{
						maHoSoLonNhat = result.ToString();
					}
				}
			}
			finally
			{
				connection.Close();
			}
			return maHoSoLonNhat;
		}
		public bool UpdatePassword(string maHoSo, string newPassword)
		{
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				string query = "UPDATE Users SET Password = @NewPassword WHERE MaHoSo = @MaHoSo";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@NewPassword", newPassword);
				command.Parameters.AddWithValue("@MaHoSo", maHoSo);

				connection.Open();
				int rowsAffected = command.ExecuteNonQuery();
				return rowsAffected > 0;
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
				// Check if the result is DBNull
				return result != DBNull.Value ? (string)result : string.Empty; // Properly checking for DBNull
			}
		}
		public DataTable GetThongTinHoSo(string maHoSo)
		{
			try
			{
				connection.Open();
				string sql = "SELECT * FROM HoSo WHERE MaHoSo = @MaHoSo";
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@MaHoSo", maHoSo);
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
			finally
			{
				connection.Close();
			}
		}
		public bool UpdateHoSo(string maHoSo, string hoTen, string diaChi, string sdt, string gioiTinh, string ngaySinh, string anhHoSo)
		{
			try
			{
				connection.Open();
				string sql = @"UPDATE HoSo 
                             SET HoTen = @hoten, NgaySinh = @ngaysinh, 
                                 GioiTinh = @gioitinh, SoDienThoai = @sdt, 
                                 DiaChi = @diachi, AnhHoSo = @anh 
                             WHERE MaHoSo = @mahoso";

				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@mahoso", maHoSo);
					command.Parameters.AddWithValue("@hoten", hoTen);
					command.Parameters.AddWithValue("@ngaysinh", ngaySinh);
					command.Parameters.AddWithValue("@gioitinh", gioiTinh);
					command.Parameters.AddWithValue("@sdt", sdt);
					command.Parameters.AddWithValue("@diachi", diaChi);
					command.Parameters.AddWithValue("@anh", anhHoSo);

					return command.ExecuteNonQuery() > 0;
				}
			}
			catch (Exception)
			{
				throw;
			}
			finally
			{
				connection.Close();
			}
		}
		public bool CreateNewAccount(string maHoSo, string account, string password)
		{
			bool success = false;
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				connection.Open();
				using (SqlTransaction transaction = connection.BeginTransaction())
				{
					try
					{
						// Insert into Users table
						string userQuery = "INSERT INTO Users (MaHoSo, Account, Password) VALUES (@MaHoSo, @Account, @Password)";
						using (SqlCommand cmd = new SqlCommand(userQuery, connection, transaction))
						{
							cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
							cmd.Parameters.AddWithValue("@Account", account);
							cmd.Parameters.AddWithValue("@Password", password);
							cmd.ExecuteNonQuery();
						}
						string hosoQuery = "INSERT INTO hoso(MaHoSo) VALUES (@MaHoSo)";
						using (SqlCommand cmd = new SqlCommand(hosoQuery, connection, transaction))
						{
							cmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
							cmd.ExecuteNonQuery();
						}

						transaction.Commit();
						success = true;
					}
					catch
					{
						transaction.Rollback();
						throw;
					}
					finally
					{
						connection.Close();
					}
				}
				return success;
			}
		}
	}
}
