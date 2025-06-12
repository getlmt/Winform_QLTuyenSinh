using BUS;
using Microsoft.Win32;
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
    public partial class Payment : Form
    {
        private string hinhThucThanhToan = "";
        private PaymentBUS paymentBUS;
        public QuanLyChiTieuNganhBUS bus;
        string ma;
        IPayment payment;
		private UserBUS userBUS;
		public Payment(string userId)
        {
            ma = userId;
            paymentBUS = new PaymentBUS();
            bus = new QuanLyChiTieuNganhBUS();
            userBUS = new UserBUS();    
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbViettelMoney.Checked)
            {
                hinhThucThanhToan = "Viettel Money";
            }
        }
        private void rbChuyenKhoanNganHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChuyenKhoanNganHang.Checked)
            {
                hinhThucThanhToan = "Chuyển Khoản Ngân Hàng";
            }
        }
        private void rbTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTienMat.Checked)
            {
                hinhThucThanhToan = "Tiền Mặt";
            }
        }
        private void rbPayal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPayal.Checked)
            {
                hinhThucThanhToan = "PayPal";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!bus.CheckTrungTuyen()==true)
            {
				MessageBox.Show("Chưa đến thời gian thông báo trúng tuyển hoặc bạn chưa trúng tuyển để nộp học phí.");
				return;
			}    
            if (!paymentBUS.CanProcessPayment(ma))
            {
                MessageBox.Show("Người dùng đã thanh toán rồi.");
                return;
            }
            this.Hide();
            XulyPayment paymentForm = new XulyPayment(hinhThucThanhToan, ma);
            paymentForm.ShowDialog();
            this.Close();
            
        }
        public string GetMaHoSo()
        {
            return ma;
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
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DiemHocBa diemHocBa = new DiemHocBa(ma);
            diemHocBa.ShowDialog();
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void lblTen_Load(object sender, EventArgs e)
        {
            string hoten = paymentBUS.GetHoTen(ma);
            userid.Text = hoten;
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInterface userInterface = new UserInterface(ma);
            userInterface.ShowDialog();
            this.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(ma);
            changePassword.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            NguyenVong nguyenVong = new NguyenVong(ma);
            nguyenVong.ShowDialog();
            this.Close();
        }
        private void Payment_Load(object sender, EventArgs e)
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
					Sdt.Text = row["SoDienThoai"].ToString();
					NgaySinh.Text = row["NgaySinh"].ToString();
				}
				else
				{
				
				}
			}
			catch (Exception ex)
			{

			}
		}
	}
}
