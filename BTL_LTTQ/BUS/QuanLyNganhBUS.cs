using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BUS
{
    public class QuanLyNganhBUS
    {
        private QuanLyNganhDAL nganhDAL;
        public QuanLyNganhBUS()
        {
            nganhDAL = new QuanLyNganhDAL();
        }
        public DataTable LayDanhSachNganh()
        {
            return nganhDAL.GetAllNganh();
        }
        public bool ThemNganh(string maNganh, string moTa, string tenNganh, int chiTieu)
        {
            if (string.IsNullOrWhiteSpace(maNganh) || string.IsNullOrWhiteSpace(moTa)||chiTieu==null)
                return false;
            if (nganhDAL.KiemTraMaNganhTonTai(maNganh))
                return false;
            return nganhDAL.ThemNganh(maNganh, moTa, tenNganh, chiTieu);
        }
		public bool CheckTrungTuyen()
		{
			return nganhDAL.CheckTrungTuyen();
		}
		public DataTable TimKiemNganh(string maNganh)
		{
			if (string.IsNullOrWhiteSpace(maNganh))
				throw new ArgumentException("Mã ngành không được để trống");

			return nganhDAL.TimKiemNganh(maNganh);
		}
		public bool XoaNganh(string maNganh)
        {
            if (string.IsNullOrWhiteSpace(maNganh))
                return false;
            return nganhDAL.XoaNganh(maNganh);
        }
        public bool SuaNganh(string maNganh, string moTa, string tenNganh, int chiTieu)
        {
            return nganhDAL.SuaNganh(maNganh, moTa, tenNganh, chiTieu);
        }
    }
}
