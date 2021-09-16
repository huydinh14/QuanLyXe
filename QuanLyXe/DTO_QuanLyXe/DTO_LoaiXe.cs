using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_LoaiXe
    {
        string _StrMaLoai;
        string _StrTenLoai;

        public string StrMaLoai { get => _StrMaLoai; set => _StrMaLoai = value; }
        public string StrTenLoai { get => _StrTenLoai; set => _StrTenLoai = value; }

        public DTO_LoaiXe()
        {

        }
        public DTO_LoaiXe(string maloai, string tenloai)
        {
            this.StrMaLoai = maloai;
            this.StrTenLoai = tenloai;
        }
    }
}
