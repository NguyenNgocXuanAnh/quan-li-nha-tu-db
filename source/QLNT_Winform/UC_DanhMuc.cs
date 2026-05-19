using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_DanhMuc : UserControl
    {
        public UC_DanhMuc()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label lbl = new Label();
            lbl.Text = "Danh Mục Hệ Thống (To be implemented)";
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(50, 50);
            lbl.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Controls.Add(lbl);
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}
