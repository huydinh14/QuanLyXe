using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLyXe;

namespace DAO_QuanLyXe
{
    public class DAO_Xe : DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_Xe()
        {
            dt = getDataContext();
        }

        public List<DTO_Xe> layDanhSachXe()
        {
            var dsxe = dt.XEs.Select(p => p).OrderBy(p => p.MAXE);

            List<DTO_Xe> lskh = new List<DTO_Xe>();

            foreach (XE item in dsxe)
            {
                    DTO_Xe xe = new DTO_Xe();
                    xe.StrMaXe = item.MAXE;
                    xe.StrTenXe = item.TENXE;
                    xe.StrMaLoai = item.MALOAIXE;
                    xe.MaNCC = item.MANCC;
                    xe.StrGhiChu = item.GHICHU;
                    xe.DecDonGiaBan = (decimal)item.DONGIABAN;
                xe.DecDonGiaNhap = (decimal)item.DONGIANHAP;
                    xe.IPhanKhoi = (int)item.PHANKHOI;
                xe.ISoLuongTon = (int)item.SOLUONGTON;

                lskh.Add(xe);
            }
            return lskh;
        }

        public IEnumerable<XE> getsTenXeTheoMaXe(string Xe)
        {
            IEnumerable<XE> xe = from n in dt.XEs
                                 where n.MAXE == Xe
                                 select n;
            return xe;
        }
    }
}
