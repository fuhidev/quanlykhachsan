namespace Gui
{
    partial class frmDichVu
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridView = new Telerik.WinControls.UI.RadGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvLoaiDichVu = new System.Windows.Forms.ListView();
            this.loaiDichVu = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvDichVu = new System.Windows.Forms.ListView();
            this.dichVu = new System.Windows.Forms.ImageList(this.components);
            this.btnXacNhan = new Telerik.WinControls.UI.RadButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridView);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 386);
            this.panel1.TabIndex = 0;
            // 
            // gridView
            // 
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.gridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridView.MasterTemplate.AllowAddNewRow = false;
            this.gridView.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "tenDichVu";
            gridViewTextBoxColumn1.HeaderText = "Tên Dịch Vụ";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 101;
            gridViewTextBoxColumn2.FieldName = "soLuong";
            gridViewTextBoxColumn2.HeaderText = "Số lượng";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 76;
            gridViewTextBoxColumn3.FieldName = "dichVu";
            gridViewTextBoxColumn3.HeaderText = "column3";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.VisibleInColumnChooser = false;
            gridViewTextBoxColumn4.FieldName = "donGia";
            gridViewTextBoxColumn4.HeaderText = "Đơn giá";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 67;
            gridViewTextBoxColumn5.FieldName = "thoiGian";
            gridViewTextBoxColumn5.HeaderText = "Thời gian";
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.Width = 78;
            this.gridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.gridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridView.Name = "gridView";
            this.gridView.ReadOnly = true;
            this.gridView.ShowGroupPanel = false;
            this.gridView.Size = new System.Drawing.Size(345, 321);
            this.gridView.TabIndex = 54;
            this.gridView.Text = "radGridView1";
            this.gridView.ThemeName = "Office2013Light";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(159)))), ((int)(((byte)(134)))));
            this.panel4.Controls.Add(this.btnXacNhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 63);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lvLoaiDichVu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 100);
            this.panel2.TabIndex = 1;
            // 
            // lvLoaiDichVu
            // 
            this.lvLoaiDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.lvLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLoaiDichVu.LargeImageList = this.loaiDichVu;
            this.lvLoaiDichVu.Location = new System.Drawing.Point(0, 0);
            this.lvLoaiDichVu.Name = "lvLoaiDichVu";
            this.lvLoaiDichVu.Size = new System.Drawing.Size(515, 98);
            this.lvLoaiDichVu.TabIndex = 0;
            this.lvLoaiDichVu.UseCompatibleStateImageBehavior = false;
            this.lvLoaiDichVu.SelectedIndexChanged += new System.EventHandler(this.listViewLoaiDichVu_SelectedIndexChanged);
            // 
            // loaiDichVu
            // 
            this.loaiDichVu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("loaiDichVu.ImageStream")));
            this.loaiDichVu.TransparentColor = System.Drawing.Color.Transparent;
            this.loaiDichVu.Images.SetKeyName(0, "hambuger.png");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvDichVu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(347, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 286);
            this.panel3.TabIndex = 2;
            // 
            // lvDichVu
            // 
            this.lvDichVu.BackColor = System.Drawing.Color.White;
            this.lvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDichVu.LargeImageList = this.dichVu;
            this.lvDichVu.Location = new System.Drawing.Point(0, 0);
            this.lvDichVu.Name = "lvDichVu";
            this.lvDichVu.Size = new System.Drawing.Size(517, 286);
            this.lvDichVu.TabIndex = 0;
            this.lvDichVu.UseCompatibleStateImageBehavior = false;
            this.lvDichVu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDichVu_MouseDoubleClick);
            // 
            // dichVu
            // 
            this.dichVu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dichVu.ImageStream")));
            this.dichVu.TransparentColor = System.Drawing.Color.Transparent;
            this.dichVu.Images.SetKeyName(0, "carot.png");
            this.dichVu.Images.SetKeyName(1, "flan.png");
            this.dichVu.Images.SetKeyName(2, "fruit.png");
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(104)))), ((int)(((byte)(89)))));
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.Font = new System.Drawing.Font("Arial Unicode MS", 12F);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.Location = new System.Drawing.Point(50, 13);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(236, 39);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDichVu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Dịch vụ";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnXacNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvLoaiDichVu;
        private System.Windows.Forms.ListView lvDichVu;
        private System.Windows.Forms.ImageList loaiDichVu;
        private System.Windows.Forms.ImageList dichVu;
        private Telerik.WinControls.UI.RadGridView gridView;
        private Telerik.WinControls.UI.RadButton btnXacNhan;
    }
}
