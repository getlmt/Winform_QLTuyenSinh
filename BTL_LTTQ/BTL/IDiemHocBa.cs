using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	public interface IDiemHocBa
	{
		string MaHoSo { get; set; }
		string DiemKi1Lop10 { get; set; }
		string DiemKi2Lop10 { get; set; }
		string DiemKi1Lop11 { get; set; }
		string DiemKi2Lop11 { get; set; }
		string DiemKi1Lop12 { get; set; }
		string DiemKi2Lop12 { get; set; }
		string DiemXetTuyen { get; set; }
		string HanhKiemCap3 { get; set; }
		void HienThongTinDiem();
	}
}
