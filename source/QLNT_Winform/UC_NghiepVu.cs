using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_NghiepVu : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private TabControl tabControl;
        private DataGridView dgvThamNuoi;
        private DataGridView dgvLichThamNuoi;
        private DataGridView dgvChuyenPhong;
        private DataGridView dgvCaiTao;

        public UC_NghiepVu()
        {
            try
            {
                InitializeComponent();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo giao diện Nghiệp Vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            
            TabPage tabThamNuoi = new TabPage("Thăm Nuôi");
            TabPage tabLichThamNuoi = new TabPage("Lịch Thăm Nuôi");
            TabPage tabChuyenPhong = new TabPage("Lịch Sử Chuyển Phòng");
            TabPage tabCaiTao = new TabPage("Cải Tạo");

            this.dgvThamNuoi = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvLichThamNuoi = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvChuyenPhong = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvCaiTao = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };

            tabThamNuoi.Controls.Add(dgvThamNuoi);
            tabLichThamNuoi.Controls.Add(dgvLichThamNuoi);
            tabChuyenPhong.Controls.Add(dgvChuyenPhong);
            tabCaiTao.Controls.Add(dgvCaiTao);

            this.tabControl.Controls.Add(tabThamNuoi);
            this.tabControl.Controls.Add(tabLichThamNuoi);
            this.tabControl.Controls.Add(tabChuyenPhong);
            this.tabControl.Controls.Add(tabCaiTao);
            
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void LoadData()
        {
            try
            {
                dgvThamNuoi.DataSource = db.ExecuteQuery("SELECT * FROM THAMNUOI");
                dgvLichThamNuoi.DataSource = db.ExecuteQuery("SELECT * FROM LICHTHAMNUOI");
                dgvChuyenPhong.DataSource = db.ExecuteQuery("SELECT * FROM LICHSUCHUYENPHONG");
                dgvCaiTao.DataSource = db.ExecuteQuery("SELECT * FROM CAITAO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Nghiệp Vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
