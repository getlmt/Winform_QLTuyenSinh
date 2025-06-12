using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoSoBUS
    {
        private HoSoDAL hoSoDAL;
        public HoSoBUS()
        {
            hoSoDAL = new HoSoDAL();
        }
        public bool KiemTraMaHoSo(string maHoSo)
        {
            if (string.IsNullOrEmpty(maHoSo))
                return false;
            return hoSoDAL.KiemTraMaHoSo(maHoSo);
        }
        public string GenerateNewMaHoSo()
        {
            string currentMaHoSo = hoSoDAL.GetMaxMaHoSo();
            string numberPart = currentMaHoSo.Substring(2);
            int nextNumber = int.Parse(numberPart) + 1;
            return $"HS{nextNumber:D3}";
        }
        public bool ChecKMaHoSo(string maHoSo)
        {
            return hoSoDAL.CheckMaHoSoExists(maHoSo);
        }
		public bool ThemHoSo(string maHoSo, string hoTen, string diaChi, string sdt,
                            string gioiTinh, string ngaySinh, string anhHoSo)
        {
            // Validate input
            if (string.IsNullOrEmpty(maHoSo) || string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt))
                return false;

            // Parse date
            if (!DateTime.TryParseExact(ngaySinh, "dd/MM/yyyy", null,
                System.Globalization.DateTimeStyles.None, out DateTime ngaySinhDate))
                return false;
            try
            {
                return hoSoDAL.ThemHoSo(maHoSo, hoTen, diaChi, sdt,
                                       gioiTinh, ngaySinhDate, anhHoSo);
            }
            catch
            {
                return false;
            }
        }
    }
}
