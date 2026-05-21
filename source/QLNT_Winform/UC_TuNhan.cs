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
            try
            {
                LoadTuNhan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở danh sách tù nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTuNhan()
        {
            try
            {
                string query = "SELECT MaTuNhan, HoTen, SoCCCD, NgaySinh, GioiTinh, MaPhong, TrangThai, MucDoNguyHiem FROM TUNHAN";
                DataTable dt = db.ExecuteQuery(query);
                dgvTuNhan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách tù nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTuNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvTuNhan.Rows[e.RowIndex];
                    if (row.Cells["MaTuNhan"].Value != null && row.Cells["MaTuNhan"].Value != DBNull.Value)
                    {
                        string maTuNhan = row.Cells["MaTuNhan"].Value.ToString();
                        
                        txtMaTuNhan.Text = maTuNhan;
                        txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                        txtCCCD.Text = row.Cells["SoCCCD"].Value?.ToString() ?? "";
                        txtPhong.Text = row.Cells["MaPhong"].Value?.ToString() ?? "";
                        cbGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                        
                        if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                        
                        txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";
                        cbMucDo.Text = row.Cells["MucDoNguyHiem"].Value?.ToString() ?? "";

                        LoadThanNhan(maTuNhan);
                        LoadBanAn(maTuNhan);
                        LoadViPham(maTuNhan);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị thông tin tù nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadThanNhan(string maTuNhan)
        {
            try
            {
                string query = "SELECT MaThanNhan, HoTenThanNhan, QuanHe, SoDienThoai FROM THANNHAN WHERE MaTuNhan = @maTuNhan";
                SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
                dgvThanNhan.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin thân nhân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBanAn(string maTuNhan)
        {
            try
            {
                string query = "SELECT MaBanAn, ToiDanh, MucAn, NgayTuyenAn, NgayKetThucDuKien FROM BANAN WHERE MaTuNhan = @maTuNhan";
                SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
                dgvBanAn.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin bản án: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadViPham(string maTuNhan)
        {
            try
            {
                string query = "SELECT MaViPham, NgayViPham, NoiDung, HinhThucXuLy FROM VIPHAMKYLUAT WHERE MaTuNhan = @maTuNhan";
                SqlParameter[] param = { new SqlParameter("@maTuNhan", maTuNhan) };
                dgvViPham.DataSource = db.ExecuteQuery(query, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thông tin kỷ luật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement insert logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement update logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa đổi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Implement delete logic
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
