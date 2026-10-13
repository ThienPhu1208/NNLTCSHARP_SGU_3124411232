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

        // Khi Form duoc load
        private void Form1_Load(
            object sender,
            EventArgs e)
        {
            radBacNhat.Checked = true;

            txtC.Enabled = false;

            btnGiai.Enabled = false;

            txtKetQua.Clear();
        }

        // Chon phuong trinh bac nhat
        private void radBacNhat_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radBacNhat.Checked)
            {
                txtC.Enabled = false;

                txtC.Clear();

                txtKetQua.Clear();

                btnGiai.Enabled = false;
            }
        }

        // Chon phuong trinh bac hai
        private void radBacHai_CheckedChanged(
            object sender,
            EventArgs e)
        {
            if (radBacHai.Checked)
            {
                txtC.Enabled = true;

                txtKetQua.Clear();

                btnGiai.Enabled = false;
            }
        }

        // Kiem tra du lieu nhap
        private bool KiemTraDuLieu()
        {
            double a;
            double b;
            double c;

            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show(
                    "Vui long nhap a hop le!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();

                return false;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(
                    "Vui long nhap b hop le!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();

                return false;
            }

            if (radBacHai.Checked)
            {
                if (!double.TryParse(txtC.Text, out c))
                {
                    MessageBox.Show(
                        "Vui long nhap c hop le!",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtC.Focus();

                    return false;
                }
            }

            return true;
        }

        // Kiem tra da nhap day du chua
        private void KiemTraNhapDu()
        {
            if (radBacNhat.Checked)
            {
                if (txtA.Text.Trim() != "" &&
                    txtB.Text.Trim() != "")
                {
                    btnGiai.Enabled = true;
                }
                else
                {
                    btnGiai.Enabled = false;
                }
            }
            else
            {
                if (txtA.Text.Trim() != "" &&
                    txtB.Text.Trim() != "" &&
                    txtC.Text.Trim() != "")
                {
                    btnGiai.Enabled = true;
                }
                else
                {
                    btnGiai.Enabled = false;
                }
            }
        }

        // Khi nhap a
        private void txtA_TextChanged(
            object sender,
            EventArgs e)
        {
            KiemTraNhapDu();
        }

        // Khi nhap b
        private void txtB_TextChanged(
            object sender,
            EventArgs e)
        {
            KiemTraNhapDu();
        }

        // Khi nhap c
        private void txtC_TextChanged(
            object sender,
            EventArgs e)
        {
            KiemTraNhapDu();
        }

        // Nut Giai
        private void btnGiai_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
            {
                return;
            }

            PhuongTrinhBacHai pt =
                new PhuongTrinhBacHai();

            pt.A = double.Parse(txtA.Text);
            pt.B = double.Parse(txtB.Text);

            if (radBacNhat.Checked)
            {
                txtKetQua.Text =
                    pt.GiaiBacNhat();
            }
            else
            {
                pt.C = double.Parse(txtC.Text);

                txtKetQua.Text =
                    pt.GiaiBacHai();
            }

            // Giai xong thi nut Giai mo di
            btnGiai.Enabled = false;
        }

        // Chi cho nhap so
        private void txtA_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtC_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }
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