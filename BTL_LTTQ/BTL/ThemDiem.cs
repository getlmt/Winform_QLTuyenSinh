using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL
{
	public partial class ThemDiem : Form
	{
		QuanLyDiemBUS DiemBUS;
		public ThemDiem()
		{
			DiemBUS = new QuanLyDiemBUS();
			InitializeComponent();
		}
		static bool IsNonNegativeFloatInRange(string input)
		{
			string pattern = @"^\d+(\.\d+)?$";
			if (Regex.IsMatch(input, pattern))
			{
				if (float.TryParse(input, out float value))
				{
					return value >= 0 && value <= 10;
				}
			}
			return false;
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!DiemBUS.MaHoSo(textBox1.Text) || DiemBUS.CheckMaHoSo(textBox1.Text))
			{
				MessageBox.Show("Hồ sơ đã có trong csdl hoặc không đăng ký vào trường GTVT vui lòng xem lại!!!.", "Thông báo");
				return;
			}
			if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(txtDHB.Text)|| string.IsNullOrEmpty(txtDiemToan.Text)
				|| string.IsNullOrEmpty(txtDiemVan.Text)|| string.IsNullOrEmpty(txtDiemAnh.Text)|| string.IsNullOrEmpty(txtDiemLy.Text)
				|| string.IsNullOrEmpty(txtDiemHoa.Text)|| string.IsNullOrEmpty(txtDiemSinh.Text)|| string.IsNullOrEmpty(txtDiemSu.Text)
				|| string.IsNullOrEmpty(txtDiemDia.Text)|| string.IsNullOrEmpty(txtDiemGDCD.Text))
			{
				MessageBox.Show("Không được để trống dữ liệu!!!", "Thông báo");
				return;
			}
			if (IsNonNegativeFloatInRange(txtDiemToan.Text) == false
				||IsNonNegativeFloatInRange(txtDiemVan.Text) == false
				||IsNonNegativeFloatInRange(txtDHB.Text) == false
				||IsNonNegativeFloatInRange(txtDiemAnh.Text) == false
				||IsNonNegativeFloatInRange(txtDiemLy.Text) == false
				||IsNonNegativeFloatInRange(txtDiemHoa.Text) == false
				||IsNonNegativeFloatInRange(txtDiemSinh.Text) == false
				||IsNonNegativeFloatInRange(txtDiemSu.Text) == false
				||IsNonNegativeFloatInRange(txtDiemDia.Text) == false
				|| IsNonNegativeFloatInRange(txtDiemGDCD.Text) == false)
			{
				MessageBox.Show("Điểm không hợp lệ!!!");
				return;
			}

			DiemBUS.Them(textBox1.Text, float.Parse(txtDHB.Text) , float.Parse(txtDiemToan.Text), float.Parse(txtDiemVan.Text), float.Parse(txtDiemAnh.Text), float.Parse(txtDiemLy.Text), float.Parse(txtDiemHoa.Text), float.Parse(txtDiemSinh.Text), float.Parse(txtDiemSu.Text), float.Parse(txtDiemDia.Text), float.Parse(txtDiemGDCD.Text), textBox2.Text);
			MessageBox.Show("Thêm thành công!!!", "Thông báo");
		}
		private void btnSua_Click(object sender, EventArgs e)
		{

		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			QuanLyDiem quanLyDiem = new QuanLyDiem();
			quanLyDiem.ShowDialog();
			this.Close();
		}
	}
}
