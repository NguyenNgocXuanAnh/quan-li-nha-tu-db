namespace QLNT_Winform
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnTuNhan;
        private System.Windows.Forms.Button btnCanBo;
        private System.Windows.Forms.Button btnNghiepVu;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTitle;

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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnNghiepVu = new System.Windows.Forms.Button();
            this.btnCanBo = new System.Windows.Forms.Button();
            this.btnTuNhan = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            
            // pnlSidebar
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnDanhMuc);
            this.pnlSidebar.Controls.Add(this.btnNghiepVu);
            this.pnlSidebar.Controls.Add(this.btnCanBo);
            this.pnlSidebar.Controls.Add(this.btnTuNhan);
            this.pnlSidebar.Controls.Add(this.lblTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 681);
            this.pnlSidebar.TabIndex = 0;
            
            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hệ Thống QLNT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // btnTuNhan
            this.btnTuNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTuNhan.FlatAppearance.BorderSize = 0;
            this.btnTuNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTuNhan.ForeColor = System.Drawing.Color.White;
            this.btnTuNhan.Location = new System.Drawing.Point(0, 70);
            this.btnTuNhan.Name = "btnTuNhan";
            this.btnTuNhan.Size = new System.Drawing.Size(280, 60);
            this.btnTuNhan.TabIndex = 1;
            this.btnTuNhan.Text = "Quản lý Tù Nhân";
            this.btnTuNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuNhan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTuNhan.UseVisualStyleBackColor = true;
            this.btnTuNhan.Click += new System.EventHandler(this.btnTuNhan_Click);
            
            // btnCanBo
            this.btnCanBo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanBo.FlatAppearance.BorderSize = 0;
            this.btnCanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanBo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCanBo.ForeColor = System.Drawing.Color.White;
            this.btnCanBo.Location = new System.Drawing.Point(0, 130);
            this.btnCanBo.Name = "btnCanBo";
            this.btnCanBo.Size = new System.Drawing.Size(280, 60);
            this.btnCanBo.TabIndex = 2;
            this.btnCanBo.Text = "Cán Bộ && Phòng Giam";
            this.btnCanBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanBo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCanBo.UseVisualStyleBackColor = true;
            this.btnCanBo.Click += new System.EventHandler(this.btnCanBo_Click);
            
            // btnNghiepVu
            this.btnNghiepVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNghiepVu.FlatAppearance.BorderSize = 0;
            this.btnNghiepVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiepVu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNghiepVu.ForeColor = System.Drawing.Color.White;
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 190);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(280, 60);
            this.btnNghiepVu.TabIndex = 3;
            this.btnNghiepVu.Text = "Nghiệp Vụ && Thăm Nuôi";
            this.btnNghiepVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNghiepVu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNghiepVu.UseVisualStyleBackColor = true;
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            
            // btnDanhMuc
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 250);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(280, 60);
            this.btnDanhMuc.TabIndex = 4;
            this.btnDanhMuc.Text = "Danh Mục Hệ Thống";
            this.btnDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            
            // btnThongKe
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 310);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(280, 60);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê && Báo Cáo";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            
            // pnlMain
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(280, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(984, 681);
            this.pnlMain.TabIndex = 1;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Nhà Tù (QLNT)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
