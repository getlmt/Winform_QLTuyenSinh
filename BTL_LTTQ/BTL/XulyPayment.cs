using BUS;
using DAL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
	public partial class XulyPayment : Form
	{
		public string ma;
		public PaymentBUS paymentBUS;
		public XulyPayment(string hinhThucThanhToan, string userId)
		{
			ma = userId;
			InitializeComponent();
			txtHinhThucThanhToan.Text = hinhThucThanhToan;
			txtMaHoSo.Enabled = false;
			paymentBUS = new PaymentBUS();
		}
		public void ShowMaHoSo(object sender, EventArgs e)
		{
			string a = GetMaHoSo();
			txtMaHoSo.Text = a;
		}
		private string _hinhThucThanhToan;
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void XulyPayment_Load(object sender, EventArgs e)
		{

		}
		private void txtMaHoSo_TextChanged(object sender, EventArgs e)
		{
			string maHoSo = txtMaHoSo.Text;
			// Kiểm tra có ký tự đặc biệt hay không (không bao gồm chữ cái, số, dấu gạch ngang và dấu gạch dưới)
			if (System.Text.RegularExpressions.Regex.IsMatch(maHoSo, @"[^a-zA-Z0-9_-]"))
			{
				MessageBox.Show("Mã hồ sơ không được chứa ký tự đặc biệt như .,;@.");
				txtMaHoSo.Focus(); // Trả focus về textbox mã hồ sơ
				txtMaHoSo.SelectAll(); // Chọn toàn bộ văn bản để người dùng có thể nhập lại
			}
		}
		private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
		{
			if (!paymentBUS.ValidateSoTien(txtSoTienThanhToan.Text))
			{
				MessageBox.Show("Số tiền thanh toán không hợp lệ hoặc là số âm.");
				txtSoTienThanhToan.Focus();
				txtSoTienThanhToan.SelectAll();
			}
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			// Kiểm tra các trường dữ liệu bắt buộc
			if (string.IsNullOrEmpty(txtMaHoSo.Text))
			{
				MessageBox.Show("Bạn phải nhập mã hồ sơ.");
				txtMaHoSo.Focus();
				return;
			}
			if (string.IsNullOrEmpty(txtSoTienThanhToan.Text) || !double.TryParse(txtSoTienThanhToan.Text, out double soTienThanhToan) || soTienThanhToan < 0)
			{
				MessageBox.Show("Bạn phải nhập số tiền thanh toán hợp lệ.");
				txtSoTienThanhToan.Focus();
				return;
			}
			if (soTienThanhToan == 0)
			{
				MessageBox.Show("Bạn chưa đăng ký nguyện vọng!");
				txtSoTienThanhToan.Focus();
				return;
			}
			// Kiểm tra nếu ảnh biên lai chưa được chọn
			if (string.IsNullOrEmpty(pbBienLai.ImageLocation))
			{
				MessageBox.Show("Bạn phải chọn ảnh biên lai.");
				return;
			}
			// Initialize the connection with a valid connection string
			try
			{
				bool success = paymentBUS.ThemThanhToan(
					txtMaHoSo.Text,
					txtHinhThucThanhToan.Text,
					txtSoTienThanhToan.Text,
					pbBienLai.ImageLocation
				);

				if (success)
				{
					MessageBox.Show("Dữ liệu đã được lưu thành công!");
				}
				else
				{
					MessageBox.Show("Lỗi khi lưu dữ liệu!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
			}
		}
		private void pbBienLai_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
				openFileDialog.Title = "Chọn ảnh biên lai";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					// Hiển thị đường dẫn ảnh đã chọn lên biên lai

					pbBienLai.ImageLocation = openFileDialog.FileName; // Lưu đường dẫn ảnh vào tag của PictureBox để dùng sau
				}
			}
		}
		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			DiemHocBa diemHocBa = new DiemHocBa(ma);
			diemHocBa.ShowDialog();
			this.Close();
		}
		public string GetMaHoSo()
		{
			return ma;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			UserInterface userInterface = new UserInterface(ma);
			userInterface.ShowDialog();
			this.Close();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			NguyenVong nguyenVong = new NguyenVong(ma);
			nguyenVong.ShowDialog();
			this.Close();
		}
		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			ChangePassword changePassword = new ChangePassword(ma);
			changePassword.ShowDialog();
			this.Close();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Payment payment = new Payment(ma);
			payment.ShowDialog();
			this.Close();
		}
		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThemHoTro themHoTro = new ThemHoTro(ma);
			themHoTro.ShowDialog();
			this.Close();
		}
		private void lblTen_Load(object sender, EventArgs e)
		{
			label5.Text = paymentBUS.GetHoTen(ma);
		}
		private void txtSoTienThanhToan_VisibleChanged(object sender, EventArgs e)
		{
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				string query = "SELECT 8400000 FROM XetTuyen WHERE MaHoSo = @MaHoSo";
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@MaHoSo", ma);
				connection.Open();
				object result = command.ExecuteScalar();
				txtSoTienThanhToan.Text = result != null ? result.ToString() : "0";
			}
		}
	}
}
