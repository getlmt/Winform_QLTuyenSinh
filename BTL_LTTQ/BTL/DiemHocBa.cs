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
using DAL;
using BUS;
using Microsoft.VisualBasic.ApplicationServices;
namespace BTL
{
	public partial class DiemHocBa : Form
	{
		string ma;
		HocBaBUS HocBabus;
		IDiemHocBa diemHocBa;
		public DiemHocBa(string userId)
		{
			ma = userId;
			HocBabus = new HocBaBUS();
			InitializeComponent();
			if (HocBabus.GetDiemSu(ma) == "0")
			{
				txtDiemSu.Hide();
				lblSu.Hide();
			}
			if (HocBabus.GetDiemDia(ma) == "0")
			{
				txtDiemDia.Hide();
				lblDia.Hide();
			}
			if (HocBabus.GetDiemGDCD(ma) == "0")
			{
				txtDiemGDCD.Hide();
				lblGDCD.Hide();
			}
			if (HocBabus.GetDiemLy(ma) == "0")
			{
				txtDiemLy.Hide();
				lblLy.Hide();
			}
			if (HocBabus.GetDiemHoa(ma) == "0")
			{
				txtDiemHoa.Hide();
				lblHoa.Hide();
			}
			if (HocBabus.GetDiemSinh(ma) == "0")
			{
				txtDiemSinh.Hide();
				lblSinh.Hide();
			}
		}
		public string GetMaHoSo()
		{
			return ma;
		}
		public string GetHoTen()
		{
			string hoten = "";
			string maHoSo = GetMaHoSo();
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
			label1.Text = hoten;
		}
		private void button8_Click(object sender, EventArgs e)
		{
			this.Hide();
			ChangePassword changePassword = new ChangePassword(ma);
			changePassword.ShowDialog();
			this.Close();
		}
		private bool ValidateScore(string scoreText)
		{
			if (double.TryParse(scoreText, out double score))
			{
				return score >= 0 && score <= 10;
			}
			return false;
		}
		public void txtDiemToan_Load(object sender, EventArgs e)
		{
			txtDiemToan.Text = HocBabus.GetDiemToan(ma);
		}
		public void txtDiemVan_Load(object sender, EventArgs e)
		{
			txtDiemVan.Text = HocBabus.GetDiemVan(ma);
		}
		public void txtDiemAnh_Load(object sender, EventArgs e)
		{
			txtDiemAnh.Text = HocBabus.GetDiemAnh(ma);
		}
		public void txtDiemLy_Load(object sender, EventArgs e)
		{
			txtDiemLy.Text = HocBabus.GetDiemLy(ma);
		}
		public void txtDiemHoa_Load(object sender, EventArgs e)
		{
			txtDiemHoa.Text = HocBabus.GetDiemHoa(ma);
		}
		public void txtDiemSinh_Load(object sender, EventArgs e)
		{
			txtDiemSinh.Text = HocBabus.GetDiemSinh(ma);
		}
		public void txtDiemSu_Load(object sender, EventArgs e)
		{ 
			txtDiemSu.Text = HocBabus.GetDiemSu(ma);
		}
		public void txtDiemDia_Load(object sender, EventArgs e)
		{
			txtDiemDia.Text = HocBabus.GetDiemDia(ma);
		}
		public void txtDiemGDCD_Load(object sender, EventArgs e)
		{
			txtDiemGDCD.Text = HocBabus.GetDiemGDCD(ma);
		}
		public void txtDiemHocBa_Load(object sender, EventArgs e)
		{
			txtDiemHocBa.Text = HocBabus.GetDiemTrungBinhHocBa(ma);
		}
		public void txtHanhKiem_Load(object sender, EventArgs e)
		{
			string maHoSo = GetMaHoSo();
			using (SqlConnection connection = DBConnection.GetConnection())
			{
				connection.Open();
				// Câu lệnh SQL để lấy điểm xét tuyển
				string sql = "SELECT HanhKiemCap3 FROM Diem WHERE MaHoSo = @MaHoSo";
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@MaHoSo", maHoSo);
				// Thực thi câu lệnh và lấy dữ liệu
				object result = Convert.ToString(command.ExecuteScalar());
				txtHanhKiem.Text = (string)result;
			}
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
		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			Payment payment = new Payment(ma);
			payment.ShowDialog();
			this.Close();
		}
		private void button10_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void txtHanhKiem_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtDiemThi_TextChanged(object sender, EventArgs e)
		{

		}
		private void button7_Click(object sender, EventArgs e)
		{

		}
		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThemHoTro themHoTro = new ThemHoTro(ma);
			themHoTro.ShowDialog();
			this.Close();
		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void DiemHocBa_Load(object sender, EventArgs e)
		{
			InitializeComponent();

		}
		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}
		private void txt121_TextChanged(object sender, EventArgs e)
		{

		}
	}
}