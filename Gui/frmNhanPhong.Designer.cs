namespace Gui
{
    partial class frmNhanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanPhong));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnThemKhach = new Telerik.WinControls.UI.RadButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtChungMinhThu = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDatPhong = new Telerik.WinControls.UI.RadButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbPhongDangChon = new Telerik.WinControls.UI.RadLabel();
            this.lbNguoiDungTen = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.radDesktopAlert1 = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKhach)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDatPhong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbPhongDangChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNguoiDungTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 476);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.cbEmail);
            this.panel7.Controls.Add(this.radLabel1);
            this.panel7.Controls.Add(this.btnThemKhach);
            this.panel7.Controls.Add(this.txtEmail);
            this.panel7.Controls.Add(this.txtSoDienThoai);
            this.panel7.Controls.Add(this.txtTen);
            this.panel7.Controls.Add(this.txtChungMinhThu);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 73);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 343);
            this.panel7.TabIndex = 12;
            // 
            // cbEmail
            // 
            this.cbEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbEmail.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.cbEmail.ForeColor = System.Drawing.Color.Gray;
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Items.AddRange(new object[] {
            "gmail.com",
            "yahoo.com",
            "yahoo.com.vn",
            "outlook.com",
            "hotmail.com"});
            this.cbEmail.Location = new System.Drawing.Point(170, 171);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(95, 29);
            this.cbEmail.TabIndex = 14;
            this.cbEmail.Text = "gmail.com";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel1.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.radLabel1.ForeColor = System.Drawing.Color.Gray;
            this.radLabel1.Location = new System.Drawing.Point(145, 171);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(25, 25);
            this.radLabel1.TabIndex = 18;
            this.radLabel1.Text = "@";
            this.radLabel1.ThemeName = "Office2013Light";
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemKhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnThemKhach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKhach.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnThemKhach.ForeColor = System.Drawing.Color.White;
            this.btnThemKhach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhach.Image")));
            this.btnThemKhach.Location = new System.Drawing.Point(23, 274);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(236, 39);
            this.btnThemKhach.TabIndex = 17;
            this.btnThemKhach.Text = "LẤY THÔNG TIN";
            this.btnThemKhach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(23, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 29);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.textBox1_Click);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.txtSoDienThoai.Location = new System.Drawing.Point(23, 119);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(236, 29);
            this.txtSoDienThoai.TabIndex = 12;
            this.txtSoDienThoai.Text = "Số điện thoại";
            this.txtSoDienThoai.Click += new System.EventHandler(this.textBox1_Click);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChungMinhThu_KeyPress);
            this.txtSoDienThoai.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTen.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Gray;
            this.txtTen.Location = new System.Drawing.Point(23, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(236, 29);
            this.txtTen.TabIndex = 11;
            this.txtTen.Text = "Tên";
            this.txtTen.Click += new System.EventHandler(this.textBox1_Click);
            this.txtTen.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtChungMinhThu
            // 
            this.txtChungMinhThu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtChungMinhThu.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChungMinhThu.ForeColor = System.Drawing.Color.Gray;
            this.txtChungMinhThu.Location = new System.Drawing.Point(23, 17);
            this.txtChungMinhThu.MaxLength = 9;
            this.txtChungMinhThu.Name = "txtChungMinhThu";
            this.txtChungMinhThu.Size = new System.Drawing.Size(236, 29);
            this.txtChungMinhThu.TabIndex = 10;
            this.txtChungMinhThu.Click += new System.EventHandler(this.textBox1_Click);
            this.txtChungMinhThu.TextChanged += new System.EventHandler(this.txtChungMinhThu_TextChanged);
            this.txtChungMinhThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChungMinhThu_KeyPress);
            this.txtChungMinhThu.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.radLabel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 73);
            this.panel3.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(283, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(776, 97);
            this.panel9.TabIndex = 1;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.ForeColor = System.Drawing.Color.White;
            this.radLabel3.Location = new System.Drawing.Point(19, 23);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(249, 27);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(134)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 60);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(134)))));
            this.panel5.Controls.Add(this.btnDatPhong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 416);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(776, 60);
            this.panel5.TabIndex = 6;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.Image")));
            this.btnDatPhong.Location = new System.Drawing.Point(528, 9);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(219, 39);
            this.btnDatPhong.TabIndex = 14;
            this.btnDatPhong.Text = "NHẬN PHÒNG";
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            this.btnDatPhong.MouseLeave += new System.EventHandler(this.ButtonLeave_Event);
            this.btnDatPhong.MouseHover += new System.EventHandler(this.ButtonHover_Event);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.gridView);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 476);
            this.panel2.TabIndex = 1;
            // 
            // gridView
            // 
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 73);
            // 
            // 
            // 
            this.gridView.MasterTemplate.AllowAddNewRow = false;
            this.gridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.HeaderText = "Tên";
            gridViewTextBoxColumn1.Name = "column4";
            gridViewTextBoxColumn1.Width = 210;
            gridViewTextBoxColumn2.HeaderText = "CMND";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.HeaderText = "Email";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.HeaderText = "Vai trò";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.HeaderText = "Phòng đang chọn";
            gridViewTextBoxColumn6.Name = "column6";
            gridViewTextBoxColumn6.Width = 150;
            this.gridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.Size = new System.Drawing.Size(776, 343);
            this.gridView.TabIndex = 8;
            this.gridView.Text = "radGridView1";
            this.gridView.ThemeName = "TelerikMetroTouch";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.panel6.Controls.Add(this.lbPhongDangChon);
            this.panel6.Controls.Add(this.lbNguoiDungTen);
            this.panel6.Controls.Add(this.radLabel4);
            this.panel6.Controls.Add(this.radLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(776, 73);
            this.panel6.TabIndex = 7;
            // 
            // lbPhongDangChon
            // 
            this.lbPhongDangChon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhongDangChon.ForeColor = System.Drawing.Color.White;
            this.lbPhongDangChon.Location = new System.Drawing.Point(203, 23);
            this.lbPhongDangChon.Name = "lbPhongDangChon";
            this.lbPhongDangChon.Size = new System.Drawing.Size(85, 27);
            this.lbPhongDangChon.TabIndex = 1;
            this.lbPhongDangChon.Text = "Phòng 1";
            // 
            // lbNguoiDungTen
            // 
            this.lbNguoiDungTen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiDungTen.ForeColor = System.Drawing.Color.White;
            this.lbNguoiDungTen.Location = new System.Drawing.Point(544, 23);
            this.lbNguoiDungTen.Name = "lbNguoiDungTen";
            this.lbNguoiDungTen.Size = new System.Drawing.Size(159, 28);
            this.lbNguoiDungTen.TabIndex = 1;
            this.lbNguoiDungTen.Text = "Hồ Phương Hiếu";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.ForeColor = System.Drawing.Color.White;
            this.radLabel4.Location = new System.Drawing.Point(6, 23);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(178, 28);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Phòng đang chọn";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.ForeColor = System.Drawing.Color.White;
            this.radLabel2.Location = new System.Drawing.Point(347, 23);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(182, 28);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "NGƯỜI ĐỨNG TÊN";
            // 
            // radDesktopAlert1
            // 
            this.radDesktopAlert1.ThemeName = "Office2013Light";
            // 
            // frmNhanPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1067, 506);
            this.Name = "frmNhanPhong";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận phòng";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKhach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDatPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbPhongDangChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbNguoiDungTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.BindingSource chiTietThuePhongBindingSource;
        private System.Windows.Forms.Panel panel5;
        private Telerik.WinControls.UI.RadButton btnDatPhong;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadGridView gridView;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.UI.RadDesktopAlert radDesktopAlert1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbEmail;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnThemKhach;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtChungMinhThu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private System.Windows.Forms.Panel panel6;
        private Telerik.WinControls.UI.RadLabel lbNguoiDungTen;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbPhongDangChon;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}
