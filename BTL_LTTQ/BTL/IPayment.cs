using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	public interface IPayment
	{
		string MaHoSo { get; set; }
		Double SoTienThanhToan { get; set; }
		string HinhThucThanhToan { get; set; }
		string BienLai { get; set; }
		void KiemTraThanhToan();
	}
}
