using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PaymentBUS
    {
        private PaymentDAL paymentDAL;
        public PaymentBUS()
        {
            paymentDAL = new PaymentDAL();
        }
        public bool CanProcessPayment(string maHoSo)
        {
            return !paymentDAL.CheckPaymentExists(maHoSo);
        }
        public string GetHoTen(string maHoSo)
        {
            return paymentDAL.GetHoTen(maHoSo);
        }
        public DataTable GetAllThanhToan()
        {
            return paymentDAL.GetAllThanhToan();
        }
        public bool ValidateMaHoSo(string maHoSo)
        {
            if (string.IsNullOrEmpty(maHoSo))
                return false;

            // Kiểm tra có ký tự đặc biệt hay không
            return !System.Text.RegularExpressions.Regex.IsMatch(maHoSo, @"[^a-zA-Z0-9_-]");
        }
        public bool ValidateSoTien(string soTien)
        {
            if (!double.TryParse(soTien, out double amount))
                return false;

            return amount >= 0;
        }

		public bool SuaThanhToan(string maHoSo, string hinhThuc, string soTien, string bienLai)
		{
			// Validate input
			if (string.IsNullOrWhiteSpace(maHoSo) ||
				string.IsNullOrWhiteSpace(hinhThuc) ||
				string.IsNullOrWhiteSpace(soTien) ||
				string.IsNullOrWhiteSpace(bienLai))
			{
				return false;
			}
			// Parse soTien
			if (!decimal.TryParse(soTien, out decimal soTienDecimal))
			{
				throw new Exception("Số tiền không hợp lệ");
			}
			try
			{
				return paymentDAL.SuaThanhToan(maHoSo, hinhThuc, soTienDecimal, bienLai);
			}
			catch
			{
				throw;
			}
		}
        public bool CheckMaHoSo2(string maHoSo)
        {
            return paymentDAL.KiemTraMaHoSo2(maHoSo);
        }
		public bool ChecKMaHoSo(string maHoSo)
		{
			return paymentDAL.CheckMaHoSoExists(maHoSo);
		}
		public bool ThemThanhToan(string maHoSo, string hinhThuc, string soTien, string bienLai)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(maHoSo) ||
                string.IsNullOrWhiteSpace(hinhThuc) ||
                string.IsNullOrWhiteSpace(soTien) ||
                string.IsNullOrWhiteSpace(bienLai))
            {
                return false;
            }
            // Check if MaHoSo already exists
            if (paymentDAL.KiemTraMaHoSo(maHoSo))
            {
                throw new Exception("Mã hồ sơ đã tồn tại trong bảng ThanhToan");
            }
            // Parse soTien
            if (!decimal.TryParse(soTien, out decimal soTienDecimal))
            {
                throw new Exception("Số tiền không hợp lệ");
            }
            try
            {
                return paymentDAL.ThemThanhToan(maHoSo, hinhThuc, soTienDecimal, bienLai);
            }
            catch
            {
                throw;
            }
        }
    }
}
