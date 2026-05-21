using System;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class Form1 : Form
    {
        private UserControl currentUserControl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the default view
            btnTuNhan_Click(sender, e);
        }

        private void AddUserControl(UserControl uc)
        {
            try
            {
                if (currentUserControl != null)
                {
                    pnlMain.Controls.Remove(currentUserControl);
                    currentUserControl.Dispose();
                }

                currentUserControl = uc;
                uc.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(uc);
                pnlMain.Tag = uc;
                uc.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển giao diện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTuNhan_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(new UC_TuNhan());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải giao diện Tù Nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCanBo_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(new UC_CanBo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải giao diện Cán Bộ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(new UC_NghiepVu());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải giao diện Nghiệp Vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(new UC_DanhMuc());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải giao diện Danh Mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                AddUserControl(new UC_ThongKe());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải giao diện Thống Kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
