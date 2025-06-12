using BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BTL
{
	public partial class QuanLyDiem : Form
	{
		private QuanLyDiemBUS DiemBUS;
		public QuanLyDiem()
		{
			InitializeComponent();
			DiemBUS = new QuanLyDiemBUS();
			LoadInitialData();
			dataGridView1.MouseWheel += DataGridView1_MouseWheel;
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
		private void LoadInitialData()
		{
			dataGridView1.DataSource = DiemBUS.GetAllDiem();
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
			QuanLyNganhHoc quanLyHoSo = new QuanLyNganhHoc();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan quanLyHoSo = new QuanLyThanhToan();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyChiTieuNganh quanLyHoSo = new QuanLyChiTieuNganh();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoTro quanLyHoSo = new QuanLyHoTro();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login quanLyHoSo = new Login();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void button8_Click(object sender, EventArgs e)
		{
			if (DiemBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể thêm/ sửa điểm khi đã có danh sách trúng tuyển!!!");
				return;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Import Excel";
			openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
				try
				{
					// Kiểm tra tên file có hợp lệ không
					if (!IsValidFileName(fileName))
					{
						MessageBox.Show("Tên file không hợp lệ! Vui lòng chọn file có tên bắt đầu với 'DiemCuaCacThiSinh'");
						return;
					}

					// Nếu tên file hợp lệ, tiếp tục xử lý
					DiemBUS.ImportExcel(fileName, dataGridView1);
					MessageBox.Show("Nhập file thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
				}
			}
			this.Hide();
			QuanLyDiem quanLyHoSo = new QuanLyDiem();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		// Hàm kiểm tra tên file có hợp lệ không
		private bool IsValidFileName(string filePath)
		{
			string fileName = Path.GetFileName(filePath);

			// Kiểm tra xem tên file có bắt đầu với 'Diem_' và có phần mở rộng là .xlsx hoặc .xls không
			return fileName.StartsWith("DiemCuaCacThiSinh") && (fileName.EndsWith(".xlsx") || fileName.EndsWith(".xls"));
		}
		private void QuanLyDiem_Load(object sender, EventArgs e)
		{

		}
		private void button13_Click(object sender, EventArgs e)
		{

		}
		private void button12_Click(object sender, EventArgs e)
		{
			if (DiemBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể thêm/ sửa điểm khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int rowIndex = dataGridView1.CurrentCell.RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

				if (selectedRow.Cells["MaHoSo"].Value != null)
				{
					string maHoSo = selectedRow.Cells["MaHoSo"].Value.ToString();
					var result = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

					if (result == DialogResult.Yes)
					{
						try
						{
							if (DiemBUS.Delete(maHoSo))
							{
								MessageBox.Show("Xóa bản ghi thành công.");
								LoadInitialData();
							}
							else
							{
								MessageBox.Show("Không tìm thấy bản ghi để xóa.");
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
						}
					}
				}
				else
				{
					MessageBox.Show("Không thể xác định Mã Hồ Sơ để xóa.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một bản ghi để xóa.");
			}
		}
		private void button11_Click(object sender, EventArgs e)
		{
			if (DiemBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể thêm/ sửa điểm khi đã có danh sách trúng tuyển!!!");
				return;
			}
			this.Hide();
			ThemDiem themDiem = new ThemDiem();
			themDiem.ShowDialog();
			this.Close();
		}
		private void button9_Click(object sender, EventArgs e)
		{
			string maHoSo = textBox1.Text.Trim();
			try
			{
				DataTable result = DiemBUS.TimKiem(maHoSo);
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
	}
}
