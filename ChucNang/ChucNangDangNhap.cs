using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ChucNang
{
    public class ChucNangDangNhap:Provider
    {
        List<NhanVien> lstNhanVien;
        public ChucNangDangNhap(Entities provider)
        {
            this.provider = provider;
            lstNhanVien = provider.NhanViens.ToList();
        }
        public bool KiemTraDangNhap(String taiKhoan, String matKhau)
        {
            if (lstNhanVien.FirstOrDefault(a => a.taikhoan == taiKhoan && a.matkhau == matKhau) != null) return true;
            return false;
        }
        public NhanVien LayNhanVienTuTaiKhoan(String taiKhoan)
        {
            return lstNhanVien.FirstOrDefault(a => a.taikhoan == taiKhoan);
        }
        public NhanVien LayNhanVienTuMa(int ma)
        {
            return lstNhanVien.FirstOrDefault(a => a.id == ma);
        }
    }
}
