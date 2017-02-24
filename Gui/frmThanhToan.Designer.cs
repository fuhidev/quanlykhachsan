namespace Gui
{
    partial class frmThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongTienPhong = new System.Windows.Forms.Label();
            this.lbTienConLai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radThanhToan = new Telerik.WinControls.UI.RadButton();
            this.btnThoat = new Telerik.WinControls.UI.RadButton();
            this.btnInHoaDon = new Telerik.WinControls.UI.RadButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbTongDichVu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbThanhToanMotPhan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNgaydi = new System.Windows.Forms.Label();
            this.lbNgayden = new System.Windows.Forms.Label();
            this.lbTenNguoiThanhToan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridView);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbTongTienPhong);
            this.panel1.Controls.Add(this.lbTienConLai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radThanhToan);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnInHoaDon);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbTongTien);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbTongDichVu);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lbThanhToanMotPhan);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTenNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbNgaydi);
            this.panel1.Controls.Add(this.lbNgayden);
            this.panel1.Controls.Add(this.lbTenNguoiThanhToan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 544);
            this.panel1.TabIndex = 0;
            // 
            // gridView
            // 
            this.gridView.Location = new System.Drawing.Point(26, 327);
            // 
            // 
            // 
            this.gridView.MasterTemplate.AllowAddNewRow = false;
            this.gridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn11.FieldName = "tenDichVu";
            gridViewTextBoxColumn11.HeaderText = "Tên Dịch Vụ";
            gridViewTextBoxColumn11.Name = "column1";
            gridViewTextBoxColumn11.Width = 200;
            gridViewTextBoxColumn12.FieldName = "soLuong";
            gridViewTextBoxColumn12.HeaderText = "Số lượng";
            gridViewTextBoxColumn12.Name = "column2";
            gridViewTextBoxColumn12.Width = 100;
            gridViewTextBoxColumn13.FieldName = "dichVu";
            gridViewTextBoxColumn13.HeaderText = "column3";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "column3";
            gridViewTextBoxColumn13.VisibleInColumnChooser = false;
            gridViewTextBoxColumn14.FieldName = "donGia";
            gridViewTextBoxColumn14.HeaderText = "Đơn giá";
            gridViewTextBoxColumn14.Name = "column4";
            gridViewTextBoxColumn14.Width = 200;
            gridViewTextBoxColumn15.FieldName = "thoiGian";
            gridViewTextBoxColumn15.HeaderText = "Thời gian";
            gridViewTextBoxColumn15.Name = "column5";
            gridViewTextBoxColumn15.Width = 150;
            this.gridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15});
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.ShowGroupPanel = false;
            this.gridView.Size = new System.Drawing.Size(672, 84);
            this.gridView.TabIndex = 52;
            this.gridView.Text = "radGridView1";
            this.gridView.ThemeName = "Office2013Light";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(386, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "VNĐ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(386, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 51;
            this.label7.Text = "VNĐ";
            // 
            // lbTongTienPhong
            // 
            this.lbTongTienPhong.AutoSize = true;
            this.lbTongTienPhong.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTongTienPhong.ForeColor = System.Drawing.Color.Gray;
            this.lbTongTienPhong.Location = new System.Drawing.Point(224, 248);
            this.lbTongTienPhong.Name = "lbTongTienPhong";
            this.lbTongTienPhong.Size = new System.Drawing.Size(81, 21);
            this.lbTongTienPhong.TabIndex = 50;
            this.lbTongTienPhong.Text = "1,000,000";
            // 
            // lbTienConLai
            // 
            this.lbTienConLai.AutoSize = true;
            this.lbTienConLai.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTienConLai.ForeColor = System.Drawing.Color.Gray;
            this.lbTienConLai.Location = new System.Drawing.Point(224, 214);
            this.lbTienConLai.Name = "lbTienConLai";
            this.lbTienConLai.Size = new System.Drawing.Size(81, 21);
            this.lbTienConLai.TabIndex = 50;
            this.lbTienConLai.Text = "1,000,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(22, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tổng tiền phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(22, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 49;
            this.label10.Text = "Còn lại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(386, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 48;
            this.label6.Text = "VNĐ";
            // 
            // radThanhToan
            // 
            this.radThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.radThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radThanhToan.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.radThanhToan.ForeColor = System.Drawing.Color.White;
            this.radThanhToan.Location = new System.Drawing.Point(581, 493);
            this.radThanhToan.Name = "radThanhToan";
            this.radThanhToan.Size = new System.Drawing.Size(133, 39);
            this.radThanhToan.TabIndex = 46;
            this.radThanhToan.Text = "THANH TOÁN";
            this.radThanhToan.Click += new System.EventHandler(this.radThanhToan_Click);
            this.radThanhToan.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.radThanhToan.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(396, 493);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 39);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnThoat.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.Enabled = false;
            this.btnInHoaDon.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Location = new System.Drawing.Point(26, 493);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(133, 39);
            this.btnInHoaDon.TabIndex = 44;
            this.btnInHoaDon.Text = "IN HÓA ĐƠN";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            this.btnInHoaDon.MouseLeave += new System.EventHandler(this.btnThoat_MouseLeave);
            this.btnInHoaDon.MouseHover += new System.EventHandler(this.btnThoat_MouseHover);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(671, 446);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 21);
            this.label19.TabIndex = 43;
            this.label19.Text = "VNĐ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(671, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 21);
            this.label18.TabIndex = 42;
            this.label18.Text = "VNĐ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTongTien.ForeColor = System.Drawing.Color.Gray;
            this.lbTongTien.Location = new System.Drawing.Point(574, 446);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(81, 21);
            this.lbTongTien.TabIndex = 41;
            this.lbTongTien.Text = "1,200,000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label16.ForeColor = System.Drawing.Color.Gray;
            this.label16.Location = new System.Drawing.Point(461, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 21);
            this.label16.TabIndex = 40;
            this.label16.Text = "Tổng cộng";
            // 
            // lbTongDichVu
            // 
            this.lbTongDichVu.AutoSize = true;
            this.lbTongDichVu.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTongDichVu.ForeColor = System.Drawing.Color.Gray;
            this.lbTongDichVu.Location = new System.Drawing.Point(574, 414);
            this.lbTongDichVu.Name = "lbTongDichVu";
            this.lbTongDichVu.Size = new System.Drawing.Size(19, 21);
            this.lbTongDichVu.TabIndex = 39;
            this.lbTongDichVu.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(461, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 21);
            this.label14.TabIndex = 38;
            this.label14.Text = "Tổng dịch vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(22, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Dịch Vụ";
            // 
            // lbThanhToanMotPhan
            // 
            this.lbThanhToanMotPhan.AutoSize = true;
            this.lbThanhToanMotPhan.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbThanhToanMotPhan.ForeColor = System.Drawing.Color.Gray;
            this.lbThanhToanMotPhan.Location = new System.Drawing.Point(224, 173);
            this.lbThanhToanMotPhan.Name = "lbThanhToanMotPhan";
            this.lbThanhToanMotPhan.Size = new System.Drawing.Size(68, 21);
            this.lbThanhToanMotPhan.TabIndex = 30;
            this.lbThanhToanMotPhan.Text = "200,000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(22, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Đã thanh toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày đến";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Gray;
            this.lbTenNhanVien.Location = new System.Drawing.Point(224, 9);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(129, 21);
            this.lbTenNhanVien.TabIndex = 3;
            this.lbTenNhanVien.Text = "Hồ Phương Hiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên thanh toán";
            // 
            // lbNgaydi
            // 
            this.lbNgaydi.AutoSize = true;
            this.lbNgaydi.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbNgaydi.ForeColor = System.Drawing.Color.Gray;
            this.lbNgaydi.Location = new System.Drawing.Point(224, 132);
            this.lbNgaydi.Name = "lbNgaydi";
            this.lbNgaydi.Size = new System.Drawing.Size(116, 21);
            this.lbNgaydi.TabIndex = 1;
            this.lbNgaydi.Text = "15/4/2016 7:00";
            // 
            // lbNgayden
            // 
            this.lbNgayden.AutoSize = true;
            this.lbNgayden.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbNgayden.ForeColor = System.Drawing.Color.Gray;
            this.lbNgayden.Location = new System.Drawing.Point(224, 91);
            this.lbNgayden.Name = "lbNgayden";
            this.lbNgayden.Size = new System.Drawing.Size(116, 21);
            this.lbNgayden.TabIndex = 1;
            this.lbNgayden.Text = "15/4/2016 7:00";
            // 
            // lbTenNguoiThanhToan
            // 
            this.lbTenNguoiThanhToan.AutoSize = true;
            this.lbTenNguoiThanhToan.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTenNguoiThanhToan.ForeColor = System.Drawing.Color.Gray;
            this.lbTenNguoiThanhToan.Location = new System.Drawing.Point(224, 50);
            this.lbTenNguoiThanhToan.Name = "lbTenNguoiThanhToan";
            this.lbTenNguoiThanhToan.Size = new System.Drawing.Size(134, 21);
            this.lbTenNguoiThanhToan.TabIndex = 1;
            this.lbTenNguoiThanhToan.Text = "Huỳnh Ngọc Tiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người thanh toán";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 544);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanhToan";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh Toán";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenNguoiThanhToan;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbTongDichVu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Telerik.WinControls.UI.RadButton radThanhToan;
        private Telerik.WinControls.UI.RadButton btnThoat;
        private Telerik.WinControls.UI.RadButton btnInHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTienConLai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbThanhToanMotPhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbNgaydi;
        private System.Windows.Forms.Label lbNgayden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTongTienPhong;
        private System.Windows.Forms.Label label4;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.UI.RadGridView gridView;
    }
}
