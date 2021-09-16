using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_HonLoan
    {
        DAO_HonLoan DAOhl;
        public BUS_HonLoan()
        {
            DAOhl = new DAO_HonLoan();
        }

        public IEnumerable<dynamic> getHonLoan()
        {
            return DAOhl.GopHoaHonKhachHangXe();
        }
    }
}
