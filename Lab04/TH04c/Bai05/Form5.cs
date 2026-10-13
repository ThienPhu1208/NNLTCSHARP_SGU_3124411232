using System;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Doc hang tram
        private string DocHangTram(int so)
        {
            string[] chuSo =
            {
                "Không",
                "Một",
                "Hai",
                "Ba",
                "Bốn",
                "Năm",
                "Sáu",
                "Bảy",
                "Tám",
                "Chín"
            };

            int tram = so / 100;
            int chuc = (so % 100) / 10;
            int donVi = so % 10;

            string ketQua = "";

            if (tram > 0)
            {
                ketQua += chuSo[tram] + " Trăm";

                if (chuc == 0 && donVi != 0)
                {
                    ketQua += " Lẻ";
                }
            }

            if (chuc > 0)
            {
                if (chuc == 1)
                {
                    ketQua += " Mười";
                }
                else
                {
                    ketQua += " " + chuSo[chuc] + " Mươi";
                }
            }

            if (donVi > 0)
            {
                if (donVi == 1 && chuc > 1)
                {
                    ketQua += " Mốt";
                }
                else if (donVi == 5 && chuc > 0)
                {
                    ketQua += " Lăm";
                }
                else
                {
                    ketQua += " " + chuSo[donVi];
                }
            }

            return ketQua.Trim();
        }

        // Nut Thuc hien
        private void btnThucHien_Click(
            object sender,
            EventArgs e)
        {
            int so;

            if (!int.TryParse(txtNhapSo.Text, out so))
            {
                MessageBox.Show(
                    "Vui long nhap mot so nguyen!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNhapSo.Focus();
                return;
            }

            if (so < 1 || so > 999)
            {
                MessageBox.Show(
                    "Vui long nhap so tu 1 den 999!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNhapSo.Focus();
                return;
            }

            txtKetQua.Text = DocHangTram(so);
        }

        // Nut Xoa
        private void btnXoa_Click(
            object sender,
            EventArgs e)
        {
            txtNhapSo.Clear();
            txtKetQua.Clear();

            txtNhapSo.Focus();
        }

        // Nut Thoat
        private void btnThoat_Click(
            object sender,
            EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Ban co muon thoat chuong trinh khong?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Chi cho nhap so
        private void txtNhapSo_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Hoi xac nhan truoc khi dong Form
        private void Form5_FormClosing(
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