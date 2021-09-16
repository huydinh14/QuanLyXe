using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_HoaDon
    {
        DAO_HoaDon DAOhd;
        public BUS_HoaDon()
        {
            DAOhd = new DAO_HoaDon();
        }

        public IEnumerable<HoaDon> getAllHoadon()
        {
            return DAOhd.getAllHoaDon();
        }
    }
}
