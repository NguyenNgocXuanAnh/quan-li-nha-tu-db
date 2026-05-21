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

        private void btnTuNhan_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_TuNhan());
        }

        private void btnCanBo_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_CanBo());
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_NghiepVu());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_DanhMuc());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            AddUserControl(new UC_ThongKe());
        }
    }
}
