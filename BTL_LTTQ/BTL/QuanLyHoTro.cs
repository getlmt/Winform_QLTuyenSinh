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
namespace BTL
{
	public partial class QuanLyHoTro : Form
	{
		private QuanLyHoTroBUS hoTroBUS;
		public void Loaddata()
		{
			dataGridView1.DataSource = hoTroBUS.GetAllHoTro();
		}
		public QuanLyHoTro()
		{
			InitializeComponent();
			hoTroBUS = new QuanLyHoTroBUS();
			dataGridView1.MouseWheel += DataGridView1_MouseWheel;
		}
		private void QuanLyHoTro_Load(object sender, EventArgs e)
		{
			button11.Enabled = false;
			Loaddata();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			button11.Enabled = true;
		}
		private void button9_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThemHoTro themhotro = new ThemHoTro();
			themhotro.ShowDialog();
			this.Close();
		}
		private void DataGridView1_MouseWheel(object sender, MouseEventArgs e)
		{
			// Kiểm tra xem con lăn chuột cuộn lên hay xuống
			if (e.Delta > 0) // Cuộn lên
			{
				if (dataGridView1.FirstDisplayedScrollingRowIndex > 0)
				{
					dataGridView1.FirstDisplayedScrollingRowIndex--;
				}
			}
			else if (e.Delta < 0) // Cuộn xuống
			{
				if (dataGridView1.FirstDisplayedScrollingRowIndex < dataGridView1.RowCount - 1)
				{
					dataGridView1.FirstDisplayedScrollingRowIndex++;
				}
			}
		}
		private void button11_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridView1.SelectedCells.Count > 0)
				{
					int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
					string maHoSo = dataGridView1.Rows[selectedRowIndex].Cells["MaHoSo"].Value?.ToString();

					if (!string.IsNullOrWhiteSpace(maHoSo))
					{
						DialogResult result = MessageBox.Show(
							$"Bạn có chắc chắn muốn xóa hồ sơ {maHoSo} không?",
							"Xác nhận xóa",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Warning);

						if (result == DialogResult.Yes)
						{
							if (hoTroBUS.XoaHoTro(maHoSo))
							{
								MessageBox.Show("Xóa thành công!", "Thông báo");
								Loaddata();
								button11.Enabled = false;
							}
							else
							{
								MessageBox.Show("Không tìm thấy hồ sơ cần xóa.", "Thông báo");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
			}
		}
		private void button10_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
				DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

				string maHoSo = row.Cells["MaHoSo"].Value.ToString();
				string thongTinYeuCau = row.Cells["ThongTinYeuCau"].Value.ToString();
				string thongTinHoTro = row.Cells["ThongTinHoTro"].Value.ToString();
				string hinhThucHoTro = row.Cells["HinhThucHoTro"].Value.ToString();

				SuaHoTro suaForm = new SuaHoTro(maHoSo, thongTinYeuCau, thongTinHoTro, hinhThucHoTro);
				suaForm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một ô để sửa.", "Thông báo");
			}
		}
		private void button12_Click(object sender, EventArgs e)
		{
			string maHoSo = textBox1.Text.Trim();
			try
			{
				DataTable result = hoTroBUS.TimKiemHoSo(maHoSo);
				if (result.Rows.Count > 0)
				{
					dataGridView1.DataSource = result;
				}
				else
				{
					MessageBox.Show("Không tìm thấy hồ sơ.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoSo quanLyHoSo = new QuanLyHoSo();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyNganhHoc quanLyNganhHoc = new QuanLyNganhHoc();
			quanLyNganhHoc.ShowDialog();
			this.Close();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan quanLyThanhToan = new QuanLyThanhToan();
			quanLyThanhToan.ShowDialog();
			this.Close();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyChiTieuNganh quanLyChiTieuNganh = new QuanLyChiTieuNganh();
			quanLyChiTieuNganh.ShowDialog();
			this.Close();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox1.Clear();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyDiem quanLyHoSo = new QuanLyDiem();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
	}
}
