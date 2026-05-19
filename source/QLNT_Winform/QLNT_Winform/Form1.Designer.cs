namespace QLNT_Winfrom
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabCRUD = new System.Windows.Forms.TabPage();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            
            // Tab CRUD Controls
            this.lblTable = new System.Windows.Forms.Label();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            
            // Tab Advanced Controls
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.dgvAdvanced = new System.Windows.Forms.DataGridView();
            
            // Tab Reports Controls
            this.lblReport = new System.Windows.Forms.Label();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            
            this.tabControlMain.SuspendLayout();
            this.tabCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanced)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            
            // tabControlMain
            this.tabControlMain.Controls.Add(this.tabCRUD);
            this.tabControlMain.Controls.Add(this.tabAdvanced);
            this.tabControlMain.Controls.Add(this.tabReports);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1000, 600);
            
            // tabCRUD
            this.tabCRUD.Controls.Add(this.btnSave);
            this.tabCRUD.Controls.Add(this.dgvData);
            this.tabCRUD.Controls.Add(this.btnSearch);
            this.tabCRUD.Controls.Add(this.txtSearch);
            this.tabCRUD.Controls.Add(this.cmbTables);
            this.tabCRUD.Controls.Add(this.lblTable);
            this.tabCRUD.Location = new System.Drawing.Point(4, 29);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.tabCRUD.Size = new System.Drawing.Size(992, 567);
            this.tabCRUD.Text = "Cập nhật & Truy vấn";
            this.tabCRUD.UseVisualStyleBackColor = true;
            
            // lblTable
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(12, 18);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(89, 20);
            this.lblTable.Text = "Chọn bảng:";
            
            // cmbTables
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(107, 15);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(200, 28);
            
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(330, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 26);
            
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(640, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            
            // btnSave
            this.btnSave.Location = new System.Drawing.Point(750, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Lưu (Ghi)";
            this.btnSave.UseVisualStyleBackColor = true;
            
            // dgvData
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(10, 60);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(970, 490);
            this.dgvData.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            
            // tabAdvanced
            this.tabAdvanced.Controls.Add(this.dgvAdvanced);
            this.tabAdvanced.Controls.Add(this.btnSearchName);
            this.tabAdvanced.Controls.Add(this.txtSearchName);
            this.tabAdvanced.Controls.Add(this.lblSearchName);
            this.tabAdvanced.Location = new System.Drawing.Point(4, 29);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(992, 567);
            this.tabAdvanced.Text = "Nghiệp vụ (Tìm Tù Nhân)";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            
            // lblSearchName
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(12, 18);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(95, 20);
            this.lblSearchName.Text = "Tên tù nhân:";
            
            // txtSearchName
            this.txtSearchName.Location = new System.Drawing.Point(120, 15);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(300, 26);
            
            // btnSearchName
            this.btnSearchName.Location = new System.Drawing.Point(430, 13);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(100, 30);
            this.btnSearchName.Text = "Tìm kiếm";
            this.btnSearchName.UseVisualStyleBackColor = true;
            
            // dgvAdvanced
            this.dgvAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvanced.Location = new System.Drawing.Point(10, 60);
            this.dgvAdvanced.Name = "dgvAdvanced";
            this.dgvAdvanced.Size = new System.Drawing.Size(970, 490);
            this.dgvAdvanced.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.dgvAdvanced.ReadOnly = true;
            
            // tabReports
            this.tabReports.Controls.Add(this.dgvReport);
            this.tabReports.Controls.Add(this.btnLoadReport);
            this.tabReports.Controls.Add(this.cmbReports);
            this.tabReports.Controls.Add(this.lblReport);
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(992, 567);
            this.tabReports.Text = "Thống kê & Báo cáo";
            this.tabReports.UseVisualStyleBackColor = true;
            
            // lblReport
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(12, 18);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(111, 20);
            this.lblReport.Text = "Chọn báo cáo:";
            
            // cmbReports
            this.cmbReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(130, 15);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(300, 28);
            
            // btnLoadReport
            this.btnLoadReport.Location = new System.Drawing.Point(440, 13);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(100, 30);
            this.btnLoadReport.Text = "Xem";
            this.btnLoadReport.UseVisualStyleBackColor = true;
            
            // dgvReport
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(10, 60);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(970, 490);
            this.dgvReport.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.dgvReport.ReadOnly = true;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Hệ thống Quản lý Nhà tù (QLNT)";
            
            this.tabControlMain.ResumeLayout(false);
            this.tabCRUD.ResumeLayout(false);
            this.tabCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabAdvanced.ResumeLayout(false);
            this.tabAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvanced)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        
        // Tab 1
        private System.Windows.Forms.TabPage tabCRUD;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvData;
        
        // Tab 2
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.DataGridView dgvAdvanced;
        
        // Tab 3
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.DataGridView dgvReport;
    }
}

