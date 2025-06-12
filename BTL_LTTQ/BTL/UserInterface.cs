using BUS;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserInterface : Form
    {
        string ma;
        private IUsers users;
        private UserBUS userBUS;
        public UserInterface(string userId)
        {
            ma = userId;
            userBUS = new UserBUS();
            InitializeComponent();
        }
        public void HienUserId(object sender, EventArgs e)
        {
            maHoSo.Text = ma;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public string GetMaHoSo()
        {
            return ma;
        }
        private void lblTen_Load(object sender, EventArgs e)
        {
            string hoten = userBUS.GetHoTen(ma);
            label1.Text = hoten;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(ma);
            changePassword.ShowDialog();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void HienThongTin(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = userBUS.GetThongTinHoSo(ma);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    HoVaTen.Text = row["HoTen"].ToString();
                    DiaChi.Text = row["DiaChi"].ToString();
                    GioiTinh.Text = row["GioiTinh"].ToString();
                    Sdt.Text = row["SoDienThoai"].ToString();
                    NgaySinh.Text = row["NgaySinh"].ToString();
                    AnhHoSo.ImageLocation = row["AnhHoSo"].ToString();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
		private bool IsValidPhoneNumber(string phoneNumber)
		{
			// Giả sử số điện thoại có độ dài từ 10-11 số và chỉ chứa chữ số
			return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
		}
		private void LuuThongTin_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(AnhHoSo.ImageLocation) ||
                string.IsNullOrWhiteSpace(HoVaTen.Text) ||
                string.IsNullOrWhiteSpace(GioiTinh.Text) ||
                string.IsNullOrWhiteSpace(Sdt.Text) ||
                string.IsNullOrWhiteSpace(NgaySinh.Text) ||
                string.IsNullOrWhiteSpace(DiaChi.Text))
            {
                MessageBox.Show("Không được bỏ trống thông tin!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			if (!IsValidPhoneNumber(Sdt.Text))
			{
				MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin không?",
                        "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = userBUS.UpdateHoSo(
                        ma,
                        HoVaTen.Text,
                        DiaChi.Text,
                        Sdt.Text,
                        GioiTinh.Text,
                        NgaySinh.Text,
                        AnhHoSo.ImageLocation
                    );

                    if (success)
                    {
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void DiaChi_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DiemHocBa diemHocBa = new DiemHocBa(ma);
            diemHocBa.ShowDialog();
            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiemHocBa diemHocBa = new DiemHocBa(ma);
            diemHocBa.ShowDialog();
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
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHoTro themHoTro = new ThemHoTro(ma);
            themHoTro.ShowDialog();
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void ThayDoiAnh_Click(object sender, EventArgs e)
        {
            // Khởi tạo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image"
            };

            // Mở hộp thoại chọn file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị hình ảnh đã chọn trong PictureBox
                AnhHoSo.ImageLocation = openFileDialog.FileName;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void UserInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
