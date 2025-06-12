using BUS;
using DAL;
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

namespace BTL
{
    public partial class ChangePassword : Form
    {
        string ma;
        UserBUS user_bus;
        public ChangePassword(string MaHoSo)
        {
            InitializeComponent();
            ma = MaHoSo; // Lưu mã hồ sơ
            user_bus = new UserBUS();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblTen_Load(object sender, EventArgs e)
        {
            string hoten = user_bus.GetHoTen(ma);
            label5.Text = hoten; // Hiển thị với 2 chữ số thập phân
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = user_bus.ChangePassword(
                    ma,
                    txtMKcu.Text,
                    txtMKmoi.Text,
                    txtXNMKMoi.Text
                );

                if (success)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể đổi mật khẩu. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiemHocBa diemHocBa = new DiemHocBa(ma);
            diemHocBa.ShowDialog();
            this.Close();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface userInterface = new UserInterface(ma);
            userInterface.ShowDialog();
            this.Close();
        }
        private void btnPreferences_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguyenVong nguyenVong = new NguyenVong(ma);
            nguyenVong.ShowDialog();
            this.Close();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment(ma);
            payment.ShowDialog();
            this.Close();
        }
        private void btnSupport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemHoTro themHoTro = new ThemHoTro(ma);
            themHoTro.ShowDialog();
            this.Close();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

