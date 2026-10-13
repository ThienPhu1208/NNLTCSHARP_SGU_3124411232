using System;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form7 : Form
    {
        // Luu so dang nhap
        double so1 = 0;
        double so2 = 0;

        // Luu phep tinh
        string phepTinh = "";

        // Kiem tra dang nhap so moi
        bool nhapSoMoi = true;

        public Form7()
        {
            InitializeComponent();
        }

        // Xu ly cac nut so
        private void btnSo_Click(
            object sender,
            EventArgs e)
        {
            Button nut = (Button)sender;

            if (nhapSoMoi)
            {
                txtManHinh.Text = nut.Text;
                nhapSoMoi = false;
            }
            else
            {
                txtManHinh.Text += nut.Text;
            }
        }

        // Xu ly cac phep tinh
        private void btnPhepTinh_Click(
            object sender,
            EventArgs e)
        {
            Button nut = (Button)sender;

            if (txtManHinh.Text == "")
            {
                return;
            }

            so1 = double.Parse(txtManHinh.Text);

            phepTinh = nut.Text;

            nhapSoMoi = true;
        }

        // Nut =
        private void btnBang_Click(
            object sender,
            EventArgs e)
        {
            if (txtManHinh.Text == "" ||
                phepTinh == "")
            {
                return;
            }

            so2 = double.Parse(txtManHinh.Text);

            double ketQua = 0;

            if (phepTinh == "+")
            {
                ketQua = so1 + so2;
            }
            else if (phepTinh == "-")
            {
                ketQua = so1 - so2;
            }
            else if (phepTinh == "*")
            {
                ketQua = so1 * so2;
            }
            else if (phepTinh == "/")
            {
                if (so2 == 0)
                {
                    MessageBox.Show(
                        "Khong the chia cho 0!",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                ketQua = so1 / so2;
            }

            txtManHinh.Text = ketQua.ToString();

            nhapSoMoi = true;
            phepTinh = "";
        }

        // Nut C
        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            txtManHinh.Clear();

            so1 = 0;
            so2 = 0;

            phepTinh = "";

            nhapSoMoi = true;
        }

        // Hoi xac nhan truoc khi dong
        private void Form7_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co muon thoat chuong trinh khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}