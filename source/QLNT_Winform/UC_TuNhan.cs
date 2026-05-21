using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_TuNhan : UserControl
    {
        DatabaseHelper db = new DatabaseHelper();

        public UC_TuNhan()
        {
            InitializeComponent();
        }

        private void UC_TuNhan_Load(object sender, EventArgs e)
        {
            LoadTuNhan();
        }

        private void LoadTuNhan()
        {
            string query = "SELECT MaTuNhan, HoTen, SoCCCD, NgaySinh, GioiTinh, MaPhong, TrangThai, MucDoNguyHiem FROM TUNHAN";
            DataTable dt = db.ExecuteQuery(query);
            dgvTuNhan.DataSource = dt;
        }

        private void dgvTuNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTuNhan.Rows[e.RowIndex];
                string maTuNhan = row.Cells["MaTuNhan"].Value.ToString();
                
                txtMaTuNhan.Text = maTuNhan;
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtCCCD.Text = row.Cells["SoCCCD"].Value.ToString();
                txtPhong.Text = row.Cells["MaPhong"].Value.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                
                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                
                txtTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                cbMucDo.Text = row.Cells["MucDoNguyHiem"].Value.ToString();

                LoadThanNhan(maTuNhan);
                LoadBanAn(maTuNhan);
                LoadViPham(maTuNhan);
            }
        }

        private void LoadThanNhan(string maTuNhan)
        {
            string query = "SELECT MaThanNhan, HoTenThanNhan, QuanHe, SoDienThoai FROM THANNHAN WHERE MaTuNhan = @maTuNhan";
            SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
            dgvThanNhan.DataSource = db.ExecuteQuery(query, param);
        }

        private void LoadBanAn(string maTuNhan)
        {
            string query = "SELECT MaBanAn, ToiDanh, MucAn, NgayTuyenAn, NgayKetThucDuKien FROM BANAN WHERE MaTuNhan = @maTuNhan";
            SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
            dgvBanAn.DataSource = db.ExecuteQuery(query, param);
        }

        private void LoadViPham(string maTuNhan)
        {
            string query = "SELECT MaViPham, NgayViPham, NoiDung, HinhThucXuLy FROM VIPHAMKYLUAT WHERE MaTuNhan = @maTuNhan";
            SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
            dgvViPham.DataSource = db.ExecuteQuery(query, param);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Implement insert logic
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Implement update logic
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Implement delete logic
        }
    }
}
