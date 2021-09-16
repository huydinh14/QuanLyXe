using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_NhanVien
    {
        string _StrMaNV;
        string _StrTenNV;
        DateTime _DTNgaySinh;
        string _StrCMND;
        string _StrSDT;
        string _StrDiaChi;
        string _StrGioiTinh;

        public string StrMaNV { get => _StrMaNV; set => _StrMaNV = value; }
        public string StrTenNV { get => _StrTenNV; set => _StrTenNV = value; }
        public DateTime DTNgaySinh { get => _DTNgaySinh; set => _DTNgaySinh = value; }
        public string StrCMND { get => _StrCMND; set => _StrCMND = value; }
        public string StrSDT { get => _StrSDT; set => _StrSDT = value; }
        public string StrDiaChi { get => _StrDiaChi; set => _StrDiaChi = value; }
        public string StrGioiTinh { get => _StrGioiTinh; set => _StrGioiTinh = value; }

        public DTO_NhanVien()
        {

        }

        public DTO_NhanVien(string manv, string tennv, DateTime ngaysinh, string cmnd, string sdt, string diachi, string gioitinh)
        {
            this.StrMaNV = manv;
            this.StrTenNV = tennv;
            this.DTNgaySinh = ngaysinh;
            this.StrCMND = cmnd;
            this.StrSDT = sdt;
            this.StrDiaChi = diachi;
            this.StrGioiTinh = gioitinh;
        }
    }
}
