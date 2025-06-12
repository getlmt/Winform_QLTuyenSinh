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
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BTL
{
	public partial class ThemThanhToan : Form
	{
		private PaymentBUS thanhToanBUS;
		public ThemThanhToan()
		{
			InitializeComponent();
			thanhToanBUS = new PaymentBUS();
			LoadData();
		}
		public void LoadData()
		{
			try
			{
				dgvThongTin.DataSource = thanhToanBUS.GetAllThanhToan();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void ThemThanhToan_Load(object sender, EventArgs e)
		{

		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (thanhToanBUS.ChecKMaHoSo(txtMaHoSo.Text) == true)
			{
				MessageBox.Show("Mã hồ sơ đã tồn tại!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!thanhToanBUS.CheckMaHoSo2(txtMaHoSo.Text))
			{
				MessageBox.Show("Mã hồ sơ không tồn tại trong danh sách tham gia xét tuyển vào trường!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (string.IsNullOrWhiteSpace(txtMaHoSo.Text))
			{
				MessageBox.Show("Vui lòng nhập mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaHoSo.Focus();
				return;
			}
			if (string.IsNullOrWhiteSpace(txtHinhThucThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập hình thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHinhThucThanhToan.Focus();
				return;
			}
			if (string.IsNullOrWhiteSpace(txtSoTienThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập số tiền thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSoTienThanhToan.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtBienLai.Text))
			{
				MessageBox.Show("Vui lòng nhập biên lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBienLai.Focus();
				return;
			}
			try
			{
				bool success = thanhToanBUS.ThemThanhToan(
					txtMaHoSo.Text,
					txtHinhThucThanhToan.Text,
					txtSoTienThanhToan.Text,
					txtBienLai.Text
				);

				if (success)
				{
					MessageBox.Show("Thêm thông tin thành công.", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData();
				}
				else
				{
					MessageBox.Show("Thêm thông tin không thành công.", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm thông tin: " + ex.Message, "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void txtMaHoSo_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtBienLai_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan quanLyThanhToan = new QuanLyThanhToan();
			quanLyThanhToan.ShowDialog();
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!thanhToanBUS.CheckMaHoSo2(txtMaHoSo.Text))
			{
				MessageBox.Show("Mã hồ sơ không tồn tại trong danh sách tham gia xét tuyển vào trường!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (string.IsNullOrWhiteSpace(txtMaHoSo.Text))
			{
				MessageBox.Show("Vui lòng nhập mã hồ sơ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMaHoSo.Focus();
				return;
			}
			if (string.IsNullOrWhiteSpace(txtHinhThucThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập hình thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtHinhThucThanhToan.Focus();
				return;
			}
			if (string.IsNullOrWhiteSpace(txtSoTienThanhToan.Text))
			{
				MessageBox.Show("Vui lòng nhập số tiền thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSoTienThanhToan.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(txtBienLai.Text))
			{
				MessageBox.Show("Vui lòng nhập biên lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBienLai.Focus();
				return;
			}
			try
			{
				bool success = thanhToanBUS.SuaThanhToan(
					txtMaHoSo.Text,
					txtHinhThucThanhToan.Text,
					txtSoTienThanhToan.Text,
					txtBienLai.Text
				);

				if (success)
				{
					MessageBox.Show("Sửa thông tin thành công.", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadData();
				}
				else
				{
					MessageBox.Show("Sửa thông tin không thành công.", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi sửa thông tin: " + ex.Message, "Thông báo",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
