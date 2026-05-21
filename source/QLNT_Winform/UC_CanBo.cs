using System;
using System.Data;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_CanBo : UserControl
    {
        private DatabaseHelper db = new DatabaseHelper();
        private TabControl tabControl;
        private DataGridView dgvQuanNguc;
        private DataGridView dgvPhongGiam;
        private DataGridView dgvKhuVuc;

        public UC_CanBo()
        {
            try
            {
                InitializeComponent();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo giao diện Cán Bộ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            
            // TabPages
            TabPage tabQuanNguc = new TabPage("Quản Ngục");
            TabPage tabPhongGiam = new TabPage("Phòng Giam");
            TabPage tabKhuVuc = new TabPage("Khu Vực");

            // DataGridViews
            this.dgvQuanNguc = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvPhongGiam = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };
            this.dgvKhuVuc = new DataGridView() { Dock = DockStyle.Fill, ReadOnly = true, AllowUserToAddRows = false };

            tabQuanNguc.Controls.Add(dgvQuanNguc);
            tabPhongGiam.Controls.Add(dgvPhongGiam);
            tabKhuVuc.Controls.Add(dgvKhuVuc);

            this.tabControl.Controls.Add(tabQuanNguc);
            this.tabControl.Controls.Add(tabPhongGiam);
            this.tabControl.Controls.Add(tabKhuVuc);
            
            this.tabControl.Dock = DockStyle.Fill;
            this.Controls.Add(this.tabControl);
            this.Size = new System.Drawing.Size(800, 600);
        }

        private void LoadData()
        {
            try
            {
                dgvQuanNguc.DataSource = db.ExecuteQuery("SELECT * FROM QUANNGUC");
                dgvPhongGiam.DataSource = db.ExecuteQuery("SELECT * FROM PHONGGIAM");
                dgvKhuVuc.DataSource = db.ExecuteQuery("SELECT * FROM KHUVUC");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Cán Bộ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
