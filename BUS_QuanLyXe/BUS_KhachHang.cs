using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    public class BUS_KhachHang
    {
        DAO_KhachHang DAOkh;
        public BUS_KhachHang()
        {
            DAOkh = new DAO_KhachHang();
        }

        public List<DTO_KhachHang> getDanhSachKhachHang()
        {
            return DAOkh.layDanhSachKhachHang();
        }
        public IEnumerable<KHACHHANG> getTenXeTheoMaKH(string KH)
        {
            return DAOkh.getsTenXeTheoMaKH(KH);
        }
    }
}
