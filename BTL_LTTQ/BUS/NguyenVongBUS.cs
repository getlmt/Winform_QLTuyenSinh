using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class NguyenVongBUS
    {
        private NguyenVongDAL nguyenVongDAL;
        public NguyenVongBUS()
        {
            nguyenVongDAL = new NguyenVongDAL();
        }
        public DataTable GetNguyenVongByMaHoSo(string maHoSo)
        {
            return nguyenVongDAL.GetNguyenVongByMaHoSo(maHoSo);
        }
        public bool DeleteNguyenVong(string maNganh)
        {
            if (string.IsNullOrWhiteSpace(maNganh))
                return false;
            return nguyenVongDAL.DeleteNguyenVong(maNganh);
        }
        public float GetDiemXetTuyen(string maHoSo)
        {
            return nguyenVongDAL.GetDiemXetTuyen(maHoSo);
        }
        public bool InsertNguyenVong(string maHoSo, string maNganh, float diemXetTuyen)
        {
            if (string.IsNullOrWhiteSpace(maNganh) || string.IsNullOrWhiteSpace(maHoSo)||nguyenVongDAL.KiemTraNguyenVong(maNganh, maHoSo)||!nguyenVongDAL.CheckMaNganhExists(maNganh))
                return false;
            return nguyenVongDAL.InsertNguyenVong(maHoSo, maNganh, diemXetTuyen);
        }
        public string GetHoTen(string maHoSo)
        {
            return nguyenVongDAL.GetHoTen(maHoSo);
        }
        public DataTable GetDanhSachNganh()
        {
            return nguyenVongDAL.GetAllNganh();
        }
    }
}
