using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_HonLoan : DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_HonLoan()
        {
            dt = getDataContext();
        }
        public IEnumerable<dynamic> GopHoaHonKhachHangXe()
        {
            var q = from n in dt.HOADONs
                    join x in dt.CHITIETHDs
                    on n.MAHD equals x.MAHD
                    join z in dt.KHACHHANGs
                    on n.MAHD equals z.MAKH
                    select new { maHD = n.MAHD, maXe = x.MAXE, soLuong = x.SOLUONG, donGia = x.DONGIA, thanhTien = (x.SOLUONG*x.DONGIA) };   
            return q;
        }
    }
}
