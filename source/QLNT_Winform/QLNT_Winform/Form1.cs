using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNT_Winfrom
{
    public partial class Form1 : Form
    {
        // ConnectionString có thể được cấu hình từ App.config hoặc cấu hình tay ở đây
        private string connectionString = "Data Source=LAPCUAXUANANH\\MSSQLSERVER01;Initial Catalog=QLNT;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        private SqlCommandBuilder commandBuilder;
        private string currentTable = "";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            
            // Events for Tab 1
            cmbTables.SelectedIndexChanged += CmbTables_SelectedIndexChanged;
            btnSearch.Click += BtnSearch_Click;
            btnSave.Click += BtnSave_Click;
            
            // Events for Tab 2 & 3
            btnSearchName.Click += BtnSearchName_Click;
            btnLoadReport.Click += BtnLoadReport_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tải danh sách bảng
            LoadTableList();
            
            // Tải danh sách báo cáo
            cmbReports.Items.Add("Thống kê Tù nhân theo Mức độ nguy hiểm");
            cmbReports.Items.Add("Thống kê Hiệu suất Phòng giam");
            cmbReports.Items.Add("Thống kê Vi phạm Kỷ luật");
            if (cmbReports.Items.Count > 0) cmbReports.SelectedIndex = 0;
        }

        private void LoadTableList()
        {
            // Các bảng trong hệ thống QLNT
            string[] tables = new string[] {
                "KHUVUC", "QUANNGUC", "PHONGGIAM", "TUNHAN", "THANNHAN",
                "BANAN", "TOIDANH", "BANAN_TOIDANH", "CONGVIEC", "CAITAO",
                "THAMNUOI", "LICHSUCHUYENPHONG", "VIPHAMKYLUAT", "TAIKHOAN", "LICHTHAMNUOI"
            };
            cmbTables.Items.AddRange(tables);
        }

        private void CmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedItem == null) return;
            currentTable = cmbTables.SelectedItem.ToString();
            LoadDataToGrid(currentTable);
        }

        private void LoadDataToGrid(string tableName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = $"SELECT * FROM {tableName}";
                    dataAdapter = new SqlDataAdapter(query, conn);
                    commandBuilder = new SqlCommandBuilder(dataAdapter);
                    
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    
                    dgvData.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (dataTable == null) return;
            
            string filterText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(filterText))
            {
                dataTable.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Xây dựng chuỗi lọc cho tất cả các cột kiểu string
            string rowFilter = "";
            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.DataType == typeof(string))
                {
                    if (rowFilter.Length > 0)
                        rowFilter += " OR ";
                    rowFilter += $"[{column.ColumnName}] LIKE '%{filterText}%'";
                }
            }
            
            try
            {
                dataTable.DefaultView.RowFilter = rowFilter;
            }
            catch
            {
                // Bỏ qua lỗi nếu cú pháp lọc không hợp lệ
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (dataAdapter == null || dataTable == null) return;
            
            try
            {
                // Cập nhật các thay đổi từ DataTable vào DB (Thêm, Sửa, Xóa)
                dataAdapter.Update(dataTable);
                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchName_Click(object sender, EventArgs e)
        {
            string nameToSearch = txtSearchName.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_TimKiemTuNhan", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HoTen", nameToSearch);
                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvAdvanced.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadReport_Click(object sender, EventArgs e)
        {
            if (cmbReports.SelectedItem == null) return;
            
            string reportType = cmbReports.SelectedItem.ToString();
            string query = "";
            bool isStoredProcedure = false;
            
            if (reportType.Contains("Tù nhân"))
            {
                query = "SELECT * FROM dbo.fn_TUNHAN_ThongKe() ORDER BY MucDoNguyHiem, SoLuong DESC";
            }
            else if (reportType.Contains("Phòng giam"))
            {
                query = "SELECT * FROM dbo.fn_PHONGGIAM_ThongKe() ORDER BY TiLeLapDay DESC";
            }
            else if (reportType.Contains("Vi phạm"))
            {
                // Execute Stored Procedure
                query = "sp_ThongKeViPhamTheoHinhThuc";
                isStoredProcedure = true;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (isStoredProcedure)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    dgvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
