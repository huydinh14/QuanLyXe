using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_LoaiHD : DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_LoaiHD()
        {
            dt = new QuanLyXeDataContext();
        }
        public IEnumerable<LOAIHD> getInForLoaiHoaDon()
        {
            IEnumerable<LOAIHD> q = from n in dt.LOAIHDs
                select n;
            return q;

        }
    }
}
