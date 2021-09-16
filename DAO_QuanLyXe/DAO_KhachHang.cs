using DTO_QuanLyXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO_QuanLyXe
{
    public class DAO_KhachHang : DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_KhachHang()
        {
            dt = getDataContext();
        }

        public List<DTO_KhachHang> layDanhSachKhachHang()
        {
            var dskh = dt.KHACHHANGs.Select(p => p).OrderBy(p => p.MAKH);

            List<DTO_KhachHang> lskh = new List<DTO_KhachHang>();

            foreach (KHACHHANG item in dskh)
            {
                DTO_KhachHang kh = new DTO_KhachHang();
                kh.StrMaKH = item.MAKH;
                kh.StrTenKH = item.TENKH;
                kh.DTNgaySinh = (DateTime)item.NGAYSINH; ;
                kh.StrSDT = item.SDT;
                kh.StrDiaChi = item.DIACHI;
                kh.StrCMND = item.CMND;

                lskh.Add(kh);
            }
            return lskh;
        }

        public IEnumerable<KHACHHANG> getsTenXeTheoMaKH(string KH)
        {
            IEnumerable<KHACHHANG> kh = from n in dt.KHACHHANGs
                                 where n.MAKH == KH
                                        select n;
            return kh;
        }
    }
}
