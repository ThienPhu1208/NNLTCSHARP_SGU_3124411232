using System;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kiem tra textbox a
        private bool KiemTraA()
        {
            if (txtA.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtA,
                    "Vui long nhap so a"
                );

                MessageBox.Show(
                    "Vui long nhap gia tri a!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();
                return false;
            }

            errorProvider1.SetError(txtA, "");
            return true;
        }

        // Kiem tra textbox b
        private bool KiemTraB()
        {
            if (txtB.Text.Trim() == "")
            {
                errorProvider1.SetError(
                    txtB,
                    "Vui long nhap so b"
                );

                MessageBox.Show(
                    "Vui long nhap gia tri b!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();
                return false;
            }

            errorProvider1.SetError(txtB, "");
            return true;
        }

        // Phep cong
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!KiemTraA() || !KiemTraB())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a + b).ToString();
        }

        // Phep tru
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!KiemTraA() || !KiemTraB())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a - b).ToString();
        }

        // Phep nhan
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!KiemTraA() || !KiemTraB())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            txtKetQua.Text = (a * b).ToString();
        }

        // Phep chia
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!KiemTraA() || !KiemTraB())
                return;

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (b == 0)
            {
                MessageBox.Show(
                    "Khong the chia cho 0!",
                    "Loi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtB.Focus();
                return;
            }

            txtKetQua.Text = (a / b).ToString();
        }

        // Chan ky tu khong phai so
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Hoi xac nhan truoc khi dong Form
        private void Form1_FormClosing(
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