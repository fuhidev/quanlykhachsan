using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using ChucNang;using Entity;

namespace Gui
{
    public partial class frmThanhToan : Telerik.WinControls.UI.RadForm
    {
        ChucNangProvider provider;
        Phong phong;
        ThuePhong thuePhong;
        public frmThanhToan()
        {
            InitializeComponent();
        }
        public frmThanhToan(Phong phong, ChucNangProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
            this.phong = phong;
        }
        HoaDon hoaDon = null;
        class HienThiDichVu
        {
            public String tenDichVu { get; set; }
            public int SoLuong { get; set; }
            public decimal donGia { get; set; }
            public DateTime thoiGian { get; set; }
        }
        void HienThiDichVuGridView()
        {
            var tp = provider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            if (tp == null) return;
            var lstDv = provider.ChucNangDichVu.LayDichVuTheoThuePhong(tp.mathuephong);
            if (lstDv == null || lstDv.Count == 0) return;
            var htdv = new List<HienThiDichVu>();
            foreach (var dv in lstDv)
            {
                htdv.Add(new HienThiDichVu
                {
                    tenDichVu=dv.DichVu1.tendichvu,
                    donGia=dv.DichVu1.dongia.Value,
                    SoLuong=dv.soluong.Value,
                    thoiGian=dv.thoigian.Value
                });
            }
            BindingSource binding = new BindingSource();
            binding.DataSource = htdv;
            gridView.DataSource = binding;
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            if (thuePhong == null)
                thuePhong = provider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            if (thuePhong == null) return;
            lbNgayden.Text = thuePhong.ngaythue.Value.ToLongDateString();
            lbNgaydi.Text = thuePhong.ngaytra.Value.ToLongDateString();
            hoaDon = provider.ChucNangPhong.LayHoaDon(thuePhong.mathuephong);
            if (hoaDon == null) return;
            if (hoaDon.KhachHang1 == null) return;
            lbTenNguoiThanhToan.Text = hoaDon.KhachHang1.ten;
            if (hoaDon.NhanVien1 == null) return;
            lbTenNhanVien.Text = hoaDon.NhanVien1.ten;
            if (hoaDon.tiendatra == null) return;
            lbThanhToanMotPhan.Text = hoaDon.tiendatra.Value+"";
            if (hoaDon.tienconthua == null) return;
            lbTienConLai.Text = hoaDon.tienconthua.Value + "";
            if (hoaDon.tongtienphong == null) return;
            lbTongTienPhong.Text = hoaDon.tongtienphong.Value + "";
            if (hoaDon.tongtien == null) return;
            lbTongTien.Text = hoaDon.tongtien.Value + "";
            if(hoaDon.tongtiendichvu != null)
            lbTongDichVu.Text = hoaDon.tongtiendichvu.Value + "";
            HienThiDichVuGridView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            XuLyButton.XuLyHover((RadButton)sender);
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            XuLyButton.XuLyLeave((RadButton)sender);
        }

        private void radThanhToan_Click(object sender, EventArgs e)
        {
            try
            {

                var result = provider.ChucNangPhong.ThanhToan(hoaDon, DateTime.Now);
                 if (result)
                {
                    XuLyRadDesktopAlert.showAlert("Thông báo", "Thanh toán thành công", radDesktopAlert1);
                    radThanhToan.Enabled = false;
                    btnInHoaDon.Enabled = true;
                }
                else
                {
                    XuLyRadDesktopAlert.showAlert("Thông báo", "Thanh toán thất bại", radDesktopAlert1);
                }
            }
            catch (Exception ex)
            {
                 XuLyRadDesktopAlert.showAlert("Thông báo", "Thanh toán thất bại", radDesktopAlert1);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình chưa thể hổ trợ in hóa đơn", "Thông báo");
        }
       
    }
}
