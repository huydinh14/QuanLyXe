using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace QuanLyXe.Regular_Expression
{
    public class CheckHoaDon
    {
        public bool checkRegex(string soLuong)
        {
            return Regex.Match(soLuong, @"^([0-9]{1,2})$").Success;
        }
    }
}
