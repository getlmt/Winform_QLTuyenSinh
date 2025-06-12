using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanLyHoTroBUS : HoTroBUS
    {
        private QuanLyHoTroDAL hoTroDAL;
        public QuanLyHoTroBUS()
        {
            hoTroDAL = new QuanLyHoTroDAL();
        }
        public DataTable GetAllHoTro()
        {
            return hoTroDAL.GetAllHoTro();
        }
        public DataTable TimKiemHoSo(string maHoSo)
        {
            if (string.IsNullOrWhiteSpace(maHoSo))
                throw new ArgumentException("Mã hồ sơ không được để trống");

            return hoTroDAL.TimKiemHoSo(maHoSo);
        }
        public bool XoaHoTro(string maHoSo)
        {
            if (string.IsNullOrWhiteSpace(maHoSo))
                throw new ArgumentException("Mã hồ sơ không được để trống");

            return hoTroDAL.XoaHoTro(maHoSo);
        }
    }
}
