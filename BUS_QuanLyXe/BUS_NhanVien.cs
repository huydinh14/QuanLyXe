using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QuanLyXe;
using DTO_QuanLyXe;

namespace BUS_QuanLyXe
{
    
   public class BUS_NhanVien: DAO_KetNoi
    {
        DAO_NhanVien DAOnv;
        public BUS_NhanVien()
        {
            DAOnv = new DAO_NhanVien();
        }
        public List<DTO_NhanVien> getDanhSachNhanVien()
        {
            return DAOnv.layDanhSachNV();
        }
    }
}
