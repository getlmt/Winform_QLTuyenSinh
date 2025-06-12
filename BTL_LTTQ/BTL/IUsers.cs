using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	public interface IUsers
	{
		string MaHoSo { get; set; }
		string HoTen { get; set; }
		string SoDienThoai { get; set; }
		string NgaySinh { get; set; }
		string DiaChi { get; set; }
		string AnhHoSo { get; set; }
		void HienThiThongTin();
	}
}
