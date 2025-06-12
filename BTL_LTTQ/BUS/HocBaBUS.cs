using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HocBaBUS
    {
        private readonly HocBaDAL hocBaDAL;
        public HocBaBUS()
        {
            hocBaDAL = new HocBaDAL();
        }
        public string GetHoTen(string maHoSo)
        {
            return hocBaDAL.GetHoTen(maHoSo);
        }
        public bool ValidateScore(string scoreText)
        {
            if (double.TryParse(scoreText, out double score))
            {
                return score >= 0 && score <= 10;
            }
            return false;
        }
		public bool ValidateDXT(string scoreText)
		{
			if (double.TryParse(scoreText, out double score))
			{
				return score >= 0 && score <= 30;
			}
			return false;
		}
        public string GetDiemTrungBinhHocBa(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemHocBaTrungBinh");
        }
        public string GetDiemToan(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemToan");
        }
        public string GetDiemVan(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemVan");
        }
        public string GetDiemAnh(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemAnh");
        }
        public string GetDiemLy(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemLy");
        }
        public string GetDiemHoa(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemHoa");
        }
        public string GetDiemSinh(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "DiemSinh");
        }
		public string GetDiemSu(string maHoSo)
		{
			return hocBaDAL.GetDiemHocBa(maHoSo, "DiemSu");
		}
		public string GetDiemDia(string maHoSo)
		{
			return hocBaDAL.GetDiemHocBa(maHoSo, "DiemDia");
		}
		public string GetDiemGDCD(string maHoSo)
		{
			return hocBaDAL.GetDiemHocBa(maHoSo, "DiemGDCD");
		}
		public string GetHanhKiem(string maHoSo)
        {
            return hocBaDAL.GetDiemHocBa(maHoSo, "HanhKiemCap3");
        }
        public HocBaModel GetHocBa(string maHoSo)
        {
            return hocBaDAL.GetHocBaModel(maHoSo);
        }
    }
}