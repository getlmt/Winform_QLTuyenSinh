using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoTroBUS
    {
        private HoTroDAL hoTroDAL;
        public HoTroBUS()
        {
            hoTroDAL = new HoTroDAL();
        }
        public bool UpdateHoTro(string maHoSo, string thongTinYeuCau, string thongTinHoTro, string hinhThuc)
        {
            // Add any business logic/validation here if needed
            if (string.IsNullOrEmpty(maHoSo) || string.IsNullOrEmpty(thongTinYeuCau) ||
                string.IsNullOrEmpty(thongTinHoTro) || string.IsNullOrEmpty(hinhThuc))
            {
                return false;
            }
            return hoTroDAL.UpdateHoTro(maHoSo, thongTinYeuCau, thongTinHoTro, hinhThuc);
        }
        public bool CheckMaHoSo(string maHoSo)
        {
            return hoTroDAL.CheckMaHoSoExists(maHoSo);
        }
        public bool ThemHoTro(string maHoSo, string thongTinYeuCau, string thongTinHoTro, string hinhThucHoTro)
        {
            // Validate input
            if (string.IsNullOrEmpty(thongTinYeuCau) ||
                string.IsNullOrEmpty(thongTinHoTro) ||
                string.IsNullOrEmpty(hinhThucHoTro))
            {
                return false;
            }
            try
            {
                return hoTroDAL.ThemHoTro(maHoSo, thongTinYeuCau, thongTinHoTro, hinhThucHoTro);
            }
            catch
            {
                throw;
            }
        }
    }
}
