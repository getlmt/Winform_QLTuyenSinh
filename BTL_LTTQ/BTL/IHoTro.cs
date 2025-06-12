using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	public interface IHoTro
	{
		string MaHoSo {  get; set; }
		string ThongTinYeuCau { get; set; }
		string ThongTinHoTro { get; set; }
		string HinhThucHoTro { get; set; }
		void HienThiThongTinHoTro();
	}
}
