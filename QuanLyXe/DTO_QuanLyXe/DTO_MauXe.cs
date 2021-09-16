using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLyXe
{
    public class DTO_MauXe
    {
        string _STrMaMau;
        string _StrTenMau;
        public string StrMaMau { get => _STrMaMau; set => _STrMaMau = value; }
        public string StrTenMau { get => _StrTenMau; set => _StrTenMau = value; }

        public DTO_MauXe()
        {

        }

        public DTO_MauXe(string mamau, string tenmau)
        {
            this.StrMaMau = mamau;
            this.StrTenMau = tenmau;
        }
    }
}
