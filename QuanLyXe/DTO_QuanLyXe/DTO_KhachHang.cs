using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_KhachHang
    {
        private string _StrMaKH;
        private string _StrTenKH;
        private string _StrSoDienThoai;
        private DateTime _DTNgaySinh;
        private string _StrCMND;
        private string _StrDiaChi;

        public string StrMaKH { get => _StrMaKH; set => _StrMaKH = value; }
        public string StrTenKH { get => _StrTenKH; set => _StrTenKH = value; }
        public string StrSDT { get => _StrSoDienThoai; set => _StrSoDienThoai = value; }
        public DateTime DTNgaySinh { get => _DTNgaySinh; set => _DTNgaySinh = value; }
        public string StrCMND { get => _StrCMND; set => _StrCMND = value; }
        public string StrDiaChi { get => _StrDiaChi; set => _StrDiaChi = value; }

        public DTO_KhachHang()
        {

        }

        public DTO_KhachHang(string makh, string tenkh, string sdt, DateTime ngaysinh, string cmnd, string diachi)
        {
            this.StrMaKH = makh;
            this.StrTenKH = tenkh;
            this.StrSDT = sdt;
            this.DTNgaySinh = ngaysinh;
            this.StrCMND = cmnd;
            this.StrDiaChi = diachi;
        }
    }
}
