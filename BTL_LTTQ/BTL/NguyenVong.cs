using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;
using BUS;
using DAL;
using System.Data.Common;
namespace BTL
{
	public partial class NguyenVong : Form
	{

		string ma;
		NguyenVongBUS nguyenvong;
		PaymentBUS paymentBUS;
		public NguyenVong(string userId)
		{
			ma = userId;
			InitializeComponent();
			nguyenvong = new NguyenVongBUS();
			paymentBUS = new PaymentBUS();
			dataGridView1.DataSource = nguyenvong.GetNguyenVongByMaHoSo(ma);
		}
		private void btnHome_Click(object sender, EventArgs e)
		{
			this.Hide();
			UserInterface HoSo = new UserInterface(ma);
			HoSo.ShowDialog();
			this.Close();
		}
		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			this.Hide();
			ChangePassword changePassword = new ChangePassword(ma);
			changePassword.ShowDialog();
			this.Close();

		}
		private void btnPayment_Click(object sender, EventArgs e)
		{
			this.Hide();
			Payment payment = new Payment(ma);
			payment.ShowDialog();
			this.Close();
		}
		private void btnSupport_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThemHoTro themHoTro = new ThemHoTro(ma);
			themHoTro.ShowDialog();
			this.Close();
		}
		private void btnSignOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void btnPreferences_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}
		private void NguyenVong_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = nguyenvong.GetNguyenVongByMaHoSo(ma);
		}
		private void button1_Click(object sender, EventArgs e)
		{
		}
		public string GetHoTen()
		{
			string hoten = "";
			string maHoSo = ma;
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				try
				{
					connection.Open();
					// Câu lệnh SQL để lấy điểm xét tuyển
					string sql = "SELECT HoTen FROM HoSo WHERE MaHoSo = @MaHoSo";
					SqlCommand command = new SqlCommand(sql, connection);
					command.Parameters.AddWithValue("@MaHoSo", maHoSo);
					// Thực thi câu lệnh và lấy dữ liệu
					object result = command.ExecuteScalar();
					hoten = (string)result;
					// Sử dụng ExecuteScalar() vì chỉ lấy một giá trị
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Lỗi: {ex.Message}");
				}
			}
			return hoten;
		}
		private void lblTen_Load(object sender, EventArgs e)
		{
			string hoten = GetHoTen();
			label1.Text = hoten; // Hiển thị với 2 chữ số thập phân
		}
		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			DiemHocBa diemHocBa = new DiemHocBa(ma);
			diemHocBa.ShowDialog();
			this.Close();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
