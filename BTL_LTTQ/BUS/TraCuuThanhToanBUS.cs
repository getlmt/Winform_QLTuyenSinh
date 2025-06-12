using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TraCuuThanhToanBUS
    {
        private TraCuuThanhToanDAL traCuuThanhToanDAL;
        public TraCuuThanhToanBUS()
        {
            traCuuThanhToanDAL = new TraCuuThanhToanDAL();
        }
        public DataTable TimKiemThanhToan(string maHoSo)
        {
            if (string.IsNullOrWhiteSpace(maHoSo))
            {
                throw new ArgumentException("Mã hồ sơ không được để trống");
            }
            return traCuuThanhToanDAL.GetThanhToanByMaHoSo(maHoSo);
        }
    }
}
