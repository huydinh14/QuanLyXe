using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_HoaDon : DAO_KetNoi
    {
        QuanLyXeDataContext dt;

        public DAO_HoaDon()
        {
            dt = getDataContext();
        } 

        //Lay nguyen bang Hoa Don
        public IEnumerable<HoaDon> getAllHoaDon()
        {
            IEnumerable<HoaDon> hd = from n in dt.HoaDons
                                     select n;
            return hd;
        }
    }
}
