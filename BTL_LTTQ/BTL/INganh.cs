using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	public interface INganh
	{
		string MaNganh { get; set; }
		string MoTa { get; set; }
		string AnhNganh { get; set; }
		string TenNganh { get; set; }
		void HienThiThongTinNganh();
	}
}
