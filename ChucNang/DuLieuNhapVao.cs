using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChucNang
{
    public class DuLieuNhapVao
    {

        public static bool KiemTraDuLieuNhapSoKhongAm(int so)
        {
            if (so < 0)
                return false;
            return true;
        }
    }
}
