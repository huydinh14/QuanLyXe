using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_NhaCungCap
    {
        string _StrMaNCC;
        string _StrTenNCC;
        string _StrDiaChi;
        string _StrSoDienThoai;

        public string StrMaNCC { get => _StrMaNCC; set => _StrMaNCC = value; }
        public string StrTenNCC { get => _StrTenNCC; set => _StrTenNCC = value; }
        public string StrDiaChi { get => _StrDiaChi; set => _StrDiaChi = value; }
        public string StrSoDienThoai { get => _StrSoDienThoai; set => _StrSoDienThoai = value; }

        public DTO_NhaCungCap()
        {

        }

        public DTO_NhaCungCap(string mancc, string tenncc, string diachi, string sdt)
        {
            this.StrMaNCC = mancc;
            this.StrTenNCC = tenncc;
            this.StrDiaChi = diachi;
            this.StrSoDienThoai = sdt;
        }
    }
}
