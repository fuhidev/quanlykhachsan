using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Entity;
using System.Linq;
using ChucNang;
using System.Data.SqlClient;
using System.Reflection;

namespace Gui
{
    public partial class frmDatPhong : Telerik.WinControls.UI.RadForm
    {
        private const String CHUNGMINHTHU = "Chứng minh thư";
        private const String TEN = "Tên";
        private const String SDT = "Số điện thoại";
        private const String EMAIL = "Email";
        private const String VAITRO = "Vai trò";
        private const String PHONGDANGCHON = "Phòng đang chọn";
        private const String TYPEMAIL = "gmail.com";
        Phong phong;

        KhachHang khachHang;


        ChucNangProvider chucNangProvider;

        List<Phong> phongDangChon;
        public frmDatPhong()
        {
            InitializeComponent();
        }
        public frmDatPhong(Phong phong)
        {
            InitializeComponent();
            this.phong = phong;
        }
        public frmDatPhong(Phong phong, ChucNangProvider cn)
        {
            InitializeComponent();
            this.phong = phong;
            this.chucNangProvider = cn;
        }
        public frmDatPhong(List<Phong> phong, ChucNangProvider cn)
        {
            InitializeComponent();
            this.phongDangChon = phong;
            this.chucNangProvider = cn;
        }
        private string getText(TextBox tb)
        {
            string s = CHUNGMINHTHU;
            if (tb == txtChungMinhThu)
                s = CHUNGMINHTHU;
            if (tb == txtTen)
                s = TEN;
            if (tb == txtSoDienThoai)
                s = SDT;
            if (tb == txtEmail)
                s = EMAIL;
            return s;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            XuLyTextBox.XuLyClick(tb, getText(tb));
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            XuLyTextBox.XuLyLeave(tb, getText(tb));
        }
        void HienThiTongTienThuePhong()
        {

            var tienPhong = chucNangProvider.ChucNangPhong.LayTienPhong(phong.loaiphong, dateDen.Value, dateDi.Value);
        }
        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.ChiTietThuePhong' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.quanLyKhachSanDataSet.KhachHang);
            XuLyButton.xoaBorder(btnDatPhong);
            //XuLyButton.xoaBorder(btnCoThongTin);
            KhoiTaoThoiGian();
            var nv = chucNangProvider.ChucNangDangNhap.LayNhanVienTuMa(Properties.Settings.Default.NhanVien);
            lbTenNV.Text = nv.ten;
            cbSoNgay.SelectedIndex = 0;
        }
        void KhoiTaoThoiGian()
        {
            dateDen.Value = DateTime.Now;
            dateDi.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
        }
        private void ButtonHover_Event(object sender, EventArgs e)
        {
            XuLyButton.XuLyHover((RadButton)sender);
        }

        private void ButtonLeave_Event(object sender, EventArgs e)
        {
            XuLyButton.XuLyLeave((RadButton)sender);
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            KhachHang kh;
            if (!kiemTraNhapDuThongTin())
            {
                kh = new KhachHang
               {
                   id = "205857263",
                   ten = "Hồ Phương Hiếu",
                   sodienthoai = "0968674213",
                   email = "hatphehat.vn@gmail.com"
               };
                return;
            }
            else
            {
                kh = layKhachHang();
            }
            khachHang = kh;
            groupBox1.Enabled = false;
            lbTenNguoiDatPhong.Text = kh.ten;
            txtTienDatCoc.Enabled = true;
            txtTienDatCoc.Focus();
            txtTienDatCoc.Text = "";
        }
        private KhachHang layKhachHang()
        {
            var khachHang = new KhachHang
            {
                id = txtChungMinhThu.Text,
                ten = txtTen.Text,
                sodienthoai = txtSoDienThoai.Text,
                email = txtEmail.Text + (String)cbEmail.SelectedValue
            };

            return khachHang;
        }
        private bool kiemTraNhapDuThongTin()
        {
            if (txtChungMinhThu.Text.Length == 0 || txtChungMinhThu.Text == CHUNGMINHTHU)
            {
                return false;
            }
            if (txtTen.Text.Length == 0 || txtTen.Text == TEN)
            {
                return false;
            } if (txtSoDienThoai.Text.Length == 0 || txtSoDienThoai.Text == SDT)
            {
                return false;
            } if (txtEmail.Text.Length == 0 || txtEmail.Text == EMAIL)
            {
                return false;
            }
            //if (cbVaitro.SelectedIndex == -1)
            //{
            //    return false;
            //}
            return true;
        }
        private void clearTextFormThongTinKhachHang()
        {
            txtChungMinhThu.Clear();
            txtTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            //cbVaitro.ResetText();
        }

        private void btnDatPhong_Click(object sender, EventArgs ea)
        {
            var dden = dateDen.Value;
            var ddi = dateDi.Value;

            var thuePhong = new ThuePhong
            {
                maphong = phong.id,
                ngaythue = dden,
                ngaytra = ddi
            };
            var tienDatCoc = Decimal.Parse(txtTienDatCoc.Text);

            try
            {
                var result = chucNangProvider.ChucNangPhong.DatPhong(thuePhong, khachHang, tienDatCoc, Properties.Settings.Default.NhanVien);
                if (result)
                {
                    this.Close();
                    XuLyRadDesktopAlert.showAlert("Thông báo", "Thêm thành công dồi đó", radDesktopAlert1);
                }
                else
                {
                    XuLyRadDesktopAlert.showAlert("Thông báo", "Bị lỗi dồi nè, coi lại cái nè", radDesktopAlert1);
                }
            }
            catch (Exception ex)
            {
                XuLyRadDesktopAlert.showAlert("Thông báo", "Bị lỗi dồi nè, coi lại cái nè", radDesktopAlert1);
            }

        }


        private void dateNgayDen_ValueChanged(object sender, EventArgs e)
        {
            CapNhatNgay();
        }


        private void txtChungMinhThu_TextChanged(object sender, EventArgs e)
        {
            if (txtChungMinhThu.Text.Length == 9)
            {
                using (Entities et = new Entities())
                {
                    var kh = et.KhachHangs.FirstOrDefault(a => a.id == txtChungMinhThu.Text);
                    if (kh != null)
                    {
                        var email = (String[])kh.email.Split('@');
                        txtEmail.Text = email[0]; txtSoDienThoai.Text = kh.sodienthoai; txtTen.Text = kh.ten;
                        cbEmail.Text = email[1];
                    }
                }
            }
        }


        void CapNhatGioTable()
        {

            lbThoiGianNhanPhong.Text = dateDen.Value.ToLongDateString();
            lbThoiGianTraPhong.Text = dateDi.Value.ToLongDateString();
        }
        private void thoiGian_ValueChanged(object sender, EventArgs e)
        {
            CapNhatGioTable();
        }
        private void txtChungMinhThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
            if (char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@') e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSoNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatNgay();
        }
        void CapNhatNgay()
        {
            var soNgay = int.Parse(cbSoNgay.Text);
            var dt = dateDen.Value;
            dateDi.Value = dt.AddDays(soNgay);
            lbTongTienThuePhong.Text = (soNgay * 500000) + "";
        }

        private void cbSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
            if (char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void txtTienDatCoc_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTienDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
            if (char.IsControl(e.KeyChar)) e.Handled = false;
            decimal tongTien = decimal.Parse(lbTongTienThuePhong.Text);
            if (char.IsNumber(e.KeyChar))
            {
                var tien = txtTienDatCoc.Text + e.KeyChar;
                if (decimal.Parse(tien) > tongTien) e.Handled = true;
            }
        }
    }
}
