using System.Windows.Forms;

namespace QLNT_Winform
{
    public partial class UC_ThongKe : UserControl
    {
        public UC_ThongKe()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label lbl = new Label();
            lbl.Text = "Thống Kê & Báo Cáo (To be implemented)";
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(50, 50);
            lbl.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Controls.Add(lbl);
            this.Size = new System.Drawing.Size(800, 600);
        }
    }
}
