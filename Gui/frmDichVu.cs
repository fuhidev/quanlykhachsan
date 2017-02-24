using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ChucNang;
using Entity;
using System.Linq;

namespace Gui
{
    public partial class frmDichVu : Telerik.WinControls.UI.RadForm
    {
        List<DichVu> lstDichVu = null;
        Phong phong;
        ThuePhong thuePhong;
        ChucNangProvider provider;
        List<DichVuDaChon> lstDichVuDaChon = null;
    
        public frmDichVu()
        {
            InitializeComponent();
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            lstDichVuDaChon = new List<DichVuDaChon>();
            BindingSource binding = new BindingSource();
            binding.DataSource = lstDichVuDaChon;
            gridView.DataSource = binding;
            var listLoaiDichVu = provider.ChucNangDichVu.LayLoaiDichVu();
            foreach (var ldv in listLoaiDichVu)
            {
                var lvi = new ListViewItem
                {
                    Text = ldv.tendichvu,
                    ImageIndex = ldv.Id - 1,
                    Tag = ldv
                };
                lvLoaiDichVu.Items.Add(lvi);
            }
            //HienThiDichVuGridView();
        }
        public frmDichVu(Phong phong, ChucNangProvider provider)
        {
            InitializeComponent();
            this.phong = phong;
            this.provider = provider;
        }
        public frmDichVu(ThuePhong thuePhong, ChucNangProvider provider)
        {
            InitializeComponent();
            this.thuePhong = thuePhong;
            this.provider = provider;
        }
        private void listViewLoaiDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvDichVu.Clear();

            var maLDV = ((LoaiDichVu)(lvLoaiDichVu.SelectedItems[0].Tag)).Id;
            var tmpDichVu = provider.ChucNangDichVu.LayDichVuTheoLoaiDichVu(maLDV);

            foreach (var dv in tmpDichVu)
            {
                var lvi = new ListViewItem
                {
                    Tag = dv,
                    Text = dv.tendichvu,
                    ImageIndex = dv.madichvu-1
                };  
                lvDichVu.Items.Add(lvi);
            }

        }

        private void listViewDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        private void HienThiGridView()
        {

        }
        

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
                List<ChiTietDichVu> lstChiTietDichVu = new List<ChiTietDichVu>();
            foreach(var dvdc in lstDichVuDaChon){
                var ctd = new ChiTietDichVu{
                    soluong = dvdc.soLuong,
                    dichvu=dvdc.dichVu.madichvu,
                    thoigian=DateTime.Now,
                };
                lstChiTietDichVu.Add(ctd);
            }
            thuePhong = provider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            var result = provider.ChucNangDichVu.ThemDichVuVaoPhong(thuePhong, lstChiTietDichVu);
            if (result)
                this.Close();
        }
        class HienThiDichVu
        {
            public String tenDichVu { get; set; }
            public int SoLuong { get; set; }
            public decimal donGia { get; set; }
            public DateTime thoiGian { get; set; }
        }
        List<HienThiDichVu> htdv;
        void HienThiDichVuGridView()
        {
            var tp = provider.ChucNangPhong.LayThuePhongTuPhong(phong.id);
            var lstDv = provider.ChucNangDichVu.LayDichVuTheoThuePhong(tp.mathuephong);
            htdv = new List<HienThiDichVu>();
            foreach (var dv in lstDv)
            {
                htdv.Add(new HienThiDichVu
                {
                    tenDichVu = dv.DichVu1.tendichvu,
                    donGia = dv.DichVu1.dongia.Value,
                    SoLuong = dv.soluong.Value,
                    thoiGian = dv.thoigian.Value
                });
            }
            BindingSource binding = new BindingSource();
            binding.DataSource = htdv;
            gridView.DataSource = binding;
        }
        private void lvDichVu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dv = (DichVu)lvDichVu.SelectedItems[0].Tag;
            if (dv == null) return;
            var dvdc = lstDichVuDaChon.FirstOrDefault(a => a.dichVu == dv);

            if (dvdc == null)
            {
                lstDichVuDaChon.Add(new DichVuDaChon
                {
                    dichVu = dv,
                    soLuong = 1,
                    tenDichVu=dv.tendichvu,
                    thoiGian=DateTime.Now,
                    donGia=dv.dongia.Value
                });
            }
            else
            {
                dvdc.soLuong += 1;
            }

            BindingSource binding = new BindingSource();
            binding.DataSource = lstDichVuDaChon;
            gridView.DataSource = binding;
        }

    }
    class DichVuDaChon
    {
        public DichVu dichVu { get; set; }
        public String tenDichVu { get; set; }
        public int soLuong { get; set; }
        public decimal donGia { get; set; }
        public DateTime thoiGian { get; set; }
    }
}
