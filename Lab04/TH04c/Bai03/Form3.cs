using System;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Tim UCLN
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            return a;
        }

        // Tim BCNN
        private int BCNN(int a, int b)
        {
            return a / UCLN(a, b) * b;
        }

        // Kiem tra du lieu
        private bool KiemTraDuLieu()
        {
            int a;
            int b;

            if (!int.TryParse(txtA.Text, out a))
            {
                MessageBox.Show(
                    "Vui long nhap so a hop le!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();
                return false;
            }

            if (!int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show(
                    "Vui long nhap so b hop le!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();
                return false;
            }

            if (a <= 0)
            {
                MessageBox.Show(
                    "So a phai lon hon 0!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtA.Focus();
                return false;
            }

            if (b <= 0)
            {
                MessageBox.Show(
                    "So b phai lon hon 0!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtB.Focus();
                return false;
            }

            return true;
        }

        // Nut Thuc Hien
        private void btnThucHien_Click(
            object sender,
            EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            int ucln = UCLN(a, b);
            int bcnn = BCNN(a, b);

            txtUCLN.Text = ucln.ToString();
            txtBCNN.Text = bcnn.ToString();
        }

        // Nut Tiep Tuc
        private void btnTiepTuc_Click(
            object sender,
            EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();

            txtA.Focus();
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

        // Chan ky tu khong phai so
        private void txtA_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtB_KeyPress(
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
        private void Form3_FormClosing(
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