namespace QLNT_Winform
{
    partial class UC_TuNhan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTuNhan;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabThongTin;
        private System.Windows.Forms.TabPage tabThanNhan;
        private System.Windows.Forms.TabPage tabBanAn;
        private System.Windows.Forms.TabPage tabViPham;
        
        // ThongTin controls
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTuNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMucDo;
        
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;

        // Grids for tabs
        private System.Windows.Forms.DataGridView dgvThanNhan;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.DataGridView dgvViPham;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTuNhan = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabThongTin = new System.Windows.Forms.TabPage();
            this.tabThanNhan = new System.Windows.Forms.TabPage();
            this.tabBanAn = new System.Windows.Forms.TabPage();
            this.tabViPham = new System.Windows.Forms.TabPage();
            
            // Textboxes and labels
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTuNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMucDo = new System.Windows.Forms.ComboBox();
            
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            
            this.dgvThanNhan = new System.Windows.Forms.DataGridView();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.dgvViPham = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuNhan)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.tabThanNhan.SuspendLayout();
            this.tabBanAn.SuspendLayout();
            this.tabViPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).BeginInit();
            this.SuspendLayout();
            
            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            
            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.dgvTuNhan);
            
            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            
            // dgvTuNhan
            this.dgvTuNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTuNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvTuNhan.Name = "dgvTuNhan";
            this.dgvTuNhan.RowTemplate.Height = 24;
            this.dgvTuNhan.Size = new System.Drawing.Size(400, 600);
            this.dgvTuNhan.TabIndex = 0;
            this.dgvTuNhan.AllowUserToAddRows = false;
            this.dgvTuNhan.ReadOnly = true;
            this.dgvTuNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuNhan_CellClick);
            
            // tabControl1
            this.tabControl1.Controls.Add(this.tabThongTin);
            this.tabControl1.Controls.Add(this.tabThanNhan);
            this.tabControl1.Controls.Add(this.tabBanAn);
            this.tabControl1.Controls.Add(this.tabViPham);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 600);
            this.tabControl1.TabIndex = 0;
            
            // tabThongTin
            this.tabThongTin.Controls.Add(this.label1);
            this.tabThongTin.Controls.Add(this.txtMaTuNhan);
            this.tabThongTin.Controls.Add(this.label2);
            this.tabThongTin.Controls.Add(this.txtHoTen);
            this.tabThongTin.Controls.Add(this.label3);
            this.tabThongTin.Controls.Add(this.txtCCCD);
            this.tabThongTin.Controls.Add(this.label4);
            this.tabThongTin.Controls.Add(this.dtpNgaySinh);
            this.tabThongTin.Controls.Add(this.label5);
            this.tabThongTin.Controls.Add(this.cbGioiTinh);
            this.tabThongTin.Controls.Add(this.label6);
            this.tabThongTin.Controls.Add(this.txtPhong);
            this.tabThongTin.Controls.Add(this.label7);
            this.tabThongTin.Controls.Add(this.txtTrangThai);
            this.tabThongTin.Controls.Add(this.label8);
            this.tabThongTin.Controls.Add(this.cbMucDo);
            this.tabThongTin.Controls.Add(this.btnThem);
            this.tabThongTin.Controls.Add(this.btnSua);
            this.tabThongTin.Controls.Add(this.btnXoa);
            
            this.tabThongTin.Location = new System.Drawing.Point(4, 25);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTin.Size = new System.Drawing.Size(588, 571);
            this.tabThongTin.TabIndex = 0;
            this.tabThongTin.Text = "Thông tin chi tiết";
            this.tabThongTin.UseVisualStyleBackColor = true;
            
            // Labels and Textboxes Setup
            int startY = 30;
            int gapY = 40;
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, startY);
            this.label1.Name = "label1";
            this.label1.Text = "Mã Tù Nhân:";
            this.txtMaTuNhan.Location = new System.Drawing.Point(130, startY - 3);
            this.txtMaTuNhan.Size = new System.Drawing.Size(150, 22);
            
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, startY + gapY);
            this.label2.Name = "label2";
            this.label2.Text = "Họ Tên:";
            this.txtHoTen.Location = new System.Drawing.Point(130, startY + gapY - 3);
            this.txtHoTen.Size = new System.Drawing.Size(250, 22);

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, startY + gapY * 2);
            this.label3.Name = "label3";
            this.label3.Text = "Số CCCD:";
            this.txtCCCD.Location = new System.Drawing.Point(130, startY + gapY * 2 - 3);
            this.txtCCCD.Size = new System.Drawing.Size(150, 22);

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, startY + gapY * 3);
            this.label4.Name = "label4";
            this.label4.Text = "Ngày Sinh:";
            this.dtpNgaySinh.Location = new System.Drawing.Point(130, startY + gapY * 3 - 3);
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, startY + gapY * 4);
            this.label5.Name = "label5";
            this.label5.Text = "Giới Tính:";
            this.cbGioiTinh.Location = new System.Drawing.Point(130, startY + gapY * 4 - 3);
            this.cbGioiTinh.Size = new System.Drawing.Size(100, 24);
            this.cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, startY + gapY * 5);
            this.label6.Name = "label6";
            this.label6.Text = "Mã Phòng:";
            this.txtPhong.Location = new System.Drawing.Point(130, startY + gapY * 5 - 3);
            this.txtPhong.Size = new System.Drawing.Size(150, 22);

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, startY + gapY * 6);
            this.label7.Name = "label7";
            this.label7.Text = "Trạng Thái:";
            this.txtTrangThai.Location = new System.Drawing.Point(130, startY + gapY * 6 - 3);
            this.txtTrangThai.Size = new System.Drawing.Size(200, 22);

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, startY + gapY * 7);
            this.label8.Name = "label8";
            this.label8.Text = "Mức Nguy Hiểm:";
            this.cbMucDo.Location = new System.Drawing.Point(130, startY + gapY * 7 - 3);
            this.cbMucDo.Size = new System.Drawing.Size(150, 24);
            this.cbMucDo.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao", "Đặc biệt" });

            this.btnThem.Location = new System.Drawing.Point(50, startY + gapY * 9);
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(170, startY + gapY * 9);
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.Text = "Cập Nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(290, startY + gapY * 9);
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // tabThanNhan
            this.tabThanNhan.Controls.Add(this.dgvThanNhan);
            this.tabThanNhan.Location = new System.Drawing.Point(4, 25);
            this.tabThanNhan.Name = "tabThanNhan";
            this.tabThanNhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabThanNhan.Size = new System.Drawing.Size(588, 571);
            this.tabThanNhan.TabIndex = 1;
            this.tabThanNhan.Text = "Thân Nhân";
            this.tabThanNhan.UseVisualStyleBackColor = true;

            this.dgvThanNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanNhan.ReadOnly = true;
            
            // tabBanAn
            this.tabBanAn.Controls.Add(this.dgvBanAn);
            this.tabBanAn.Location = new System.Drawing.Point(4, 25);
            this.tabBanAn.Name = "tabBanAn";
            this.tabBanAn.Size = new System.Drawing.Size(588, 571);
            this.tabBanAn.TabIndex = 2;
            this.tabBanAn.Text = "Bản Án";
            this.tabBanAn.UseVisualStyleBackColor = true;

            this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanAn.ReadOnly = true;

            // tabViPham
            this.tabViPham.Controls.Add(this.dgvViPham);
            this.tabViPham.Location = new System.Drawing.Point(4, 25);
            this.tabViPham.Name = "tabViPham";
            this.tabViPham.Size = new System.Drawing.Size(588, 571);
            this.tabViPham.TabIndex = 3;
            this.tabViPham.Text = "Kỷ Luật & Vi Phạm";
            this.tabViPham.UseVisualStyleBackColor = true;
            
            this.dgvViPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvViPham.ReadOnly = true;

            // UC_TuNhan
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UC_TuNhan";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.UC_TuNhan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuNhan)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabThongTin.ResumeLayout(false);
            this.tabThongTin.PerformLayout();
            this.tabThanNhan.ResumeLayout(false);
            this.tabBanAn.ResumeLayout(false);
            this.tabViPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViPham)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
