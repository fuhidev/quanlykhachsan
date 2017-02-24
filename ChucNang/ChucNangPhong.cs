using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Linq;


namespace ChucNang
{
    public class ChucNangPhong : Provider
    {
        public static class TinhTrang
        {
            public static int TINHTRANG_CHUADAT = 0;
            public static int TINHTRANG_DADAT = 1;
            public static int TINHTRANG_DANGTHUE = 2;
        }
        public static class VaiTro
        {
            public static int NGUOIDUNGTEN = 0;
            public static int NGUOIKHAC = 1;
        }
        public Phong LayPhongTheoMa(int maPhong)
        {
            return provider.Phongs.FirstOrDefault(a => a.id == (int)maPhong);
        }
        public LoaiPhong LayLoaiPhongTheoPhong(int maPhong)
        {
            var p = LayPhongTheoMa(maPhong);
            return provider.LoaiPhongs.FirstOrDefault(a => a.maloaiphong == (int)p.loaiphong);
        }
        public ChucNangPhong(Entities provider)
        {
            this.provider = provider;
        }
        public List<Phong> LayDanhSachPhong()
        {
            return provider.Phongs.ToList();
        }
        public List<Phong> TimPhongTheoTinhTrang(int tinhTrang)
        {
            if (tinhTrang == -1)
                return provider.Phongs.ToList();
            else
                return provider.Phongs.Where(q => q.tinhtrang == tinhTrang).ToList();
        }
        private const int DOSAU = 10;
        public static List<List<Phong>> timKiemYeuCauKhachHang(int soLuong, List<Phong> lstPhong, List<LoaiPhong> lstLoaiPhong)
        {
            var result = new List<List<Phong>>();
            List<LoaiPhong> tmpLoaiPhong = lstLoaiPhong.Where(q => q.soLuongGiuong >= soLuong).ToList();
            if (tmpLoaiPhong == null || tmpLoaiPhong.Count == 0)
            {
                int sizeLoaiPhong = lstLoaiPhong.Count;
                //tìm 2 loại phòng
                List<List<LoaiPhong>> tmplstLoaiPhong = new List<List<LoaiPhong>>();
                for (int i = 0; i < sizeLoaiPhong; i++)
                {
                    for (int j = i; j < sizeLoaiPhong; j++)
                    {
                        if (lstLoaiPhong[i].soLuongGiuong + lstLoaiPhong[j].soLuongGiuong >= soLuong)
                        {
                            var tmp = new List<LoaiPhong>();
                            tmp.Add(lstLoaiPhong[i]);
                            tmp.Add(lstLoaiPhong[j]);
                            tmplstLoaiPhong.Add(tmp);
                        }

                    }
                }
                if (tmplstLoaiPhong.Count != 0)
                {
                }
                for (int i = 0; i < sizeLoaiPhong; i++)
                {
                    for (int j = i; j < sizeLoaiPhong; j++)
                    {
                        for (int k = i; k < sizeLoaiPhong; k++)
                        {
                            if (lstLoaiPhong[i].soLuongGiuong + lstLoaiPhong[j].soLuongGiuong + lstLoaiPhong[k].soLuongGiuong >= soLuong)
                            {
                                var tmp = new List<LoaiPhong>();
                                tmp.Add(lstLoaiPhong[i]);
                                tmp.Add(lstLoaiPhong[j]);
                                tmplstLoaiPhong.Add(tmp);
                            }
                        }

                    }
                }
                if (tmplstLoaiPhong.Count != 0)
                {
                }
                foreach (var lp in lstLoaiPhong)
                {
                    int h = 0, soluong = 0;
                    do
                    {
                        soluong += lp.soLuongGiuong.Value;
                        if (soluong >= soLuong)
                        {
                            var tmp = new List<LoaiPhong>();
                            for (int s = 0; s < h; s++)
                                tmp.Add(lp);
                            tmplstLoaiPhong.Add(tmp);
                        }
                    } while (h < DOSAU);
                }
            }
            else
            {
                var tmp = new List<Phong>();
                foreach (var p in lstPhong)
                {
                    foreach (var lp in tmpLoaiPhong)
                    {
                        if (p.loaiphong == lp.maloaiphong)
                            tmp.Add(p);
                    }
                }
                result.Add(tmp);
            }

            return result;
        }
        /*public static List<List<Phong>> timKiemYeuCauKhachHang(int loaiPhong, int soLuong, List<Phong> lstPhong)
        {
            List<List<Phong>> result = new List<List<Phong>>();
            List<LoaiPhong> lstLoaiPhong = qlks.LoaiPhongs.ToList();
            var lp = lstLoaiPhong.First(q => q.maloaiphong == loaiPhong);
            //không có số lượng thì không cần tìm
            if (soLuong == null)
                return null;
            IEnumerable<Phong> query = null;
            //kiểm tra có loại phòng không
            if (lp != null)
            {
                query = lstPhong.Where(q => q.loaiphong == loaiPhong);
                //nếu số lượng của loại phòng đó mà lớn hơn số lượng yêu cầu, có nghĩa là loại phòng đó đủ sức chứa
                if (lp.soLuong >= soLuong)
                {
                    //thì trả về danh sách những những phòng thuộc loại phòng đó
                    result.Add(query.ToList());
                    return result;
                }
                //nếu không thì phải tìm những nhóm phòng có thể đáp ứng được yêu câu số lượng như vậy
                else
                {

                    var lstP = query.ToList();
                    //kiểm tra xem thử cần bao nhiêu phòng để đạt được số lượng như vậy
                    int soLuongPhongCan = soLuong / lp.soLuong.Value;
                    //nếu số lượng phòng còn trống không đủ số lượng phòng cần thì return 
                    if (lstP.Count < soLuongPhongCan)
                        return null;
                    //nếu số lượng phòng còn trống vừa đủ số lượng phòng cần thì trả về những phòng còn lại đó
                    if (lstP.Count == soLuongPhongCan)
                    {
                        result.Add(lstP);
                        return result;
                    }

                    var q = new Queue<Phong>();
                    q.Enqueue(lstP[0]);
                    while (q.Count == 0)
                    {
                        var item = q.Peek();
                        List<Phong> tmp = new List<Phong>();

                        foreach (var p in lstP)
                        {
                            if (item == p) continue;
                            tmp.Add(p);
                        }
                        int min = Math.Abs(tmp[0].id - item.id);
                        foreach (var p in tmp)
                        {
                            int value = Math.Abs(p.id - item.id);
                            if (value < min)
                                min =value;
                        }
                        foreach (var p in tmp)
                        {
                            if (p.id == min)
                            {
                                q.Enqueue(p); break;
                            }
                                
                        }
                        
                    }

                    /*var lstLoaiPhongs = new List<List<LoaiPhong>>();
                    for (int i = 0; i < lstLoaiPhong.Count; i++)
                    {
                        for (int j = i; j < lstLoaiPhong.Count; j++)
                        {
                            if (lstLoaiPhong[i].soLuong + lstLoaiPhong[j].soLuong >= soLuong)
                            {
                                var a = new List<LoaiPhong>();
                                a.Add(lstLoaiPhong[i]); a.Add(lstLoaiPhong[j]);
                                lstLoaiPhongs.Add(a);
                            }
                        }
                    }
                    //nếu như không tìm được tổ hợp phòng nào phù hợp
                    if (lstLoaiPhongs.Count == 0)
                        //thì trả về rỗng
                        return null;
                    //nếu như có tổ hợp rồi thì từ tổ hợp loại phòng đó rồi tìm ra những tổ hợp phòng tương ứng
                    foreach (var lstP in lstLoaiPhongs)
                    {
                        List<Phong> phongs = query
                    }/
                }
            }
            else
            {
                query = from p in lstPhong
                        from l in lstLoaiPhong
                        where p.tinhtrang == Phong.TINHTRANG_CHUADAT && p.loaiphong == l.maloaiphong && l.soLuong >= soLuong
                        select p;
                //nếu như tìm thấy
                if (query != null)
                {
                    //thì trả về
                    result.Add(query.ToList());
                    return result;
                }
                //nếu không
                else
                {
                    //phải tìm những nhóm phngf có thể đáp ứng được yêu cầu số lượng như vậy
                }
            }
            var phongs = query.ToList();

            //query.Where(q=>q.)
            Stack<Phong> stack = new Stack<Phong>();
            return null;
        }*/
        private static List<List<Phong>> timPhongTheoLoaiPhong(List<LoaiPhong> lstLoaiPhong)
        {
            return null;
        }
        public static List<List<Phong>> a(int soLuong, List<Phong> lstPhong, List<LoaiPhong> lstLoaiPhong)
        {
            List<List<Phong>> result = new List<List<Phong>>();

            Queue<Node> q = new Queue<Node>();
            var currentNode = new Node { current = lstPhong[0], value = lstLoaiPhong.FirstOrDefault(a => a.maloaiphong == lstPhong[0].loaiphong).soLuongGiuong.Value };
            q.Enqueue(currentNode);
            int h = 0;
            while (q.Count != 0 && h < DOSAU)
            {
                var current = q.Dequeue();
                if (current.value >= soLuong)
                {
                    var tmpList = new List<Phong>();
                    var tmpNode = current;
                    do
                    {
                        tmpList.Add(tmpNode.current);
                        tmpNode = current.parent;

                    } while (tmpNode.parent != null);
                    result.Add(tmpList);
                }
                foreach (var p in lstPhong)
                {
                    var soLuongP = lstLoaiPhong.FirstOrDefault(w => w.maloaiphong == p.loaiphong).soLuongGiuong.Value;
                    var node = new Node { parent = current, value = soLuongP + current.value, current = p };
                    if (!kiemTraPhaiLaCha(current, node))
                        q.Enqueue(node);
                }
                h++;
            }



            return null;
        }
        private static bool kiemTraPhaiLaCha(Node n1, Node n2)
        {
            var current = n2;
            do
            {
                if (current == n1)
                    return true;
                current = n2.parent;
            } while (current.parent != null);
            return false;
        }

        public class LoaiTienPhong
        {
            public static String O_MOT_NGAY = "Ở một ngày";
        }
        public decimal LayTienPhong(int loaiPhong, DateTime ngayThue, DateTime ngayTra)
        {
            var sOGioO = ngayTra - ngayThue;
            var tienPhongs = provider.GiaTiens.Where(a => a.loaiphong == loaiPhong).ToList();
            decimal tienPhong = 0;
            if (sOGioO.Days != 0)
            {
                tienPhong = tienPhongs.FirstOrDefault(a => a.loaigiatien == LoaiTienPhong.O_MOT_NGAY).giatien1.Value;
                tienPhong *= sOGioO.Days;
            }
            return tienPhong;
        }
        public HoaDon LayHoaDon(int maThuePhong)
        {
            return provider.HoaDons.First(a => a.mathuephong == maThuePhong);
        }
        public bool ThanhToan(HoaDon hoaDon, DateTime ngayThanhToan)
        {
            try
            {

                var hd = provider.HoaDons.FirstOrDefault(a => a.mahoadon == (long)hoaDon.mahoadon);
                hd.tienconthua = 0; hd.tiendatra = hd.tongtien; hd.ngaythanhtoan = ngayThanhToan;
                hd.ThuePhong.Phong.tinhtrang = TinhTrang.TINHTRANG_CHUADAT;
                return provider.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool DatPhong(ThuePhong thuePhong, KhachHang khachHang, decimal tienDatCoc = 0, int nhanVien = 1)
        {
            var hoaDon = new HoaDon();
            if (khachHang == null || thuePhong == null) return false;
            try
            {
                //provider = new Entities();
                if (provider.KhachHangs.FirstOrDefault(a => a.id == khachHang.id) == null)
                {
                    provider.KhachHangs.Add(khachHang);
                }
                var cttp = new ChiTietThuePhong
                {
                    khachhang = khachHang.id,
                    ThuePhong = thuePhong,
                    vaitro = VaiTro.NGUOIDUNGTEN
                };
                provider.ThuePhongs.Add(thuePhong);
                provider.ChiTietThuePhongs.Add(cttp);
                var sOGioO = thuePhong.ngaytra - thuePhong.ngaythue;
                var tienPhongs = provider.GiaTiens.Where(a => a.loaiphong == 1).ToList();
                decimal tienPhong = 0;
                if (sOGioO.Value.Days != 0)
                {
                    tienPhong = tienPhongs.FirstOrDefault(a => a.loaigiatien == LoaiTienPhong.O_MOT_NGAY).giatien1.Value;
                    tienPhong *= sOGioO.Value.Days;
                }
                hoaDon = new HoaDon
                {
                    khachhang = khachHang.id,
                    ThuePhong = thuePhong,
                    nhanvien = nhanVien,
                    tiendatra = (decimal)tienDatCoc,
                    tongtienphong = (decimal)tienPhong,
                    tienconthua = tienPhong - tienDatCoc,
                    tongtien = tienPhong
                };
                provider.HoaDons.Add(hoaDon);

                provider.Phongs.FirstOrDefault(a => a.id == (int)thuePhong.maphong).tinhtrang = TinhTrang.TINHTRANG_DADAT;

                var result = provider.SaveChanges() > 0;
                if (result)
                    return true;
                else
                {
                    provider.ChiTietThuePhongs.RemoveRange(thuePhong.ChiTietThuePhongs);
                    provider.ThuePhongs.Remove(thuePhong);
                    provider.HoaDons.Remove(hoaDon);
                    provider.Phongs.FirstOrDefault(a => a.id == (int)thuePhong.maphong).tinhtrang = TinhTrang.TINHTRANG_CHUADAT;
                    provider.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
                provider.ChiTietThuePhongs.RemoveRange(thuePhong.ChiTietThuePhongs);
                provider.ThuePhongs.Remove(thuePhong);
                provider.HoaDons.Remove(hoaDon);
                provider.Phongs.FirstOrDefault(a => a.id == (int)thuePhong.maphong).tinhtrang = TinhTrang.TINHTRANG_CHUADAT;
                provider.SaveChanges();
            }
            return false;
        }
        public bool NhanPhong(Phong phong, List<KhachHang> tmpListKhachHang, List<ChiTietThuePhong> tmpChiTietThuePhong)
        {
            var thuePhong = LayThuePhongTuPhong(phong.id);
            if (thuePhong == null || tmpListKhachHang.Count != tmpChiTietThuePhong.Count || tmpListKhachHang == null || tmpChiTietThuePhong == null) return false;
            try
            {
                List<KhachHang> lstKH = provider.KhachHangs.ToList();
                foreach (var kh in tmpListKhachHang)
                    if (lstKH.FirstOrDefault(a => a.id == (String)kh.id) == null)
                        provider.KhachHangs.Add(kh);
                tmpChiTietThuePhong.ForEach(a => a.mathuephong = thuePhong.mathuephong);
                provider.ChiTietThuePhongs.AddRange(tmpChiTietThuePhong);
                provider.Phongs.FirstOrDefault(a => a.id == (int)thuePhong.maphong).tinhtrang = TinhTrang.TINHTRANG_DANGTHUE;
                var result = provider.SaveChanges() > 0;
                if (result) return true;
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LoaiPhong> LayDanhSachLoaiPhong()
        {
            return provider.LoaiPhongs.ToList();
        }
        public List<LoaiPhong> LayLoaiPhongTheoTang(int maTang)
        {
            List<LoaiPhong> tmpLp = new List<LoaiPhong>();
            var tmpPhong = provider.Phongs.Where(w => w.tang == maTang).ToList();
            var lstLoaiPhong = provider.LoaiPhongs.ToList();
            foreach (var lp in lstLoaiPhong)
            {
                if (tmpPhong.FirstOrDefault(f => f.loaiphong == (int)lp.maloaiphong) != null)
                {
                    tmpLp.Add(lp);
                    continue;
                }
            }
            return tmpLp;
        }
        public List<Phong> LayPhongTheoTangVaLoaiPhong(int tang, int loaiphong)
        {
            return provider.Phongs.Where(a => a.tinhtrang == TinhTrang.TINHTRANG_CHUADAT && a.loaiphong == loaiphong && a.tang == tang).ToList();
        }
        //public List<Phong> LayPhongTheoNgayGio(DateTime ngayden, DateTime ngaydi,List<Phong> tmpPhong)
        //{
        //}
        public bool KiemTraTrungThoiGian(Phong phong, DateTime thoiGianDen, DateTime thoiGianDi)
        {
            var thuePhong = provider.ThuePhongs.FirstOrDefault(a => a.maphong == (int)phong.id);
            if (thuePhong.ngaythue <= thoiGianDen && thuePhong.ngaythue <= thoiGianDi)
                return false;
            return true;
        }
        public bool KiemTraTrungThoiGian(ThuePhong thuePhong)
        {
            var phong = provider.Phongs.First(a => a.id == (int)thuePhong.maphong);
            return KiemTraTrungThoiGian(phong, thuePhong.ngaythue.Value, thuePhong.ngaytra.Value);
        }
        public bool ChuyenPhong(Phong phongCu, int phongMoi)
        {
            try
            {
                var tmpTP = provider.ThuePhongs.FirstOrDefault(f => (int)phongCu.id == f.maphong);
                var tinhtrang = tmpTP.Phong.tinhtrang;
                tmpTP.Phong.tinhtrang = TinhTrang.TINHTRANG_CHUADAT;
                tmpTP.maphong = phongMoi;
                provider.SaveChanges();
                tmpTP.Phong.tinhtrang = tinhtrang;
                provider.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
        public ThuePhong LayThuePhongTuPhong(int maPhong)
        {
            return provider.ThuePhongs.OrderByDescending(o=>o.ngaythue).FirstOrDefault(a => a.maphong == (int)maPhong 
                && 
                a.ngaythue.Value <= DateTime.Now && a.ngaytra.Value >= DateTime.Now);
        }
        public LoaiPhong LayLoaiPhongTheoMa(int ma)
        {
            return provider.LoaiPhongs.FirstOrDefault(a => a.maloaiphong == ma);
        }
        public KhachHang LayKhachHangTheoThuePhong(int maThuePhong)
        {
            var tp = provider.ThuePhongs.FirstOrDefault(a => a.mathuephong == (int)maThuePhong);
            foreach (var cttp in tp.ChiTietThuePhongs)
            {
                if (cttp.vaitro == VaiTro.NGUOIDUNGTEN)
                    return cttp.KhachHang1;
            }
            return null;
        }
        public KhachHang LayNguoiDungTenCuaPhong(int maPhong)
        {
            var thuePhong = LayThuePhongTuPhong(maPhong);
            return thuePhong.ChiTietThuePhongs.First().KhachHang1;
        }
    }

    class Node
    {
        public Node parent;
        public Phong current;
        public int value;
    }
    class Main
    {

    }
}