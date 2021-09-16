using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_ChiTietHoaDon
    {
        DAO_ChiTietHoaDon cthd;
        public BUS_ChiTietHoaDon()
        {
            cthd = new DAO_ChiTietHoaDon();
        }

        public IEnumerable<
            ChiTietHD> getAllChiTietHD(String StrMaHD)
        {
            return cthd.getChiTietHDThuocHD(StrMaHD);
        }
    }
}
