using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChucNang;
using Entity;
namespace Gui
{
    public partial class frmDangNhap : Form
    {
        ChucNangProvider provider;
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public frmDangNhap(ChucNangProvider provider)
        {
            InitializeComponent();
            this.provider = provider;
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            btnDangNhap.ButtonElement.ShowBorder = false;
            radButton2.ButtonElement.ShowBorder = false;
            
        }

        private void radButton2_MouseHover(object sender, EventArgs e)
        {
            radButton2.ForeColor = Color.Red;
        }

        private void radButton2_MouseLeave(object sender, EventArgs e)
        {
            radButton2.ForeColor = Color.White;
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void radButton1_MouseHover(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void radButton1_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.FromArgb(79, 197, 173);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieuNhap()) return;
            try
            {
                var result = provider.ChucNangDangNhap.KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    Properties.Settings.Default.NhanVien = provider.ChucNangDangNhap.LayNhanVienTuTaiKhoan(txtTaiKhoan.Text).id;
                }
                else
                    this.DialogResult = DialogResult.None;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.None;
            }
        }
        private NhanVien LayDuLieuNhap()
        {
            return new NhanVien
            {
                taikhoan = txtTaiKhoan.Text,
                matkhau = txtMatKhau.Text
            };
        }
        private bool KiemTraDuLieuNhap()
        {
            if (txtTaiKhoan.Text.Length == 0)
            {
                txtTaiKhoan.Focus();
                //HienThiThongBao("Tài khoản chưa điền");
                return false;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                //HienThiThongBao("Mật khẩu chưa điền");
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        void HienThiThongBao(String s)
        {
            lbThongBao.Text = s;
            lbThongBao.Visible = true;
        }
    }
}
