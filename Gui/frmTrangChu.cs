using Entity;
using System;
using ChucNang;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gui
{
    public partial class frmTrangChu 
    {
        #region Biến

        RadButton[] btnItem = null;

        RadButton btnClicked = null;

        ChucNangProvider chucNangProvider;

        RadButton[] btnTang = null;

        #endregion
        public frmTrangChu()
        {
            InitializeComponent();
        }

        #region KhoiTao
        private void KhoiTaoGroup()
        {
            List<LoaiPhong> lstLoaiPhong = chucNangProvider.ChucNangPhong.LayDanhSachLoaiPhong();
            foreach (var lp in lstLoaiPhong)
            {
                var gr = new ListViewGroup(lp.maloaiphong.ToString(), lp.tenLoaiPhong);
                lvPhong.Groups.Add(gr);
            }
        }
        bool KhoiTaoDangNhap()
        {
            var frm = new frmDangNhap(chucNangProvider);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK) return true;
            else return false;
        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            chucNangProvider = new ChucNangProvider();
            var kqDangNhap = KhoiTaoDangNhap();
            if (!kqDangNhap) return;
            btnTang = new RadButton[3] { btnTang1, btnTang2, btnTang3 };
            btnClicked = btnTatCa;
            btnTangVuaClick = null;

            KhoiTaoGroup();
            var nv = chucNangProvider.ChucNangDangNhap.LayNhanVienTuMa(Properties.Settings.Default.NhanVien);
            lbNhanVien.Text = nv.ten;

            btnItem = new RadButton[4];
            btnItem[0] = btnPhongDaDat; btnItem[1] = btnPhongDangThue; btnItem[2] = btnPhongTrong; btnItem[3] = btnTatCa;
            foreach (var r in btnItem)
            {
                XuLyButton.xoaBorder(r);
            }
            foreach (var r in btnTang)
                XuLyButton.xoaBorder(r);
            HienThiThongTin();
            btnTang_Click(null, null);
        }
        private void HienThiThongTinTrangThai()
        {
            lbTongPhongTrong.Text = chucNangProvider.ChucNangPhong.TimPhongTheoTinhTrang(ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT).Count().ToString();
            lbTongPhongDangThue.Text = chucNangProvider.ChucNangPhong.TimPhongTheoTinhTrang(ChucNangPhong.TinhTrang.TINHTRANG_DANGTHUE).Count().ToString();
            lbTongPhongDaDat.Text = chucNangProvider.ChucNangPhong.TimPhongTheoTinhTrang(ChucNangPhong.TinhTrang.TINHTRANG_DADAT).Count().ToString();
        }
        private void HienThiDuLieuLenListPhong()
        {
            lvPhong.Items.Clear();
            var lst = chucNangProvider.ChucNangPhong.LayDanhSachPhong();
            if (lst == null || lst.Count == 0) return;
            var tinhtrang = -1;
            var tang = 0;
            if (btnClicked == btnTatCa)
            {
                tinhtrang = -1;
            }
            else if (btnClicked == btnPhongDaDat)
            {
                tinhtrang = ChucNangPhong.TinhTrang.TINHTRANG_DADAT;

            }
            else if (btnClicked == btnPhongDangThue)
            {
                tinhtrang = ChucNangPhong.TinhTrang.TINHTRANG_DANGTHUE;
            }
            else if (btnClicked == btnPhongTrong)
            {
                tinhtrang = ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT;
            }

            if (btnTangVuaClick == btnTang1)
            {
                tang = 1;
            }
            else if (btnTangVuaClick == btnTang2)
            {
                tang = 2;
            }
            else if (btnTangVuaClick == btnTang3)
            {
                tang = 3;
            }
            else
            {
                tang = 0;
            }

            if (tinhtrang == -1 && tang != 0)
            {
                lst = lst.Where(a => a.tang.Value == tang).ToList();
            }
            else if (tinhtrang != -1 && tang == 0)
            {
                lst = lst.Where(a => a.tinhtrang == tinhtrang).ToList();
            }
            else if (tinhtrang != -1 && tang != 0)
            {
                lst = lst.Where(a => a.tinhtrang == tinhtrang && a.tang.Value == (int)tang).ToList();
            }
            foreach (var p in lst)
            {
                var lvi = new ListViewItem
                {
                    Name = p.tenphong,
                    Text = p.tenphong,
                    Tag = p,
                    ImageIndex = p.tinhtrang.Value,
                    Group = lvPhong.Groups[p.loaiphong.ToString()]
                };
                lvPhong.Items.Add(lvi);
            }
        }

        #endregion


        #region Event Button
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnTimKiem.BackColor = XuLyButton.MAIN_COLOR;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnTimKiem.BackColor = XuLyButton.SUB_COLOR;
        }
        private void ButtonHoverEvent(object sender, EventArgs e)
        {
            XuLyButton.XuLyHover((RadButton)sender);
        }

        private void ButtonLeaveEvent(object sender, EventArgs e)
        {
            if ((RadButton)sender != btnClicked)
                XuLyButton.XuLyLeave((RadButton)sender, Color.WhiteSmoke);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text);

            if (!DuLieuNhapVao.KiemTraDuLieuNhapSoKhongAm(soLuong))
            {
                return;
            }

            var tmplistphong = chucNangProvider.ChucNangPhong.LayDanhSachPhong().Where(q => q.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT).ToList();


            //hienThiDuLieuLenListPhong(tmpPhong);


        }
        private void button_Click(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            if (btn == btnClicked) return;
            btnClicked = btn;
            foreach (var r in btnItem)
            {
                if (r == btn)
                    ButtonHoverEvent(r, null);
                else
                    ButtonLeaveEvent(r, null);
            }
            HienThiDuLieuLenListPhong();
        }

        #endregion



        #region Kéo vị trí
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);


        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        #endregion


        /*#region Xử lý nút EXIT
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EXIT_MouseHover(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            btn.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void EXIT_MouseLeave(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            btn.BackColor = Color.FromArgb(69, 159, 134);
        }


        private void HIDE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MAXIMUM_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }
        #endregion*/

        #region ContextMenuListPhong
        private void đặtPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var select = lvPhong.SelectedItems;
            if (select == null || select.Count == 0)
                return;
            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            var frm = new frmDatPhong(phong, chucNangProvider);
            frm.ShowDialog();
            HienThiThongTin();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            var frm = new frmDichVu(phong, chucNangProvider);
            frm.ShowDialog();
        }

        private void thanhToánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            var frm = new frmThanhToan(phong, chucNangProvider);
            frm.ShowDialog();
            HienThiThongTin();
        }
        private void chuyểnPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            //var thuePhong = chucNangProvider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            var frm = new frmChuyenPhong(phong, chucNangProvider);
            frm.ShowDialog();
            HienThiDuLieuLenListPhong();
        }
        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            var frm = new frmNhanPhong(phong, chucNangProvider);
            frm.ShowDialog();
            HienThiThongTin();
        }
        #endregion

        RadButton btnTangVuaClick;
        void HienThiThongTin()
        {
            HienThiDuLieuLenListPhong();
            HienThiThongTinTrangThai();
        }
        private void btnTang_Click(object sender, EventArgs e)
        {
            var btn = (RadButton)sender;
            if (btn == btnTangVuaClick)
            {
                btnTangVuaClick = null;
                btn = null;
            }
            foreach (var b in btnTang)
            {
                if (btn == b)
                    b.ImageList = largeTang;
                else
                    b.ImageList = smallTang;
            }
            btnTangVuaClick = btn;
            HienThiDuLieuLenListPhong();
        }

        private void contextMenuListPhong_Opening(object sender, CancelEventArgs e)
        {
            var select = lvPhong.SelectedItems;
            if (select.Count == 0) return;
            if (select.Count == 1)
            {
                var p = (Phong)select[0].Tag;
                if (p.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT)
                {
                    tmiChuyenPhong.Enabled = false;
                    tmiDatPhong.Enabled = true;
                    tmiNhanPhong.Enabled = false;
                    tmiThanhToan.Enabled = false;
                    tmiDichVu.Enabled = false;
                }
                else if (p.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_DADAT)
                {
                    tmiChuyenPhong.Enabled = true;
                    tmiDatPhong.Enabled = false;
                    tmiNhanPhong.Enabled = true;
                    tmiThanhToan.Enabled = false;
                    tmiDichVu.Enabled = false;
                }
                else
                {
                    tmiChuyenPhong.Enabled = true;
                    tmiDatPhong.Enabled = false;
                    tmiNhanPhong.Enabled = false;
                    tmiThanhToan.Enabled = true;
                    tmiDichVu.Enabled = true;
                }
            }
            else
            {
                tmiChuyenPhong.Enabled = true;
                tmiDatPhong.Enabled = true;
                tmiNhanPhong.Enabled = true;
                tmiThanhToan.Enabled = true;
                tmiDichVu.Enabled = true;
                foreach (ListViewItem lvi in select)
                {
                    var p = (Phong)lvi.Tag;
                    if (p.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT)
                    {
                        tmiChuyenPhong.Enabled = false;
                        tmiNhanPhong.Enabled = false;
                        tmiThanhToan.Enabled = false;
                        tmiDichVu.Enabled = false;
                    }
                    else if (p.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_DADAT)
                    {
                        tmiDatPhong.Enabled = false;
                        tmiThanhToan.Enabled = false;
                        tmiDichVu.Enabled = false;
                    }
                    else
                    {
                        tmiDatPhong.Enabled = false;
                        tmiNhanPhong.Enabled = false;
                    }
                }
            }
        }

        private void txtSoLuong_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
        }

        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length == 0) txtSoLuong.Text = "Số Lượng";
        }
        class ThongTinChiTiet
        {
            public String tenPhong { get; set; }
            public String tenKhachHang { get; set; }
            public String chungMinhThu { get; set; }
            public DateTime ngayDat { get; set; }
            public DateTime ngayTra { get; set; }
        }
        private void lvPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhong.SelectedItems == null || lvPhong.SelectedItems.Count == 0) return;

            var phong = (Phong)lvPhong.SelectedItems[0].Tag;
            ThongTinChiTiet ttct = null;
            if (phong.tinhtrang == ChucNangPhong.TinhTrang.TINHTRANG_CHUADAT)
            {
                lvtThongTin.Visible = false;
                return;
            }
            lvtThongTin.Visible=true;
                var thuePhong = chucNangProvider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
                if (thuePhong == null) return;

                var kh = thuePhong.ChiTietThuePhongs.First().KhachHang1;
                if (kh == null) return;

                ttct = new ThongTinChiTiet
                {
                    ngayDat = thuePhong.ngaythue.Value,
                    ngayTra = thuePhong.ngaytra.Value,
                    tenKhachHang = kh.ten,
                    chungMinhThu = kh.id,
                    tenPhong = phong.tenphong
                };

            BindingSource bd = new BindingSource();
            bd.DataSource = ttct;
            lvtThongTin.DataSource = bd;
            lvtThongTin.Columns[0].HeaderText = "Phòng";
            lvtThongTin.Columns[1].HeaderText = "Tên";
            lvtThongTin.Columns[2].HeaderText = "Chứng minh thư";
            lvtThongTin.Columns[3].HeaderText = "Ngày đến";
            lvtThongTin.Columns[4].HeaderText = "Ngày đi";
        }

        private void lvPhong_DoubleClick(object sender, EventArgs e)
        {
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            chucNangProvider.Dispose();
        }
    }
}
