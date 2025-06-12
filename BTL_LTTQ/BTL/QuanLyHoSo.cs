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
using BUS;
using DAL;
using OfficeOpenXml;
namespace BTL
{
	public partial class QuanLyHoSo : Form
	{
		public QuanLyHoSoBUS hoSoBUS;

		public QuanLyHoSo()
		{
			InitializeComponent();
			hoSoBUS = new QuanLyHoSoBUS();
			LoadData();
			dataGridView1.MouseWheel += DataGridView1_MouseWheel;
		}
		private void LoadData()
		{
			dataGridView1.DataSource = hoSoBUS.GetAllHoSo();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void panel1_Paint(object sender, PaintEventArgs e)
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
		private void button10_Click(object sender, EventArgs e)
		{
			if (hoSoBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể xoá hồ sơ khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int rowIndex = dataGridView1.CurrentCell.RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
				string maHoSo = selectedRow.Cells["MaHoSo"].Value.ToString();

				DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hồ sơ này?",
					"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (dialogResult == DialogResult.Yes)
				{
					if (hoSoBUS.DeleteHoSo(maHoSo))
					{
						MessageBox.Show("Xóa hồ sơ thành công!", "Thông báo",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
						LoadData();
					}
					else
					{
						MessageBox.Show("Có lỗi xảy ra khi xóa hồ sơ.", "Lỗi",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một hồ sơ để xóa.", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void QuanLyHoSo_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void button1_Click(object sender, EventArgs e)
		{

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
		private void button5_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoTro quanLyHoTro = new QuanLyHoTro();
			quanLyHoTro.ShowDialog();
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
		private void button13_Click(object sender, EventArgs e)
		{
			string maHoSo = textBox1.Text.Trim();
			try
			{
				DataTable result = hoSoBUS.TimKiemHoSo(maHoSo);
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
				MessageBox.Show("Vui lòng nhập một hồ sơ để tìm", "Thông báo");
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (hoSoBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể sửa hồ sơ khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
				DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
				string maHoSo = row.Cells["MaHoSo"].Value.ToString();
				string hoTen = row.Cells["HoTen"].Value.ToString();
				string gioiTinh = row.Cells["GioiTinh"].Value.ToString();
				string ngaySinh = row.Cells["NgaySinh"].Value.ToString();
				string soDienThoai = row.Cells["SoDienThoai"].Value.ToString();
				string diaChi = row.Cells["DiaChi"].Value.ToString();
				string anhHoSo = row.Cells["AnhHoSo"].Value.ToString();
				ThemHoSo themHoSo = new ThemHoSo(false, maHoSo, hoTen, gioiTinh, ngaySinh, soDienThoai, diaChi, anhHoSo);
				themHoSo.ShowDialog();
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một ô để sửa.", "Thông báo");
			}
		}
		private void button12_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();

			foreach (DataGridViewColumn column in dataGridView1.Columns)
			{
				dataTable.Columns.Add(column.Name, column.ValueType ?? typeof(string)); // Sử dụng kiểu dữ liệu của cột hoặc mặc định là string
			}

			// Thêm các hàng vào DataTable
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (!row.IsNewRow) // Bỏ qua hàng trống cuối cùng trong DataGridView
				{
					DataRow dataRow = dataTable.NewRow();
					foreach (DataGridViewCell cell in row.Cells)
					{
						dataRow[cell.ColumnIndex] = cell.Value ?? DBNull.Value; // Đặt giá trị ô hoặc DBNull nếu ô trống
					}
					dataTable.Rows.Add(dataRow);
				}
			}
			hoSoBUS.ToExcel(dataTable, "Book0");
		}
		//private void button9_Click_1(object sender, EventArgs e)
		//{
		//	OpenFileDialog openFileDialog = new OpenFileDialog();
		//	openFileDialog.Title = "Import Excel";
		//	openFileDialog.Filter = "Excel (*,xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
		//	if (openFileDialog.ShowDialog() == DialogResult.OK)
		//	{
		//		try
		//		{
		//			hoSoBUS.ImportExcel(openFileDialog.FileName, dataGridView1);
		//			MessageBox.Show("Nhập file thành công!");
		//		}
		//		catch (Exception ex)
		//		{
		//			MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
		//		}
		//	}
		//	this.Hide();
		//	QuanLyHoSo quanLyHoSo = new QuanLyHoSo();
		//	quanLyHoSo.ShowDialog();
		//	this.Close();
		//}
		private void button9_Click_1(object sender, EventArgs e)
		{
			if (hoSoBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể nhập dữ liệu hồ sơ khi đã có danh sách trúng tuyển!!!");
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
						MessageBox.Show("Tên file không hợp lệ! Vui lòng chọn file có tên bắt đầu với 'DanhSachThamGiaXetTuyen'");
						return;
					}

					// Nếu tên file hợp lệ, tiếp tục xử lý
					hoSoBUS.ImportExcel(fileName, dataGridView1);
					MessageBox.Show("Nhập file thành công!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
				}
			}

			this.Hide();
			QuanLyHoSo quanLyHoSo = new QuanLyHoSo();
			quanLyHoSo.ShowDialog();
			this.Close();
		}

		// Hàm kiểm tra tên file có hợp lệ không
		private bool IsValidFileName(string filePath)
		{
			string fileName = Path.GetFileName(filePath);

			// Kiểm tra xem tên file có bắt đầu với 'HoSo_' và có phần mở rộng là .xlsx hoặc .xls không
			return fileName.StartsWith("DanhSachThamGiaXetTuyen") && (fileName.EndsWith(".xlsx") || fileName.EndsWith(".xls"));
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (hoSoBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể thêm mới hồ sơ khi đã có danh sách trúng tuyển!!!");
				return;
			}
			ThemHoSo themHoSo = new ThemHoSo(true, null, null, null, null, null, null, null);
			themHoSo.ShowDialog();
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
