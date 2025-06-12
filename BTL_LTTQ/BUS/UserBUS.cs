using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class UserBUS
    {
        public UserDAL userDAL;
        public UserBUS()
        {
            userDAL = new UserDAL();
        }
        public bool IsAdmin(string username, string password)
        {
            return username == "admin" && password == "admin123";
        }
        public string ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Tên đăng nhập và mật khẩu không được để trống");
            }

            return userDAL.GetMaHoSo(username, password);
        }
        public bool ChangePassword(string maHoSo, string oldPassword, string newPassword, string confirmPassword)
        {
            // Validate password format
            if (!Regex.IsMatch(newPassword, "^[a-zA-Z0-9]{6,24}$"))
            {
                throw new ArgumentException("Mật khẩu phải có 6 ký tự trở lên!");
            }
            // Validate password match
            if (newPassword != confirmPassword)
            {
                throw new ArgumentException("Mật khẩu mới và mật khẩu xác nhận không khớp!");
            }
            // Verify old password
            if (!userDAL.VerifyOldPassword(maHoSo, oldPassword))
            {
                throw new ArgumentException("Mật khẩu cũ không đúng!");
            }
            // Update password
            return userDAL.UpdatePassword(maHoSo, newPassword);
        }
        public string GetHoTen(string maHoSo)
        {
            return userDAL.GetHoTen(maHoSo);
        }
        public bool CheckAccount(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }
        public string GenerateNewMaHoSo()
        {
            string currentMaHoSo = userDAL.GetMaxMaHoSo();
            string numberPart = currentMaHoSo.Substring(2);
            int nextNumber = int.Parse(numberPart) + 1;
            return $"HS{nextNumber:D3}";
        }
        public bool UpdateHoSo(string maHoSo, string hoTen, string diaChi, string sdt,
                          string gioiTinh, string ngaySinh, string anhHoSo)
        {
            // Validate input
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) ||
                string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(gioiTinh) ||
                string.IsNullOrEmpty(ngaySinh))
            {
                return false;
            }

            return userDAL.UpdateHoSo(maHoSo, hoTen, diaChi, sdt, gioiTinh, ngaySinh, anhHoSo);
        }
        public DataTable GetThongTinHoSo(string maHoSo)
        {
            if (string.IsNullOrEmpty(maHoSo))
                throw new ArgumentException("Mã hồ sơ không được để trống");

            return userDAL.GetThongTinHoSo(maHoSo);
        }
        public bool IsAccountExists(string account)
        {
            return userDAL.CheckAccountExists(account);
        }
        public bool RegisterNewUser(string account, string password)
        {
            if (account == "admin") return false;
            if (!CheckAccount(account)) return false;
            if (!CheckAccount(password)) return false;
            if (IsAccountExists(account)) return false;
            string maHoSo = GenerateNewMaHoSo();
            return userDAL.CreateNewAccount(maHoSo, account, password);
        }
    }
}
