
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH05d
{
    public class Bai03 : Form
    {
        private Label lblDongHo;
        private Button btnBatDau;
        private System.Windows.Forms.Timer timerDemNguoc;

        // Thoi gian ban dau: 30 phut = 1800 giay
        private int thoiGian = 30 * 60;

        public Bai03()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Đồng hồ";
            this.Size = new Size(300, 180);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Label hien thi thoi gian
            lblDongHo = new Label();
            lblDongHo.Text = "30:00";
            lblDongHo.Font = new Font("Arial", 18, FontStyle.Bold);
            lblDongHo.TextAlign = ContentAlignment.MiddleCenter;
            lblDongHo.Location = new Point(65, 25);
            lblDongHo.Size = new Size(160, 35);

            // Nut bat dau
            btnBatDau = new Button();
            btnBatDau.Text = "Bắt đầu";
            btnBatDau.Font = new Font("Arial", 10);
            btnBatDau.Location = new Point(100, 70);
            btnBatDau.Size = new Size(90, 35);
            btnBatDau.Click += BtnBatDau_Click;

            // Timer dem nguoc moi giay
            timerDemNguoc = new System.Windows.Forms.Timer();
            timerDemNguoc.Interval = 1000;
            timerDemNguoc.Tick += TimerDemNguoc_Tick;

            this.Controls.Add(lblDongHo);
            this.Controls.Add(btnBatDau);
        }

        // Bat dau dem nguoc
        private void BtnBatDau_Click(object sender, EventArgs e)
        {
            btnBatDau.Enabled = false;
            timerDemNguoc.Start();
        }

        // Xu ly moi giay
        private void TimerDemNguoc_Tick(object sender, EventArgs e)
        {
            if (thoiGian > 0)
            {
                thoiGian--;

                int phut = thoiGian / 60;
                int giay = thoiGian % 60;

                lblDongHo.Text = phut.ToString("00") + ":" + giay.ToString("00");
            }
            else
            {
                timerDemNguoc.Stop();
                btnBatDau.Enabled = true;

                MessageBox.Show(
                    "Đã hết thời gian!",
                    "Đồng hồ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}