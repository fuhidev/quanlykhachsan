namespace Gui
{
    partial class frmChuyenPhong
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
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.panelChuyenPhong = new System.Windows.Forms.Panel();
            this.btnXacNhan = new Telerik.WinControls.UI.RadButton();
            this.btnHuy = new Telerik.WinControls.UI.RadButton();
            this.lbSoLuongNguoiDangO = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhongDangO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLoaiPhongDangO = new System.Windows.Forms.Label();
            this.lbTenChuPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.panelChuyenPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChuyenPhong
            // 
            this.panelChuyenPhong.Controls.Add(this.btnXacNhan);
            this.panelChuyenPhong.Controls.Add(this.btnHuy);
            this.panelChuyenPhong.Controls.Add(this.lbSoLuongNguoiDangO);
            this.panelChuyenPhong.Controls.Add(this.cbPhong);
            this.panelChuyenPhong.Controls.Add(this.cbLoaiPhong);
            this.panelChuyenPhong.Controls.Add(this.cbTang);
            this.panelChuyenPhong.Controls.Add(this.label3);
            this.panelChuyenPhong.Controls.Add(this.lbPhongDangO);
            this.panelChuyenPhong.Controls.Add(this.label2);
            this.panelChuyenPhong.Controls.Add(this.lbLoaiPhongDangO);
            this.panelChuyenPhong.Controls.Add(this.lbTenChuPhong);
            this.panelChuyenPhong.Controls.Add(this.label1);
            this.panelChuyenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChuyenPhong.Location = new System.Drawing.Point(0, 0);
            this.panelChuyenPhong.Name = "panelChuyenPhong";
            this.panelChuyenPhong.Size = new System.Drawing.Size(646, 232);
            this.panelChuyenPhong.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(408, 148);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(219, 39);
            this.btnXacNhan.TabIndex = 22;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            this.btnXacNhan.MouseLeave += new System.EventHandler(this.btnHuy_MouseLeave);
            this.btnXacNhan.MouseHover += new System.EventHandler(this.btnHuy_MouseHover);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(155, 148);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(228, 39);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.MouseLeave += new System.EventHandler(this.btnHuy_MouseLeave);
            this.btnHuy.MouseHover += new System.EventHandler(this.btnHuy_MouseHover);
            // 
            // lbSoLuongNguoiDangO
            // 
            this.lbSoLuongNguoiDangO.AccessibleDescription = "";
            this.lbSoLuongNguoiDangO.AutoSize = true;
            this.lbSoLuongNguoiDangO.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbSoLuongNguoiDangO.ForeColor = System.Drawing.Color.Gray;
            this.lbSoLuongNguoiDangO.Location = new System.Drawing.Point(399, 59);
            this.lbSoLuongNguoiDangO.Name = "lbSoLuongNguoiDangO";
            this.lbSoLuongNguoiDangO.Size = new System.Drawing.Size(76, 21);
            this.lbSoLuongNguoiDangO.TabIndex = 20;
            this.lbSoLuongNguoiDangO.Text = "3/5 người";
            // 
            // cbPhong
            // 
            this.cbPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPhong.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.cbPhong.ForeColor = System.Drawing.Color.Gray;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(537, 98);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(90, 29);
            this.cbPhong.TabIndex = 18;
            this.cbPhong.Text = "Phòng";
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoaiPhong.AutoCompleteCustomSource.AddRange(new string[] {
            "Phòng Vip",
            "Phòng Bình Thường"});
            this.cbLoaiPhong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLoaiPhong.DisplayMember = "tenLoaiPhong";
            this.cbLoaiPhong.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.cbLoaiPhong.ForeColor = System.Drawing.Color.Gray;
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Location = new System.Drawing.Point(155, 98);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(228, 29);
            this.cbLoaiPhong.TabIndex = 17;
            this.cbLoaiPhong.Text = "Loại phòng";
            this.cbLoaiPhong.ValueMember = "maloaiphong";
            this.cbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiPhong_SelectedIndexChanged);
            // 
            // cbTang
            // 
            this.cbTang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTang.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.cbTang.ForeColor = System.Drawing.Color.Gray;
            this.cbTang.FormattingEnabled = true;
            this.cbTang.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3"});
            this.cbTang.Location = new System.Drawing.Point(415, 98);
            this.cbTang.Name = "cbTang";
            this.cbTang.Size = new System.Drawing.Size(90, 29);
            this.cbTang.TabIndex = 16;
            this.cbTang.Text = "Tầng";
            this.cbTang.SelectedIndexChanged += new System.EventHandler(this.cbTang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chuyển đến";
            // 
            // lbPhongDangO
            // 
            this.lbPhongDangO.AccessibleDescription = "";
            this.lbPhongDangO.AutoSize = true;
            this.lbPhongDangO.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbPhongDangO.ForeColor = System.Drawing.Color.Gray;
            this.lbPhongDangO.Location = new System.Drawing.Point(291, 59);
            this.lbPhongDangO.Name = "lbPhongDangO";
            this.lbPhongDangO.Size = new System.Drawing.Size(70, 21);
            this.lbPhongDangO.TabIndex = 2;
            this.lbPhongDangO.Text = "Phòng 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng đang ở";
            // 
            // lbLoaiPhongDangO
            // 
            this.lbLoaiPhongDangO.AutoSize = true;
            this.lbLoaiPhongDangO.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbLoaiPhongDangO.ForeColor = System.Drawing.Color.Gray;
            this.lbLoaiPhongDangO.Location = new System.Drawing.Point(151, 59);
            this.lbLoaiPhongDangO.Name = "lbLoaiPhongDangO";
            this.lbLoaiPhongDangO.Size = new System.Drawing.Size(37, 21);
            this.lbLoaiPhongDangO.TabIndex = 0;
            this.lbLoaiPhongDangO.Text = "VIP";
            // 
            // lbTenChuPhong
            // 
            this.lbTenChuPhong.AutoSize = true;
            this.lbTenChuPhong.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.lbTenChuPhong.ForeColor = System.Drawing.Color.Gray;
            this.lbTenChuPhong.Location = new System.Drawing.Point(146, 20);
            this.lbTenChuPhong.Name = "lbTenChuPhong";
            this.lbTenChuPhong.Size = new System.Drawing.Size(134, 21);
            this.lbTenChuPhong.TabIndex = 1;
            this.lbTenChuPhong.Text = "Huỳnh Ngọc Tiển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên chủ phòng";
            // 
            // frmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 232);
            this.Controls.Add(this.panelChuyenPhong);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChuyenPhong";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHUYỂN PHÒNG";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
            this.panelChuyenPhong.ResumeLayout(false);
            this.panelChuyenPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private System.Windows.Forms.Panel panelChuyenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhongDangO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLoaiPhongDangO;
        private System.Windows.Forms.Label lbTenChuPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbTang;
        private System.Windows.Forms.Label lbSoLuongNguoiDangO;
        private Telerik.WinControls.UI.RadButton btnHuy;
        private Telerik.WinControls.UI.RadButton btnXacNhan;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
    }
}
