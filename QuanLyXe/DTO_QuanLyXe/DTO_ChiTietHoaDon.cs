using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_ChiTietHoaDon
    {
        private string _StrMaHD;
        private string _StrMaXe;
        private int _ISoLuong;
        private int _IDonGia;
        private int _IThanhTien;

        public string StrMaHD { get => _StrMaHD; set => _StrMaHD = value; }
        public string StrMaXe { get => _StrMaXe; set => _StrMaXe = value; }
        public int ISoLuong { get => _ISoLuong; set => _ISoLuong = value; }
        public int IDonGia { get => _IDonGia; set => _IDonGia = value; }
        public int IThanhTien { get => _IThanhTien; set => _IThanhTien = value; }

        public DTO_ChiTietHoaDon()
        {

        }

        public DTO_ChiTietHoaDon(string mahd, string maxe, int soluong, int dongia, int thanhtien)
        {
            this.StrMaHD = mahd;
            this.StrMaXe = maxe;
            this.ISoLuong = soluong;
            this.IDonGia = dongia;
            this.IThanhTien = thanhtien;
        }
    }
}
