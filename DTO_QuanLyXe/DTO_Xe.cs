using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_Xe
    {
        string _StrMaXe;
        string _StrTenXe;
        int _IPhanKhoi;
        int _ISoLuongTon;
        string _StrMauMa;
        string _StrMaLoai;
        decimal _DecDonGiaNhap;
        decimal _DecDonGiaBan;
        string _StrGhiChu;
        string _MaNCC;

        public string StrMaXe { get => _StrMaXe; set => _StrMaXe = value; }
        public string StrTenXe { get => _StrTenXe; set => _StrTenXe = value; }
        public int IPhanKhoi { get => _IPhanKhoi; set => _IPhanKhoi = value; }
        public int ISoLuongTon { get => _ISoLuongTon; set => _ISoLuongTon = value; }
        public string StrMauMa { get => _StrMauMa; set => _StrMauMa = value; }
        public string StrMaLoai { get => _StrMaLoai; set => _StrMaLoai = value; }
        public decimal DecDonGiaNhap { get => _DecDonGiaNhap; set => _DecDonGiaNhap = value; }
        public decimal DecDonGiaBan { get => _DecDonGiaBan; set => _DecDonGiaBan = value; }
        public string StrGhiChu { get => _StrGhiChu; set => _StrGhiChu = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }

        public DTO_Xe()
        {

        }

        public DTO_Xe(string maxe, string tenxe, int phankhoi, int soluongton, string mauma, string maloai, decimal dongianhap, decimal dongiaban, string ghichu, string mancc)
        {
            this.StrMaXe = maxe;
            this.StrTenXe = tenxe;
            this.IPhanKhoi = phankhoi;
            this.ISoLuongTon = soluongton;
            this.StrMauMa = mauma;
            this.StrMaLoai = maloai;
            this.DecDonGiaNhap = dongianhap;
            this.DecDonGiaBan = dongiaban;
            this.StrGhiChu = ghichu;
            this.MaNCC = mancc;
        }
    }
}
