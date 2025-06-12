using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BTL
{
	public partial class QuanLyChiTieuNganh : Form
	{

		private QuanLyChiTieuNganhBUS bus;
		public QuanLyChiTieuNganh()
		{
			InitializeComponent();
			bus = new QuanLyChiTieuNganhBUS();
			LoadInitialData();
			LoadNganhComboBox();
			dataGridView1.MouseWheel += DataGridView1_MouseWheel;
			label1.Hide();
			comboBox1.Hide();
		}
		private void LoadInitialData()
		{
			dataGridView1.DataSource = bus.GetAllXetTuyen();
		}
		private void LoadNganhComboBox()
		{
			comboBox1.DataSource = bus.GetAllNganh();
			comboBox1.DisplayMember = "TenNganh";
			comboBox1.ValueMember = "MaNganh";
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
		private void button9_Click(object sender, EventArgs e)
		{
			if (bus.CheckTrungTuyen() == false)
			{
				var result = MessageBox.Show("Sau khi có danh sách trúng tuyển sẽ không thể sửa hoặc thêm thông tin liên quan đến xét tuyển?", "Xác nhận", MessageBoxButtons.YesNo);
				string selectedMaNganh = comboBox1.SelectedValue.ToString();
				if (result == DialogResult.Yes)
				{
					lblDXT.Hide();
					txtDXT.Hide();
					lblTHXT.Hide();
					txtTHXT.Hide();
					lblTTNV.Hide();
					txtTTNV.Hide();
					label3.Hide();
					label4.Hide();
					label5.Hide();
					textBox2.Hide();
					textBox3.Hide();
					textBox4.Hide();
					label1.Show();
					comboBox1.Show();
					button16.Hide();
					button15.Hide();
					button11.Hide();
					button14.Hide();
					bus.DanhSachTrungTuyen();
					bus.Update();
					bus.Update2();
					bus.ThanhToan();
					dataGridView1.DataSource = bus.DSTT(selectedMaNganh);
				}
			}
			else
			{
				string selectedMaNganh = comboBox1.SelectedValue.ToString();
				lblDXT.Hide();
				txtDXT.Hide();
				lblTHXT.Hide();
				txtTHXT.Hide();
				lblTTNV.Hide();
				txtTTNV.Hide();
				label3.Hide();
				label4.Hide();
				label5.Hide();
				textBox2.Hide();
				textBox3.Hide();
				textBox4.Hide();
				label1.Show();
				comboBox1.Show();
				button16.Hide();
				button15.Hide();
				button11.Hide();
				button14.Hide();
				bus.DanhSachTrungTuyen();
				bus.Update();
				bus.Update2();
				bus.ThanhToan();
				dataGridView1.DataSource = bus.DSTT(selectedMaNganh);
			}

		}
		private void button11_Click(object sender, EventArgs e)
		{
			if (bus.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể sửa khi đã có danh sách trúng tuyển!!!");
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
							if (bus.DeleteXetTuyen(maHoSo))
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
		private void button13_Click(object sender, EventArgs e)
		{
			this.Close();
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
		private void button10_Click(object sender, EventArgs e)
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
			bus.ToExcel(dataTable, "Book0");
		}
		private void textBox2_MouseClick(object sender, MouseEventArgs e)
		{
			textBox2.Clear();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			if (e.RowIndex >= 0) // Đảm bảo RowIndex không âm
			{
				// Lấy giá trị từ cột 0                                             
				textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["MaHoSo"].Value?.ToString();
				textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value?.ToString();// Lấy giá trị từ cột 1
				txtDXT.Text = dataGridView1.Rows[e.RowIndex].Cells["DiemXetTuyen"].Value?.ToString();
				txtTHXT.Text = dataGridView1.Rows[e.RowIndex].Cells["ToHopXetTuyen"].Value?.ToString();
				txtTTNV.Text = dataGridView1.Rows[e.RowIndex].Cells["TTNV"].Value?.ToString();
			}
		}
		private void button15_Click(object sender, EventArgs e)
		{
			string maHoSo = textBox2.Text.Trim();
			try
			{
				DataTable result = bus.TimKiem(maHoSo);
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
		static bool IsNonNegativeFloatInRange(string input)
		{
			string pattern = @"^\d+(\.\d+)?$";
			if (Regex.IsMatch(input, pattern))
			{
				if (float.TryParse(input, out float value))
				{
					return value >= 0 && value <= 30;
				}
			}
			return false;
		}
		private bool IsNonNegativeInteger(string input)
		{
			return int.TryParse(input, out int value) && value >= 0;
		}
		private void button14_Click(object sender, EventArgs e)
		{
			if (bus.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Không thể sửa khi đã có danh sách trúng tuyển!!!");
				return;
			}
			if (IsNonNegativeFloatInRange(txtDXT.Text)==false)
			{
				MessageBox.Show("Điểm không hợp lệ!!!");
				return;
			}
			if (IsNonNegativeInteger(txtTTNV.Text) == false)
			{
				MessageBox.Show("Thứ tự nguyện vọng không hợp lệ!!!");
				return;
			}
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int rowIndex = dataGridView1.CurrentCell.RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

				if (selectedRow.Cells["MaHoSo"].Value != null || selectedRow.Cells["MaNganh"].Value != null || textBox4.Text != null|| selectedRow.Cells["ToHopXetTuyen"].Value != null|| selectedRow.Cells["DiemXetTuyen"].Value != null|| selectedRow.Cells["TTNV"].Value != null)
				{
					string maHoSo = selectedRow.Cells["MaHoSo"].Value.ToString();
					string maNganh = selectedRow.Cells["MaNganh"].Value.ToString();
					float dxt = float.TryParse(txtDXT.Text, out float diem) ? diem : -1; // Giá trị mặc định khi không hợp lệ
					int ttnv = int.Parse(txtTTNV.Text);        // Giá trị mặc định khi không hợp lệ
					string thxt = txtTHXT.Text;
					string maNganhMoi = textBox4.Text;
					var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						try
						{
							if (bus.SuaXetTuyen(maHoSo, maNganh, maNganhMoi, dxt, thxt, ttnv))
							{
								MessageBox.Show("Sửa bản ghi thành công.");
								LoadInitialData();
							}
							else
							{
								MessageBox.Show("Có lỗi xảy ra, vui lòng nhập đúng và thử lại.");
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
					MessageBox.Show("Không thể xác định Mã Hồ Sơ để sửa.");
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một bản ghi để sửa.");
			}
		}
		private void button16_Click(object sender, EventArgs e)
		{
			if (bus.CheckTrungTuyen() == true)
			{
				MessageBox.Show("Lưu ý khi nhập lại danh sách nguyện vọng sẽ mất hết danh sách trúng tuyển!!!");
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Import Excel";
			openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;

				try
				{
					// Kiểm tra tên file có đúng định dạng yêu cầu
				
					bus.DeleteAll();
					// Nếu tên file hợp lệ, tiếp tục xử lý
					bus.ImportExcel(fileName, dataGridView1);
					MessageBox.Show("Nhập file thành công!");

					this.Hide();
					QuanLyChiTieuNganh quanLyHoSo = new QuanLyChiTieuNganh();
					quanLyHoSo.ShowDialog();
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Nhập file không thành công!\n" + ex.Message);
				}
			}
		}

		// Hàm kiểm tra tên file có hợp lệ không
		private bool IsValidFileName(string filePath)
		{
			string fileName = Path.GetFileName(filePath);

			// Kiểm tra xem tên file có bắt đầu bằng 'DuLieu_' và có phần mở rộng là .xlsx hoặc .xls không
			return fileName.StartsWith("DanhSachNguyenVong") && (fileName.EndsWith(".xlsx") || fileName.EndsWith(".xls"));
		}
		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyChiTieuNganh quanLyChiTieuNganh = new QuanLyChiTieuNganh();
			quanLyChiTieuNganh.ShowDialog();
			this.Close();
		}

		private void btnQLD_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyDiem quanLyHoSo = new QuanLyDiem();
			quanLyHoSo.ShowDialog();
			this.Close();
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
