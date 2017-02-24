using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ChucNang
{
    public class ChucNangProvider
    {
        private Entities provider;
        public ChucNangPhong ChucNangPhong { get; set; }
        public ChucNangDichVu ChucNangDichVu { get; set; }
        public ChucNangDangNhap ChucNangDangNhap { get; set; }
        public ChucNangProvider()
        {
            provider = new Entities();
            ChucNangPhong = new ChucNangPhong(provider);
            ChucNangDichVu = new ChucNangDichVu(provider);
            ChucNangDangNhap = new ChucNangDangNhap(provider) ;
        }
        public void Dispose()
        {
            provider.Dispose();
        }
    }
}
