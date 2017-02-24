using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ChucNang;
using Telerik.WinControls.UI;
using Entity;
namespace Gui
{
    public partial class frmChuyenPhong : Telerik.WinControls.UI.RadForm
    {
        ChucNangProvider provider;
        ThuePhong thuePhong;
        List<Phong> lstPhong;
        BindingList<Phong> bindingPhong;
        Phong phong;
        public frmChuyenPhong()
        {
            InitializeComponent();
            this.provider = new ChucNangProvider();
        }

        public frmChuyenPhong(ThuePhong thuePhong, ChucNangProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
            this.thuePhong = thuePhong;
        }
        public frmChuyenPhong(Phong phong, ChucNangProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
            this.phong = phong;
        }
        private void KhoiTaoComboboxPhong()
        {
            cbPhong.DataSource = bindingPhong;
            cbPhong.DisplayMember = "tenphong";
            cbPhong.ValueMember = "id";
        }

        private void btnHuy_MouseHover(object sender, EventArgs e)
        {
            XuLyButton.XuLyHover((RadButton)sender);
        }

        private void btnHuy_MouseLeave(object sender, EventArgs e)
        {
            XuLyButton.XuLyLeave((RadButton)sender);
        }

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            var lstLoaiPhong = provider.ChucNangPhong.LayDanhSachLoaiPhong();
            lstPhong = new List<Phong>();
            BindingSource binding = new BindingSource();
            binding.DataSource = lstLoaiPhong;
            cbLoaiPhong.DataSource = binding;

            KhoiTaoComboboxPhong();
            KhoiTaoThongTinPhongCanChuyen();
        }
        void KhoiTaoThongTinPhongCanChuyen()
        {
            var loaiPhong = provider.ChucNangPhong.LayLoaiPhongTheoMa(phong.loaiphong);
            lbLoaiPhongDangO.Text = loaiPhong.tenLoaiPhong;
            lbPhongDangO.Text = phong.tenphong;
            var kh = provider.ChucNangPhong.LayKhachHangTheoThuePhong(provider.ChucNangPhong.LayThuePhongTuPhong(phong.id).mathuephong);
            if (kh != null)
                lbTenChuPhong.Text = kh.ten;
            var thuePhong = provider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            var soLuongNguoiDangO = thuePhong.ChiTietThuePhongs.Count;
            lbSoLuongNguoiDangO.Text = soLuongNguoiDangO + "/" + loaiPhong.soLuongGiuong;
        }
        private void cbTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maTang = cbTang.SelectedIndex + 1;
            var loaiPhong = (int)cbLoaiPhong.SelectedValue;

            var lst = (provider.ChucNangPhong.LayPhongTheoTangVaLoaiPhong(maTang, loaiPhong));
            bindingPhong = new BindingList<Phong>(lst);
            KhoiTaoComboboxPhong();
        }

        private void cbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTang_SelectedIndexChanged(null, null);
        }
        private bool KiemTra()
        {
            if (cbLoaiPhong.SelectedIndex == -1)
            {

                return false;
            }
            if (cbTang.SelectedIndex == -1)
            {
                return false;
            }
            if (cbPhong.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var phongMoi = (int)cbPhong.SelectedValue;
            var result = provider.ChucNangPhong.ChuyenPhong(phong, phongMoi);
            if (result)
            {
                XuLyRadDesktopAlert.showAlert("Thông báo", "Chuyển phòng thành công", radDesktopAlert1);
                this.Close();
            }
            else
            {
                XuLyRadDesktopAlert.showAlert("Thông báo", "Chuyển phòng không thành công", radDesktopAlert1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
