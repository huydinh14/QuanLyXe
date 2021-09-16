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
            var q = from n in dt.HoaDons
                    join x in dt.ChiTietHDs
                    on n.MaHD equals x.MaHD
                    join z in dt.KhachHangs
                    on n.MaKH equals z.MaKH
                    //join v in dt.Xes
                    //on n.
                    select new { tt = n.MaHD, x.MaXe, x.Soluong, x.DonGia, x.ThanhTien };
            return q;
        }
    }
}
