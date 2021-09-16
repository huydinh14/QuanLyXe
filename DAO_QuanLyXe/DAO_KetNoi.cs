using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QuanLyXe
{
    public class DAO_KetNoi
    {
        QuanLyXeDataContext dt;
        public QuanLyXeDataContext getDataContext()
        {
            string Str = @"Data Source=LAPTOP-FUAJRQ65;Initial Catalog=QL_QuanLyXe;Integrated Security=True";
            dt = new QuanLyXeDataContext(Str);
            dt.Connection.Open();
            return dt;
        }
    }
}
