using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using BUS;

namespace BTL
{
	public partial class QuanLyThanhToan : Form
	{
		private QuanLyThanhToanBUS thanhToanBUS;
		private DataTable table;
		public void LoadData()
		{
			try
			{
				table = thanhToanBUS.GetAllThanhToan();
				dgvThanhToan.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		public QuanLyThanhToan()
		{
			InitializeComponent();
			thanhToanBUS = new QuanLyThanhToanBUS();
			table = new DataTable();
			dgvThanhToan.MouseWheel += DataGridView1_MouseWheel;

		}
		private void btnMaHoSo_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyHoSo quanLyHoSo = new QuanLyHoSo();
			quanLyHoSo.ShowDialog();
			this.Close();
		}
		private void btnHinhThucThanhToan_Click(object sender, EventArgs e)
		{

		}
		private void btnSoTienThanhToan_Click(object sender, EventArgs e)
		{

		}
		private void DataGridView1_MouseWheel(object sender, MouseEventArgs e)
		{
			// Kiểm tra xem con lăn chuột cuộn lên hay xuống
			if (e.Delta > 0) // Cuộn lên
			{
				if (dgvThanhToan.FirstDisplayedScrollingRowIndex > 0)
				{
					dgvThanhToan.FirstDisplayedScrollingRowIndex--;
				}
			}
			else if (e.Delta < 0) // Cuộn xuống
			{
				if (dgvThanhToan.FirstDisplayedScrollingRowIndex < dgvThanhToan.RowCount - 1)
				{
					dgvThanhToan.FirstDisplayedScrollingRowIndex++;
				}
			}
		}
		private void btnBienLai_Click(object sender, EventArgs e)
		{

		}
		private void dgvThanhToan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void btnSignOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();
			login.ShowDialog();
			this.Close();
		}
		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
		private void btnTraCuu_Click(object sender, EventArgs e)
		{
			//TraCuuThanhToan traCuuForm = new TraCuuThanhToan();
			//traCuuForm.ShowDialog(); // Hiển thị form

			this.Hide();
			TraCuuThanhToan register = new TraCuuThanhToan();
			register.ShowDialog();
			this.Close();
		}
		private void btnChiTiet_Click(object sender, EventArgs e)
		{

		}
		private void btnXuatExcel_Click(object sender, EventArgs e)
		{

		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (dgvThanhToan.SelectedRows.Count > 0)
			{
				string maHoSo = dgvThanhToan.SelectedRows[0].Cells["MaHoSo"].Value.ToString();

				DialogResult result = MessageBox.Show($"Có muốn xóa hồ sơ có mã {maHoSo} không?",
					"Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						bool success = thanhToanBUS.XoaThanhToan(maHoSo);
						if (success)
						{
							MessageBox.Show($"Xóa hồ sơ có mã {maHoSo} thành công.");
							LoadData();
						}
						else
						{
							MessageBox.Show("Không tìm thấy hồ sơ để xóa.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Lỗi khi xóa hồ sơ: {ex.Message}");
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn hồ sơ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			// ThemThanhToan themThanhToanForm = new ThemThanhToan();

			//// Hiển thị form ThemThanhToan
			//themThanhToanForm.ShowDialog();

			this.Hide();
			ThemThanhToan register = new ThemThanhToan();
			register.ShowDialog();
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
		private void QuanLyThanhToan_Load(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			ThemThanhToan themThanhToan = new ThemThanhToan();
			themThanhToan.ShowDialog();
			this.Close();
		}
		private void button6_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			foreach (DataGridViewColumn column in dgvThanhToan.Columns)
			{
				dataTable.Columns.Add(column.Name, column.ValueType ?? typeof(string)); // Sử dụng kiểu dữ liệu của cột hoặc mặc định là string
			}

			// Thêm các hàng vào DataTable
			foreach (DataGridViewRow row in dgvThanhToan.Rows)
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
			thanhToanBUS.ToExcel(dataTable, "Book0");
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
