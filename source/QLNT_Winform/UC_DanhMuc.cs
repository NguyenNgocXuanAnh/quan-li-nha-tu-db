using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_DanhMuc : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private TabControl tabControl;
        private DataGridView dgvToiDanh;
        private DataGridView dgvCongViec;
        private DataGridView dgvTaiKhoan;

        public UC_DanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            
            TabPage tabToiDanh = new TabPage("Tội Danh");
            TabPage tabCongViec = new TabPage("Công Việc");
            TabPage tabTaiKhoan = new TabPage("Tài Khoản");

            this.dgvToiDanh = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvCongViec = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvTaiKhoan = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };

            tabToiDanh.Controls.Add(dgvToiDanh);
            tabCongViec.Controls.Add(dgvCongViec);
            tabTaiKhoan.Controls.Add(dgvTaiKhoan);

            this.tabControl.Controls.Add(tabToiDanh);
            this.tabControl.Controls.Add(tabCongViec);
            this.tabControl.Controls.Add(tabTaiKhoan);
            
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void LoadData()
        {
            dgvToiDanh.DataSource = db.ExecuteQuery("SELECT * FROM TOIDANH");
            dgvCongViec.DataSource = db.ExecuteQuery("SELECT * FROM CONGVIEC");
            dgvTaiKhoan.DataSource = db.ExecuteQuery("SELECT * FROM TAIKHOAN");
        }
    }
}
