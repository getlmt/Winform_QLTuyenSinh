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
namespace BTL
{
	public partial class ThemHoSo : Form
	{
		private HoSoBUS hoSoBUS;
		string connect = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adapter;
		DataTable dt = new DataTable();
		private void AddHoSo()
		{
			string MaHoSo = textBox1.Text;
			string HoTen = textBox2.Text;
			string DiaChi = textBox3.Text;
			string SDT = textBox4.Text;
			string GioiTinh = textBox5.Text;
			string NgaySinh = textBox6.Text;
			string AnhHoSo = textBox7.Text;
			if (DateTime.TryParseExact(NgaySinh, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime NgaySinhDate))
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(connect))
					{
						connection.Open();

						string insertQuery = "INSERT INTO HoSo (MaHoSo, HoTen, DiaChi, SoDienThoai, GioiTinh, NgaySinh, AnhHoSo) " +
											 "VALUES (@MaHoSo, @HoTen, @DiaChi, @SoDienThoai, @GioiTinh, @NgaySinh, @AnhHoSo)";
						using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
						{
							cmd.Parameters.AddWithValue("@MaHoSo", MaHoSo);
							cmd.Parameters.AddWithValue("@HoTen", HoTen);
							cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
							cmd.Parameters.AddWithValue("@SoDienThoai", SDT);
							cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
							cmd.Parameters.AddWithValue("@NgaySinh", NgaySinhDate);
							cmd.Parameters.AddWithValue("@AnhHoSo", AnhHoSo);

							int result = cmd.ExecuteNonQuery();

							if (result > 0)
							{
								MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								textBox1.Clear();
								textBox2.Clear();
								textBox3.Clear();
								textBox4.Clear();
								textBox5.Clear();
								textBox6.Clear();
								textBox7.Clear();
							}
							else
							{
								MessageBox.Show("Có lỗi xảy ra khi thêm hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thêm hồ sơ vào cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Định dạng ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public ThemHoSo(bool test, string maHoSo, string hoTen, string gioiTinh, string ngaySinh, string soDienThoai, string diaChi, string anhHoSo)
		{
			InitializeComponent();
			hoSoBUS = new HoSoBUS();
			if (test==true)
			{
				button4.Hide();
			}
			else
			{
				if(hoSoBUS.KiemTraMaHoSo(maHoSo))
			
				textBox1.ReadOnly=false;
				button2.Hide();
				textBox1.Text = maHoSo;
				textBox2.Text = hoTen;
				textBox3.Text = diaChi;
				textBox4.Text = soDienThoai;
				textBox5.Text = gioiTinh;
				textBox6.Text = ngaySinh;
				textBox7.Text = anhHoSo;
			}
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
			// Kiểm tra nếu người dùng chọn file
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// Lấy đường dẫn file ảnh
				string imagePath = openFileDialog.FileName;
				textBox7.Text = imagePath;
				// Gán ảnh vào PictureBox
				pictureBox1.Image = new System.Drawing.Bitmap(imagePath);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Đặt chế độ hiển thị ảnh vừa với PictureBox
			}
		}
		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void label4_Click(object sender, EventArgs e)
		{

		}
		private void ThemHoSo_Load(object sender, EventArgs e)
		{

		}
		private void button4_Click(object sender, EventArgs e)
		{
			if (!hoSoBUS.ChecKMaHoSo(textBox1.Text) == true)
			{
				MessageBox.Show("Mã hồ sơ không tồn tại!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (string.IsNullOrEmpty(textBox7.Text)
				||string.IsNullOrEmpty(textBox6.Text)
				||string.IsNullOrEmpty(textBox5.Text)
				||string.IsNullOrEmpty(textBox4.Text)
				||string.IsNullOrEmpty(textBox3.Text)
				||string.IsNullOrEmpty(textBox2.Text)
				||string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string MaHoSo = textBox1.Text;
			string HoTen = textBox2.Text;
			string DiaChi = textBox3.Text;
			string SDT = textBox4.Text;
			string GioiTinh = textBox5.Text;
			string NgaySinh = textBox6.Text;
			string AnhHoSo = textBox7.Text;
			if (string.IsNullOrEmpty(SDT) || SDT.Length != 10 || !SDT.All(char.IsDigit))
			{
				MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập đúng 10 chữ số.", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (DateTime.TryParseExact(NgaySinh, "mm/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime NgaySinhDate))
			{
				try
				{
					using (SqlConnection connection = new SqlConnection(connect))
					{
						connection.Open();
						string insertQuery = "UPDATE HoSo SET HoTen=@hoten, GioiTinh=@gioitinh, NgaySinh=@ngaysinh, SoDienThoai=@sdt, DiaChi=@diachi, AnhHoSo=@anh WHERE MaHoSo=@mahoso";
						using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
						{
							cmd.Parameters.AddWithValue("@hoten", textBox2.Text);
							cmd.Parameters.AddWithValue("@gioitinh", textBox5.Text);
							cmd.Parameters.AddWithValue("@ngaysinh", textBox6.Text);
							cmd.Parameters.AddWithValue("@sdt", textBox4.Text);
							cmd.Parameters.AddWithValue("@diachi", textBox3.Text);
							cmd.Parameters.AddWithValue("@anh", textBox7.Text);
							cmd.Parameters.AddWithValue("@mahoso", textBox1.Text);
							int result = cmd.ExecuteNonQuery();
							if (result > 0)
							{
								MessageBox.Show("Sửa hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								textBox1.Clear();
								textBox2.Clear();
								textBox3.Clear();
								textBox4.Clear();
								textBox5.Clear();
								textBox6.Clear();
								textBox7.Clear();
							}
							else
							{
								MessageBox.Show("Có lỗi xảy ra khi sửa hồ sơ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi thêm hồ sơ vào cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Định dạng ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public void Account()
		{
			string connectionString = "Data Source=KHABANH\\SQLEXPRESS;Initial Catalog=QLTuyenSinh;Integrated Security=True;";
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				string maHoSo = textBox1.Text;
				// Kiểm tra xem mã hồ sơ đã tồn tại trong CSDL hay chưa
				string checkQuery = "SELECT COUNT(*) FROM Users WHERE MaHoSo = @MaHoSo";
				using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
				{
					checkCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
					int count = (int)checkCmd.ExecuteScalar();
					// Nếu mã hồ sơ chưa tồn tại thì tiến hành thêm mới
					if (count == 0)
					{
						string query = @"INSERT INTO Users
                                          (MaHoSo, Account, Password) 
                                          VALUES (@MaHoSo, @Acc, @SoDienThoai)";
						using (SqlCommand insertCmd = new SqlCommand(query, conn))
						{
							insertCmd.Parameters.AddWithValue("@MaHoSo", maHoSo);
							insertCmd.Parameters.AddWithValue("@Acc", maHoSo);
							insertCmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
							// Thực thi lệnh chèn dữ liệu
							insertCmd.ExecuteNonQuery();
						}
					}
				}
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (hoSoBUS.ChecKMaHoSo(textBox1.Text) == true)
			{
				MessageBox.Show("Mã hồ sơ đã tồn tại!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!hoSoBUS.KiemTraMaHoSo(textBox1.Text))
			{
				MessageBox.Show("Mã hồ sơ không tồn tại trong danh sách tham gia xét tuyển vào trường!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (string.IsNullOrEmpty(textBox7.Text)
			|| string.IsNullOrEmpty(textBox6.Text)
			|| string.IsNullOrEmpty(textBox5.Text)
			|| string.IsNullOrEmpty(textBox4.Text)
			|| string.IsNullOrEmpty(textBox3.Text)
			|| string.IsNullOrEmpty(textBox2.Text)
			|| string.IsNullOrEmpty(textBox1.Text))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string maHoSo = textBox1.Text;
			string hoTen = textBox2.Text;
			string diaChi = textBox3.Text;
			string sdt = textBox4.Text;
			string gioiTinh = textBox5.Text;
			string ngaySinh = textBox6.Text;
			string anhHoSo = textBox7.Text;
			if (string.IsNullOrEmpty(sdt) || sdt.Length != 10 || !sdt.All(char.IsDigit))
			{
				MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập đúng 10 chữ số.", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			try
			{
				if (hoSoBUS.ThemHoSo(maHoSo, hoTen, diaChi, sdt, gioiTinh, ngaySinh, anhHoSo))
				{
					MessageBox.Show("Thêm hồ sơ thành công!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					// Generate new MaHoSo after successful addition
					textBox2.Clear();
					textBox3.Clear();
					textBox4.Clear();
					textBox5.Clear();
					textBox6.Clear();
					textBox7.Clear();
				}
				else
				{
					MessageBox.Show("Có lỗi xảy ra khi thêm hồ sơ.", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			Account();
		}
	}
}
