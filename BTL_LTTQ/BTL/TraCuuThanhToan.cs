using BUS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTL
{
	public partial class TraCuuThanhToan : Form
	{
        private TraCuuThanhToanBUS traCuuThanhToanBUS;
		public TraCuuThanhToan()
		{
            InitializeComponent();
            traCuuThanhToanBUS = new TraCuuThanhToanBUS();
        }
		private void TraCuuThanhToan_Load(object sender, EventArgs e)
		{

		}
		// Sự kiện click nút Tìm kiếm
		private void btnTimKiem_Click(object sender, EventArgs e)
		{

		}
		private void txtMaHoSo_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox MaHoSo thay đổi (nếu cần)
		}
		private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox SoTienThanhToan thay đổi (nếu cần)
		}
		private void txtHinhThucThanhToan_TextChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi nội dung TextBox HinhThucThanhToan thay đổi (nếu cần)
		}
		private void dgvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Bỏ qua sự kiện này nếu không cần
		}
		private void btnTimKiem_Click_1(object sender, EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(txtNhapMaHoSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hồ sơ để tìm kiếm.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhapMaHoSo.Focus();
                return;
            }
            try
            {
                DataTable result = traCuuThanhToanBUS.TimKiemThanhToan(txtNhapMaHoSo.Text);

                if (result.Rows.Count > 0)
                {
                    DataRow row = result.Rows[0];
                    txtMaHoSo.Text = row["MaHoSo"].ToString();
                    txtHinhThucThanhToan.Text = row["HinhThucThanhToan"].ToString();
                    txtSoTienThanhToan.Text = row["SoTienThanhToan"].ToString();

                    string imagePath = row["BienLai"].ToString();
                    try
                    {
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            pbBienLai.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            pbBienLai.Image = null;
                            MessageBox.Show("Không tìm thấy tệp ảnh hoặc đường dẫn không hợp lệ.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                        pbBienLai.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hồ sơ trong cơ sở dữ liệu.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
		private void txtNhapMaHoSo_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan	quanLyThanhToan = new QuanLyThanhToan();
			quanLyThanhToan.ShowDialog();
			this.Close();
		}
	}
}
