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
    public partial class frmNhanPhong : Telerik.WinControls.UI.RadForm
    {
        private const String CHUNGMINHTHU = "Chứng minh thư";
        private const String TEN = "Tên";
        private const String SDT = "Số điện thoại";
        private const String EMAIL = "Email";
        private const String VAITRO = "Vai trò";
        private const String PHONGDANGCHON = "Phòng đang chọn";
        private const String TYPEMAIL = "gmail.com";
        Phong phong;

        List<KhachHang> lstKhachHang = new List<KhachHang>();

        List<ChiTietThuePhong> lstChiTietThuePhong = new List<ChiTietThuePhong>();

        ChucNangProvider provider;

        List<Phong> phongDangChon;
        public frmNhanPhong()
        {
            InitializeComponent();
        }
        public frmNhanPhong(Phong phong)
        {
            InitializeComponent();
            this.phong = phong;
        }
        public frmNhanPhong(Phong phong, ChucNangProvider cn)
        {
            InitializeComponent();
            this.phong = phong;
            this.provider = cn;
        }
        public frmNhanPhong(List<Phong> phong, ChucNangProvider cn)
        {
            InitializeComponent();
            this.phongDangChon = phong;
            this.provider = cn;
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.ChiTietThuePhong' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'quanLyKhachSanDataSet.KhachHang' table. You can move, or remove it, as needed.
            //this.khachHangTableAdapter.Fill(this.quanLyKhachSanDataSet.KhachHang);
            KhoiTaoPhongDangChon();
            KhoiTaoNguoiDungTen();
            XuLyButton.xoaBorder(btnDatPhong);
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
                //return;
            }
            else
            {
                kh = layKhachHang();
            }
            if (lstKhachHang.FirstOrDefault(q => q.id == kh.id) != null)
            {
                XuLyRadDesktopAlert.showAlert("Thông báo", "Đã có thông tin khách hàng này", radDesktopAlert1);
                //radDesktopAlert1.CaptionText = ;
                //radDesktopAlert1.ContentText = ;
                //radDesktopAlert1.Show();
                //radDesktopAlert1.Hide();
                return;
            }
            lstKhachHang.Add(kh);
            var row = new GridViewDataRowInfo(this.gridView.MasterView);
            row.Cells[0].Value = kh.ten;
            row.Cells[1].Value = kh.id;
            row.Cells[2].Value = kh.sodienthoai;
            row.Cells[3].Value = kh.email;
            gridView.Rows.Add(row);

            var cttp = new ChiTietThuePhong
            {
                khachhang = (String)kh.id,
                vaitro = (int)ChucNangPhong.VaiTro.NGUOIKHAC
            };
            lstChiTietThuePhong.Add(cttp);
            clearTextFormThongTinKhachHang();
            //thuePhong.
            //qlks.ThuePhongs.Add
        }
        private KhachHang layKhachHang()
        {
            var khachHang = new KhachHang
            {
                id = txtChungMinhThu.Text,
                ten = txtTen.Text,
                sodienthoai = txtSoDienThoai.Text,
                email = txtEmail.Text + "@"+(String)cbEmail.Text
            };

            return khachHang;
        }
        private bool kiemTraNhapDuThongTin()
        {
            if (txtChungMinhThu.Text.Length == 0)
            {
                return false;
            }
            if (txtTen.Text.Length == 0)
            {
                return false;
            } if (txtSoDienThoai.Text.Length == 0)
            {
                return false;
            } if (txtEmail.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void clearTextFormThongTinKhachHang()
        {
            txtChungMinhThu.Clear();
            txtTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
        }

        private void btnDatPhong_Click(object sender, EventArgs ea)
        {
            //lstChiTietThuePhong.ForEach(q => q.ThuePhong = thuePhong);
            /* using (var provider = new Entities())
             {
                 //provider.ChiTietThuePhongs.AddRange(lstChiTietThuePhong);
                 //thuePhong.ChiTietThuePhongs = lstChiTietThuePhong;
                 //provider.KhachHangs.AddRange(lstKhachHang);
                 //provider.ThuePhongs.Add(thuePhong);
                 provider.KhachHangs.AddRange(lstKhachHang);
                 //provider.ThuePhongs.Add(thuePhong);
                 lstChiTietThuePhong.ForEach(a => a.mathuephong = (int)thuePhong.mathuephong);
                 provider.ThuePhongs.Add(thuePhong);
                 provider.ChiTietThuePhongs.AddRange(lstChiTietThuePhong);
                 //provider.ChiTietThuePhongs.AddRange(lstChiTietThuePhong);
                 provider.SaveChanges();
             }
             */
            try
            {
                var result = provider.ChucNangPhong.NhanPhong(phong, lstKhachHang, lstChiTietThuePhong);
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
                MessageBox.Show(ex.Message);
            }

        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNgayDi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeGioDen_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayDen_ValueChanged(object sender, EventArgs e)
        {

        }
        KhachHang nguoiDungTen;
        void KhoiTaoNguoiDungTen()
        {
            var khachHang = provider.ChucNangPhong.LayNguoiDungTenCuaPhong(phong.id);
            lbNguoiDungTen.Text = khachHang.ten;
        }
        private void KhoiTaoPhongDangChon()
        {
            lbPhongDangChon.Text = phong.tenphong;
            
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
                        txtEmail.Text = email[0];
                        txtSoDienThoai.Text = kh.sodienthoai; txtTen.Text = kh.ten;
                        cbEmail.Text = email[1];
                    }
                }
            }
        }

        private void txtChungMinhThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))e.Handled=true;
            if (char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@') e.Handled = true;
        }
    }
}
