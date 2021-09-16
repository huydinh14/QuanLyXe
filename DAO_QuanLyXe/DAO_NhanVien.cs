using DTO_QuanLyXe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_NhanVien : DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public DAO_NhanVien()
        {
            dt = getDataContext();
        }
        public List<DTO_NhanVien> layDanhSachNV()
        {
            var dsNV = dt.NHANVIENs.Select(p => p).OrderBy(p => p.MANV);

            List<DTO_NhanVien> lsnv = new List<DTO_NhanVien>();

            foreach (NHANVIEN item in dsNV)
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.StrMaNV = item.MANV;
                nv.StrTenNV = item.TENNV;
                nv.DTNgaySinh = (DateTime)item.NGAYSINH;
                nv.StrSDT = item.SDT;
                nv.StrDiaChi = item.DIACHI;
                nv.StrCMND = item.CMND;
                nv.GioiTinh = (bool)item.GIOITINH;
                lsnv.Add(nv);
            }
            return lsnv;
        }
    }
}
