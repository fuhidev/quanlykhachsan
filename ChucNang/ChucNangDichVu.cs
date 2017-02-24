using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace ChucNang
{
    public class ChucNangDichVu : Provider
    {
        List<DichVu> lstDichVu;
        List<LoaiDichVu> lstLoaiDichVu;
        public ChucNangDichVu(Entities provider)
        {
            this.provider = provider;
            lstDichVu = provider.DichVus.ToList();
            lstLoaiDichVu = provider.LoaiDichVus.ToList();
        }
        public List<ChiTietDichVu> LayDichVuTheoThuePhong(int maThuePhong)
        {
            return provider.ChiTietDichVus.Where(a => a.mathuephong == maThuePhong).ToList();
        }
        public bool ThemDichVuVaoPhong(ThuePhong thuePhong, List<ChiTietDichVu> tmpChiTietDichVu)
        {

            try
            {
                if (tmpChiTietDichVu == null || tmpChiTietDichVu.Count == 0 || thuePhong == null) return false;
                if (thuePhong == null )
                    return false;
                tmpChiTietDichVu.ForEach(a =>  a.mathuephong = (int)thuePhong.mathuephong );
                foreach (var cttdv in tmpChiTietDichVu)
                {
                    var dv = provider.DichVus.FirstOrDefault(f => f.madichvu == cttdv.dichvu);
                    thuePhong.HoaDons.First().tongtiendichvu =cttdv.soluong+dv.dongia.Value;
                }
                thuePhong.HoaDons.First().tongtien += thuePhong.HoaDons.First().tongtiendichvu;
                provider.ChiTietDichVus.AddRange(tmpChiTietDichVu);
                return provider.SaveChanges()>0;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<DichVu> LayDichVu()
        {
            return provider.DichVus.ToList();
        }
        public List<LoaiDichVu> LayLoaiDichVu()
        {
            return lstLoaiDichVu;
        }
        public List<DichVu> LayDichVuTheoLoaiDichVu(int maLoaiDichVu)
        {
            return provider.DichVus.Where(a => a.loaidichvu == maLoaiDichVu).ToList();
        }
    }
}
