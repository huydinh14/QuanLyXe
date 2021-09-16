using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_ChiTietHoaDon:DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_ChiTietHoaDon()
        {
            dt = getDataContext();
        }

        public IEnumerable<ChiTietHD> getChiTietHDThuocHD(string StrHoaDon)
        {
            IEnumerable<ChiTietHD> q;
            if (StrHoaDon.Equals(""))
                q = from n in dt.ChiTietHDs
                    select n;
            else
                q = from n in dt.ChiTietHDs
                    where n.MaHD.Equals(StrHoaDon)
                    select n;
            return q;
        }
    }
}
