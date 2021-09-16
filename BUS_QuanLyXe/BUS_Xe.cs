using DTO_QuanLyXe;
using DAO_QuanLyXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLyXe
{
    public class BUS_Xe
    {
        DAO_Xe xe;
        public BUS_Xe()
        {
            xe = new DAO_Xe();
        }

        public List<DTO_Xe> getsDanhSachXe()
        {
            return xe.layDanhSachXe();
        }

        public IEnumerable<XE> getTenXeTheoMaXe(string Xe)
        {
            return xe.getsTenXeTheoMaXe(Xe);
        }
    }
}
