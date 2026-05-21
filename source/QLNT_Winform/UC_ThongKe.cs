using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_ThongKe : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private TabControl tabControl;
        private DataGridView dgvPhongGiam;
        private DataGridView dgvToiDanh;
        private DataGridView dgvViPham;

        public UC_ThongKe()
        {
            try
            {
                InitializeComponent();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo giao diện Thống Kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            
            TabPage tabPhongGiam = new TabPage("Hiệu Suất Phòng Giam");
            TabPage tabToiDanh = new TabPage("Thống Kê Tội Danh");
            TabPage tabViPham = new TabPage("Thống Kê Vi Phạm");

            this.dgvPhongGiam = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvToiDanh = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvViPham = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };

            tabPhongGiam.Controls.Add(dgvPhongGiam);
            tabToiDanh.Controls.Add(dgvToiDanh);
            tabViPham.Controls.Add(dgvViPham);

            this.tabControl.Controls.Add(tabPhongGiam);
            this.tabControl.Controls.Add(tabToiDanh);
            this.tabControl.Controls.Add(tabViPham);
            
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void LoadData()
        {
            try
            {
                // Call SQL Functions
                dgvPhongGiam.DataSource = db.ExecuteQuery("SELECT * FROM dbo.fn_PHONGGIAM_ThongKe()");
                dgvToiDanh.DataSource = db.ExecuteQuery("SELECT * FROM dbo.fn_TOIDANH_ThongKe()");
                
                // Call SQL Procedure
                dgvViPham.DataSource = db.ExecuteStoredProcedureQuery("sp_ThongKeViPhamTheoHinhThuc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Thống Kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
