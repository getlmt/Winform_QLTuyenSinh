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
	public partial class SuaHoTro : Form
	{
		private HoTroBUS hoTroBUS;
		public SuaHoTro(string mahoso, string thongtinyeucau, string thongtinhotro, string hinhthuc)
		{
			hoTroBUS = new HoTroBUS();
			InitializeComponent();
			label5.Text = mahoso;
			textBox2.Text = thongtinyeucau;
			textBox3.Text = thongtinhotro;
			textBox4.Text = hinhthuc;
		}
		public void SuaHoTro_Load()
		{

		}
		private void label5_Click(object sender, EventArgs e)
		{

		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBox2.Text))
			{
				MessageBox.Show("Không được bỏ trống thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBox3.Text))
			{
				MessageBox.Show("Không được bỏ trống thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBox4.Text))
			{
				MessageBox.Show("Không được bỏ trống thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string maHoSo = label5.Text;
			string thongTinYeuCau = textBox2.Text;
			string thongTinHoTro = textBox3.Text;
			string hinhThuc = textBox4.Text;
			try
			{
				bool success = hoTroBUS.UpdateHoTro(maHoSo, thongTinYeuCau, thongTinHoTro, hinhThuc);

				if (success)
				{
					MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
				}
				else
				{
					MessageBox.Show("Không có thay đổi nào được thực hiện hoặc mã hồ sơ không tồn tại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Lỗi");
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Close();
		}
	}
}
