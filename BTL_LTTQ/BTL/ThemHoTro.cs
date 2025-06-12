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
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BTL
{
	public partial class ThemHoTro : Form
	{
        private string ma;
        private HoTroBUS hoTroBUS;
        IHoTro hoTro;
        public ThemHoTro(string userId)
		{
            InitializeComponent();
            ma = userId;
            hoTroBUS = new HoTroBUS();
            textBox4.Enabled = false;
        }
		public ThemHoTro()
		{
            InitializeComponent();
            hoTroBUS = new HoTroBUS();
        }
		public void HienThiId(object sender, EventArgs e)
		{
			textBox4.Text = ma;
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
		private void ThemHoTro_Load(object sender, EventArgs e)
		{

		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ma))
			{
				this.Hide();
				QuanLyHoTro quanLyHoTro = new QuanLyHoTro();
				quanLyHoTro.ShowDialog();
				this.Close();
			}
			else
			{
				this.Hide();
				UserInterface userInterface = new UserInterface(ma);
				userInterface.ShowDialog();
				this.Close();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
            if(!hoTroBUS.CheckMaHoSo(textBox4.Text))
            {
				MessageBox.Show("Mã hồ sơ không hợp lệ!", "Lỗi",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
            string mahoso = string.IsNullOrEmpty(ma) ? textBox4.Text.Trim() : ma;
            string thongTinYeuCau = textBox1.Text.Trim();
            string thongTinHoTro = textBox2.Text.Trim();
            string hinhThucHoTro = textBox3.Text.Trim();
			if (string.IsNullOrEmpty(mahoso))
			{
				MessageBox.Show("Thông tin yêu cầu không được để trống!", "Lỗi",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(thongTinYeuCau))
            {
                MessageBox.Show("Thông tin yêu cầu không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(thongTinHoTro))
            {
                MessageBox.Show("Thông tin hỗ trợ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(hinhThucHoTro))
            {
                MessageBox.Show("Hình thức hỗ trợ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thêm yêu cầu hỗ trợ này không?",
                "Xác nhận thêm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (hoTroBUS.ThemHoTro(mahoso, thongTinYeuCau, thongTinHoTro, hinhThucHoTro))
                    {
                        MessageBox.Show("Thêm mới thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm mới đã bị hủy.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
