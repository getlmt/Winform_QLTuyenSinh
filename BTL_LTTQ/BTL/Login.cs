using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using DAL;
using BUS;
namespace BTL
{
	public partial class Login : Form
	{
		UserBUS user_bus;
		UserDAL user_dal;
		public Login()
		{
			InitializeComponent();
			user_bus = new UserBUS(); 
			user_dal = new UserDAL();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		private void label7_Click(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void button3_Click(object sender, EventArgs e)
		{
		}
		private string KiemTraDangNhap(string tentk, string mk)
		{
			string maHoSo = string.Empty; // Biến lưu mã hồ sơ nếu đăng nhập thành công
			string query = "SELECT MaHoSo FROM Users WHERE Account = @Account AND Password = @Password";
			try
			{
				using (SqlConnection con = DBConnection.GetConnection())
				{
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						// Thêm tham số vào câu truy vấn để tránh SQL Injection
						cmd.Parameters.AddWithValue("@Account", tentk);
						cmd.Parameters.AddWithValue("@Password", mk);

						con.Open(); // Mở kết nối

						object result = cmd.ExecuteScalar(); // Thực thi truy vấn và lấy mã hồ sơ nếu có

						if (result != null) // Kiểm tra nếu kết quả không rỗng
						{
							maHoSo = result.ToString();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
			}
			return maHoSo; // Trả về mã hồ sơ (nếu không tìm thấy trả về chuỗi rỗng)
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string tentk = textBox1.Text.Trim(); // Get and trim username input
			string mk = textBox2.Text.Trim(); // Get and trim password input

			// Check for empty username
			if (string.IsNullOrEmpty(tentk))
			{
				MessageBox.Show("Vui lòng nhập tên tài khoản!");
				textBox1.Focus(); 
				return;
			}
			if (string.IsNullOrEmpty(mk))
			{
				MessageBox.Show("Vui lòng nhập mật khẩu");
				textBox2.Focus(); 
				return; 
			}
			if (user_bus.IsAdmin(tentk, mk))
			{
				MessageBox.Show("Admin đăng nhập thành công!");
				this.Hide();
			
				QuanLyHoSo quanLyHoSo = new QuanLyHoSo();
				quanLyHoSo.ShowDialog();
				this.Close(); 
				return;
			}
			string maHoSo = user_dal.GetMaHoSo(tentk , mk);
			if (string.IsNullOrEmpty(maHoSo)) 
			{
				MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại.");
				textBox1.Clear();
				textBox2.Clear();
				textBox1.Focus();
			}
			else 
			{
				MessageBox.Show("Đăng nhập thành công!");
				this.Hide();

				UserInterface userform = new UserInterface(maHoSo);
				Console.WriteLine(maHoSo);
				userform.ShowDialog();

				this.Close(); // Close the login form when the user interface form is closed
			}
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				button2.PerformClick(); 
				e.SuppressKeyPress = true; 
			}
		}
		private void TextBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				textBox2.Focus(); 
				e.SuppressKeyPress = true; 
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
		private void textBox2_Enter(object sender, EventArgs e)
		{
			string tentk = textBox1.Text;
			string mk = textBox2.Text;
			if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
			if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); }
			string maHoSo = KiemTraDangNhap(tentk, mk);
			if (maHoSo != string.Empty)
				if (string.IsNullOrEmpty(maHoSo)) // Nếu mã hồ sơ rỗng, hiển thị thông báo lỗi
				{
					MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại.");
					textBox1.Clear();
					textBox2.Clear();
					textBox1.Focus(); // Đặt con trỏ vào ô nhập tài khoản
				}
				else // Nếu mã hồ sơ hợp lệ, tiến hành đăng nhập
				{
					MessageBox.Show("Đăng nhập thành công!");
					this.Hide();
					UserInterface userform = new UserInterface(maHoSo);
					userform.ShowDialog();
					this.Show(); // Hiển thị lại form đăng nhập khi đóng form giao diện người dùng
				}
		}
	}
}
