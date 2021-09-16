using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_LoaiHD
    {
        private string _StrMaLoai;
        private string _StrTenLoai;

        public string StrMaLoai { get => _StrMaLoai; set => _StrMaLoai = value; }
        public string StrTenLoai { get => _StrTenLoai; set => _StrTenLoai = value; }
    }
}
