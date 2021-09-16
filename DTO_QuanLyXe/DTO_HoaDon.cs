using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_HoaDon
    {
        private string _StrMaHD;
        private DateTime _DTNgayLapHD;
        private string _StrMaNV;
        private string _StrMaKH;
        private int _ITongTien;
        private string _StrLoaiHD;

        public string StrMaHD { get => _StrMaHD; set => _StrMaHD = value; }
        public DateTime DTNgayLapHD { get => _DTNgayLapHD; set => _DTNgayLapHD = value; }
        public string StrMaNV { get => _StrMaNV; set => _StrMaNV = value; }
        public string StrMaKH { get => _StrMaKH; set => _StrMaKH = value; }
        public int ITongTien { get => _ITongTien; set => _ITongTien = value; }
        public string StrLoaiHD { get => _StrLoaiHD; set => _StrLoaiHD = value; }

        public DTO_HoaDon()
        {

        }

        public DTO_HoaDon(string mahd, DateTime ngaylaphd, string manv, string makh, int tongtien, string loaihd)
        {
            this.StrMaHD = mahd;
            this.StrMaKH = makh;
            this.DTNgayLapHD = ngaylaphd;
            this.StrMaNV = manv;
            this.ITongTien = tongtien;
            this.StrLoaiHD = loaihd;
        }
    }
}
