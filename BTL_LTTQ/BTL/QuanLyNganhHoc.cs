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
	public partial class QuanLyNganhHoc : Form
	{
		private QuanLyNganhBUS nganhBUS;
		public QuanLyChiTieuNganhBUS bUS;
		INganh nganh;
		public QuanLyNganhHoc()
		{
			InitializeComponent();
			nganhBUS = new QuanLyNganhBUS();
			bUS = new QuanLyChiTieuNganhBUS();
			dataGridView1.MouseWheel += DataGridView1_MouseWheel;
		}
		private void button5_Click_1(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Danh sách ngành sẽ được gửi và không thể thêm và xoá, bạn có chắc không?",
										   "Xác nhận",
										   MessageBoxButtons.YesNo,
										   MessageBoxIcon.Question);
			if (result == DialogResult.No)
			{
				return; 			
			}
		
			button1.Enabled = false;
			button3.Enabled = false;
			button5.Enabled = false;
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
			bUS.ToExcel(dataTable, "Book0");
		}
		public void form_load(object sender, EventArgs e)
		{

			dataGridView1.DataSource = nganhBUS.LayDanhSachNganh();
		}
		private void btnQuanLyHoSo_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoSo register = new QuanLyHoSo();
			register.ShowDialog();
			this.Close();
		}
		private void btnQuanLyThanhToan_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyThanhToan register = new QuanLyThanhToan();
			register.ShowDialog();
			this.Close();
		}
		private void btnQuanLyChiTieuNganh_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyChiTieuNganh register = new QuanLyChiTieuNganh();
			register.ShowDialog();
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
		private void btnQuanLyHoTro_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoTro register = new QuanLyHoTro();
			register.ShowDialog();
			this.Close();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			if (e.RowIndex >= 0) // Đảm bảo RowIndex không âm
			{
				textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value?.ToString(); // Lấy giá trị từ cột 0                                                                          // Nếu bạn muốn lấy giá trị từ cột 1, bạn có thể thêm dòng sau
				textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["MoTa"].Value?.ToString();
				textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["TenNganh"].Value?.ToString();// Lấy giá trị từ cột 1 
				textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ChiTieu"].Value?.ToString();// Lấy đường dẫn ảnh từ cột "ImagePath" (thay tên cột nếu khác)
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private bool IsNonNegativeInteger(string input)
		{
			return int.TryParse(input, out int value) && value >= 0;
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (!IsNonNegativeInteger(textBox4.Text))
			{
				MessageBox.Show("Số lượng không hợp lệ!!!");
				return;
			}
			if (string.IsNullOrEmpty(textBox1.Text)
				|| string.IsNullOrEmpty(textBox2.Text)
				|| string.IsNullOrEmpty(textBox3.Text)
				|| string.IsNullOrEmpty(textBox4.Text))
			{
				MessageBox.Show("Không được bỏ trống!!!");
				return;
			}
			if (nganhBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể thêm mới ngành khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// ... other validation checks ...
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm ngành không?",
											   "Xác nhận thêm",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				if (nganhBUS.ThemNganh(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text)))
				{
					MessageBox.Show("Thêm ngành thành công!");
					dataGridView1.DataSource = nganhBUS.LayDanhSachNganh();
				}
				else
				{
					MessageBox.Show("Thêm ngành thất bại!");
				}
			}
		}
		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void button5_Click(object sender, EventArgs e)
		{

		}
		private void button3_Click(object sender, EventArgs e)
		{
			if (nganhBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể xoá ngành khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox3.Text))
			{
				MessageBox.Show("Tên ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa ngành này không?",
											   "Xác nhận xóa",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					if (nganhBUS.XoaNganh(textBox1.Text))
					{
						MessageBox.Show("Xóa thành công!");
						dataGridView1.DataSource = nganhBUS.LayDanhSachNganh();
						// Clear the input fields
						textBox1.Clear();
						textBox2.Clear();
						textBox3.Clear();
					}
					else
					{
						MessageBox.Show("Xóa thất bại!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (nganhBUS.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể sửa ngành khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox1.Text))
			{
				MessageBox.Show("Mã ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox3.Text))
			{
				MessageBox.Show("Tên ngành không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("Mô tả không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin không?",
											   "Xác nhận sửa",
											   MessageBoxButtons.YesNo,
											   MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				try
				{
					if (nganhBUS.SuaNganh(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text)))
					{
						MessageBox.Show("Cập nhật thành công!");
						dataGridView1.DataSource = nganhBUS.LayDanhSachNganh();
					}
					else
					{
						MessageBox.Show("Cập nhật thất bại!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{

		}
		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void QuanLyNganhHoc_Load(object sender, EventArgs e)
		{

		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}
		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			textBox1.Clear();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			string maNganh = textBox1.Text.Trim();
			try
			{
				DataTable result = nganhBUS.TimKiemNganh(maNganh);
				if (result.Rows.Count > 0)
				{
					dataGridView1.DataSource = result;
				}
				else
				{
					MessageBox.Show("Không tìm thấy ngành.", "Thông báo");
					dataGridView1.DataSource = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo");
			}
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
